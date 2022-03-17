namespace karbantartasAdmin
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.userIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queryUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.queryAllUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queryListBox = new System.Windows.Forms.ListBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.fullNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.occComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userForEditComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userEditUsernameTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userEditPassTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.editUserRoleComboBox = new System.Windows.Forms.ComboBox();
            this.editUserOccComboBox = new System.Windows.Forms.ComboBox();
            this.editUserDataButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteUserComboBox = new System.Windows.Forms.ComboBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIdTxtBox
            // 
            this.userIdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userIdTxtBox.Location = new System.Drawing.Point(30, 109);
            this.userIdTxtBox.Name = "userIdTxtBox";
            this.userIdTxtBox.Size = new System.Drawing.Size(132, 20);
            this.userIdTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lekérdezés felhasználói id alapján:";
            // 
            // queryUserButton
            // 
            this.queryUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryUserButton.Location = new System.Drawing.Point(168, 107);
            this.queryUserButton.Name = "queryUserButton";
            this.queryUserButton.Size = new System.Drawing.Size(88, 23);
            this.queryUserButton.TabIndex = 2;
            this.queryUserButton.Text = "Lekérdezés";
            this.queryUserButton.UseVisualStyleBackColor = true;
            this.queryUserButton.Click += new System.EventHandler(this.queryUserButton_Click);
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
            // queryAllUser
            // 
            this.queryAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryAllUser.Location = new System.Drawing.Point(30, 38);
            this.queryAllUser.Name = "queryAllUser";
            this.queryAllUser.Size = new System.Drawing.Size(226, 36);
            this.queryAllUser.TabIndex = 5;
            this.queryAllUser.Text = "Összes felhasználó lekérdezése";
            this.queryAllUser.UseVisualStyleBackColor = true;
            this.queryAllUser.Click += new System.EventHandler(this.queryAllUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.queryListBox);
            this.groupBox1.Controls.Add(this.queryAllUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.queryUserButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userIdTxtBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(14, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 152);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lekérdezés a felhasználói adatbázisból";
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
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTxtBox.Location = new System.Drawing.Point(9, 105);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(160, 22);
            this.usernameTxtBox.TabIndex = 7;
            // 
            // passTxtBox
            // 
            this.passTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTxtBox.Location = new System.Drawing.Point(9, 156);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(160, 22);
            this.passTxtBox.TabIndex = 8;
            // 
            // fullNameTxtBox
            // 
            this.fullNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fullNameTxtBox.Location = new System.Drawing.Point(9, 53);
            this.fullNameTxtBox.Name = "fullNameTxtBox";
            this.fullNameTxtBox.Size = new System.Drawing.Size(160, 22);
            this.fullNameTxtBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.addUserButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.occComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rolesComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.fullNameTxtBox);
            this.groupBox2.Controls.Add(this.passTxtBox);
            this.groupBox2.Controls.Add(this.usernameTxtBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(14, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 205);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Új felhasználó hozzáadása";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(232, 144);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(160, 46);
            this.addUserButton.TabIndex = 18;
            this.addUserButton.Text = "Felhasználó hozzáadása";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(229, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Végzettség";
            // 
            // occComboBox
            // 
            this.occComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.occComboBox.FormattingEnabled = true;
            this.occComboBox.Location = new System.Drawing.Point(232, 103);
            this.occComboBox.Name = "occComboBox";
            this.occComboBox.Size = new System.Drawing.Size(160, 24);
            this.occComboBox.TabIndex = 16;
            this.occComboBox.SelectedIndexChanged += new System.EventHandler(this.occComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(229, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Munkakör";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(232, 53);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(160, 24);
            this.rolesComboBox.TabIndex = 14;
            this.rolesComboBox.SelectedIndexChanged += new System.EventHandler(this.rolesComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jelszó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Teljes Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Felhasználónév";
            // 
            // userForEditComboBox
            // 
            this.userForEditComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userForEditComboBox.FormattingEnabled = true;
            this.userForEditComboBox.Location = new System.Drawing.Point(9, 53);
            this.userForEditComboBox.Name = "userForEditComboBox";
            this.userForEditComboBox.Size = new System.Drawing.Size(160, 24);
            this.userForEditComboBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Teljes Név";
            // 
            // userEditUsernameTxtBox
            // 
            this.userEditUsernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userEditUsernameTxtBox.Location = new System.Drawing.Point(9, 105);
            this.userEditUsernameTxtBox.Name = "userEditUsernameTxtBox";
            this.userEditUsernameTxtBox.Size = new System.Drawing.Size(160, 22);
            this.userEditUsernameTxtBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Felhasználónév";
            // 
            // userEditPassTxtBox
            // 
            this.userEditPassTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userEditPassTxtBox.Location = new System.Drawing.Point(9, 156);
            this.userEditPassTxtBox.Name = "userEditPassTxtBox";
            this.userEditPassTxtBox.Size = new System.Drawing.Size(160, 22);
            this.userEditPassTxtBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Jelszó";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(220, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Munkakör";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(220, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Végzettség";
            // 
            // editUserRoleComboBox
            // 
            this.editUserRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editUserRoleComboBox.FormattingEnabled = true;
            this.editUserRoleComboBox.Location = new System.Drawing.Point(199, 53);
            this.editUserRoleComboBox.Name = "editUserRoleComboBox";
            this.editUserRoleComboBox.Size = new System.Drawing.Size(160, 24);
            this.editUserRoleComboBox.TabIndex = 19;
            this.editUserRoleComboBox.SelectedIndexChanged += new System.EventHandler(this.editUserRoleComboBox_SelectedIndexChanged);
            // 
            // editUserOccComboBox
            // 
            this.editUserOccComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editUserOccComboBox.FormattingEnabled = true;
            this.editUserOccComboBox.Location = new System.Drawing.Point(199, 105);
            this.editUserOccComboBox.Name = "editUserOccComboBox";
            this.editUserOccComboBox.Size = new System.Drawing.Size(160, 24);
            this.editUserOccComboBox.TabIndex = 19;
            this.editUserOccComboBox.SelectedIndexChanged += new System.EventHandler(this.editUserOccComboBox_SelectedIndexChanged);
            // 
            // editUserDataButton
            // 
            this.editUserDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editUserDataButton.Location = new System.Drawing.Point(199, 144);
            this.editUserDataButton.Name = "editUserDataButton";
            this.editUserDataButton.Size = new System.Drawing.Size(160, 46);
            this.editUserDataButton.TabIndex = 19;
            this.editUserDataButton.Text = "Adatmódosítás";
            this.editUserDataButton.UseVisualStyleBackColor = true;
            this.editUserDataButton.Click += new System.EventHandler(this.editUserDataButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.editUserDataButton);
            this.groupBox3.Controls.Add(this.editUserOccComboBox);
            this.groupBox3.Controls.Add(this.editUserRoleComboBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.userEditPassTxtBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.userEditUsernameTxtBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.userForEditComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(445, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 205);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adatmódosítás";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(14, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 32);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Vissza";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteUserComboBox
            // 
            this.deleteUserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteUserComboBox.FormattingEnabled = true;
            this.deleteUserComboBox.Location = new System.Drawing.Point(27, 22);
            this.deleteUserComboBox.Name = "deleteUserComboBox";
            this.deleteUserComboBox.Size = new System.Drawing.Size(160, 24);
            this.deleteUserComboBox.TabIndex = 20;
            this.deleteUserComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteUserComboBox_SelectedIndexChanged);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteUserButton.Location = new System.Drawing.Point(217, 16);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(160, 32);
            this.deleteUserButton.TabIndex = 20;
            this.deleteUserButton.Text = "Felhasználó törlése";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.deleteUserButton);
            this.groupBox4.Controls.Add(this.deleteUserComboBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(427, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 62);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Felhasználó törlése";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felhasználók kezelése";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userIdTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button queryUserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button queryAllUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.TextBox fullNameTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox occComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox queryListBox;
        private System.Windows.Forms.ComboBox userForEditComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userEditUsernameTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userEditPassTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox editUserRoleComboBox;
        private System.Windows.Forms.ComboBox editUserOccComboBox;
        private System.Windows.Forms.Button editUserDataButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox deleteUserComboBox;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}