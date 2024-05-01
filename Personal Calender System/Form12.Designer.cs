namespace Personal_Calender_System
{
    partial class Form12
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
            button1.Location = new Point(354, 356);
            button1.Name = "button1";
            button1.Size = new Size(194, 63);
            button1.TabIndex = 5;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // eventdisplay
            // 
            eventdisplay.Location = new Point(238, 144);
            eventdisplay.Multiline = true;
            eventdisplay.Name = "eventdisplay";
            eventdisplay.Size = new Size(425, 192);
            eventdisplay.TabIndex = 4;
            eventdisplay.TextChanged += eventdisplay_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(223, 100);
            label1.Name = "label1";
            label1.Size = new Size(459, 41);
            label1.TabIndex = 3;
            label1.Text = "Would you like to edit this Event?";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(button1);
            Controls.Add(eventdisplay);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox eventdisplay;
        private Label label1;
    }
}