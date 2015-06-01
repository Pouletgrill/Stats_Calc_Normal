using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        double[,] TableauNormale;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_Cas.SelectedIndex = 0;
        }

        //Gestion des événements
        private void CB_Cas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshButton()
        {
            //a faire
            if (NUD_a.Value < NUD_b.Value)
            {
                BTN_Calculer.Enabled = true;
            }
            else
            {
                BTN_Calculer.Enabled = false;
            }
        }

        private void BTN_Calculer_Click(object sender, EventArgs e)
        {
            TB_Rep.Text = CalculerAireSousCourbe();
        }

        private string CalculerAireSousCourbe()
        {
            int NB_PointSousCourbe = 0;
            Random rnd = new Random();
            if (CB_Cas.SelectedIndex == 0)//si Fonction 1
            {
                for (int i=0; i<10000;i++)
                {
                    double rnd_X = (rnd.Next(Convert.ToInt32(NUD_a.Value)*100,
                        Convert.ToInt32(NUD_b.Value)*100+1))/100f;
                    double rnd_Y = rnd.Next(0*100,5*100+1)/100f;
                    rnd_X = 5.0;
                    rnd_Y = 5.0;
                    double test = Fct1GetY(rnd_X);
                    if (rnd_Y <= test)
                    {
                        NB_PointSousCourbe++;
                    }
                }
            }
            else if (CB_Cas.SelectedIndex == 1)//si Fonction 2
            {
                for (int i = 0; i < 10000; i++)
                {

                }
            }
            else if (CB_Cas.SelectedIndex == 2)//si Fonction 3
            {
                for (int i = 0; i < 10000; i++)
                {

                }
            }
            else if (CB_Cas.SelectedIndex == 3)//si Fonction 4
            {
                for (int i = 0; i < 10000; i++)
                {

                }
            }
            else if (CB_Cas.SelectedIndex == 4)//si Fonction 5
            {
                for (int i = 0; i < 10000; i++)
                {

                }
            }
            return "";//a faire
        }

        private void NUD_a_b_ValueChanged(object sender, EventArgs e)
        {
            RefreshButton();
        }

        /////////////
        //Fonctions//
        /////////////
        private double Fct1GetY(double x)
        {
            return (0-CubicRoot(Math.Pow(x,2f)- (16f*x)+63f))+4f;
        }

        private double Fct2GetY(double x)
        {
            return 3*(Math.Pow((x-7f)/5f,5f))-5*(Math.Pow((x-7f)/5f,3f))+3f;
        }

        private double Fct3GetY(double x)
        {
            return (0-(1f/3f))*Math.Pow(x-6f,2f)+12f;
        }

        private double Fct4GetY(double x)
        {
            return x + Math.Sin(x);
        }

        private double Fct5GetY(double x)
        {
            return Math.Cos(x)+3f;
        }
        //////////////////////////////////////////////
        //Math//
        ////////
        private double CubicRoot(double x)
        {
            return Math.Pow(x, (1.0 / 3.0));
        }
    }
}
