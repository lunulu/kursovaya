namespace Kursovaya
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuControl = new System.Windows.Forms.TabControl();
            this.customerInfo = new System.Windows.Forms.TabPage();
            this.printButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contractAdd = new System.Windows.Forms.TabPage();
            this.addContractButton = new System.Windows.Forms.Button();
            this.idCargo = new System.Windows.Forms.TextBox();
            this.idRoute = new System.Windows.Forms.TextBox();
            this.idCustomer = new System.Windows.Forms.TextBox();
            this.idTruck = new System.Windows.Forms.TextBox();
            this.unloadingDate = new System.Windows.Forms.TextBox();
            this.loadingDate = new System.Windows.Forms.TextBox();
            this.freightCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editBD = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cargoType = new System.Windows.Forms.TextBox();
            this.cargoWeight = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.addCargo = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.distance = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.endAddress = new System.Windows.Forms.TextBox();
            this.startAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.addRoute = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fullInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.menuControl.SuspendLayout();
            this.customerInfo.SuspendLayout();
            this.contractAdd.SuspendLayout();
            this.editBD.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fullInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.Controls.Add(this.customerInfo);
            this.menuControl.Controls.Add(this.contractAdd);
            this.menuControl.Controls.Add(this.editBD);
            this.menuControl.Controls.Add(this.fullInfo);
            this.menuControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuControl.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menuControl.Location = new System.Drawing.Point(0, 64);
            this.menuControl.Multiline = true;
            this.menuControl.Name = "menuControl";
            this.menuControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuControl.SelectedIndex = 0;
            this.menuControl.Size = new System.Drawing.Size(1245, 641);
            this.menuControl.TabIndex = 14;
            // 
            // customerInfo
            // 
            this.customerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.customerInfo.Controls.Add(this.printButton1);
            this.customerInfo.Controls.Add(this.button1);
            this.customerInfo.Controls.Add(this.label2);
            this.customerInfo.Controls.Add(this.richTextBox1);
            this.customerInfo.Controls.Add(this.label1);
            this.customerInfo.Controls.Add(this.textBox1);
            this.customerInfo.Location = new System.Drawing.Point(4, 45);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.customerInfo.Size = new System.Drawing.Size(1237, 592);
            this.customerInfo.TabIndex = 1;
            this.customerInfo.Text = "Информация о заказах";
            // 
            // printButton1
            // 
            this.printButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.printButton1.Location = new System.Drawing.Point(1098, 37);
            this.printButton1.Name = "printButton1";
            this.printButton1.Size = new System.Drawing.Size(131, 43);
            this.printButton1.TabIndex = 5;
            this.printButton1.Text = "Печать";
            this.printButton1.UseVisualStyleBackColor = true;
            this.printButton1.Click += new System.EventHandler(this.printButton1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.button1.Location = new System.Drawing.Point(775, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заказы:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(136, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1093, 461);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя заказчика:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.textBox1.Location = new System.Drawing.Point(337, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 43);
            this.textBox1.TabIndex = 0;
            // 
            // contractAdd
            // 
            this.contractAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.contractAdd.Controls.Add(this.addContractButton);
            this.contractAdd.Controls.Add(this.idCargo);
            this.contractAdd.Controls.Add(this.idRoute);
            this.contractAdd.Controls.Add(this.idCustomer);
            this.contractAdd.Controls.Add(this.idTruck);
            this.contractAdd.Controls.Add(this.unloadingDate);
            this.contractAdd.Controls.Add(this.loadingDate);
            this.contractAdd.Controls.Add(this.freightCost);
            this.contractAdd.Controls.Add(this.label9);
            this.contractAdd.Controls.Add(this.label8);
            this.contractAdd.Controls.Add(this.label7);
            this.contractAdd.Controls.Add(this.label6);
            this.contractAdd.Controls.Add(this.label5);
            this.contractAdd.Controls.Add(this.label4);
            this.contractAdd.Controls.Add(this.label3);
            this.contractAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.contractAdd.Location = new System.Drawing.Point(4, 45);
            this.contractAdd.Name = "contractAdd";
            this.contractAdd.Padding = new System.Windows.Forms.Padding(3);
            this.contractAdd.Size = new System.Drawing.Size(1237, 592);
            this.contractAdd.TabIndex = 0;
            this.contractAdd.Text = "Составление договора";
            // 
            // addContractButton
            // 
            this.addContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContractButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.addContractButton.Location = new System.Drawing.Point(873, 442);
            this.addContractButton.Name = "addContractButton";
            this.addContractButton.Size = new System.Drawing.Size(270, 43);
            this.addContractButton.TabIndex = 14;
            this.addContractButton.Text = "Добавить договор";
            this.addContractButton.UseVisualStyleBackColor = true;
            this.addContractButton.Click += new System.EventHandler(this.addContractButton_Click);
            // 
            // idCargo
            // 
            this.idCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.idCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.idCargo.Location = new System.Drawing.Point(377, 317);
            this.idCargo.Name = "idCargo";
            this.idCargo.Size = new System.Drawing.Size(403, 43);
            this.idCargo.TabIndex = 13;
            // 
            // idRoute
            // 
            this.idRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.idRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.idRoute.Location = new System.Drawing.Point(377, 268);
            this.idRoute.Name = "idRoute";
            this.idRoute.Size = new System.Drawing.Size(403, 43);
            this.idRoute.TabIndex = 12;
            // 
            // idCustomer
            // 
            this.idCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.idCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.idCustomer.Location = new System.Drawing.Point(377, 219);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(403, 43);
            this.idCustomer.TabIndex = 11;
            // 
            // idTruck
            // 
            this.idTruck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.idTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTruck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.idTruck.Location = new System.Drawing.Point(377, 170);
            this.idTruck.Name = "idTruck";
            this.idTruck.Size = new System.Drawing.Size(403, 43);
            this.idTruck.TabIndex = 10;
            // 
            // unloadingDate
            // 
            this.unloadingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.unloadingDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unloadingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.unloadingDate.Location = new System.Drawing.Point(377, 121);
            this.unloadingDate.Name = "unloadingDate";
            this.unloadingDate.Size = new System.Drawing.Size(403, 43);
            this.unloadingDate.TabIndex = 9;
            // 
            // loadingDate
            // 
            this.loadingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.loadingDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.loadingDate.Location = new System.Drawing.Point(377, 72);
            this.loadingDate.Name = "loadingDate";
            this.loadingDate.Size = new System.Drawing.Size(403, 43);
            this.loadingDate.TabIndex = 8;
            // 
            // freightCost
            // 
            this.freightCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.freightCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.freightCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.freightCost.Location = new System.Drawing.Point(377, 23);
            this.freightCost.Name = "freightCost";
            this.freightCost.Size = new System.Drawing.Size(403, 43);
            this.freightCost.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 36);
            this.label9.TabIndex = 6;
            this.label9.Text = "id груза:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 36);
            this.label8.TabIndex = 5;
            this.label8.Text = "id маршрута:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "id заказчика:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "id грузовика:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата выгрузки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата загрузки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Стоимость грузоперевозки:";
            // 
            // editBD
            // 
            this.editBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.editBD.Controls.Add(this.panel4);
            this.editBD.Controls.Add(this.panel3);
            this.editBD.Controls.Add(this.panel2);
            this.editBD.Location = new System.Drawing.Point(4, 45);
            this.editBD.Name = "editBD";
            this.editBD.Padding = new System.Windows.Forms.Padding(3);
            this.editBD.Size = new System.Drawing.Size(1237, 592);
            this.editBD.TabIndex = 2;
            this.editBD.Text = "Редактирование БД";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.cargoType);
            this.panel4.Controls.Add(this.cargoWeight);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.addCargo);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Location = new System.Drawing.Point(6, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(591, 186);
            this.panel4.TabIndex = 19;
            // 
            // cargoType
            // 
            this.cargoType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.cargoType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cargoType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.cargoType.Location = new System.Drawing.Point(267, 121);
            this.cargoType.Name = "cargoType";
            this.cargoType.Size = new System.Drawing.Size(302, 43);
            this.cargoType.TabIndex = 18;
            // 
            // cargoWeight
            // 
            this.cargoWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.cargoWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cargoWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.cargoWeight.Location = new System.Drawing.Point(267, 61);
            this.cargoWeight.Name = "cargoWeight";
            this.cargoWeight.Size = new System.Drawing.Size(258, 43);
            this.cargoWeight.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(3, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 36);
            this.label18.TabIndex = 16;
            this.label18.Text = "Тип груза:";
            // 
            // addCargo
            // 
            this.addCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.addCargo.Location = new System.Drawing.Point(432, 3);
            this.addCargo.Name = "addCargo";
            this.addCargo.Size = new System.Drawing.Size(154, 44);
            this.addCargo.TabIndex = 15;
            this.addCargo.Text = "Добавить";
            this.addCargo.UseVisualStyleBackColor = true;
            this.addCargo.Click += new System.EventHandler(this.addCargo_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(3, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(285, 36);
            this.label19.TabIndex = 1;
            this.label19.Text = "Добавить новый груз:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(3, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 36);
            this.label20.TabIndex = 2;
            this.label20.Text = "Вес груза:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.distance);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.endAddress);
            this.panel3.Controls.Add(this.startAddress);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.addRoute);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(603, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 241);
            this.panel3.TabIndex = 19;
            // 
            // distance
            // 
            this.distance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.distance.Location = new System.Drawing.Point(267, 179);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(248, 43);
            this.distance.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(3, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 36);
            this.label17.TabIndex = 19;
            this.label17.Text = "Дистанция:";
            // 
            // endAddress
            // 
            this.endAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.endAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.endAddress.Location = new System.Drawing.Point(267, 121);
            this.endAddress.Name = "endAddress";
            this.endAddress.Size = new System.Drawing.Size(302, 43);
            this.endAddress.TabIndex = 18;
            // 
            // startAddress
            // 
            this.startAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.startAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.startAddress.Location = new System.Drawing.Point(267, 61);
            this.startAddress.Name = "startAddress";
            this.startAddress.Size = new System.Drawing.Size(302, 43);
            this.startAddress.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(3, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 36);
            this.label13.TabIndex = 16;
            this.label13.Text = "Конечный адрес:";
            // 
            // addRoute
            // 
            this.addRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.addRoute.Location = new System.Drawing.Point(432, 3);
            this.addRoute.Name = "addRoute";
            this.addRoute.Size = new System.Drawing.Size(154, 44);
            this.addRoute.TabIndex = 15;
            this.addRoute.Text = "Добавить";
            this.addRoute.UseVisualStyleBackColor = true;
            this.addRoute.Click += new System.EventHandler(this.addRoute_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(344, 36);
            this.label14.TabIndex = 1;
            this.label14.Text = "Добавить новый маршрут:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(3, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 36);
            this.label15.TabIndex = 2;
            this.label15.Text = "Начальный адрес:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.customerEmail);
            this.panel2.Controls.Add(this.customerName);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.addCustomer);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 186);
            this.panel2.TabIndex = 3;
            // 
            // customerEmail
            // 
            this.customerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.customerEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.customerEmail.Location = new System.Drawing.Point(267, 121);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(302, 43);
            this.customerEmail.TabIndex = 18;
            // 
            // customerName
            // 
            this.customerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.customerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.customerName.Location = new System.Drawing.Point(267, 61);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(302, 43);
            this.customerName.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(3, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 36);
            this.label12.TabIndex = 16;
            this.label12.Text = "Почта:";
            // 
            // addCustomer
            // 
            this.addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.addCustomer.Location = new System.Drawing.Point(432, 3);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(154, 44);
            this.addCustomer.TabIndex = 15;
            this.addCustomer.Text = "Добавить";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(3, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(339, 36);
            this.label10.TabIndex = 1;
            this.label10.Text = "Добавить нового клиента:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(3, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "Имя:";
            // 
            // fullInfo
            // 
            this.fullInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.fullInfo.Controls.Add(this.dataGridView1);
            this.fullInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullInfo.Location = new System.Drawing.Point(4, 45);
            this.fullInfo.Name = "fullInfo";
            this.fullInfo.Padding = new System.Windows.Forms.Padding(3);
            this.fullInfo.Size = new System.Drawing.Size(1237, 592);
            this.fullInfo.TabIndex = 3;
            this.fullInfo.Text = "Полная информация";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(101)))), ((int)(((byte)(93)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1231, 586);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 58);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(66, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(659, 44);
            this.label16.TabIndex = 13;
            this.label16.Text = "Панель управления грузоперевозок";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label16_MouseDown);
            this.label16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label16_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(176)))), ((int)(((byte)(33)))));
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::Kursovaya.Properties.Resources.close;
            this.exitButton.Location = new System.Drawing.Point(1201, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 11;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(531, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 36);
            this.label21.TabIndex = 19;
            this.label21.Text = "кг";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(521, 181);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 36);
            this.label22.TabIndex = 21;
            this.label22.Text = "км";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1245, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuControl.ResumeLayout(false);
            this.customerInfo.ResumeLayout(false);
            this.customerInfo.PerformLayout();
            this.contractAdd.ResumeLayout(false);
            this.contractAdd.PerformLayout();
            this.editBD.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fullInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.TabControl menuControl;
        private System.Windows.Forms.TabPage contractAdd;
        private System.Windows.Forms.TabPage customerInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage editBD;
        private System.Windows.Forms.TabPage fullInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idCargo;
        private System.Windows.Forms.TextBox idRoute;
        private System.Windows.Forms.TextBox idCustomer;
        private System.Windows.Forms.TextBox idTruck;
        private System.Windows.Forms.TextBox unloadingDate;
        private System.Windows.Forms.TextBox loadingDate;
        private System.Windows.Forms.TextBox freightCost;
        private System.Windows.Forms.Button addContractButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox endAddress;
        private System.Windows.Forms.TextBox startAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button addRoute;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cargoType;
        private System.Windows.Forms.TextBox cargoWeight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button addCargo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}