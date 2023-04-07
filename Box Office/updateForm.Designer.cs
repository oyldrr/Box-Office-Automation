namespace Box_Office
{
    partial class updateForm
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
            this.priceComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.customerComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.movieComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.datePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addressTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fullnameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mailTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.telTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ageUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.genderComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.screewriterTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ageComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.nameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.producerTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.directorTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.yearComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // priceComboBox
            // 
            this.priceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.priceComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceComboBox.DropDownWidth = 75;
            this.priceComboBox.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Senior",
            "Student",
            "Matinee"});
            this.priceComboBox.Location = new System.Drawing.Point(18, 370);
            this.priceComboBox.MaxDropDownItems = 16;
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(306, 37);
            this.priceComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.priceComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.priceComboBox.StateCommon.ComboBox.Border.Rounding = 10;
            this.priceComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.priceComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceComboBox.TabIndex = 13;
            this.priceComboBox.Tag = "sessionsElements";
            this.priceComboBox.Text = "Select a price type...";
            this.priceComboBox.UseMnemonic = false;
            this.priceComboBox.Visible = false;
            // 
            // customerComboBox
            // 
            this.customerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customerComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerComboBox.DropDownWidth = 75;
            this.customerComboBox.Location = new System.Drawing.Point(18, 163);
            this.customerComboBox.MaxDropDownItems = 16;
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerComboBox.Size = new System.Drawing.Size(306, 37);
            this.customerComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.customerComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.customerComboBox.StateCommon.ComboBox.Border.Rounding = 10;
            this.customerComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.customerComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerComboBox.TabIndex = 9;
            this.customerComboBox.Tag = "sessionsElements";
            this.customerComboBox.Text = "Select a customer...";
            this.customerComboBox.UseMnemonic = false;
            this.customerComboBox.Visible = false;
            // 
            // movieComboBox
            // 
            this.movieComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.movieComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movieComboBox.DropDownWidth = 75;
            this.movieComboBox.Location = new System.Drawing.Point(18, 64);
            this.movieComboBox.MaxDropDownItems = 16;
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(306, 37);
            this.movieComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.movieComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.movieComboBox.StateCommon.ComboBox.Border.Rounding = 10;
            this.movieComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.movieComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieComboBox.TabIndex = 8;
            this.movieComboBox.Tag = "sessionsElements";
            this.movieComboBox.Text = "Select a movie...";
            this.movieComboBox.UseMnemonic = false;
            this.movieComboBox.Visible = false;
            // 
            // datePicker
            // 
            this.datePicker.CalendarTodayDate = new System.DateTime(2023, 4, 5, 0, 0, 0, 0);
            this.datePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePicker.Location = new System.Drawing.Point(18, 268);
            this.datePicker.MinDate = new System.DateTime(2023, 4, 6, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datePicker.Size = new System.Drawing.Size(306, 37);
            this.datePicker.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.datePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.datePicker.StateCommon.Border.Rounding = 10;
            this.datePicker.StateCommon.Border.Width = 1;
            this.datePicker.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.datePicker.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datePicker.TabIndex = 11;
            this.datePicker.Tag = "sessionsElements";
            this.datePicker.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label4.Size = new System.Drawing.Size(67, 56);
            this.label4.TabIndex = 15;
            this.label4.Tag = "sessionsElements";
            this.label4.Text = "Price:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(66, 56);
            this.label3.TabIndex = 14;
            this.label3.Tag = "sessionsElements";
            this.label3.Text = "Date:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(117, 56);
            this.label2.TabIndex = 12;
            this.label2.Tag = "sessionsElements";
            this.label2.Text = "Customer:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(77, 56);
            this.label1.TabIndex = 10;
            this.label1.Tag = "sessionsElements";
            this.label1.Text = "Movie:";
            this.label1.Visible = false;
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
            this.saveButton.Location = new System.Drawing.Point(0, 543);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(345, 41);
            this.saveButton.TabIndex = 16;
            this.saveButton.Tag = "";
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
            this.cancelButton.Location = new System.Drawing.Point(0, 584);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(345, 41);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Tag = "";
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(18, 425);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(306, 36);
            this.addressTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.addressTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addressTextBox.StateCommon.Border.Rounding = 10;
            this.addressTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.addressTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressTextBox.TabIndex = 34;
            this.addressTextBox.Tag = "customersElements";
            this.addressTextBox.Visible = false;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(18, 55);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(306, 36);
            this.fullnameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.fullnameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fullnameTextBox.StateCommon.Border.Rounding = 10;
            this.fullnameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.fullnameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullnameTextBox.TabIndex = 29;
            this.fullnameTextBox.Tag = "customersElements";
            this.fullnameTextBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(12, 366);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label6.Size = new System.Drawing.Size(99, 56);
            this.label6.TabIndex = 40;
            this.label6.Tag = "customersElements";
            this.label6.Text = "Address:";
            this.label6.Visible = false;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(18, 327);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(306, 36);
            this.mailTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.mailTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mailTextBox.StateCommon.Border.Rounding = 10;
            this.mailTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.mailTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTextBox.TabIndex = 33;
            this.mailTextBox.Tag = "customersElements";
            this.mailTextBox.Visible = false;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(18, 238);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(306, 36);
            this.telTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.telTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.telTextBox.StateCommon.Border.Rounding = 10;
            this.telTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.telTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telTextBox.TabIndex = 32;
            this.telTextBox.Tag = "customersElements";
            this.telTextBox.Visible = false;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ageUpDown.Location = new System.Drawing.Point(18, 138);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(89, 35);
            this.ageUpDown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.ageUpDown.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageUpDown.StateCommon.Border.Rounding = 10;
            this.ageUpDown.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.ageUpDown.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageUpDown.TabIndex = 30;
            this.ageUpDown.Tag = "customersElements";
            this.ageUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ageUpDown.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label5.Size = new System.Drawing.Size(58, 56);
            this.label5.TabIndex = 39;
            this.label5.Tag = "customersElements";
            this.label5.Text = "Age:";
            this.label5.Visible = false;
            // 
            // genderComboBox
            // 
            this.genderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.genderComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderComboBox.DropDownWidth = 75;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderComboBox.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.genderComboBox.Location = new System.Drawing.Point(139, 138);
            this.genderComboBox.MaxDropDownItems = 16;
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(185, 37);
            this.genderComboBox.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.genderComboBox.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.genderComboBox.StateCommon.ComboBox.Border.Rounding = 10;
            this.genderComboBox.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.genderComboBox.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderComboBox.TabIndex = 31;
            this.genderComboBox.Tag = "customersElements";
            this.genderComboBox.Text = "Select a gender...";
            this.genderComboBox.UseMnemonic = false;
            this.genderComboBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label7.Location = new System.Drawing.Point(12, 268);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label7.Size = new System.Drawing.Size(146, 56);
            this.label7.TabIndex = 38;
            this.label7.Tag = "customersElements";
            this.label7.Text = "Mail address:";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label8.Location = new System.Drawing.Point(12, 179);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label8.Size = new System.Drawing.Size(168, 56);
            this.label8.TabIndex = 37;
            this.label8.Tag = "customersElements";
            this.label8.Text = "Phone Number:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label9.Location = new System.Drawing.Point(133, 79);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label9.Size = new System.Drawing.Size(93, 56);
            this.label9.TabIndex = 36;
            this.label9.Tag = "customersElements";
            this.label9.Text = "Gender:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label10.Location = new System.Drawing.Point(12, -4);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label10.Size = new System.Drawing.Size(117, 56);
            this.label10.TabIndex = 35;
            this.label10.Tag = "customersElements";
            this.label10.Text = "Full name:";
            this.label10.Visible = false;
            // 
            // screewriterTextBox
            // 
            this.screewriterTextBox.Location = new System.Drawing.Point(22, 425);
            this.screewriterTextBox.Name = "screewriterTextBox";
            this.screewriterTextBox.Size = new System.Drawing.Size(306, 36);
            this.screewriterTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.screewriterTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.screewriterTextBox.StateCommon.Border.Rounding = 10;
            this.screewriterTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.screewriterTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.screewriterTextBox.TabIndex = 46;
            this.screewriterTextBox.Tag = "moviesElements";
            this.screewriterTextBox.Visible = false;
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
            this.ageComboBox.Location = new System.Drawing.Point(22, 138);
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
            this.ageComboBox.TabIndex = 42;
            this.ageComboBox.Tag = "moviesElements";
            this.ageComboBox.Text = "not specified";
            this.ageComboBox.UseMnemonic = false;
            this.ageComboBox.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(22, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(306, 36);
            this.nameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.nameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameTextBox.StateCommon.Border.Rounding = 10;
            this.nameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.nameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.TabIndex = 41;
            this.nameTextBox.Tag = "moviesElements";
            this.nameTextBox.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label11.Location = new System.Drawing.Point(16, 366);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label11.Size = new System.Drawing.Size(141, 56);
            this.label11.TabIndex = 52;
            this.label11.Tag = "moviesElements";
            this.label11.Text = "Screenwriter:";
            this.label11.Visible = false;
            // 
            // producerTextBox
            // 
            this.producerTextBox.Location = new System.Drawing.Point(22, 327);
            this.producerTextBox.Name = "producerTextBox";
            this.producerTextBox.Size = new System.Drawing.Size(306, 36);
            this.producerTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.producerTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.producerTextBox.StateCommon.Border.Rounding = 10;
            this.producerTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.producerTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.producerTextBox.TabIndex = 45;
            this.producerTextBox.Tag = "moviesElements";
            this.producerTextBox.Visible = false;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(22, 238);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(306, 36);
            this.directorTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.directorTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.directorTextBox.StateCommon.Border.Rounding = 10;
            this.directorTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.directorTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.directorTextBox.TabIndex = 44;
            this.directorTextBox.Tag = "moviesElements";
            this.directorTextBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label12.Location = new System.Drawing.Point(16, 79);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label12.Size = new System.Drawing.Size(161, 56);
            this.label12.TabIndex = 51;
            this.label12.Tag = "moviesElements";
            this.label12.Text = "Age restriction:";
            this.label12.Visible = false;
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
            this.yearComboBox.Location = new System.Drawing.Point(214, 138);
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
            this.yearComboBox.TabIndex = 43;
            this.yearComboBox.Tag = "moviesElements";
            this.yearComboBox.Text = "not specified";
            this.yearComboBox.UseMnemonic = false;
            this.yearComboBox.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label13.Location = new System.Drawing.Point(16, 268);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label13.Size = new System.Drawing.Size(105, 56);
            this.label13.TabIndex = 50;
            this.label13.Tag = "moviesElements";
            this.label13.Text = "Producer";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label14.Location = new System.Drawing.Point(16, 179);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label14.Size = new System.Drawing.Size(96, 56);
            this.label14.TabIndex = 49;
            this.label14.Tag = "moviesElements";
            this.label14.Text = "Director:";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label15.Location = new System.Drawing.Point(208, 79);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label15.Size = new System.Drawing.Size(64, 56);
            this.label15.TabIndex = 48;
            this.label15.Tag = "moviesElements";
            this.label15.Text = "Year:";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label16.Location = new System.Drawing.Point(16, -4);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label16.Size = new System.Drawing.Size(142, 56);
            this.label16.TabIndex = 47;
            this.label16.Tag = "moviesElements";
            this.label16.Text = "Movie name:";
            this.label16.Visible = false;
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Box_Office.Properties.Resources.wave_haikei__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(345, 625);
            this.ControlBox = false;
            this.Controls.Add(this.screewriterTextBox);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.producerTextBox);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.priceComboBox);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "updateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update the data!";
            this.Load += new System.EventHandler(this.updateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox priceComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox customerComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox movieComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox fullnameTextBox;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mailTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox telTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown ageUpDown;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox genderComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox screewriterTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ageComboBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameTextBox;
        private System.Windows.Forms.Label label11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox producerTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox directorTextBox;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox yearComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}