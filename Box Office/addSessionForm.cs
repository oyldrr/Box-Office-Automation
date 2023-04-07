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

            MySqlDataReader row = cmd.ExecuteReader();

            while (row.Read())
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string age_restriction = row["age_restriction"].ToString();
                string year = row["year"].ToString(); 
                movieComboBox.Items.Add(id + " " + name + " " + age_restriction + " " + year);
            }
            row.Close();
            //

            // customers to customer drop down
            query = "SELECT * FROM customers";
            cmd = new MySqlCommand(query, connection);

            row = cmd.ExecuteReader();

            while (row.Read())
            {
                string fullname = row["fullname"].ToString();
                string id = row["id"].ToString();
                string age = row["age"].ToString();
                string gender = row["gender"].ToString();
                string tel = row["tel"].ToString();
                customerComboBox.Items.Add(id + " " + fullname + " " + age + " " + gender + " " + tel);
            }
            row.Close();
            //

            connection.Close();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Parsing the text to get id of movie 
            string selectedItemText = movieComboBox.SelectedItem.ToString();
            int firstSpaceIndex = selectedItemText.IndexOf(" ");
            string integerString = selectedItemText.Substring(0, firstSpaceIndex);
            int movieId = int.Parse(integerString);
            //

            // Parsing the text to get id of customer
            selectedItemText = customerComboBox.SelectedItem.ToString();
            firstSpaceIndex = selectedItemText.IndexOf(" ");
            integerString = selectedItemText.Substring(0, firstSpaceIndex);
            int customerId = int.Parse(integerString);
            //

            // Setting variables to use later
            int movie = movieId;
            int customer = customerId;
            DateTime date = datePicker.Value;
            string price = priceComboBox.Text;

            Random random = new Random();
            string barcode = "";
            for (int i = 1; i <= 11; i++)
            {
                barcode = random.Next(0, 9) + barcode;
            }
            //

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
                    string query = "INSERT INTO sessions (movie, customer, date, price, barcode) VALUES (@val1, @val2, @val3, @val4, @val5)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", movie);
                    command.Parameters.AddWithValue("@val2", customer);
                    command.Parameters.AddWithValue("@val3", date);
                    command.Parameters.AddWithValue("@val4", price);
                    command.Parameters.AddWithValue("@val5", barcode);
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
