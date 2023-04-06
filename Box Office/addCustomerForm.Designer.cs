namespace Box_Office
{
    partial class addCustomerForm
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
            this.genderComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullnameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ageUpDown = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.telTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.mailTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addressTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genderComboBox)).BeginInit();
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
            this.genderComboBox.Location = new System.Drawing.Point(139, 141);
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
            this.genderComboBox.TabIndex = 3;
            this.genderComboBox.Text = "Select a gender...";
            this.genderComboBox.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label4.Size = new System.Drawing.Size(146, 56);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mail address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(168, 56);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(133, 82);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(93, 56);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(117, 56);
            this.label1.TabIndex = 14;
            this.label1.Text = "Full name:";
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Location = new System.Drawing.Point(18, 58);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(306, 36);
            this.fullnameTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.fullnameTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fullnameTextBox.StateCommon.Border.Rounding = 10;
            this.fullnameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.fullnameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullnameTextBox.TabIndex = 1;
            this.fullnameTextBox.TextChanged += new System.EventHandler(this.fullnameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label5.Size = new System.Drawing.Size(58, 56);
            this.label5.TabIndex = 23;
            this.label5.Text = "Age:";
            // 
            // ageUpDown
            // 
            this.ageUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ageUpDown.Location = new System.Drawing.Point(18, 141);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(89, 35);
            this.ageUpDown.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.ageUpDown.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ageUpDown.StateCommon.Border.Rounding = 10;
            this.ageUpDown.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.ageUpDown.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageUpDown.TabIndex = 2;
            this.ageUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(18, 241);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(306, 36);
            this.telTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.telTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.telTextBox.StateCommon.Border.Rounding = 10;
            this.telTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.telTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telTextBox.TabIndex = 4;
            this.telTextBox.TextChanged += new System.EventHandler(this.telTextBox_TextChanged);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(18, 330);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(306, 36);
            this.mailTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.mailTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mailTextBox.StateCommon.Border.Rounding = 10;
            this.mailTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.mailTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(18, 428);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(306, 36);
            this.addressTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.addressTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addressTextBox.StateCommon.Border.Rounding = 10;
            this.addressTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.addressTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label6.Size = new System.Drawing.Size(99, 56);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.warningLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.warningLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warningLabel.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.warningLabel.Location = new System.Drawing.Point(35, 456);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.warningLabel.Size = new System.Drawing.Size(258, 43);
            this.warningLabel.TabIndex = 28;
            this.warningLabel.Text = "Please enter necessary informations!";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // addCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Box_Office.Properties.Resources.wave_haikei__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 603);
            this.ControlBox = false;
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "addCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Customer";
            ((System.ComponentModel.ISupportInitialize)(this.genderComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox genderComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox fullnameTextBox;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown ageUpDown;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox telTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mailTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox addressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label warningLabel;
    }
}