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
    public partial class UpdateOrDelete : Form
    {
        public UpdateOrDelete()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                string query = "delete from boxoffice."+main.selectedTable+" where "+main.selectedTable+".id = "+main.selectedId+"";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Record deleted from database.", "Successfully!");
                this.Close();
                while (reader.Read())
                {

                }
            }
            catch (MySqlException ex)
            {
                Clipboard.SetText(ex.ToString());
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
