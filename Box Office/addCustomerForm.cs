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
    public partial class addCustomerForm : Form
    {
        public addCustomerForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fullname = fullnameTextBox.Text;
            int age = Convert.ToInt32(ageUpDown.Value);
            string gender = genderComboBox.Text;
            string tel = telTextBox.Text;
            string mail = mailTextBox.Text;
            string address = addressTextBox.Text;

            if (fullname == "" || tel == "" )
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
                    string query = "INSERT INTO customers (fullname, age, gender, tel, mail, address) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", fullname);
                    command.Parameters.AddWithValue("@val2", age);
                    command.Parameters.AddWithValue("@val3", gender);
                    command.Parameters.AddWithValue("@val4", tel);
                    command.Parameters.AddWithValue("@val5", mail);
                    command.Parameters.AddWithValue("@val6", address);
                    command.ExecuteNonQuery();
                    MessageBox.Show("New customer record succesfully created!", "Done");
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

        private void fullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }

        private void telTextBox_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }
    }
}
