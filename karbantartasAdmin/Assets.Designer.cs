namespace karbantartasAdmin
{
    partial class Assets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queryListBox = new System.Windows.Forms.ListBox();
            this.queryAllAssets = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.queryAssetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.assetsIdTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteAssetButton = new System.Windows.Forms.Button();
            this.deleteAssetComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addAssetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.assetNameTxtBox = new System.Windows.Forms.TextBox();
            this.assetLocationTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editAssetsDataButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.assetEditLocationTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.assetEditNameTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.assetForEditComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Controls.Add(this.queryListBox);
            this.groupBox1.Controls.Add(this.queryAllAssets);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.queryAssetButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.assetsIdTxtBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(14, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lekérdezés az eszköz adatbázisból";
            // 
            // queryListBox
            // 
            this.queryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryListBox.FormattingEnabled = true;
            this.queryListBox.Location = new System.Drawing.Point(292, 38);
            this.queryListBox.Name = "queryListBox";
            this.queryListBox.Size = new System.Drawing.Size(498, 95);
            this.queryListBox.TabIndex = 6;
            // 
            // queryAllAssets
            // 
            this.queryAllAssets.BackColor = System.Drawing.SystemColors.Control;
            this.queryAllAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryAllAssets.Location = new System.Drawing.Point(30, 38);
            this.queryAllAssets.Name = "queryAllAssets";
            this.queryAllAssets.Size = new System.Drawing.Size(226, 36);
            this.queryAllAssets.TabIndex = 5;
            this.queryAllAssets.Text = "Összes eszköz lekérdezése";
            this.queryAllAssets.UseVisualStyleBackColor = false;
            this.queryAllAssets.Click += new System.EventHandler(this.queryAllAssets_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(289, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lekérdezés eredménye:";
            // 
            // queryAssetButton
            // 
            this.queryAssetButton.BackColor = System.Drawing.SystemColors.Control;
            this.queryAssetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryAssetButton.Location = new System.Drawing.Point(168, 107);
            this.queryAssetButton.Name = "queryAssetButton";
            this.queryAssetButton.Size = new System.Drawing.Size(88, 23);
            this.queryAssetButton.TabIndex = 2;
            this.queryAssetButton.Text = "Lekérdezés";
            this.queryAssetButton.UseVisualStyleBackColor = false;
            this.queryAssetButton.Click += new System.EventHandler(this.queryAssetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lekérdezés eszköz id alapján:";
            // 
            // assetsIdTxtBox
            // 
            this.assetsIdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assetsIdTxtBox.Location = new System.Drawing.Point(30, 109);
            this.assetsIdTxtBox.Name = "assetsIdTxtBox";
            this.assetsIdTxtBox.Size = new System.Drawing.Size(132, 20);
            this.assetsIdTxtBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox4.Controls.Add(this.deleteAssetButton);
            this.groupBox4.Controls.Add(this.deleteAssetComboBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(316, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(506, 62);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eszköz törlése";
            // 
            // deleteAssetButton
            // 
            this.deleteAssetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteAssetButton.Location = new System.Drawing.Point(328, 16);
            this.deleteAssetButton.Name = "deleteAssetButton";
            this.deleteAssetButton.Size = new System.Drawing.Size(160, 32);
            this.deleteAssetButton.TabIndex = 20;
            this.deleteAssetButton.Text = "Eszköz törlése";
            this.deleteAssetButton.UseVisualStyleBackColor = true;
            this.deleteAssetButton.Click += new System.EventHandler(this.deleteAssetButton_Click);
            // 
            // deleteAssetComboBox
            // 
            this.deleteAssetComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteAssetComboBox.FormattingEnabled = true;
            this.deleteAssetComboBox.Location = new System.Drawing.Point(27, 22);
            this.deleteAssetComboBox.Name = "deleteAssetComboBox";
            this.deleteAssetComboBox.Size = new System.Drawing.Size(243, 24);
            this.deleteAssetComboBox.TabIndex = 20;
            this.deleteAssetComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteAssetComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox2.Controls.Add(this.addAssetButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.assetNameTxtBox);
            this.groupBox2.Controls.Add(this.assetLocationTxtBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(14, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 143);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Új eszköz hozzáadása";
            // 
            // addAssetButton
            // 
            this.addAssetButton.BackColor = System.Drawing.SystemColors.Control;
            this.addAssetButton.Location = new System.Drawing.Point(219, 68);
            this.addAssetButton.Name = "addAssetButton";
            this.addAssetButton.Size = new System.Drawing.Size(160, 46);
            this.addAssetButton.TabIndex = 18;
            this.addAssetButton.Text = "Eszköz hozzáadása";
            this.addAssetButton.UseVisualStyleBackColor = false;
            this.addAssetButton.Click += new System.EventHandler(this.addAssetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Eszköz megnevezése";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Elhelyezkedés";
            // 
            // assetNameTxtBox
            // 
            this.assetNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assetNameTxtBox.Location = new System.Drawing.Point(30, 53);
            this.assetNameTxtBox.Name = "assetNameTxtBox";
            this.assetNameTxtBox.Size = new System.Drawing.Size(160, 22);
            this.assetNameTxtBox.TabIndex = 10;
            // 
            // assetLocationTxtBox
            // 
            this.assetLocationTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assetLocationTxtBox.Location = new System.Drawing.Point(30, 101);
            this.assetLocationTxtBox.Name = "assetLocationTxtBox";
            this.assetLocationTxtBox.Size = new System.Drawing.Size(160, 22);
            this.assetLocationTxtBox.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox3.Controls.Add(this.editAssetsDataButton);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.assetEditLocationTxtBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.assetEditNameTxtBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.assetForEditComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(428, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 143);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adatmódosítás";
            // 
            // editAssetsDataButton
            // 
            this.editAssetsDataButton.BackColor = System.Drawing.SystemColors.Control;
            this.editAssetsDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editAssetsDataButton.Location = new System.Drawing.Point(217, 83);
            this.editAssetsDataButton.Name = "editAssetsDataButton";
            this.editAssetsDataButton.Size = new System.Drawing.Size(160, 46);
            this.editAssetsDataButton.TabIndex = 19;
            this.editAssetsDataButton.Text = "Adatmódosítás";
            this.editAssetsDataButton.UseVisualStyleBackColor = false;
            this.editAssetsDataButton.Click += new System.EventHandler(this.editAssetsDataButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(214, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Elhelyezkedés";
            // 
            // assetEditLocationTxtBox
            // 
            this.assetEditLocationTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assetEditLocationTxtBox.Location = new System.Drawing.Point(216, 51);
            this.assetEditLocationTxtBox.Name = "assetEditLocationTxtBox";
            this.assetEditLocationTxtBox.Size = new System.Drawing.Size(160, 22);
            this.assetEditLocationTxtBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(24, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Új megnevezés";
            // 
            // assetEditNameTxtBox
            // 
            this.assetEditNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assetEditNameTxtBox.Location = new System.Drawing.Point(27, 101);
            this.assetEditNameTxtBox.Name = "assetEditNameTxtBox";
            this.assetEditNameTxtBox.Size = new System.Drawing.Size(160, 22);
            this.assetEditNameTxtBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(24, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Eszköz kiválasztása";
            // 
            // assetForEditComboBox
            // 
            this.assetForEditComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assetForEditComboBox.FormattingEnabled = true;
            this.assetForEditComboBox.Location = new System.Drawing.Point(27, 51);
            this.assetForEditComboBox.Name = "assetForEditComboBox";
            this.assetForEditComboBox.Size = new System.Drawing.Size(160, 24);
            this.assetForEditComboBox.TabIndex = 12;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(14, 22);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 46);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Bezárás";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Assets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eszközök adminisztrálása";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox queryListBox;
        private System.Windows.Forms.Button queryAllAssets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button queryAssetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assetsIdTxtBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteAssetButton;
        private System.Windows.Forms.ComboBox deleteAssetComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addAssetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assetNameTxtBox;
        private System.Windows.Forms.TextBox assetLocationTxtBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button editAssetsDataButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox assetEditLocationTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox assetEditNameTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox assetForEditComboBox;
        private System.Windows.Forms.Button backButton;
    }
}