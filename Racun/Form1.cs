using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Racun
{
    public partial class Form1 : Form
    {
        string CS = "Data source = SIMI\\SQLEXPRESS; Initial catalog = Racun; Integrated security = true";
        DataTable podaci = new DataTable();
        int red = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void osvezi()
        {
            if (podaci.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_br_racuna.Text = "";
                txt_kupac.Text = "";
                txt_datum.Text = "";
                txt_vrednost.Text = "";
                txt_br_stavki.Text = "";

                button_r.Enabled = false;
                button_rr.Enabled = false;
                button_l.Enabled = false;
                button_ll.Enabled = false;
                button_delete.Enabled = false;
                button_update.Enabled = false;

                red = 0;
            }
            else
            {
                txt_id.Text = podaci.Rows[red]["id"].ToString();
                txt_br_racuna.Text = podaci.Rows[red]["br_racuna"].ToString();
                txt_kupac.Text = podaci.Rows[red]["kupac"].ToString();
                txt_datum.Text = podaci.Rows[red]["datum"].ToString();
                txt_vrednost.Text = podaci.Rows[red]["vrednost"].ToString();
                txt_br_stavki.Text = podaci.Rows[red]["br_stavki"].ToString();

                button_rr.Enabled = (red != podaci.Rows.Count - 1);
                button_r.Enabled = (red != podaci.Rows.Count - 1);
                button_ll.Enabled = (red != 0);
                button_l.Enabled = (red != 0);
                button_delete.Enabled = true;
                button_update.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM racun", veza);
            adapter.Fill(podaci);
            osvezi();
        }

        private void button_r_Click(object sender, EventArgs e)
        {
            red++;
            osvezi();
        }

        private void button_rr_Click(object sender, EventArgs e)
        {
            red = podaci.Rows.Count - 1;
            osvezi();
        }

        private void button_l_Click(object sender, EventArgs e)
        {
            red--;
            osvezi();
        }

        private void button_ll_Click(object sender, EventArgs e)
        {
            red = 0;
            osvezi();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand("DELETE FROM racun WHERE id =" + txt_id.Text, veza);

            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM racun", veza);
            podaci.Clear();
            adapter.Fill(podaci);

            if (red > podaci.Rows.Count - 1)
            {
                red = podaci.Rows.Count - 1;
            }

            osvezi();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand("UPDATE racun SET br_racuna = '" + txt_br_racuna.Text + "', kupac = '" + txt_kupac.Text + "', " +
            "datum = '" + txt_datum.Text + "', vrednost = '" + txt_vrednost.Text + "', br_stavki = '" + txt_br_stavki.Text + "' WHERE id =" + txt_id.Text, veza);

            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM racun", veza);
            podaci.Clear();
            adapter.Fill(podaci);

            if (red > podaci.Rows.Count - 1)
            {
                red = podaci.Rows.Count - 1;
            }

            osvezi();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand("INSERT INTO racun (br_racuna, kupac, datum, vrednost, br_stavki) VALUES (" + txt_br_racuna.Text + "," +
            " '" + txt_kupac.Text + "', '" + txt_datum.Text + "', " + txt_vrednost.Text + ", " + txt_br_stavki.Text + ")", veza);

            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM racun ORDER BY id", veza);

            podaci.Clear();
            adapter.Fill(podaci);

            red = podaci.Rows.Count - 1;
            osvezi();
        }

        private void button_isprazni_Click(object sender, EventArgs e)
        {
            txt_br_racuna.Text = "";
            txt_kupac.Text = "";
            txt_datum.Text = "";
            txt_vrednost.Text = "";
            txt_br_stavki.Text = "";
        }
    }
}
