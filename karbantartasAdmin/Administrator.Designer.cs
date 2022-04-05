namespace karbantartasAdmin
{
    partial class Administrator
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
            this.addMainCategory = new System.Windows.Forms.Button();
            this.addEquipment = new System.Windows.Forms.Button();
            this.addOccupationButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMainCategory
            // 
            this.addMainCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addMainCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMainCategory.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMainCategory.Location = new System.Drawing.Point(306, 340);
            this.addMainCategory.Name = "addMainCategory";
            this.addMainCategory.Size = new System.Drawing.Size(200, 60);
            this.addMainCategory.TabIndex = 0;
            this.addMainCategory.Text = "Kategóriák adminisztrálása";
            this.addMainCategory.UseVisualStyleBackColor = false;
            this.addMainCategory.Visible = false;
            this.addMainCategory.Click += new System.EventHandler(this.addMainCategory_Click);
            // 
            // addEquipment
            // 
            this.addEquipment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEquipment.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEquipment.Location = new System.Drawing.Point(306, 177);
            this.addEquipment.Name = "addEquipment";
            this.addEquipment.Size = new System.Drawing.Size(200, 60);
            this.addEquipment.TabIndex = 1;
            this.addEquipment.Text = "Eszközök adminisztrálása";
            this.addEquipment.UseVisualStyleBackColor = false;
            this.addEquipment.Click += new System.EventHandler(this.addEquipment_Click);
            // 
            // addOccupationButton
            // 
            this.addOccupationButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addOccupationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOccupationButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addOccupationButton.Location = new System.Drawing.Point(306, 262);
            this.addOccupationButton.Name = "addOccupationButton";
            this.addOccupationButton.Size = new System.Drawing.Size(200, 60);
            this.addOccupationButton.TabIndex = 2;
            this.addOccupationButton.Text = "Végzettségek adminisztrálása";
            this.addOccupationButton.UseVisualStyleBackColor = false;
            this.addOccupationButton.Click += new System.EventHandler(this.addOccupationButton_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userButton.Location = new System.Drawing.Point(306, 90);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(200, 60);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "Felhasználók adminisztrálása";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.backButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(14, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(106, 40);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Bezárás";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.addOccupationButton);
            this.Controls.Add(this.addEquipment);
            this.Controls.Add(this.addMainCategory);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminisztrálási felület kiválasztása";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMainCategory;
        private System.Windows.Forms.Button addEquipment;
        private System.Windows.Forms.Button addOccupationButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button backButton;
    }
}