
namespace Spajz
{
    partial class AdminPage
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodjaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledProizvodjacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaProizvodjacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_user.Location = new System.Drawing.Point(525, 10);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(55, 23);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.proizvodjaciToolStripMenuItem,
            this.proizvodiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(664, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem,
            this.izmenaKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled Korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // izmenaKorisnikaToolStripMenuItem
            // 
            this.izmenaKorisnikaToolStripMenuItem.Name = "izmenaKorisnikaToolStripMenuItem";
            this.izmenaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmenaKorisnikaToolStripMenuItem.Text = "Izmena Korisnika";
            this.izmenaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izmenaKorisnikaToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKategorijaToolStripMenuItem,
            this.izmenaKategorijaToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // pregledKategorijaToolStripMenuItem
            // 
            this.pregledKategorijaToolStripMenuItem.Name = "pregledKategorijaToolStripMenuItem";
            this.pregledKategorijaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledKategorijaToolStripMenuItem.Text = " Pregled Kategorija";
            this.pregledKategorijaToolStripMenuItem.Click += new System.EventHandler(this.pregledKategorijaToolStripMenuItem_Click);
            // 
            // izmenaKategorijaToolStripMenuItem
            // 
            this.izmenaKategorijaToolStripMenuItem.Name = "izmenaKategorijaToolStripMenuItem";
            this.izmenaKategorijaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmenaKategorijaToolStripMenuItem.Text = "Izmena Kategorija";
            this.izmenaKategorijaToolStripMenuItem.Click += new System.EventHandler(this.izmenaKategorijaToolStripMenuItem_Click);
            // 
            // proizvodjaciToolStripMenuItem
            // 
            this.proizvodjaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledProizvodjacaToolStripMenuItem,
            this.izmenaProizvodjacaToolStripMenuItem});
            this.proizvodjaciToolStripMenuItem.Name = "proizvodjaciToolStripMenuItem";
            this.proizvodjaciToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.proizvodjaciToolStripMenuItem.Text = "Proizvodjaci";
            // 
            // pregledProizvodjacaToolStripMenuItem
            // 
            this.pregledProizvodjacaToolStripMenuItem.Name = "pregledProizvodjacaToolStripMenuItem";
            this.pregledProizvodjacaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.pregledProizvodjacaToolStripMenuItem.Text = "Pregled Proizvodjaca";
            this.pregledProizvodjacaToolStripMenuItem.Click += new System.EventHandler(this.pregledProizvodjacaToolStripMenuItem_Click);
            // 
            // izmenaProizvodjacaToolStripMenuItem
            // 
            this.izmenaProizvodjacaToolStripMenuItem.Name = "izmenaProizvodjacaToolStripMenuItem";
            this.izmenaProizvodjacaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.izmenaProizvodjacaToolStripMenuItem.Text = "Izmena Proizvodjaca";
            this.izmenaProizvodjacaToolStripMenuItem.Click += new System.EventHandler(this.izmenaProizvodjacaToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledProizvodaToolStripMenuItem,
            this.izmenaProizvodaToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // pregledProizvodaToolStripMenuItem
            // 
            this.pregledProizvodaToolStripMenuItem.Name = "pregledProizvodaToolStripMenuItem";
            this.pregledProizvodaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledProizvodaToolStripMenuItem.Text = "Pregled Proizvoda";
            this.pregledProizvodaToolStripMenuItem.Click += new System.EventHandler(this.pregledProizvodaToolStripMenuItem_Click);
            // 
            // izmenaProizvodaToolStripMenuItem
            // 
            this.izmenaProizvodaToolStripMenuItem.Name = "izmenaProizvodaToolStripMenuItem";
            this.izmenaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izmenaProizvodaToolStripMenuItem.Text = "Izmena Proizvoda";
            this.izmenaProizvodaToolStripMenuItem.Click += new System.EventHandler(this.izmenaProizvodaToolStripMenuItem_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 280);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "AdminPage";
            this.Text = "Admin Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaKategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodjaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledProizvodjacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaProizvodjacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaProizvodaToolStripMenuItem;
    }
}

