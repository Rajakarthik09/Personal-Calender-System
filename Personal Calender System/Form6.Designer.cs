namespace Personal_Calender_System
{
    partial class Form6
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
            eventIdDisplay = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(50, 185);
            label1.Name = "label1";
            label1.Size = new Size(705, 82);
            label1.TabIndex = 0;
            label1.Text = "Success!\r\n             Please save this Event Identification Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(75, 335);
            label2.Name = "label2";
            label2.Size = new Size(251, 41);
            label2.TabIndex = 1;
            label2.Text = "Event ID Number:";
            // 
            // eventIdDisplay
            // 
            eventIdDisplay.Location = new Point(386, 293);
            eventIdDisplay.Multiline = true;
            eventIdDisplay.Name = "eventIdDisplay";
            eventIdDisplay.Size = new Size(486, 116);
            eventIdDisplay.TabIndex = 11;
            eventIdDisplay.TextChanged += eventIdDisplay_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(519, 429);
            button1.Name = "button1";
            button1.Size = new Size(245, 58);
            button1.TabIndex = 12;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(button1);
            Controls.Add(eventIdDisplay);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox eventIdDisplay;
        private Button button1;
    }
}