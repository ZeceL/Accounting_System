namespace Accounting_System
{
    partial class Error_Password
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
            Close_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Close_Button
            // 
            Close_Button.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Close_Button.Location = new Point(189, 138);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(89, 35);
            Close_Button.TabIndex = 0;
            Close_Button.Text = "ОК";
            Close_Button.UseVisualStyleBackColor = true;
            Close_Button.Click += Close_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 65);
            label1.Name = "label1";
            label1.Size = new Size(238, 29);
            label1.TabIndex = 1;
            label1.Text = "Неверный пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 29);
            label2.TabIndex = 2;
            label2.Text = "Ошибка";
            // 
            // Error_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(468, 230);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Close_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Error_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error_Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close_Button;
        private Label label1;
        private Label label2;
    }
}