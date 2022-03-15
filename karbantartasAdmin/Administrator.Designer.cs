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
            this.SuspendLayout();
            // 
            // addMainCategory
            // 
            this.addMainCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addMainCategory.Location = new System.Drawing.Point(275, 185);
            this.addMainCategory.Name = "addMainCategory";
            this.addMainCategory.Size = new System.Drawing.Size(220, 60);
            this.addMainCategory.TabIndex = 0;
            this.addMainCategory.Text = "Kategória felvitele";
            this.addMainCategory.UseVisualStyleBackColor = true;
            this.addMainCategory.Click += new System.EventHandler(this.addMainCategory_Click);
            // 
            // addEquipment
            // 
            this.addEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEquipment.Location = new System.Drawing.Point(275, 273);
            this.addEquipment.Name = "addEquipment";
            this.addEquipment.Size = new System.Drawing.Size(220, 60);
            this.addEquipment.TabIndex = 1;
            this.addEquipment.Text = "Eszköz felvitele";
            this.addEquipment.UseVisualStyleBackColor = true;
            this.addEquipment.Click += new System.EventHandler(this.addEquipment_Click);
            // 
            // addOccupationButton
            // 
            this.addOccupationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addOccupationButton.Location = new System.Drawing.Point(275, 358);
            this.addOccupationButton.Name = "addOccupationButton";
            this.addOccupationButton.Size = new System.Drawing.Size(220, 60);
            this.addOccupationButton.TabIndex = 2;
            this.addOccupationButton.Text = "Végzettség felvitele";
            this.addOccupationButton.UseVisualStyleBackColor = true;
            this.addOccupationButton.Click += new System.EventHandler(this.addOccupationButton_Click);
            // 
            // userButton
            // 
            this.userButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userButton.Location = new System.Drawing.Point(275, 104);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(220, 60);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "Felhasználók";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.addOccupationButton);
            this.Controls.Add(this.addEquipment);
            this.Controls.Add(this.addMainCategory);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMainCategory;
        private System.Windows.Forms.Button addEquipment;
        private System.Windows.Forms.Button addOccupationButton;
        private System.Windows.Forms.Button userButton;
    }
}