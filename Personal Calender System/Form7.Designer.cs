namespace Personal_Calender_System
{
    partial class Form7
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
            button1 = new Button();
            txtDescription = new TextBox();
            label6 = new Label();
            datePicker = new DateTimePicker();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            txtDuration = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(345, 433);
            button1.Name = "button1";
            button1.Size = new Size(200, 43);
            button1.TabIndex = 23;
            button1.Text = "Availability";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(345, 297);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(319, 116);
            txtDescription.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(232, 300);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 21;
            label6.Text = "Description:";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(345, 74);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(324, 30);
            datePicker.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 80);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 14;
            label2.Text = "Select Date:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(345, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(324, 30);
            txtTitle.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 12;
            label1.Text = "Add Title:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 99);
            textBox1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 181);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 24;
            label3.Text = "Members:";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(345, 130);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(324, 30);
            txtDuration.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(249, 133);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 26;
            label4.Text = "Duration:";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(txtDuration);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(datePicker);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtDescription;
        private Label label6;
        private DateTimePicker datePicker;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtDuration;
        private Label label4;
    }
}