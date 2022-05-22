using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spajz
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            string user = Program.user_ime + " " + Program.user_prezime;
            lbl_user.Text = user;
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis frm_korisnici = new Popis("Korisnik");
            frm_korisnici.Text = "Korisnici";
            frm_korisnici.Show();
        }

        private void izmenaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorKorisnik frm_korisnici = new EditorKorisnik();
            frm_korisnici.Show();
        }

        private void pregledKategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis frm_kategorije = new Popis("Kategorija");
            frm_kategorije.Text = "Kategorije";
            frm_kategorije.Show();
        }

        private void izmenaKategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorKategorija frm_kategorije = new EditorKategorija();
            frm_kategorije.Show();
        }

        private void pregledProizvodjacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis frm_proizvodjaci = new Popis("Proizvodjac");
            frm_proizvodjaci.Text = "Proizvodjaci";
            frm_proizvodjaci.Show();
        }

        private void izmenaProizvodjacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorProizvodjac frm_proizvodjaci = new EditorProizvodjac();
            frm_proizvodjaci.Show();
        }

        private void pregledProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis frm_proizvodi = new Popis("Proizvod");
            frm_proizvodi.Text = "Proizvodi";
            frm_proizvodi.Show();
        }

        private void izmenaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorProizvod frm_proizvodi = new EditorProizvod();
            frm_proizvodi.Show();
        }
    }
}
