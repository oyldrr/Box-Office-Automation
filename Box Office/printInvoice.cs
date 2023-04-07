using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box_Office
{
    public partial class printInvoice : Form
    {
        public printInvoice()
        {
            InitializeComponent();
        }

        private void Print(Panel panel)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            panel1 = panel;
            getprintarea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;

        private void getprintarea(Panel panel)
        {
            memoryimg = new Bitmap(panel.Width, Height);
            panel.DrawToBitmap(memoryimg, new Rectangle(0, 0, panel.Width, panel.Height));

        }

        private void printInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;port=3306;database=boxoffice;user=root;password=password;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // setting the text of movieLabel
                string query = "select * from movies inner join sessions on movies.id = sessions.movie where sessions.id = " + main.selectedId;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    string name = row["name"].ToString();
                    string age_restriction = row["age_restriction"].ToString();
                    string year = row["year"].ToString();
                    movieLabel.Text = name + " " + year + " " + age_restriction;
                }
                row.Close();
                //

                // setting the text of customerLabel
                query = "select * from customers inner join sessions on customers.id = sessions.customer where sessions.id = " + main.selectedId;
                cmd = new MySqlCommand(query, connection);
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    string fullname = row["fullname"].ToString();
                    string age = row["age"].ToString();
                    string gender = row["gender"].ToString();
                    string tel = row["tel"].ToString();
                    customerLabel.Text = fullname + " " + age + " " + gender + " " + tel;
                }
                row.Close();
                //


                // setting the text of labels
                query = "select date, price, barcode from sessions where sessions.id = " + main.selectedId;
                cmd = new MySqlCommand(query, connection);
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    // setting the text of dateLabel
                    string date = row["date"].ToString();
                    dateLabel.Text = date;

                    // setting the text of priceLabel
                    string price = row["price"].ToString();
                    priceLabel.Text = price;

                    // setting the text of barcodeLbel
                    string barcodeData = row["barcode"].ToString();
                    BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
                    barcodeLabel.Text = barcodeData;

                    //setting img
                    Image img = barcode.Encode(BarcodeLib.TYPE.UPCA, barcodeData, Color.FromArgb(165, 215, 232), Color.Transparent);
                    pictureBox.Image = img;

                }

                
                
                row.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex,"Error!");
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Print(panel1);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }
    }
}
