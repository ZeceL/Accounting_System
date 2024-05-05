namespace Accounting_System
{
    partial class Order_Manager_Main_Form
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
            Close_Button = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            Update_button = new Button();
            Close_conection_button = new Button();
            textBox_Error = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Close_Button
            // 
            Close_Button.AutoSize = true;
            Close_Button.Cursor = Cursors.Hand;
            Close_Button.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Close_Button.ForeColor = Color.White;
            Close_Button.Location = new Point(1730, 9);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(42, 42);
            Close_Button.TabIndex = 9;
            Close_Button.Text = "X";
            Close_Button.Click += Close_Button_Click;
            Close_Button.MouseEnter += Close_Button_MouseEnter;
            Close_Button.MouseLeave += Close_Button_MouseLeave;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1652, 937);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox_Error);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1644, 909);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(788, 897);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1644, 909);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1644, 909);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Update_button
            // 
            Update_button.Location = new Point(1681, 87);
            Update_button.Name = "Update_button";
            Update_button.Size = new Size(91, 63);
            Update_button.TabIndex = 11;
            Update_button.Text = "Обновить данные";
            Update_button.UseVisualStyleBackColor = true;
            Update_button.Click += Update_button_Click;
            // 
            // Close_conection_button
            // 
            Close_conection_button.Location = new Point(1681, 169);
            Close_conection_button.Name = "Close_conection_button";
            Close_conection_button.Size = new Size(91, 76);
            Close_conection_button.TabIndex = 12;
            Close_conection_button.Text = "закрыть конект";
            Close_conection_button.UseVisualStyleBackColor = true;
            Close_conection_button.Click += Close_conection_button_Click;
            // 
            // textBox_Error
            // 
            textBox_Error.Location = new Point(850, 72);
            textBox_Error.Name = "textBox_Error";
            textBox_Error.Size = new Size(100, 23);
            textBox_Error.TabIndex = 1;
            // 
            // Order_Manager_Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1784, 961);
            Controls.Add(Close_conection_button);
            Controls.Add(Update_button);
            Controls.Add(tabControl1);
            Controls.Add(Close_Button);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order_Manager_Main_Form";
            StartPosition = FormStartPosition.Manual;
            Text = "Order_Manager_Main_Form";
            Load += Order_Manager_Main_Form_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Close_Button;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button Update_button;
        private Button Close_conection_button;
        private TextBox textBox_Error;
    }
}