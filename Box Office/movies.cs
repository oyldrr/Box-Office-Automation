﻿using MySql.Data.MySqlClient;
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
    public partial class movies : Form
    {
        public movies()
        {
            InitializeComponent();
        }

        // Create Button
        private void addMovieButton_Click(object sender, EventArgs e)
        {
            addMovieForm form = new addMovieForm();
            form.ShowDialog();
        }

        private void movies_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT * FROM movies";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int x = 10;
                int y = 10;
                foreach (DataRow row in dataTable.Rows)
                {
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.None;
                    panel.BackColor = Color.FromArgb(87, 108, 188);
                    panel.Size = new Size(400, 225);
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

                    // label creating and settings
                    Label label = new Label();
                    label.Size = new Size((int)panel.Width, (int)panel.Height);
                    label.Text = "Id: " + row["id"].ToString() + "\n" +
                                 "Name: " + row["name"].ToString() + "\n" +
                                 "Age Restriction: " + row["age_restriction"].ToString() + "\n" +
                                 "Year: " + row["year"].ToString() + "\n" +
                                 "Director: " + row["director"].ToString() + "\n" +
                                 "Producer: " + row["producer"].ToString() + "\n" +
                                 "Screenwriter: " + row["screenwriter"].ToString() + "\n" +
                                 "Created at: " + row["created_at"].ToString() + "\n" +
                                 "Updated at: " + row["updated_at"].ToString();

                    label.MouseEnter += (sender1, e1) =>
                    {
                        label.BackColor = Color.FromArgb(11, 36, 71);
                    };

                    label.MouseLeave += (sender2, e2) =>
                    {
                        label.BackColor = Color.FromArgb(87, 108, 188);
                    };

                    label.MouseClick += (sender3, e3) =>
                    {
                        main.selectedId = Convert.ToInt32(row["id"]);
                        main.selectedTable = "movies";

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
                    string query = "SELECT * FROM movies where id = " + search.Text;
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader row = command.ExecuteReader();

                    while (row.Read())
                    {
                        MessageBox.Show("Id: " + row["id"].ToString() + "\n" +
                                 "Name: " + row["name"].ToString() + "\n" +
                                 "Age Restriction: " + row["age_restriction"].ToString() + "\n" +
                                 "Year: " + row["year"].ToString() + "\n" +
                                 "Director: " + row["director"].ToString() + "\n" +
                                 "Producer: " + row["producer"].ToString() + "\n" +
                                 "Screenwriter: " + row["screenwriter"].ToString() + "\n" +
                                 "Created at: " + row["created_at"].ToString() + "\n" +
                                 "Updated at: " + row["updated_at"].ToString(),
                                     "Copied to Clipboard!");
                    }
                    Clipboard.SetText("Id: " + row["id"].ToString() + "\n" +
                                 "Name: " + row["name"].ToString() + "\n" +
                                 "Age Restriction: " + row["age_restriction"].ToString() + "\n" +
                                 "Year: " + row["year"].ToString() + "\n" +
                                 "Director: " + row["director"].ToString() + "\n" +
                                 "Producer: " + row["producer"].ToString() + "\n" +
                                 "Screenwriter: " + row["screenwriter"].ToString() + "\n" +
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
    }
}