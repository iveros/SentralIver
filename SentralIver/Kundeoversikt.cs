using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOKlasseLib;

namespace SentralIver
{
    public partial class Kundeoversikt : Form
    {
        
        public Kundeoversikt()
        {
            InitializeComponent();
        }

        public void skrivUtKundeoversikt(Sentral o, int KID)
        {
            int antallKunder = o.KundeListe.Count();

            for (int i=0 ; i< antallKunder; i++)
            {
                richKundeliste.AppendText(o.SkrivUtKundeliste(i)); // Midlertidig funksjon i SO_Klasser
            }
        }

        private void btnLukk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


