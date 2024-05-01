namespace Personal_Calender_System
{
    partial class Form8
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
            availableTime = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(456, 41);
            label1.TabIndex = 0;
            label1.Text = "Select a Time from the list below:";
            // 
            // availableTime
            // 
            availableTime.Location = new Point(66, 158);
            availableTime.Multiline = true;
            availableTime.Name = "availableTime";
            availableTime.Size = new Size(319, 157);
            availableTime.TabIndex = 23;
            availableTime.TextChanged += availableTime_TextChanged;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(availableTime);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox availableTime;
    }
}