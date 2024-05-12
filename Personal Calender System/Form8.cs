using MySql.Data.MySqlClient;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Personal_Calender_System
{
    public partial class Form8 : Form
    {
        private string connstr = "server=csitmariadb.eku.edu;uid=student;pwd=Maroon@21?;database=csc340_db;";
        private string availableSlots;
        private string duration;
        private string title;
        private string description;
        private DateTime date;
        private string user;
        private bool formLoaded = false;
        public Form8(string availableSlots, string duration, string title, DateTime date, string user, string description)
        {
            InitializeComponent();
            this.availableSlots = availableSlots;
            this.duration = duration;
            this.title = title;
            this.date = date;
            this.user = user;
            this.description = description;
            LoadTimeSlots();
            this.Load += YourNewForm_Load;

        }

        private void LoadTimeSlots()
        {
            availableTime.Text = availableSlots;
        }
        private string GenerateRandomEventId()
        {
            Random random = new Random();
            int eventId = random.Next(10000000, 99999999); // Generates an 8-digit random number
            return eventId.ToString();
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
                selectedTimeSlot = selectedTimeSlot.Trim();
                DateTime startTime = DateTime.ParseExact(selectedTimeSlot, "HH:mm", null);
                string event_id = GenerateRandomEventId();

                // Convert duration string to an integer (minutes)
                if (int.TryParse(duration, out int durationInMinutes))
                {

                    // Calculate end time
                    DateTime endTime = startTime.AddMinutes(durationInMinutes);
                    string StartTime = startTime.ToString("HH:mm");
                    string EndTime = endTime.ToString("HH:mm");


                    MessageBox.Show($"You selected: {selectedTimeSlot}");
                    using (MySqlConnection connection = new MySqlConnection(connstr))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO pcs_events (event_id, user, title, date, start_time, end_time, description) " +
                                             "VALUES (@Event_id, @User, @Title, @Date, @StartTime, @EndTime, @Description)";
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Event_id", event_id);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Date", date);
                            cmd.Parameters.AddWithValue("@StartTime", StartTime);
                            cmd.Parameters.AddWithValue("@User", user);
                            cmd.Parameters.AddWithValue("@EndTime", EndTime);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Invalid duration format. Please provide a valid numeric value.");
                }
                this.Hide();
                var f3 = new Form3(null);
                f3.FormClosed += (s, args) => this.Close();
                f3.Show();
            }
            }
        }
    }
