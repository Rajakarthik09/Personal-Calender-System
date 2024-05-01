using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Calender_System
{
    public partial class Form8 : Form
    {
        private string availableSlots;
        private bool formLoaded = false;
        public Form8(string availableSlots)
        {
            InitializeComponent();
            this.availableSlots = availableSlots;
            LoadTimeSlots();
            this.Load += YourNewForm_Load;

        }

        private void LoadTimeSlots()
        {
            availableTime.Text = availableSlots;
        }
        private void YourNewForm_Load(object sender, EventArgs e)
        {
            formLoaded = true; // Set the flag to indicate that the form has loaded
        }
        private void availableTime_TextChanged(object sender, EventArgs e)
        {
            if (formLoaded) // Execute the logic only after the form has loaded
            {
                // Get the selected time slot from the textbox
                string selectedTimeSlot = availableTime.Text;

                // Add your custom logic here
                // For example, show a message or perform an action based on the selected time slot
                MessageBox.Show($"You selected: {selectedTimeSlot}");
            }
        }
    }
}
