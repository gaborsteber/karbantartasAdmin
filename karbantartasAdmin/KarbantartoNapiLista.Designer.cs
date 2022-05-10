
namespace karbantartasAdmin
{
    partial class KarbantartoNapiLista
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
            this.DgwFeladatok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBezar = new System.Windows.Forms.Button();
            this.CbxKarbantartoLista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgwFeladatok)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwFeladatok
            // 
            this.DgwFeladatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwFeladatok.Location = new System.Drawing.Point(49, 143);
            this.DgwFeladatok.Name = "DgwFeladatok";
            this.DgwFeladatok.Size = new System.Drawing.Size(705, 337);
            this.DgwFeladatok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karbantartó Napi Feladatok";
            // 
            // BtnBezar
            // 
            this.BtnBezar.Location = new System.Drawing.Point(785, 457);
            this.BtnBezar.Name = "BtnBezar";
            this.BtnBezar.Size = new System.Drawing.Size(75, 23);
            this.BtnBezar.TabIndex = 2;
            this.BtnBezar.Text = "Bezár";
            this.BtnBezar.UseVisualStyleBackColor = true;
            this.BtnBezar.Click += new System.EventHandler(this.BtnBezar_Click);
            // 
            // CbxKarbantartoLista
            // 
            this.CbxKarbantartoLista.FormattingEnabled = true;
            this.CbxKarbantartoLista.Location = new System.Drawing.Point(141, 74);
            this.CbxKarbantartoLista.Name = "CbxKarbantartoLista";
            this.CbxKarbantartoLista.Size = new System.Drawing.Size(121, 21);
            this.CbxKarbantartoLista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Karbantarto neve";
            // 
            // KarbantartoNapiLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxKarbantartoLista);
            this.Controls.Add(this.BtnBezar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgwFeladatok);
            this.Name = "KarbantartoNapiLista";
            this.Text = "KarbantartoNapiLista";
            ((System.ComponentModel.ISupportInitialize)(this.DgwFeladatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwFeladatok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBezar;
        private System.Windows.Forms.ComboBox CbxKarbantartoLista;
        private System.Windows.Forms.Label label2;
    }
}