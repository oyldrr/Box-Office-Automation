using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using MySql.Data.MySqlClient;

namespace Box_Office
{
    public partial class sessions : Form
    {
        public sessions()
        {
            InitializeComponent();
        }

        private void addSessionButton_Click(object sender, EventArgs e)
        {
            addSessionForm form = new addSessionForm();
            form.ShowDialog();
        }

        // Loading Functions
        private void sessions_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM sessions";
                MySqlCommand command  = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int x = 10;
                int y = 10;
                foreach (DataRow row in dataTable.Rows)
                {
                    // get movie data
                    query = "select id, name, age_restriction, year from movies where id =" + row["movie"].ToString();
                    command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string movie = "#" + reader["id"].ToString() + " " +
                            reader["name"].ToString() + " " + 
                            reader["age_restriction"].ToString() + " " +
                            reader["year"].ToString(); 
                    reader.Close();

                    // get customer data 
                    query = "select id, fullname, age, gender, tel from customers where id = " + row["customer"].ToString();
                    command = new MySqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    string customer = "#" + reader["id"].ToString() + " " +
                            reader["fullname"].ToString() + " " +
                            reader["age"].ToString() + " " +
                            reader["gender"].ToString() + " " + 
                            reader["tel"].ToString();
                    reader.Close();

                    // panel creating and styling
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.None;
                    panel.BackColor = System.Drawing.Color.FromArgb(11, 36, 71);
                    panel.Size = new Size(400, 220);
                    panel.Location = new Point(x, y);
                    panel.Cursor = Cursors.Hand;

                    // Panel border radius
                    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                    int arcSize = 10;
                    Rectangle rect = new Rectangle(panel.ClientRectangle.Location.X, panel.ClientRectangle.Location.Y, panel.ClientRectangle.Width, panel.ClientRectangle.Height);
                    path.AddArc(rect.X, rect.Y, arcSize, arcSize, 180, 90);
                    path.AddArc(rect.X + rect.Width - arcSize, rect.Y, arcSize, arcSize, 270, 90);
                    path.AddArc(rect.X + rect.Width - arcSize, rect.Y + rect.Height - arcSize, arcSize, arcSize, 0, 90);
                    path.AddArc(rect.X, rect.Y + rect.Height - arcSize, arcSize, arcSize, 90, 90);
                    path.CloseAllFigures();
                    panel.Region = new System.Drawing.Region(path);
                    // 

                    // print invoice button creating and settings
                    Button button = new Button();
                    button.Size = new Size((int)panel.Width, 30);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Text = "Print Invoice";
                    button.ForeColor = System.Drawing.Color.FromArgb(165, 215, 232);
                    button.BackColor = System.Drawing.Color.FromArgb(11, 36, 71);

                    button.MouseClick += (sender3, e3) =>
                    {
                        main.selectedId = Convert.ToInt32(row["id"]);
                        main.selectedTable = "sessions";
                        printInvoice form = new printInvoice();
                        form.ShowDialog();
                    };

                    button.MouseEnter += (sender1, e1) =>
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(87, 108, 188);
                    };

                    button.MouseLeave += (sender2, e2) =>
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(11, 36, 71);
                    };

                    panel.Controls.Add(button);
                    //


                    // label creating and settings
                    Label label = new Label();
                    label.Size = new Size((int)panel.Width, panel.Height + button.Height);
                    label.Padding = new Padding(0, button.Height+5, 0, 0);
                    label.Text = "Id: " + row["id"].ToString() + "\n" +
                                 "Movie: " + movie + "\n" +
                                 "Customer: " + customer + "\n" +
                                 "Date: " + row["date"].ToString() + "\n" +
                                 "Price: " + row["price"].ToString() + "\n" +
                                 "Created at: " + row["created_at"].ToString() + "\n" +
                                 "Updated at: " + row["updated_at"].ToString();

                    label.MouseEnter += (sender1, e1) =>
                    {
                        label.BackColor = System.Drawing.Color.FromArgb(87, 108, 188);
                    };

                    label.MouseLeave += (sender2, e2) =>
                    {
                        label.BackColor = System.Drawing.Color.FromArgb(11, 36, 71);
                    };

                    label.MouseClick += (sender3, e3) =>
                    {
                        main.selectedId = Convert.ToInt32(row["id"]);
                        main.selectedTable = "sessions";
                        UpdateOrDelete form = new UpdateOrDelete();
                        form.ShowDialog();
                    };

                    panel.Controls.Add(label);
                    //

                    
                    y += panel.Height + 10;

                    cardViewPanel.Controls.Add(panel);
                }
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


        // Searching Functions
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (search.Text != " " || search.Value > 0)
            {
                string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    string query = "SELECT * FROM sessions where id = " + search.Text;
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader row = command.ExecuteReader();

                    while (row.Read())
                    {
                        MessageBox.Show("Id: " + row["id"].ToString() + "\n" +
                                 "Movie: " + row["movie"].ToString() + "\n" +
                                 "Customer: " + row["customer"].ToString() + "\n" +
                                 "Date: " + row["date"].ToString() + "\n" +
                                 "Price: " + row["price"].ToString() + "\n" +
                                 "Created at: " + row["created_at"].ToString() + "\n" +
                                 "Updated at: " + row["updated_at"].ToString(),
                                     "Copied to Clipboard!");
                    }
                    Clipboard.SetText("Id: " + row["id"].ToString() + "\n" +
                                 "Movie: " + row["movie"].ToString() + "\n" +
                                 "Customer: " + row["customer"].ToString() + "\n" +
                                 "Date: " + row["date"].ToString() + "\n" +
                                 "Price: " + row["price"].ToString() + "\n" +
                                 "Created at: " + row["created_at"].ToString() + "\n" +
                                 "Updated at: " + row["updated_at"].ToString());
                    row.Close();
                }
                catch (MySqlException ex)
                {
                    if (ex.ToString() == "MySql.Data.MySqlClient.MySqlException (0x80004005): Invalid attempt to access a field before calling Read()\r\n   konum: MySql.Data.MySqlClient.ResultSet.get_Item(Int32 index)\r\n   konum: MySql.Data.MySqlClient.MySqlDataReader.GetFieldValue(Int32 index, Boolean checkNull)\r\n   konum: MySql.Data.MySqlClient.MySqlDataReader.GetValue(Int32 i)\r\n   konum: MySql.Data.MySqlClient.MySqlDataReader.get_Item(Int32 i)\r\n   konum: MySql.Data.MySqlClient.MySqlDataReader.get_Item(String name)\r\n   konum: Box_Office.customers.searchButton_Click(Object sender, EventArgs e) C:\\Users\\oyldr\\source\\repos\\Box Office\\Box Office\\customers.cs içinde: satır 131")
                    {
                        MessageBox.Show("Record couldn't found!", "Error");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString(), "Error!");
                    }

                }
                finally
                {
                    connection.Close();
                }

            }
        }
        //
    }
}
