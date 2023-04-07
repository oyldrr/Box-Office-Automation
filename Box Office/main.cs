using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box_Office
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public static int selectedId;
        public static string selectedTable;

        // Menu Functions
        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            f.Show();
        }
        //

        // Sessions Functions
        private void btnSessions_MouseLeave(object sender, EventArgs e)
        {
                btnSessions.ForeColor = Color.FromArgb(25, 55, 109);
        }

        private void btnSessions_MouseEnter(object sender, EventArgs e)
        {
            btnSessions.ForeColor = Color.FromArgb(11, 36, 71);

        }

        private void btnSessions_MouseClick(object sender, MouseEventArgs e)
        {
            btnSessions.ForeColor = Color.FromArgb(165, 215, 232);
            loadform(new sessions());
        }
        //


        // Customer Functions
        private void btnCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnCustomers.ForeColor = Color.FromArgb(25, 55, 109);
        }

        private void btnCustomer_MouseEnter(object sender, EventArgs e)
        {
            btnCustomers.ForeColor = Color.FromArgb(11, 36, 71);
        }

        private void btnCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            loadform(new customers());
            btnCustomers.ForeColor = Color.FromArgb(165, 215, 232);
        }
        //

        // Movies Functions
        private void btn_MoviesMouseLeave(object sender, EventArgs e)
        {
            btnMovies.ForeColor = Color.FromArgb(25, 55, 109);
        }

        private void btn_MoviesMouseEnter(object sender, EventArgs e)
        {
            btnMovies.ForeColor = Color.FromArgb(11, 36, 71);
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            loadform(new movies());
            btnMovies.ForeColor = Color.FromArgb(165, 215, 232);
        }
        //

        // Logo Functions
        private void logo_Click(object sender, EventArgs e)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
        }

        private void logo_MouseEnter(object sender, EventArgs e)
        {
            logo.ForeColor = Color.FromArgb(87, 108, 188);
        }

        private void logo_MouseLeave(object sender, EventArgs e)
        {
            logo.ForeColor = Color.FromArgb(165, 215, 232);
        }
        //

        // Version Label Functions
        private void versionLabel_MouseHover(object sender, EventArgs e)
        {
            versionLabel.Cursor = Cursors.Hand;
            versionLabel.Font = new Font(versionLabel.Font.Name, versionLabel.Font.SizeInPoints, FontStyle.Underline);
        }

        private void versionLabel_MouseLeave(object sender, EventArgs e)
        {
            versionLabel.Font = new Font(versionLabel.Font.Name, versionLabel.Font.SizeInPoints, FontStyle.Regular);
        }

        private void versionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can check updates from github :)\nAll rights reserved by oyldrr @2023", "VERSION BO1.0");
        }
        //
    }
}
