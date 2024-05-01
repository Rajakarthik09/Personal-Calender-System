namespace Personal_Calender_System
{
    partial class Form3
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(120, 161);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(494, 31);
            label1.TabIndex = 1;
            label1.Text = "Personal Calender with Meeting Coordinator";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(665, 86);
            button1.Name = "button1";
            button1.Size = new Size(175, 38);
            button1.TabIndex = 2;
            button1.Text = "Add Event";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(665, 144);
            button2.Name = "button2";
            button2.Size = new Size(175, 38);
            button2.TabIndex = 3;
            button2.Text = "Create Meeting";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Location = new Point(665, 204);
            button3.Name = "button3";
            button3.Size = new Size(175, 38);
            button3.TabIndex = 4;
            button3.Text = "View Event";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Location = new Point(665, 267);
            button4.Name = "button4";
            button4.Size = new Size(175, 38);
            button4.TabIndex = 5;
            button4.Text = "View Event List";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(665, 330);
            button5.Name = "button5";
            button5.Size = new Size(175, 38);
            button5.TabIndex = 6;
            button5.Text = "Edit Event";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Location = new Point(665, 392);
            button6.Name = "button6";
            button6.Size = new Size(175, 38);
            button6.TabIndex = 7;
            button6.Text = "Delete Event";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.Location = new Point(665, 452);
            button7.Name = "button7";
            button7.Size = new Size(175, 38);
            button7.TabIndex = 8;
            button7.Text = "Delete Meeting";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Location = new Point(121, 411);
            button8.Name = "button8";
            button8.Size = new Size(263, 50);
            button8.TabIndex = 9;
            button8.Text = "LogOut";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(900, 518);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}