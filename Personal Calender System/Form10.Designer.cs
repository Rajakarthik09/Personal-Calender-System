namespace Personal_Calender_System
{
    partial class Form10
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
            eventdisplay = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(343, 132);
            label1.Name = "label1";
            label1.Size = new Size(194, 41);
            label1.TabIndex = 0;
            label1.Text = "Event Details:";
            // 
            // eventdisplay
            // 
            eventdisplay.Location = new Point(227, 176);
            eventdisplay.Multiline = true;
            eventdisplay.Name = "eventdisplay";
            eventdisplay.Size = new Size(425, 192);
            eventdisplay.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(343, 388);
            button1.Name = "button1";
            button1.Size = new Size(194, 63);
            button1.TabIndex = 2;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(button1);
            Controls.Add(eventdisplay);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox eventdisplay;
        private Button button1;
    }
}