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
            this.dataFromDb = new System.Windows.Forms.TextBox();
            this.getAllData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataFromDb
            // 
            this.dataFromDb.Location = new System.Drawing.Point(191, 117);
            this.dataFromDb.Multiline = true;
            this.dataFromDb.Name = "dataFromDb";
            this.dataFromDb.Size = new System.Drawing.Size(392, 278);
            this.dataFromDb.TabIndex = 0;
            this.dataFromDb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // getAllData
            // 
            this.getAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.getAllData.Location = new System.Drawing.Point(191, 60);
            this.getAllData.Name = "getAllData";
            this.getAllData.Size = new System.Drawing.Size(185, 41);
            this.getAllData.TabIndex = 1;
            this.getAllData.Text = "Adatok lekérdezése";
            this.getAllData.UseVisualStyleBackColor = true;
            this.getAllData.Click += new System.EventHandler(this.getAllData_Click);
            // 
            // Occupations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getAllData);
            this.Controls.Add(this.dataFromDb);
            this.Name = "Occupations";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataFromDb;
        private System.Windows.Forms.Button getAllData;
    }
}