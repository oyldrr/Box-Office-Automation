namespace Box_Office
{
    partial class sessions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addSessionButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.search = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.cardViewPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "SESSIONS";
            // 
            // addSessionButton
            // 
            this.addSessionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.addSessionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSessionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addSessionButton.FlatAppearance.BorderSize = 0;
            this.addSessionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.addSessionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.addSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSessionButton.Font = new System.Drawing.Font("Poppins ExtraLight", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addSessionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.addSessionButton.Location = new System.Drawing.Point(746, 0);
            this.addSessionButton.Name = "addSessionButton";
            this.addSessionButton.Size = new System.Drawing.Size(60, 503);
            this.addSessionButton.TabIndex = 3;
            this.addSessionButton.Text = "Create";
            this.addSessionButton.UseVisualStyleBackColor = false;
            this.addSessionButton.Click += new System.EventHandler(this.addSessionButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.searchButton.Location = new System.Drawing.Point(458, 433);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 41);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Location = new System.Drawing.Point(225, 433);
            this.search.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.search.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(202, 35);
            this.search.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search.StateCommon.Border.Rounding = 10;
            this.search.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.search.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search.TabIndex = 45;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cardViewPanel
            // 
            this.cardViewPanel.AutoScroll = true;
            this.cardViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.cardViewPanel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cardViewPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.cardViewPanel.Location = new System.Drawing.Point(61, 62);
            this.cardViewPanel.Name = "cardViewPanel";
            this.cardViewPanel.Size = new System.Drawing.Size(617, 338);
            this.cardViewPanel.TabIndex = 44;
            // 
            // sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Box_Office.Properties.Resources.wave_haikei__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 503);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cardViewPanel);
            this.Controls.Add(this.addSessionButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sessions";
            this.Text = "sessions";
            this.Load += new System.EventHandler(this.sessions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSessionButton;
        private System.Windows.Forms.Button searchButton;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown search;
        private System.Windows.Forms.Panel cardViewPanel;
    }
}