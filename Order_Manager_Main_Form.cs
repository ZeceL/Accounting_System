using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace Accounting_System
{
    public partial class Order_Manager_Main_Form : Form
    {
        private OracleDB oracleDB;
        public Order_Manager_Main_Form()
        {
            InitializeComponent();
            oracleDB = new OracleDB();
            
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn_Form logIn_Form = new();
            logIn_Form.ShowDialog();
        }

        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.DarkRed;
        }
        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.White;
        }

        private void Order_Manager_Main_Form_Load(object sender, EventArgs e)
        {

            oracleDB.OpenConnection();
            dataGridView1.DataSource = oracleDB.GetUserData();
            oracleDB.CloseConnection();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            oracleDB.OpenConnection();
        }

        private void Close_conection_button_Click(object sender, EventArgs e)
        {
            oracleDB.CloseConnection();
        }
    }
}
