using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Personal_Calender_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            PopulateTimeComboBoxes();
        }

        private string GenerateRandomEventId()
        {
            Random random = new Random();
            int eventId = random.Next(10000000, 99999999); // Generates an 8-digit random number
            return eventId.ToString();
        }
        private void PopulateTimeComboBoxes()
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Round current time up to the nearest 30 minutes
            currentTime = currentTime.AddMinutes(30 - currentTime.Minute % 30);

            // Generate time intervals until the end of the day
            DateTime endOfDay = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 23, 59, 59);

            while (currentTime <= endOfDay)
            {
                comboBoxStartTime.Items.Add(currentTime.ToString("H:mm"));
                currentTime = currentTime.AddMinutes(30);
                comboBoxEndTime.Items.Add(currentTime.ToString("H:mm"));
            }

            // Set default values (optional)
            comboBoxStartTime.SelectedIndex = 0;
            comboBoxEndTime.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Get data from form fields
            string title = txtTitle.Text;
            DateTime date = datePicker.Value.Date;
            string startTime = comboBoxStartTime.SelectedItem.ToString();
            string endTime = comboBoxEndTime.SelectedItem.ToString();
            string description = txtDescription.Text;
            string connstr = "server=csitmariadb.eku.edu;uid=student;pwd=Maroon@21?;database=csc340_db;";
            string event_id = GenerateRandomEventId();

            // Check if the specified start time and date already exist in the table
            bool conflictExists = false;
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM pcs_events WHERE start_time = @StartTime AND date = @Date";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@StartTime", startTime);
                    checkCmd.Parameters.AddWithValue("@Date", date);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    conflictExists = count > 0;
                }
            }

            if (conflictExists)
            {
                this.Hide();
                var f5 = new Form5();
                f5.FormClosed += (s, args) => this.Close();
                f5.Show();
            }
            else
            {
                // Insert data into the database
                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO pcs_events (event_id, title, date, start_time, end_time, description) " +
                                         "VALUES (@Event_Id, @Title, @Date, @StartTime, @EndTime, @Description)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Event_Id", event_id);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@StartTime", startTime);
                        cmd.Parameters.AddWithValue("@EndTime", endTime);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Hide the current form and show Form3 (assuming Form3 is your next form)
                this.Hide();
                var f6 = new Form6(event_id);
                f6.FormClosed += (s, args) => this.Close();
                f6.Show();
            }
        }
    }
}
