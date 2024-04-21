namespace Accounting_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (User_login.Text) 
            {
                case "Alex":
                    if (User_password.Text.Contains("1234")) 
                    {
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.ShowDialog();
                    }
                    break;
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.DarkRed;
        }

        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            Close_Button.ForeColor = Color.White;
        }
    }
}
