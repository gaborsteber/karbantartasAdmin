
namespace karbantartasAdmin
{
    partial class OperatorFelulet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiosztásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibákListájaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.kiosztásToolStripMenuItem,
            this.feladatokToolStripMenuItem,
            this.hibákToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.névjegyToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // kiosztásToolStripMenuItem
            // 
            this.kiosztásToolStripMenuItem.Name = "kiosztásToolStripMenuItem";
            this.kiosztásToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kiosztásToolStripMenuItem.Text = "Kiosztás";
            // 
            // feladatokToolStripMenuItem
            // 
            this.feladatokToolStripMenuItem.Name = "feladatokToolStripMenuItem";
            this.feladatokToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.feladatokToolStripMenuItem.Text = "Feladatok";
            // 
            // hibákToolStripMenuItem
            // 
            this.hibákToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hibákListájaToolStripMenuItem});
            this.hibákToolStripMenuItem.Name = "hibákToolStripMenuItem";
            this.hibákToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hibákToolStripMenuItem.Text = "Hibák";
            // 
            // hibákListájaToolStripMenuItem
            // 
            this.hibákListájaToolStripMenuItem.Name = "hibákListájaToolStripMenuItem";
            this.hibákListájaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hibákListájaToolStripMenuItem.Text = "Hibák listája";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(260, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operátor felület";
            // 
            // OperatorFelulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "OperatorFelulet";
            this.Text = "OperatorFelulet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiosztásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibákListájaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}