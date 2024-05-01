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
    public partial class Form15 : Form
    {
        private string event_id;
        private string connstr = "server=csitmariadb.eku.edu;uid=student;pwd=Maroon@21?;database=csc340_db;";

        public Form15(string event_id)
        {
            InitializeComponent();
            this.event_id = event_id;
            LoadEventDetails();
        }

        private void LoadEventDetails()
        {

            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string selectQuery = "SELECT date, start_time, end_time FROM pcs_events WHERE event_id = @Event_Id";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Event_Id", event_id);

                    // Execute the query and read the result
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have a TextBox named txtResult to display the result
                            eventdisplay.Text = $"Date: {reader["date"]}\n Start Time: {reader["start_time"]}\n End Time: {reader["end_time"]}";
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
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM pcs_events WHERE event_id = @Event_Id;";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Event_Id", event_id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error deleting event: {ex.Message}");
            }
            this.Hide();
            var f3 = new Form3(null);
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
        }
    }
}
