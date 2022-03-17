namespace karbantartasAdmin
{
    partial class Occupations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Occupations));
            this.getAllData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.newOccTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newOccDescTxtBox = new System.Windows.Forms.TextBox();
            this.addOccToDbButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.queryOccButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.occIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editOccDescTxtBox = new System.Windows.Forms.TextBox();
            this.editOccButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editOccNameTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseOccForEditComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteOccComboBox = new System.Windows.Forms.ComboBox();
            this.deleteOccButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // getAllData
            // 
            this.getAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getAllData.Location = new System.Drawing.Point(249, 194);
            this.getAllData.Name = "getAllData";
            this.getAllData.Size = new System.Drawing.Size(134, 41);
            this.getAllData.TabIndex = 1;
            this.getAllData.Text = "Adatok lekérdezése";
            this.getAllData.UseVisualStyleBackColor = true;
            this.getAllData.Click += new System.EventHandler(this.getAllData_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(18, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 139);
            this.listBox1.TabIndex = 2;
            // 
            // newOccTxtBox
            // 
            this.newOccTxtBox.Location = new System.Drawing.Point(100, 28);
            this.newOccTxtBox.Multiline = true;
            this.newOccTxtBox.Name = "newOccTxtBox";
            this.newOccTxtBox.Size = new System.Drawing.Size(200, 20);
            this.newOccTxtBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Megnevezés:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Leírás:";
            // 
            // newOccDescTxtBox
            // 
            this.newOccDescTxtBox.Location = new System.Drawing.Point(100, 63);
            this.newOccDescTxtBox.Multiline = true;
            this.newOccDescTxtBox.Name = "newOccDescTxtBox";
            this.newOccDescTxtBox.Size = new System.Drawing.Size(200, 20);
            this.newOccDescTxtBox.TabIndex = 9;
            // 
            // addOccToDbButton
            // 
            this.addOccToDbButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addOccToDbButton.Location = new System.Drawing.Point(308, 29);
            this.addOccToDbButton.Name = "addOccToDbButton";
            this.addOccToDbButton.Size = new System.Drawing.Size(83, 55);
            this.addOccToDbButton.TabIndex = 10;
            this.addOccToDbButton.Text = "Hozzáadás";
            this.addOccToDbButton.UseVisualStyleBackColor = true;
            this.addOccToDbButton.Click += new System.EventHandler(this.addOccToDbButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.addOccToDbButton);
            this.groupBox1.Controls.Add(this.newOccDescTxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newOccTxtBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(6, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 95);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új végzettség felvitele az adatbázisba";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox2.Controls.Add(this.queryOccButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.occIdTxtBox);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.getAllData);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 251);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jelenlegi adatok lekérdezése az adatbázisból";
            // 
            // queryOccButton
            // 
            this.queryOccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryOccButton.Location = new System.Drawing.Point(124, 212);
            this.queryOccButton.Name = "queryOccButton";
            this.queryOccButton.Size = new System.Drawing.Size(88, 23);
            this.queryOccButton.TabIndex = 5;
            this.queryOccButton.Text = "Lekérdezés";
            this.queryOccButton.UseVisualStyleBackColor = true;
            this.queryOccButton.Click += new System.EventHandler(this.queryOccButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lekérdezés felhasználói id alapján:";
            // 
            // occIdTxtBox
            // 
            this.occIdTxtBox.Location = new System.Drawing.Point(18, 212);
            this.occIdTxtBox.Name = "occIdTxtBox";
            this.occIdTxtBox.Size = new System.Drawing.Size(100, 22);
            this.occIdTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Új Megnevezés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Leírás:";
            // 
            // editOccDescTxtBox
            // 
            this.editOccDescTxtBox.Location = new System.Drawing.Point(116, 108);
            this.editOccDescTxtBox.Name = "editOccDescTxtBox";
            this.editOccDescTxtBox.Size = new System.Drawing.Size(200, 22);
            this.editOccDescTxtBox.TabIndex = 14;
            // 
            // editOccButton
            // 
            this.editOccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editOccButton.Location = new System.Drawing.Point(322, 76);
            this.editOccButton.Name = "editOccButton";
            this.editOccButton.Size = new System.Drawing.Size(83, 55);
            this.editOccButton.TabIndex = 11;
            this.editOccButton.Text = "Módosítás";
            this.editOccButton.UseVisualStyleBackColor = true;
            this.editOccButton.Click += new System.EventHandler(this.editOccButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox3.Controls.Add(this.editOccNameTxtBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.chooseOccForEditComboBox);
            this.groupBox3.Controls.Add(this.editOccButton);
            this.groupBox3.Controls.Add(this.editOccDescTxtBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(413, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 165);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Végzettség adatainak módosítása";
            // 
            // editOccNameTxtBox
            // 
            this.editOccNameTxtBox.Location = new System.Drawing.Point(116, 73);
            this.editOccNameTxtBox.Name = "editOccNameTxtBox";
            this.editOccNameTxtBox.Size = new System.Drawing.Size(200, 22);
            this.editOccNameTxtBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Módosítandó:";
            // 
            // chooseOccForEditComboBox
            // 
            this.chooseOccForEditComboBox.FormattingEnabled = true;
            this.chooseOccForEditComboBox.Location = new System.Drawing.Point(116, 35);
            this.chooseOccForEditComboBox.Name = "chooseOccForEditComboBox";
            this.chooseOccForEditComboBox.Size = new System.Drawing.Size(200, 24);
            this.chooseOccForEditComboBox.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 247);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // deleteOccComboBox
            // 
            this.deleteOccComboBox.FormattingEnabled = true;
            this.deleteOccComboBox.Location = new System.Drawing.Point(12, 25);
            this.deleteOccComboBox.Name = "deleteOccComboBox";
            this.deleteOccComboBox.Size = new System.Drawing.Size(200, 24);
            this.deleteOccComboBox.TabIndex = 18;
            this.deleteOccComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteOccComboBox_SelectedIndexChanged);
            // 
            // deleteOccButton
            // 
            this.deleteOccButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteOccButton.Location = new System.Drawing.Point(228, 19);
            this.deleteOccButton.Name = "deleteOccButton";
            this.deleteOccButton.Size = new System.Drawing.Size(160, 32);
            this.deleteOccButton.TabIndex = 21;
            this.deleteOccButton.Text = "Végzettség törlése";
            this.deleteOccButton.UseVisualStyleBackColor = true;
            this.deleteOccButton.Click += new System.EventHandler(this.deleteOccButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox4.Controls.Add(this.deleteOccButton);
            this.groupBox4.Controls.Add(this.deleteOccComboBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(9, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 57);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Végzettség törlése";
            // 
            // Occupations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Occupations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Végzettségek";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button getAllData;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox newOccTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newOccDescTxtBox;
        private System.Windows.Forms.Button addOccToDbButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editOccDescTxtBox;
        private System.Windows.Forms.Button editOccButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox editOccNameTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chooseOccForEditComboBox;
        private System.Windows.Forms.TextBox occIdTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button queryOccButton;
        private System.Windows.Forms.ComboBox deleteOccComboBox;
        private System.Windows.Forms.Button deleteOccButton;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}