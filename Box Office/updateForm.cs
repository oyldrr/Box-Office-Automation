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
    public partial class updateForm : Form
    {
        public updateForm()
        {
            InitializeComponent();
        }

        public void getSessions()
        {
            string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // setting the text of movieComboBox 
            string query = "select * from movies inner join sessions on movies.id = sessions.movie where sessions.id = " + main.selectedId;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string age_restriction = row["age_restriction"].ToString();
                string year = row["year"].ToString();
                movieComboBox.Text = id + " " + name + " " + age_restriction + " " + year;
            }
            row.Close();
            //

            // setting the text of customerComboBox 
            query = "select * from customers inner join sessions on customers.id = sessions.customer where sessions.id = " + main.selectedId;
            cmd = new MySqlCommand(query, connection);
            row = cmd.ExecuteReader();
            while (row.Read())
            {
                string fullname = row["fullname"].ToString();
                string id = row["id"].ToString();
                string age = row["age"].ToString();
                string gender = row["gender"].ToString();
                string tel = row["tel"].ToString();
                customerComboBox.Text = id + " " + fullname + " " + age + " " + gender + " " + tel;
            }
            row.Close();
            //


            // setting the text of datepicker
            query = "select date from sessions where sessions.id = " + main.selectedId;
            cmd = new MySqlCommand(query, connection);
            row = cmd.ExecuteReader();
            while (row.Read())
            {
                DateTime date = (DateTime)row["date"];
                datePicker.Value = date;
            }
            row.Close();
            //

            // setting the text of price
            query = "select price from sessions where sessions.id = " + main.selectedId;
            cmd = new MySqlCommand(query, connection);
            row = cmd.ExecuteReader();
            while (row.Read())
            {
                string price = row["price"].ToString();
                priceComboBox.Text = price;
            }
            row.Close();
            //

            // Movies to movie drop down
            query = "SELECT * FROM movies";
            cmd = new MySqlCommand(query, connection);

            row = cmd.ExecuteReader();

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

        public void getCustomers()
        {
            string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // setting the text of boxes
            string query = "select * from customers where id = " + main.selectedId;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                string fullname = row["fullname"].ToString();
                string age = row["age"].ToString();
                string gender = row["gender"].ToString();
                string tel = row["tel"].ToString();
                string mail = row["mail"].ToString();
                string address = row["address"].ToString();

                fullnameTextBox.Text = fullname;
                ageComboBox.SelectedValue = age;
                genderComboBox.Text = gender;
                telTextBox.Text = tel;
                mailTextBox.Text  = mail;
                addressTextBox.Text = address;
            }
            row.Close();
            //

            connection.Close();
        }
        
        public void getMovies()
        {
            string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // setting the text of movieComboBox 
            string query = "select * from movies where id = " + main.selectedId;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                string name = row["name"].ToString();
                string age_restriction = row["age_restriction"].ToString();
                string year = row["year"].ToString();
                string director = row["director"].ToString();
                string producer = row["producer"].ToString();
                string screenwriter = row["screenwriter"].ToString();

                nameTextBox.Text = name;
                ageComboBox.Text = age_restriction;
                yearComboBox.Text = year;
                directorTextBox.Text = director;
                producerTextBox.Text = producer;
                screewriterTextBox.Text = screenwriter;
            }
            row.Close();
            //

            connection.Close();
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            List<Control> sessionsElements = new List<Control>();
            List<Control> customersElements = new List<Control>();
            List<Control> moviesElements = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "sessionsElements")
                {
                    sessionsElements.Add(control);
                }
                else if (control.Tag != null && control.Tag.ToString() == "customersElements")
                {
                    customersElements.Add(control);
                }
                else if (control.Tag != null && control.Tag.ToString() == "moviesElements")
                {
                    moviesElements.Add(control);
                }
            }

            if (main.selectedTable == "sessions")
            {
                foreach (Control control in sessionsElements)
                {
                    control.Visible = true;
                }

                getSessions();
            }
            else if (main.selectedTable == "customers")
            {
                foreach (Control control in customersElements)
                {
                    control.Visible = true;
                }

                getCustomers();
            }
            else if (main.selectedTable == "movies")
            {
                foreach (Control control in moviesElements)
                {
                    control.Visible = true;
                }

                getMovies();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (main.selectedTable == "sessions")
            {
                if (movieComboBox.SelectedIndex >= 0 || customerComboBox.SelectedIndex >= 0 || priceComboBox.SelectedIndex >= 0)
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
                    //

                    string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    try
                    {
                        connection.Open();
                        string query = "update sessions set movie = @val1, customer = @val2, date = @val3, price = @val4 where id = " + main.selectedId;
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@val1", movie);
                        command.Parameters.AddWithValue("@val2", customer);
                        command.Parameters.AddWithValue("@val3", date);
                        command.Parameters.AddWithValue("@val4", price);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Session record succesfully updated!", "Done");
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
            else if (main.selectedTable == "movies")
            {
                // Setting variables to use later
                string name = nameTextBox.Text;
                string age_restriction = ageComboBox.SelectedText;
                string year = yearComboBox.Text;
                string director = directorTextBox.Text;
                string producer = producerTextBox.Text;
                string screenwriter = screewriterTextBox.Text;
                //

                string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    string query = "update movies set name = @val1, age_restriction = @val2, year = @val3, director = @val4, producer = @val5, screenwriter = @val6 where id = " + main.selectedId;
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", name);
                    command.Parameters.AddWithValue("@val2", age_restriction);
                    command.Parameters.AddWithValue("@val3", year);
                    command.Parameters.AddWithValue("@val4", director);
                    command.Parameters.AddWithValue("@val5", producer);
                    command.Parameters.AddWithValue("@val6", screenwriter);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Movie record succesfully updated!", "Done");
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
            else if (main.selectedTable == "customers")
            {
                // Setting variables to use later
                string fullname = fullnameTextBox.Text;
                int age = Convert.ToInt32(ageUpDown.Value);
                string gender = genderComboBox.Text;
                string tel = telTextBox.Text;
                string mail = mailTextBox.Text;
                string address = addressTextBox.Text;

                //

                string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    string query = "update customers set fullname = @val1, age = @val2, gender = @val3, tel = @val4, mail = @val5, address = @val6 where id = " + main.selectedId;
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@val1", fullname);
                    command.Parameters.AddWithValue("@val2", age);
                    command.Parameters.AddWithValue("@val3", gender);
                    command.Parameters.AddWithValue("@val4", tel);
                    command.Parameters.AddWithValue("@val5", mail);
                    command.Parameters.AddWithValue("@val6", address);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer record succesfully updated!", "Done");
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
