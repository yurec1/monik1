namespace WindowsFormsApp1
{
    partial class Login
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
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_bd = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.lb_server = new System.Windows.Forms.Label();
            this.tb_dbuser = new System.Windows.Forms.TextBox();
            this.tb_dbpassw = new System.Windows.Forms.TextBox();
            this.tb_dbadress = new System.Windows.Forms.TextBox();
            this.tb_dbname = new System.Windows.Forms.TextBox();
            this.tb_dbport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_connect.Location = new System.Drawing.Point(380, 104);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(115, 34);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Вхід";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_cancel.Location = new System.Drawing.Point(380, 144);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(115, 34);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Відмінити";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_user.Location = new System.Drawing.Point(6, 19);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(115, 24);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "Користувач";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_password.Location = new System.Drawing.Point(6, 47);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(76, 24);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Пароль";
            // 
            // lb_bd
            // 
            this.lb_bd.AutoSize = true;
            this.lb_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_bd.Location = new System.Drawing.Point(6, 103);
            this.lb_bd.Name = "lb_bd";
            this.lb_bd.Size = new System.Drawing.Size(78, 24);
            this.lb_bd.TabIndex = 4;
            this.lb_bd.Text = "Ім\'я БД:";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_port.Location = new System.Drawing.Point(6, 131);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(55, 24);
            this.lb_port.TabIndex = 5;
            this.lb_port.Text = "Порт";
            // 
            // lb_server
            // 
            this.lb_server.AutoSize = true;
            this.lb_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_server.Location = new System.Drawing.Point(6, 75);
            this.lb_server.Name = "lb_server";
            this.lb_server.Size = new System.Drawing.Size(143, 24);
            this.lb_server.TabIndex = 11;
            this.lb_server.Text = "Сервер БД (IP)";
            // 
            // tb_dbuser
            // 
            this.tb_dbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_dbuser.Location = new System.Drawing.Point(172, 19);
            this.tb_dbuser.Name = "tb_dbuser";
            this.tb_dbuser.Size = new System.Drawing.Size(195, 29);
            this.tb_dbuser.TabIndex = 12;
            this.tb_dbuser.Text = "postgres";
            // 
            // tb_dbpassw
            // 
            this.tb_dbpassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_dbpassw.Location = new System.Drawing.Point(172, 47);
            this.tb_dbpassw.Name = "tb_dbpassw";
            this.tb_dbpassw.PasswordChar = '*';
            this.tb_dbpassw.Size = new System.Drawing.Size(195, 29);
            this.tb_dbpassw.TabIndex = 13;
            this.tb_dbpassw.Text = "130017";
            // 
            // tb_dbadress
            // 
            this.tb_dbadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_dbadress.Location = new System.Drawing.Point(172, 75);
            this.tb_dbadress.Name = "tb_dbadress";
            this.tb_dbadress.Size = new System.Drawing.Size(195, 29);
            this.tb_dbadress.TabIndex = 14;
            this.tb_dbadress.Text = "127.0.0.1";
            // 
            // tb_dbname
            // 
            this.tb_dbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_dbname.Location = new System.Drawing.Point(172, 103);
            this.tb_dbname.Name = "tb_dbname";
            this.tb_dbname.Size = new System.Drawing.Size(195, 29);
            this.tb_dbname.TabIndex = 15;
            this.tb_dbname.Text = "postgres";
            // 
            // tb_dbport
            // 
            this.tb_dbport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_dbport.Location = new System.Drawing.Point(172, 131);
            this.tb_dbport.Name = "tb_dbport";
            this.tb_dbport.Size = new System.Drawing.Size(195, 29);
            this.tb_dbport.TabIndex = 16;
            this.tb_dbport.Text = "5432";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-3, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "©ХНУПС, Кафедра математичного та програмного забезпечення АСУ, 2018";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.HNUPS;
            this.pictureBox1.Location = new System.Drawing.Point(376, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.bt_connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(519, 193);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dbport);
            this.Controls.Add(this.tb_dbname);
            this.Controls.Add(this.tb_dbadress);
            this.Controls.Add(this.tb_dbpassw);
            this.Controls.Add(this.tb_dbuser);
            this.Controls.Add(this.lb_server);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.lb_bd);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_connect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_bd;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.Label lb_server;
        private System.Windows.Forms.TextBox tb_dbuser;
        private System.Windows.Forms.TextBox tb_dbpassw;
        private System.Windows.Forms.TextBox tb_dbadress;
        private System.Windows.Forms.TextBox tb_dbname;
        private System.Windows.Forms.TextBox tb_dbport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}