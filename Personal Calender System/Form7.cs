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

namespace Personal_Calender_System
{
    public partial class Form7 : Form
    {
        private string connstr = "server=csitmariadb.eku.edu;uid=student;pwd=Maroon@21?;database=csc340_db;";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private DataTable GetBookedTimeSlots(DateTime startDate, DateTime endDate)
        {
            DataTable result = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    connection.Open();
                    string query = "SELECT start_time FROM pcs_events WHERE date = @StartDate AND end_time <= @EndDate";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Date);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving booked time slots: " + ex.Message);
            }
            return result;
        }

        private List<string> GenerateAllTimeSlots(DateTime startDate, DateTime endDate, int durationMinutes)
        {
            List<string> timeSlots = new List<string>();
            DateTime currentTime = startDate;
            while (currentTime <= endDate)
            {
                timeSlots.Add(currentTime.ToString("HH:mm"));
                currentTime = currentTime.AddMinutes(durationMinutes);
            }
            return timeSlots;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the desired meeting duration (in minutes)
            int durationMinutes;
            if (!int.TryParse(txtDuration.Text, out durationMinutes) || durationMinutes <= 0)
            {
                MessageBox.Show("Invalid duration. Please enter a positive integer.");
                return;
            }

            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Calculate the end time based on duration
            DateTime endTime = currentDateTime.AddMinutes(durationMinutes);

            // Query the database for booked time slots
            DataTable bookedSlots = GetBookedTimeSlots(currentDateTime, endTime);

            // Generate all possible time slots
            List<string> allTimeSlots = GenerateAllTimeSlots(currentDateTime, endTime, durationMinutes);

            // Exclude booked time slots
            List<string> availableSlots = allTimeSlots.Except(bookedSlots.AsEnumerable().Select(r => r.Field<string>("start_time"))).ToList();

            // Display the available time slots in a message box
            string availableSlotsMessage = string.Join("\n ", availableSlots);
            this.Hide();
            var f8 = new Form8(availableSlotsMessage);
            f8.FormClosed += (s, args) => this.Close();
            f8.Show();
        }
    }
}
