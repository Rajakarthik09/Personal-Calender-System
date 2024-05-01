namespace Personal_Calender_System
{
    partial class Form16
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
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 168);
            label1.Name = "label1";
            label1.Size = new Size(448, 41);
            label1.TabIndex = 0;
            label1.Text = "Please enter the Month and Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(132, 238);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 1;
            label2.Text = "Month and Year:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(343, 240);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(432, 30);
            dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(323, 334);
            button1.Name = "button1";
            button1.Size = new Size(177, 53);
            button1.TabIndex = 3;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form16";
            Text = "Form16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}