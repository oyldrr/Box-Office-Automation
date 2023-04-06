namespace Box_Office
{
    partial class addMovieForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.screewriterTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.producerTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.directorTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yearComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ageComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.saveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.saveButton.Location = new System.Drawing.Point(0, 521);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(357, 41);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.cancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Poppins Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.cancelButton.Location = new System.Drawing.Point(0, 562);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(357, 41);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(18, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(306, 36);
            this.nameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.nameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameTextBox.StateCommon.Border.Rounding = 10;
            this.nameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.nameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // screewriterTextBox
            // 
            this.screewriterTextBox.Location = new System.Drawing.Point(18, 429);
            this.screewriterTextBox.Name = "screewriterTextBox";
            this.screewriterTextBox.Size = new System.Drawing.Size(306, 36);
            this.screewriterTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.screewriterTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.screewriterTextBox.StateCommon.Border.Rounding = 10;
            this.screewriterTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.screewriterTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.screewriterTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(12, 370);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label6.Size = new System.Drawing.Size(141, 56);
            this.label6.TabIndex = 39;
            this.label6.Text = "Screenwriter:";
            // 
            // producerTextBox
            // 
            this.producerTextBox.Location = new System.Drawing.Point(18, 331);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(306, 36);
            this.producerTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.producerTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.producerTextBox.StateCommon.Border.Rounding = 10;
            this.producerTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.producerTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.producerTextBox.TabIndex = 5;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(18, 242);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(306, 36);
            this.directorTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.directorTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.directorTextBox.StateCommon.Border.Rounding = 10;
            this.directorTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.directorTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.directorTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label5.Size = new System.Drawing.Size(161, 56);
            this.label5.TabIndex = 38;
            this.label5.Text = "Age restriction:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.yearComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearComboBox.DropDownWidth = 75;
            this.yearComboBox.Items.AddRange(new object[] {
            "not specified",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.yearComboBox.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.yearComboBox.Location = new System.Drawing.Point(210, 142);
            this.yearComboBox.MaxDropDownItems = 16;
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(114, 37);
            this.yearComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.yearComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.yearComboBox.StateCommon.ComboBox.Border.Rounding = 10;
            this.yearComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.yearComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yearComboBox.TabIndex = 3;
            this.yearComboBox.Text = "not specified";
            this.yearComboBox.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label4.Size = new System.Drawing.Size(105, 56);
            this.label4.TabIndex = 37;
            this.label4.Text = "Producer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(96, 56);
            this.label3.TabIndex = 36;
            this.label3.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(204, 83);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(64, 56);
            this.label2.TabIndex = 35;
            this.label2.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(142, 56);
            this.label1.TabIndex = 34;
            this.label1.Text = "Movie name:";
            // 
            // ageComboBox
            // 
            this.ageComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ageComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ageComboBox.DropDownWidth = 75;
            this.ageComboBox.Items.AddRange(new object[] {
            "not specified",
            "G",
            "PG",
            "12+",
            "15+",
            "18+"});
            this.ageComboBox.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.ageComboBox.Location = new System.Drawing.Point(18, 142);
            this.ageComboBox.MaxDropDownItems = 16;
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(146, 37);
            this.ageComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.ageComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageComboBox.StateCommon.ComboBox.Border.Rounding = 10;
            this.ageComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.ageComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageComboBox.TabIndex = 2;
            this.ageComboBox.Text = "not specified";
            this.ageComboBox.UseMnemonic = false;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warningLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.warningLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warningLabel.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.warningLabel.Location = new System.Drawing.Point(39, 457);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.warningLabel.Size = new System.Drawing.Size(258, 43);
            this.warningLabel.TabIndex = 40;
            this.warningLabel.Text = "Please enter necessary informations!";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // addMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Box_Office.Properties.Resources.wave_haikei__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 603);
            this.ControlBox = false;
            this.Controls.Add(this.screewriterTextBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Movie";
            ((System.ComponentModel.ISupportInitialize)(this.yearComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox screewriterTextBox;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox producerTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox directorTextBox;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox yearComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ageComboBox;
        private System.Windows.Forms.Label warningLabel;
    }
}