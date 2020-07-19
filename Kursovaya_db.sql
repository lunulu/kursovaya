CREATE DATABASE  IF NOT EXISTS `kursovaya` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `kursovaya`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: kursovaya
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `all_info`
--

DROP TABLE IF EXISTS `all_info`;
/*!50001 DROP VIEW IF EXISTS `all_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `all_info` AS SELECT 
 1 AS `№ контракта`,
 1 AS `Стоимость груза`,
 1 AS `Дата загрузки`,
 1 AS `Дата выгрузки`,
 1 AS `Вес груза`,
 1 AS `Тип груза`,
 1 AS `Имя заказчика`,
 1 AS `Электронная почта`,
 1 AS `Начальный адрес`,
 1 AS `Конечный адрес`,
 1 AS `Расстояние`,
 1 AS `Грузоподъемность грузовика`,
 1 AS `ФИО водителя`,
 1 AS `Дата рождения водителя`,
 1 AS `Дата получения прав`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `cargo`
--

DROP TABLE IF EXISTS `cargo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cargo` (
  `id_cargo` int unsigned NOT NULL AUTO_INCREMENT,
  `cargo_weight` decimal(5,0) unsigned NOT NULL,
  `cargotype` tinytext NOT NULL,
  PRIMARY KEY (`id_cargo`),
  UNIQUE KEY `id_cargo_UNIQUE` (`id_cargo`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cargo`
--

LOCK TABLES `cargo` WRITE;
/*!40000 ALTER TABLE `cargo` DISABLE KEYS */;
INSERT INTO `cargo` VALUES (1,3000,'Обычное'),(2,17500,'Обычное'),(3,5500,'Обычное'),(4,7500,'Обычное'),(5,15000,'Обычное'),(6,12500,'Взрывоопасное'),(7,8300,'Обычное'),(8,3000,'Хрупкое'),(9,20000,'Обычное'),(10,2700,'Обычное');
/*!40000 ALTER TABLE `cargo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contract`
--

DROP TABLE IF EXISTS `contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contract` (
  `id_contract` int unsigned NOT NULL AUTO_INCREMENT,
  `freight_cost` double unsigned NOT NULL,
  `cargo_loading_date` datetime NOT NULL,
  `cargo_unloading_date` datetime NOT NULL,
  `truck_id_truck` int unsigned NOT NULL,
  `customer_id_customer` int unsigned NOT NULL,
  `route_id_route` int unsigned NOT NULL,
  `cargo_id_cargo` int unsigned NOT NULL,
  PRIMARY KEY (`id_contract`),
  UNIQUE KEY `id_contract_UNIQUE` (`id_contract`),
  KEY `fk_contract_truck1_idx` (`truck_id_truck`),
  KEY `fk_contract_customer1_idx` (`customer_id_customer`),
  KEY `fk_contract_route1_idx` (`route_id_route`),
  KEY `fk_contract_cargo1_idx` (`cargo_id_cargo`),
  CONSTRAINT `fk_contract_cargo1` FOREIGN KEY (`cargo_id_cargo`) REFERENCES `cargo` (`id_cargo`),
  CONSTRAINT `fk_contract_customer1` FOREIGN KEY (`customer_id_customer`) REFERENCES `customer` (`id_customer`),
  CONSTRAINT `fk_contract_route1` FOREIGN KEY (`route_id_route`) REFERENCES `route` (`id_route`),
  CONSTRAINT `fk_contract_truck1` FOREIGN KEY (`truck_id_truck`) REFERENCES `truck` (`id_truck`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contract`
--

LOCK TABLES `contract` WRITE;
/*!40000 ALTER TABLE `contract` DISABLE KEYS */;
INSERT INTO `contract` VALUES (1,25345,'2020-01-01 09:00:00','2020-01-01 11:00:00',1,1,1,1),(2,453543,'2020-01-02 10:20:00','2020-01-02 11:20:00',3,2,2,5),(3,54345,'2020-03-03 10:00:00','2020-03-03 12:25:00',2,1,1,3),(4,54645,'2020-04-04 13:20:00','2020-04-04 16:30:00',1,5,5,4),(5,21378,'2020-05-05 06:40:00','2020-05-05 08:40:00',2,4,4,7),(6,8001,'2020-06-06 17:07:00','2020-06-06 19:40:00',3,2,2,8),(7,8001,'2020-07-07 18:40:00','2020-07-07 21:30:00',4,5,5,6),(8,45605,'2020-08-07 23:50:00','2020-08-08 02:20:00',5,4,4,2);
/*!40000 ALTER TABLE `contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `id_customer` int unsigned NOT NULL AUTO_INCREMENT,
  `customer_name` tinytext NOT NULL,
  `e_mail` varchar(45) NOT NULL,
  PRIMARY KEY (`id_customer`),
  UNIQUE KEY `id_customer_UNIQUE` (`id_customer`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Газпромик','gaz@mail.ru'),(2,'Ненэфис','netu@yandex.ru'),(3,'Татпеченько','tat123@mail.ru'),(4,'Google','google@gmail.com'),(5,'Amazon','checknmate@gmail.com');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `driver`
--

DROP TABLE IF EXISTS `driver`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `driver` (
  `fio` varchar(45) NOT NULL,
  `date_of_birth` date NOT NULL,
  `driver_lic` date NOT NULL,
  `truck_id_truck` int unsigned NOT NULL,
  PRIMARY KEY (`truck_id_truck`),
  CONSTRAINT `fk_driver_truck` FOREIGN KEY (`truck_id_truck`) REFERENCES `truck` (`id_truck`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `driver`
--

LOCK TABLES `driver` WRITE;
/*!40000 ALTER TABLE `driver` DISABLE KEYS */;
INSERT INTO `driver` VALUES ('Файзуллин РР','1999-05-20','2018-03-08',1),('Иванов ИИ','2001-01-01','2019-05-01',2),('Петров ПП','1981-03-04','2002-05-05',3),('Федоров ФФ','1970-07-11','1990-02-24',4),('Павлов ПП','1984-11-27','2003-08-13',5),('Bbbbb BB','2001-01-01','2020-01-01',6);
/*!40000 ALTER TABLE `driver` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `route`
--

DROP TABLE IF EXISTS `route`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `route` (
  `id_route` int unsigned NOT NULL AUTO_INCREMENT,
  `start_adress` varchar(45) NOT NULL,
  `end_adress` varchar(45) NOT NULL,
  `distance` decimal(4,2) unsigned NOT NULL,
  PRIMARY KEY (`id_route`),
  UNIQUE KEY `id_route_UNIQUE` (`id_route`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `route`
--

LOCK TABLES `route` WRITE;
/*!40000 ALTER TABLE `route` DISABLE KEYS */;
INSERT INTO `route` VALUES (1,'Улица Начальная 1','Улица Конечная 2',10.00),(2,'Проспект Нефтянников 5','Переулок банкротов 13',20.00),(3,'Улица Фучика 123','Улица Дубравная 12',13.00),(4,'Улица Габишева 32','Улица Фучика 88',17.00),(5,'Улица Хех  123','Улица Мда 456',56.00);
/*!40000 ALTER TABLE `route` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `truck`
--

DROP TABLE IF EXISTS `truck`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `truck` (
  `id_truck` int unsigned NOT NULL AUTO_INCREMENT,
  `carrying_capacity` decimal(5,0) NOT NULL,
  PRIMARY KEY (`id_truck`),
  UNIQUE KEY `id_truck_UNIQUE` (`id_truck`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `truck`
--

LOCK TABLES `truck` WRITE;
/*!40000 ALTER TABLE `truck` DISABLE KEYS */;
INSERT INTO `truck` VALUES (1,10000),(2,10000),(3,15000),(4,15000),(5,20000),(6,81712);
/*!40000 ALTER TABLE `truck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'kursovaya'
--
/*!50003 DROP FUNCTION IF EXISTS `driver_exp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `driver_exp`(id_truck int) RETURNS int
    DETERMINISTIC
BEGIN
declare exp int;
set exp= (select timestampdiff(month, driver_lic , curdate()) 
			from driver 
			where driver.truck_id_truck=id_truck);
RETURN exp;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `weight_name` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `weight_name`(weight DECIMAL(5,0)) RETURNS varchar(7) CHARSET utf8
    DETERMINISTIC
BEGIN
case 
 when weight<10000 then return "Малый";
 when weight>10000 and weight<15000 then return "Средний";
 when weight>15000 then return "Крупный";
 end case;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `add_driver` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_driver`(in fio varchar(45),in date_of_birth date,in driver_lic date, in truck_id_truck int)
BEGIN
insert into driver(fio,date_of_birth,driver_lic,truck_id_truck) values (fio,date_of_birth,driver_lic,truck_id_truck);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `add_truck` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_truck`(in carrying_capacity decimal(5,0))
BEGIN
insert into truck(carrying_capacity) values (carrying_capacity);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `all_customer_contracts` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `all_customer_contracts`(in id_customer int)
BEGIN
select * from contract where contract.customer_id_customer=id_customer;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `customers_contracts_info` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `customers_contracts_info`()
BEGIN
select cu.customer_name as `Имя компании`, 
	count(co.id_contract) as `Количество заключенных контрактов`, 
	sum(co.freight_cost) as `Вырученная прибыль за все контракты`, 
	sum(ca.cargo_weight) as `Общий вес груза за все контракты`  
from customer cu join contract co join cargo ca 
where cu.id_customer=co.customer_id_customer and ca.id_cargo=co.cargo_id_cargo 
group by cu.customer_name;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_all_contracts_after_this` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_all_contracts_after_this`(in id int)
BEGIN
SET SQL_SAFE_UPDATES = 0;
delete from contract where contract.id_contract>id;
SET SQL_SAFE_UPDATES = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `driver_contracts` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `driver_contracts`(in id_driver int)
BEGIN
select * from all_info where all_info.`ФИО водителя`=(select driver.fio from driver where id_driver=truck_id_truck);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_fio` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_fio`(in id_driver int, in new_fio varchar(45))
BEGIN
update driver set fio=new_fio where truck_id_truck=id_driver;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_freight_cost` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_freight_cost`(in min_cost double)
BEGIN
SET SQL_SAFE_UPDATES = 0;
update contract set freight_cost=min_cost where freight_cost<min_cost;
SET SQL_SAFE_UPDATES = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `all_info`
--

/*!50001 DROP VIEW IF EXISTS `all_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `all_info` AS select `contract`.`id_contract` AS `№ контракта`,`contract`.`freight_cost` AS `Стоимость груза`,`contract`.`cargo_loading_date` AS `Дата загрузки`,`contract`.`cargo_unloading_date` AS `Дата выгрузки`,`cargo`.`cargo_weight` AS `Вес груза`,`cargo`.`cargotype` AS `Тип груза`,`customer`.`customer_name` AS `Имя заказчика`,`customer`.`e_mail` AS `Электронная почта`,`route`.`start_adress` AS `Начальный адрес`,`route`.`end_adress` AS `Конечный адрес`,`route`.`distance` AS `Расстояние`,`truck`.`carrying_capacity` AS `Грузоподъемность грузовика`,`driver`.`fio` AS `ФИО водителя`,`driver`.`date_of_birth` AS `Дата рождения водителя`,`driver`.`driver_lic` AS `Дата получения прав` from (((((`contract` join `cargo`) join `customer`) join `route`) join `truck`) join `driver`) where ((`contract`.`truck_id_truck` = `truck`.`id_truck`) and (`contract`.`route_id_route` = `route`.`id_route`) and (`contract`.`customer_id_customer` = `customer`.`id_customer`) and (`contract`.`cargo_id_cargo` = `cargo`.`id_cargo`) and (`contract`.`truck_id_truck` = `driver`.`truck_id_truck`)) order by `contract`.`id_contract` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-05 18:40:46
