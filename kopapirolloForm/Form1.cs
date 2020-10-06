using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopapirolloForm
{
    public partial class frmfo : Form

    {
        public int jatekos { get; private set; }


        public int szgep { get; private set; }


        public frmfo()
        {
            InitializeComponent();
            lbljatekos.Text = "";
            lblszamitogep.Text = "";
            lblgyoztes.Text = "";
        }



        private void btnkilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnujjatek_Click(object sender, EventArgs e)
        {
            kezdetibeallitas();
        }

        private void kezdetibeallitas()
        {
            lblgyoztes.Text = "0";
            lbljatekos.Text = "0";
            lblszamitogep.Text = "0";
            jatekos = 0;
            szgep = 0;
        }

        private void btnko_Click(object sender, EventArgs e)
        {
            pbjatekos.Image = Image.FromFile("ko.jpg");
            fordulo(1);
        }

        private void btnpapir_Click(object sender, EventArgs e)
        {
            pbjatekos.Image = Image.FromFile("papir.jpg");
            fordulo(2);
        }

        private void btnollo_Click(object sender, EventArgs e)
        {
            pbjatekos.Image = Image.FromFile("ollo.jpg");
            fordulo(3);
        }


        private void eredemynkiiras()
        {
            lbljatekos.Text = jatekos.ToString();
            lblszamitogep.Text = szgep.ToString();
        }

        private void fordulo(int jatekos)
        {
            Random rnd = new Random();
            int gep = rnd.Next(1,4);

            switch (gep)
            {
                case 1:
                    pbszamitogep.Image = Image.FromFile("ko.jpg");
                    break;

                case 2:
                    pbszamitogep.Image = Image.FromFile("papir.jpg");
                    break;
                case 3:
                    pbszamitogep.Image = Image.FromFile("ollo.jpg");
                    break;
            }


            if (gep == jatekos)
            {
                jatekos++;
                gep++;
                lblgyoztes.Text = "Döntetlen";
                
            }
            else
            {
                //ko = 1 papir = 2 ollo = 3
                if ((jatekos == 1 && gep ==3) ||(jatekos == 2 && gep == 1) || (jatekos ==3 && gep ==2))
                {
                    jatekos++;
                    lblgyoztes.Text = "Játékos";
                    
                }
                else
                {
                    szgep++;
                    lblgyoztes.Text = "Számítógép";
                    
                }



            }







            eredemynkiiras();
        }
    }
}
