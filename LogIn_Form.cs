namespace Accounting_System
{
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void Show_Password_Button_MouseDown(object sender, EventArgs e)
        {
            User_password.UseSystemPasswordChar = false;
        }

        private void Show_Password_Button_MouseUp(object sender, MouseEventArgs e)
        {
            User_password.UseSystemPasswordChar = true;
        }

        private void LogIn_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            string Alex_Password = "1";
            switch (User_login.Text)
            {
                case "1":
                    if (User_password.Text.Contains(Alex_Password))
                    {
                        Order_Manager_Main_Form form2 = new();
                        this.Hide();
                        form2.ShowDialog();
                    }
                    else
                    {
                        Error_Password error_Password1 = new();
                        error_Password1.ShowDialog();
                    }
                    break;
                default:
                    Error_Login error_Password = new();
                    error_Password.ShowDialog();
                    break;
            }
        }
    }
}
