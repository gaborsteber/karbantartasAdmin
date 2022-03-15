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
            this.userIdTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queryUserButton = new System.Windows.Forms.Button();
            this.responseTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.queryAllUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIdTxtBox
            // 
            this.userIdTxtBox.Location = new System.Drawing.Point(156, 76);
            this.userIdTxtBox.Name = "userIdTxtBox";
            this.userIdTxtBox.Size = new System.Drawing.Size(132, 20);
            this.userIdTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felhasználói id:";
            // 
            // queryUserButton
            // 
            this.queryUserButton.Location = new System.Drawing.Point(307, 74);
            this.queryUserButton.Name = "queryUserButton";
            this.queryUserButton.Size = new System.Drawing.Size(75, 23);
            this.queryUserButton.TabIndex = 2;
            this.queryUserButton.Text = "lekérdezés";
            this.queryUserButton.UseVisualStyleBackColor = true;
            this.queryUserButton.Click += new System.EventHandler(this.queryUserButton_Click);
            // 
            // responseTxtBox
            // 
            this.responseTxtBox.Location = new System.Drawing.Point(156, 118);
            this.responseTxtBox.Multiline = true;
            this.responseTxtBox.Name = "responseTxtBox";
            this.responseTxtBox.Size = new System.Drawing.Size(226, 126);
            this.responseTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lekérdezés eredménye:";
            // 
            // queryAllUser
            // 
            this.queryAllUser.Location = new System.Drawing.Point(156, 32);
            this.queryAllUser.Name = "queryAllUser";
            this.queryAllUser.Size = new System.Drawing.Size(226, 36);
            this.queryAllUser.TabIndex = 5;
            this.queryAllUser.Text = "Összes felhasználó lekérdezése";
            this.queryAllUser.UseVisualStyleBackColor = true;
            this.queryAllUser.Click += new System.EventHandler(this.queryAllUser_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryAllUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.responseTxtBox);
            this.Controls.Add(this.queryUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userIdTxtBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button queryUserButton;
        private System.Windows.Forms.TextBox responseTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button queryAllUser;
    }
}