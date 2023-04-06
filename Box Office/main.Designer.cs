namespace Box_Office
{
    partial class main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSessions = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidePanel.Controls.Add(this.versionLabel);
            this.sidePanel.Controls.Add(this.btnMovies);
            this.sidePanel.Controls.Add(this.btnCustomers);
            this.sidePanel.Controls.Add(this.btnSessions);
            this.sidePanel.Controls.Add(this.logo);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 553);
            this.sidePanel.TabIndex = 0;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.versionLabel.Location = new System.Drawing.Point(12, 514);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(179, 39);
            this.versionLabel.TabIndex = 5;
            this.versionLabel.Text = "VERSION BO1.0\r\nCopyrights reserved by oyldrr @2023\r\n\r\n";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            this.versionLabel.MouseLeave += new System.EventHandler(this.versionLabel_MouseLeave);
            this.versionLabel.MouseHover += new System.EventHandler(this.versionLabel_MouseHover);
            // 
            // btnMovies
            // 
            this.btnMovies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnMovies.Location = new System.Drawing.Point(0, 350);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(200, 101);
            this.btnMovies.TabIndex = 4;
            this.btnMovies.Text = "MOVIES";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            this.btnMovies.MouseEnter += new System.EventHandler(this.btn_MoviesMouseEnter);
            this.btnMovies.MouseLeave += new System.EventHandler(this.btn_MoviesMouseLeave);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnCustomers.Location = new System.Drawing.Point(0, 245);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(200, 101);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "CUSTOMERS";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCustomer_MouseClick);
            this.btnCustomers.MouseEnter += new System.EventHandler(this.btnCustomer_MouseEnter);
            this.btnCustomers.MouseLeave += new System.EventHandler(this.btnCustomer_MouseLeave);
            // 
            // btnSessions
            // 
            this.btnSessions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSessions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessions.FlatAppearance.BorderSize = 0;
            this.btnSessions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnSessions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessions.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.btnSessions.Location = new System.Drawing.Point(0, 146);
            this.btnSessions.Name = "btnSessions";
            this.btnSessions.Size = new System.Drawing.Size(200, 101);
            this.btnSessions.TabIndex = 2;
            this.btnSessions.Text = "SESSIONS";
            this.btnSessions.UseVisualStyleBackColor = true;
            this.btnSessions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSessions_MouseClick);
            this.btnSessions.MouseEnter += new System.EventHandler(this.btnSessions_MouseEnter);
            this.btnSessions.MouseLeave += new System.EventHandler(this.btnSessions_MouseLeave);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.logo.Location = new System.Drawing.Point(40, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(111, 106);
            this.logo.TabIndex = 1;
            this.logo.Text = "Box\r\nOffice";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.mainPanel.BackgroundImage = global::Box_Office.Properties.Resources.wave_haikei;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(782, 553);
            this.mainPanel.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box Office";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button btnSessions;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Label versionLabel;
    }
}

