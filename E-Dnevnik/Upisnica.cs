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

namespace E_Dnevnik
{
    public partial class Upisnica : Form
    {
        public Upisnica()
        {
            InitializeComponent();
        }
        private void cmb_godina_populate()
        {
            SqlConnection veza = Konekcija.Connect();
        }

        private void Upisnica_Load(object sender, EventArgs e)
        {

        }
    }
}
