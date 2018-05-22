using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            {
                
                // try connect to db
                NpgsqlConnection conn = new Npgsql.NpgsqlConnection("Server=" + tb_dbadress.Text + ";User Id=" + tb_dbuser.Text + ";Password=" + tb_dbpassw.Text + ";Database=" + tb_dbname.Text + ";Encoding=UNICODE;");
                //Open connection
                conn.Open();
                conn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
