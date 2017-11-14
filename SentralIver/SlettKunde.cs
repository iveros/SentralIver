using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentralIver
{
    public partial class SlettKunde : Form
    {
        Form1 sentral;
        int kid;
        public SlettKunde(Form1 o)
        {
            InitializeComponent();
            this.sentral = o;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSlett_Click(object sender, EventArgs e)
        {
            try
            {
                kid = Int32.Parse(txtSlett.Text);
                sentral.slettKunde(kid - 1);
                MessageBox.Show("Kunden med KID: " + kid + " er nå slettet.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Feil: " + ex.Message);
            }
            
        }
    }
}
