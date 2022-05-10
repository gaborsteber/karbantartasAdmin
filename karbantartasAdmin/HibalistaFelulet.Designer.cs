
namespace karbantartasAdmin
{
    partial class HibalistaFelulet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnHibalista = new System.Windows.Forms.Button();
            this.BtnBezar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnHibalista
            // 
            this.BtnHibalista.Location = new System.Drawing.Point(720, 42);
            this.BtnHibalista.Name = "BtnHibalista";
            this.BtnHibalista.Size = new System.Drawing.Size(131, 23);
            this.BtnHibalista.TabIndex = 1;
            this.BtnHibalista.Text = "Hibák listázása";
            this.BtnHibalista.UseVisualStyleBackColor = true;
            // 
            // BtnBezar
            // 
            this.BtnBezar.Location = new System.Drawing.Point(720, 448);
            this.BtnBezar.Name = "BtnBezar";
            this.BtnBezar.Size = new System.Drawing.Size(131, 23);
            this.BtnBezar.TabIndex = 2;
            this.BtnBezar.Text = "Bezár";
            this.BtnBezar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Visszautasított feladatok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HibalistaFelulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBezar);
            this.Controls.Add(this.BtnHibalista);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HibalistaFelulet";
            this.Text = "HibalistaFelulet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnHibalista;
        private System.Windows.Forms.Button BtnBezar;
        private System.Windows.Forms.Button button1;
    }
}