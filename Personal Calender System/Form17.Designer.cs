namespace Personal_Calender_System
{
    partial class Form17
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
            eventdisplay = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(351, 356);
            button1.Name = "button1";
            button1.Size = new Size(194, 63);
            button1.TabIndex = 11;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // eventdisplay
            // 
            eventdisplay.Location = new Point(235, 144);
            eventdisplay.Multiline = true;
            eventdisplay.Name = "eventdisplay";
            eventdisplay.Size = new Size(425, 192);
            eventdisplay.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(282, 100);
            label1.Name = "label1";
            label1.Size = new Size(348, 41);
            label1.TabIndex = 9;
            label1.Text = "Monthly Based Event List";
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(button1);
            Controls.Add(eventdisplay);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form17";
            Text = "Form17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox eventdisplay;
        private Label label1;
    }
}