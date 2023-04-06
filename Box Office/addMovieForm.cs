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

namespace Box_Office
{
    public partial class addMovieForm : Form
    {
        public addMovieForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string age_restriction = ageComboBox.Text;
            string year = yearComboBox.Text;
            string director = directorTextBox.Text;
            string producer = producerTextBox.Text;
            string screenwriter = screewriterTextBox.Text;

            if (name == "")
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
                    string query = "INSERT INTO movies (name, age_restriction, year, director, producer, screenwriter) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", name);
                    command.Parameters.AddWithValue("@val2", age_restriction);
                    command.Parameters.AddWithValue("@val3", year);
                    command.Parameters.AddWithValue("@val4", director);
                    command.Parameters.AddWithValue("@val5", producer);
                    command.Parameters.AddWithValue("@val6", screenwriter);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New movie record succesfully created!", "Done");
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

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Visible=false;
        }
    }
}
