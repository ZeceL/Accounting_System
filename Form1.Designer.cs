namespace Accounting_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            User_login = new TextBox();
            User_password = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Close_Button = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(540, 77);
            label1.TabIndex = 0;
            label1.Text = "Вход в систему";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(334, 117);
            label2.Name = "label2";
            label2.Size = new Size(178, 58);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(334, 255);
            label3.Name = "label3";
            label3.Size = new Size(210, 58);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // User_login
            // 
            User_login.Cursor = Cursors.IBeam;
            User_login.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            User_login.Location = new Point(334, 178);
            User_login.Name = "User_login";
            User_login.Size = new Size(432, 52);
            User_login.TabIndex = 3;
            // 
            // User_password
            // 
            User_password.Cursor = Cursors.IBeam;
            User_password.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            User_password.Location = new Point(334, 314);
            User_password.Name = "User_password";
            User_password.Size = new Size(432, 52);
            User_password.TabIndex = 4;
            User_password.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Turquoise;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(429, 430);
            button1.Name = "button1";
            button1.Size = new Size(191, 74);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_icon;
            pictureBox1.Location = new Point(269, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password_icon;
            pictureBox2.Location = new Point(269, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Close_Button
            // 
            Close_Button.AutoSize = true;
            Close_Button.Cursor = Cursors.Hand;
            Close_Button.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Close_Button.ForeColor = Color.White;
            Close_Button.Location = new Point(1084, 9);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(42, 42);
            Close_Button.TabIndex = 8;
            Close_Button.Text = "X";
            Close_Button.Click += Close_Button_Click;
            Close_Button.MouseEnter += Close_Button_MouseEnter;
            Close_Button.MouseLeave += Close_Button_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1138, 678);
            Controls.Add(Close_Button);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(User_password);
            Controls.Add(User_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox User_login;
        private TextBox User_password;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Close_Button;
    }
}
