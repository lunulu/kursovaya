using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Кнопка закрытия программы
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        //Кнопка поиска информации по заказам
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            DB db = new DB();
            db.openConnection();

            string sql = "SELECT * FROM all_info WHERE `Имя заказчика`='" + textBox1.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                richTextBox1.Text += "Контракт №" + rdr[0]
                    + "\r\nСтоимость груза:   " + rdr[1]
                    + "\r\nДата загрузки и выгрузки:   " + rdr[2] + ",   " + rdr[3]
                    + "\r\nВес и тип груза:   " + rdr[4] + ",   " + rdr[5]
                    + "\r\nНачальный и конечный адрес:   " + rdr[8] + ",   " + rdr[9]
                    + "\r\nДлина маршрута:   " + rdr[10]
                    + "\r\nВодитель:   " + rdr[12]
                    + "\r\n\r\n";
            }

            db.closeConnection();

        }

        //Кнопка добавления контракта
        private void addContractButton_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                db.openConnection();

                string sql = "INSERT INTO contract(freight_cost,cargo_loading_date,cargo_unloading_date,truck_id_truck,customer_id_customer,route_id_route,cargo_id_cargo) " +
                    "VALUES ('" + freightCost.Text + "','" + loadingDate.Text + "','" + unloadingDate.Text + "','" + idTruck.Text + "','"
                    + idCustomer.Text + "','" + idRoute.Text + "','" + idCargo.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Готово");
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка ввода");
            }
        }

        //Кнопка добавления нового клиента
        private void addCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                db.openConnection();

                string sql = "INSERT INTO customer(customer_name,e_mail) VALUES ('" + customerName.Text + "','" + customerEmail.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Готово");
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка ввода");
            }
            customerName.Text = "";
            customerEmail.Text = "";
        }

        //Кнопка добавления нового маршрута
        private void addRoute_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                db.openConnection();

                string sql = "INSERT INTO route(start_adress,end_adress,distance) VALUES ('" + startAddress.Text + "','" + endAddress.Text + "','" + distance.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Готово");
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка ввода");
            }
            startAddress.Text = "";
            endAddress.Text = "";
            distance.Text = "";
        }

        //Кнопка добавления нового груза
        private void addCargo_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                db.openConnection();

                string sql = "INSERT INTO cargo(cargo_weight,cargotype) VALUES ('" + cargoWeight.Text + "','" + cargoType.Text + "')";
                MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
                cmd.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Готово");
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка ввода");
            }
            cargoWeight.Text = "";
            cargoType.Text = "";
        }

        MySqlDataAdapter daInfo;
        DataSet dsInfo;

        //Заполнение DataGridView данными
        private void MainPage_Load(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();

                string sql = "SELECT * FROM all_info";
                daInfo = new MySqlDataAdapter(sql, db.getConnection());
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daInfo);

                dsInfo = new DataSet();
                daInfo.Fill(dsInfo, "all_info");
                dataGridView1.DataSource = dsInfo;
                dataGridView1.DataMember = "all_info";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Методы для возможности перемещения окна по экрану
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label16_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void printButton1_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(600, 900);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
            PrintPreviewDialog dialog = printPreviewDialog1;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }
    }
}
