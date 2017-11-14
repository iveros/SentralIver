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
//TEST
namespace SentralIver
{
    public partial class RegistrerNyKunde : Form
    {
        static int Kid = 1;
        Form1 sentral;

        
        //Sentral nySentral = new Sentral();

        public RegistrerNyKunde(Form1 o)
        {
            InitializeComponent();
            txtKid.Text = (Kid).ToString();
            this.sentral = o;
        }

        private void btn_Lagre_Click(object sender, EventArgs e)
        {
            try
            {
                sentral.leggTilKunde(txtNavn.Text, txtAdresse.Text, Kid, txtPassord.Text, txtIP.Text);
                ++Kid;

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // Midlertidig metode for autogenerering av kunder
        private void btnAuto_Click(object sender, EventArgs e)
        {
            string navn, adresse, passord, IP;
            navn = "Marta"; adresse = "Bergen"; passord = "123abc"; IP = "128.01.12.211";
            try
            {
                sentral.leggTilKunde(navn, adresse, Kid, passord, IP);
                ++Kid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            navn = "Eirik"; adresse = "Oslo"; passord = "jegelskerarduino"; IP = "128.01.12.223";
            try
            {
                sentral.leggTilKunde(navn, adresse, Kid, passord, IP);
                ++Kid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            navn = "Kent"; adresse = "Minde"; passord = "csgORuler"; IP = "192.01.12.211";
            try
            {
                sentral.leggTilKunde(navn, adresse, Kid, passord, IP);
                ++Kid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            navn = "Iver"; adresse = "Ulsteinvik"; passord = "hallaien321"; IP = "172.01.12.556";
            try
            {
                sentral.leggTilKunde(navn, adresse, Kid, passord, IP);
                ++Kid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            navn = "Vebjørn"; adresse = "vetikke"; passord = "klassefil123"; IP = "231.01.12.556";
            try
            {
                sentral.leggTilKunde(navn, adresse, Kid, passord, IP);
                ++Kid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
