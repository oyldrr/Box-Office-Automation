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
