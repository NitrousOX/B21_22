namespace B21_22
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radnaMestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nezavrseniProjektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizaBudzetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.izvestajiToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radnaMestaToolStripMenuItem,
            this.radniciToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // radnaMestaToolStripMenuItem
            // 
            this.radnaMestaToolStripMenuItem.Name = "radnaMestaToolStripMenuItem";
            this.radnaMestaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radnaMestaToolStripMenuItem.Text = "Radna mesta";
            this.radnaMestaToolStripMenuItem.Click += new System.EventHandler(this.RadnaMestaToolStripMenuItem_Click);
            // 
            // radniciToolStripMenuItem
            // 
            this.radniciToolStripMenuItem.Name = "radniciToolStripMenuItem";
            this.radniciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radniciToolStripMenuItem.Text = "Radnici";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nezavrseniProjektiToolStripMenuItem,
            this.analizaBudzetaToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaj";
            // 
            // nezavrseniProjektiToolStripMenuItem
            // 
            this.nezavrseniProjektiToolStripMenuItem.Name = "nezavrseniProjektiToolStripMenuItem";
            this.nezavrseniProjektiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nezavrseniProjektiToolStripMenuItem.Text = "Nezavrseni projekti";
            this.nezavrseniProjektiToolStripMenuItem.Click += new System.EventHandler(this.NezavrseniProjektiToolStripMenuItem_Click);
            // 
            // analizaBudzetaToolStripMenuItem
            // 
            this.analizaBudzetaToolStripMenuItem.Name = "analizaBudzetaToolStripMenuItem";
            this.analizaBudzetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analizaBudzetaToolStripMenuItem.Text = "Analiza budzeta";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.krajToolStripMenuItem.Text = "kraj";
            this.krajToolStripMenuItem.Click += new System.EventHandler(this.KrajToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radnaMestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nezavrseniProjektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizaBudzetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
    }
}

