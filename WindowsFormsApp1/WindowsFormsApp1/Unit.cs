using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UnitM : Form
    {
        public UnitM()
        {
          
            InitializeComponent();
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            textBox5.Text = UnitInfo.LocationX.ToString();
            textBox6.Text = UnitInfo.LocationY.ToString();
            //comboBox1.Items.Add(sender\)
            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            UnitInfo.Name = tb_Name.Text;
            this.Close();


        }
    }
}
