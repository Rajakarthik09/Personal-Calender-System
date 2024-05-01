namespace Personal_Calender_System
{
    partial class Form11
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
            label2 = new Label();
            eventidbox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(346, 307);
            button1.Name = "button1";
            button1.Size = new Size(233, 72);
            button1.TabIndex = 31;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(82, 210);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 30;
            label2.Text = "Event ID Number:";
            // 
            // eventidbox
            // 
            eventidbox.Location = new Point(308, 183);
            eventidbox.Multiline = true;
            eventidbox.Name = "eventidbox";
            eventidbox.Size = new Size(580, 91);
            eventidbox.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(615, 41);
            label1.TabIndex = 28;
            label1.Text = "Please enter the Event Identification Number:";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(eventidbox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox eventidbox;
        private Label label1;
    }
}