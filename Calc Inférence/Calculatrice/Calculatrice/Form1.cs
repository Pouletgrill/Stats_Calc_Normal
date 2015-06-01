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
        double pie = 0;
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
            CalculerAireSousCourbe();
        }

        private void CalculerAireSousCourbe()
        {
            int NB_PointSousCourbe = 0;
            Random rnd = new Random();
            int Ymax=0;
            double rnd_X;
            double rnd_Y;
            if (CB_Cas.SelectedIndex == 0)//si Fonction 1
            {
                Ymax = 5;
                for (int i=0; i<10000;i++)
                {
                    //Randomisation du nombre avec 2 chiffre apres la virgule
                    rnd_X = (rnd.Next(Convert.ToInt32(NUD_a.Value*100),
                        Convert.ToInt32(NUD_b.Value*100)+1))/100f;
                    rnd_Y = rnd.Next(0*100,Ymax*100+1)/100f;
                    ////////////////////////////////////////////////////////
                    if (rnd_Y <= Fct1GetY(rnd_X))
                    {
                        NB_PointSousCourbe++;
                    }
                }
            }
            else if (CB_Cas.SelectedIndex == 1)//si Fonction 2
            {
                Ymax = 5;
                for (int i = 0; i < 10000; i++)
                {
                    //Randomisation du nombre avec 2 chiffre apres la virgule
                    rnd_X = (rnd.Next(Convert.ToInt32(NUD_a.Value * 100),
                        Convert.ToInt32(NUD_b.Value * 100) + 1)) / 100f;
                    rnd_Y = rnd.Next(0 * 100, Ymax * 100 + 1) / 100f;
                    ////////////////////////////////////////////////////////
                    if (rnd_Y <= Fct2GetY(rnd_X))
                    {
                        NB_PointSousCourbe++;
                    }
                }
            }
            else if (CB_Cas.SelectedIndex == 2)//si Fonction 3
            {
                Ymax = 12;
                for (int i = 0; i < 10000; i++)
                {
                    //Randomisation du nombre avec 2 chiffre apres la virgule
                    rnd_X = (rnd.Next(Convert.ToInt32(NUD_a.Value * 100),
                        Convert.ToInt32(NUD_b.Value * 100) + 1)) / 100f;
                    rnd_Y = rnd.Next(0 * 100, Ymax * 100 + 1) / 100f;
                    ////////////////////////////////////////////////////////
                    if (rnd_Y <= Fct3GetY(rnd_X))
                    {
                        NB_PointSousCourbe++;
                    }
                }
            }
            else if (CB_Cas.SelectedIndex == 3)//si Fonction 4
            {
                Ymax = 10;
                for (int i = 0; i < 10000; i++)
                {
                    //Randomisation du nombre avec 2 chiffre apres la virgule
                    rnd_X = (rnd.Next(Convert.ToInt32(NUD_a.Value * 100),
                        Convert.ToInt32(NUD_b.Value * 100) + 1)) / 100f;
                    rnd_Y = rnd.Next(0 * 100, Ymax * 100 + 1) / 100f;
                    ////////////////////////////////////////////////////////
                    if (rnd_Y <= Fct4GetY(rnd_X))
                    {
                        NB_PointSousCourbe++;
                    }
                }
            }
            else if (CB_Cas.SelectedIndex == 4)//si Fonction 5
            {
                Ymax = 4;
                for (int i = 0; i < 10000; i++)
                {
                    //Randomisation du nombre avec 2 chiffre apres la virgule
                    rnd_X = (rnd.Next(Convert.ToInt32(NUD_a.Value * 100),
                        Convert.ToInt32(NUD_b.Value * 100) + 1)) / 100f;
                    rnd_Y = rnd.Next(0 * 100, Ymax * 100 + 1) / 100f;
                    ////////////////////////////////////////////////////////
                    if (rnd_Y <= Fct5GetY(rnd_X))
                    {
                        NB_PointSousCourbe++;
                    }
                }
            }
            int B = Ymax * Convert.ToInt32(NUD_b.Value - NUD_a.Value);
            double A = Math.Round(B * NB_PointSousCourbe / 10000f,4);
            pie = A / B;
            double ME = Math.Round(1.96 * SquareRoot((pie * (1f - pie)) / 10000), 4);
            double MEu = (A * ME*100) / ((A / B) * 100);
            TB_RepEstimateurPonc.Text = ((A/B)*100).ToString()+"%";
            TB_RepME.Text = "± "+(ME*100).ToString()+"%";
            TB_RepIntervalConfiance.Text = "[" + ((pie - ME) * 100).ToString() + "% ;" + ((pie + ME) * 100).ToString() + "%]";
            //////////////////////////////
            TB_RepAireSousCourbe.Text = A.ToString();
            TB_RepME_ASC.Text = "± " + (MEu).ToString();
            TB_RepIntervalle_ASC.Text = "[" + (A - MEu).ToString() + " ;" + (A + MEu).ToString()+"]";
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
            return 4f-(CubicRoot((x-9)*(x-7)));
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
            if (x < 0)
            {
                return 0-(Math.Pow((-1*x), 1f / 3f));
            }
            else
            {
                return Math.Pow(x, 1f / 3f);
            }            
        }
        private double SquareRoot(double x)
        {
            if (x < 0)
            {
                return 0 - (Math.Pow((-1 * x), 1f / 2f));
            }
            else
            {
                return Math.Pow(x, 1f / 2f);
            }
        }
    }
}
