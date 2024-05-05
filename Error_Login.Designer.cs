namespace Accounting_System
{
    partial class Error_Login
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
            label1 = new Label();
            label2 = new Label();
            Close_Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 69);
            label1.Name = "label1";
            label1.Size = new Size(223, 29);
            label1.TabIndex = 0;
            label1.Text = "Неверный логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 1;
            label2.Text = "Ошибка";
            // 
            // Close_Button
            // 
            Close_Button.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Close_Button.Location = new Point(183, 136);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(97, 40);
            Close_Button.TabIndex = 2;
            Close_Button.Text = "ОК";
            Close_Button.UseVisualStyleBackColor = true;
            Close_Button.Click += Close_Button_Click;
            // 
            // Error_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(468, 230);
            Controls.Add(Close_Button);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Error_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error_Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Close_Button;
    }
}