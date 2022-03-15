namespace karbantartasAdmin
{
    partial class Form1
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
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.jsonTxtBox = new System.Windows.Forms.TextBox();
            this.GET = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.textValasz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTxtBox.Location = new System.Drawing.Point(339, 89);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(300, 22);
            this.usernameTxtBox.TabIndex = 3;
            this.usernameTxtBox.TextChanged += new System.EventHandler(this.usernameTxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(417, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Felhasználónév";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passTxtBox
            // 
            this.passTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTxtBox.Location = new System.Drawing.Point(339, 155);
            this.passTxtBox.MaximumSize = new System.Drawing.Size(300, 30);
            this.passTxtBox.MinimumSize = new System.Drawing.Size(100, 30);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(300, 22);
            this.passTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(450, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jelszó";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(372, 183);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(221, 41);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Bejelentkezés";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(393, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kijelentkezés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jsonTxtBox
            // 
            this.jsonTxtBox.Location = new System.Drawing.Point(498, 328);
            this.jsonTxtBox.Name = "jsonTxtBox";
            this.jsonTxtBox.Size = new System.Drawing.Size(367, 20);
            this.jsonTxtBox.TabIndex = 8;
            // 
            // GET
            // 
            this.GET.Location = new System.Drawing.Point(249, 302);
            this.GET.Name = "GET";
            this.GET.Size = new System.Drawing.Size(75, 23);
            this.GET.TabIndex = 2;
            this.GET.Text = "getInfo";
            this.GET.UseVisualStyleBackColor = true;
            this.GET.Click += new System.EventHandler(this.GET_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(12, 302);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(213, 20);
            this.text1.TabIndex = 0;
            // 
            // textValasz
            // 
            this.textValasz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textValasz.Location = new System.Drawing.Point(12, 328);
            this.textValasz.Multiline = true;
            this.textValasz.Name = "textValasz";
            this.textValasz.Size = new System.Drawing.Size(418, 211);
            this.textValasz.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jsonTxtBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.GET);
            this.Controls.Add(this.textValasz);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Karbantartás Adminisztrációs Felület";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox jsonTxtBox;
        private System.Windows.Forms.Button GET;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox textValasz;
    }
}

