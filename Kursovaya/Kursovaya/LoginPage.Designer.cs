namespace Kursovaya
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginPageLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            this.loginImage = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginBox.Location = new System.Drawing.Point(159, 207);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(246, 36);
            this.loginBox.TabIndex = 0;
            this.loginBox.Text = "Введите логин";
            this.loginBox.Click += new System.EventHandler(this.loginBox_Click);
            this.loginBox.MouseEnter += new System.EventHandler(this.loginBox_MouseEnter);
            this.loginBox.MouseLeave += new System.EventHandler(this.loginBox_MouseLeave);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordBox.Location = new System.Drawing.Point(159, 298);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(246, 36);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "Введите пароль";
            this.passwordBox.Click += new System.EventHandler(this.passwordBox_Click);
            this.passwordBox.MouseEnter += new System.EventHandler(this.passwordBox_MouseEnter);
            this.passwordBox.MouseLeave += new System.EventHandler(this.passwordBox_MouseLeave);
            // 
            // loginPageLabel
            // 
            this.loginPageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPageLabel.Location = new System.Drawing.Point(0, 0);
            this.loginPageLabel.Name = "loginPageLabel";
            this.loginPageLabel.Size = new System.Drawing.Size(486, 162);
            this.loginPageLabel.TabIndex = 2;
            this.loginPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginButton.Location = new System.Drawing.Point(0, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(486, 100);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.loginPageLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 162);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Kursovaya.Properties.Resources.delivery;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // passwordImage
            // 
            this.passwordImage.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordImage.Image = global::Kursovaya.Properties.Resources.passwordIcon;
            this.passwordImage.Location = new System.Drawing.Point(74, 298);
            this.passwordImage.Name = "passwordImage";
            this.passwordImage.Size = new System.Drawing.Size(48, 48);
            this.passwordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordImage.TabIndex = 6;
            this.passwordImage.TabStop = false;
            // 
            // loginImage
            // 
            this.loginImage.BackColor = System.Drawing.Color.Gainsboro;
            this.loginImage.Image = global::Kursovaya.Properties.Resources.user;
            this.loginImage.Location = new System.Drawing.Point(74, 207);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(48, 48);
            this.loginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginImage.TabIndex = 5;
            this.loginImage.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::Kursovaya.Properties.Resources.close;
            this.exitButton.Location = new System.Drawing.Point(442, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(32, 32);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 4;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 100);
            this.panel2.TabIndex = 8;
            // 
            // LoginPage
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(486, 489);
            this.Controls.Add(this.passwordImage);
            this.Controls.Add(this.loginImage);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label loginPageLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.PictureBox passwordImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}