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

namespace Personal_Calender_System
{
    public partial class Form17 : Form
    {
        private DateTime date;
        private string connstr = "server=csitmariadb.eku.edu;uid=student;pwd=Maroon@21?;database=csc340_db;";
        public Form17(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            LoadEventDetails();
        }

        private void LoadEventDetails()
        {

            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string selectQuery = "SELECT date, start_time, end_time FROM pcs_events WHERE date = @Date";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Date", date);

                    // Execute the query and read the result
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Initialize a StringBuilder to store all event information
                            StringBuilder eventInfo = new StringBuilder();

                            while (reader.Read())
                            {
                                string eventDate = reader["date"].ToString();
                                string startTime = reader["start_time"].ToString();
                                string endTime = reader["end_time"].ToString();

                                // Append event information to the StringBuilder
                                eventInfo.AppendLine($"Date: {eventDate}, Start Time: {startTime}, End Time: {endTime}");
                            }

                            // Assuming you have a TextBox named eventdisplay to display the result
                            eventdisplay.Text = eventInfo.ToString();
                        }
                        else
                        {
                            eventdisplay.Text = "No data found for the specified event ID.";
                        }
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f3 = new Form3(null);
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
        }
    }
}
