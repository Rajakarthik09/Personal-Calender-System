using MySql.Data.MySqlClient;
namespace Personal_Calender_System
{
    public partial class Form1 : Form
    {

        // You can execute queries or other database operations here
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connstr = "server=csitmariadb.eku.edu;uid=student;pwd=Maroon@21?;database=csc340_db;";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                MessageBox.Show("Connected to the database!");
                // You can execute queries or other database operations here
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string selectQuery = "SELECT username, password FROM pcs_users WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string storedPassword = reader["password"].ToString();

                    // Compare stored password with input password
                    if (storedPassword == textBox2.Text)
                    {
                        this.Hide();
                        var f3 = new Form3(textBox1.Text);
                        f3.FormClosed += (s, args) => this.Close();
                        f3.Show();
                    }
                    else
                    {
                        this.Hide();
                        var f2 = new Form2();
                        f2.FormClosed += (s, args) => this.Close();
                        f2.Show();
                    }
                }
                else
                {
                    this.Hide();
                    var f2 = new Form2();
                    f2.FormClosed += (s, args) => this.Close();
                    f2.Show();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
