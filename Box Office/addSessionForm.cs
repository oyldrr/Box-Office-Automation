using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace Box_Office
{
    public partial class addSessionForm : Form
    {
        public addSessionForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSessionForm_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Movies to movie drop down
            string query = "SELECT * FROM movies";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string id = dataReader["id"].ToString();
                string name = dataReader["name"].ToString();
                string age_restriction = dataReader["age_restriction"].ToString();
                string year = dataReader["year"].ToString(); 
                movieComboBox.Items.Add(id + " " + name + " " + age_restriction + " " + year);
            }
            dataReader.Close();
            //

            // customers to customer drop down
            string query2 = "SELECT * FROM customers";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);

            MySqlDataReader dataReader2 = cmd2.ExecuteReader();

            while (dataReader2.Read())
            {
                string fullname = dataReader2["fullname"].ToString();
                string id = dataReader2["id"].ToString();
                string age = dataReader2["age"].ToString();
                string gender = dataReader2["gender"].ToString();
                string tel = dataReader2["tel"].ToString();
                customerComboBox.Items.Add(id + " " + fullname + " " + age + " " + gender + " " + tel);
            }
            dataReader.Close();
            //

            connection.Close();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int movie = movieComboBox.SelectedIndex;
            int customer = customerComboBox.SelectedIndex;
            DateTime date = datePicker.Value;
            string price = priceComboBox.Text;

            if (movie < 0 || customer < 0 || price == "")
            {
                warningLabel.Visible = true;
            }
            else
            {
                warningLabel.Visible = false;
                string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    string query = "INSERT INTO sessions (movie, customer, date, price) VALUES (@val1, @val2, @val3, @val4)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", movie);
                    command.Parameters.AddWithValue("@val2", customer);
                    command.Parameters.AddWithValue("@val3", date);
                    command.Parameters.AddWithValue("@val4", price);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New session record succesfully created!", "Done");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Something went wrong!" + ex, "Error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
