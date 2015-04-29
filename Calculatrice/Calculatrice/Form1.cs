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
      public Form1()
      {
         InitializeComponent();
         CB_Cas.SelectedIndex = 0;
      }

      private void CB_Cas_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (CB_Cas.SelectedIndex == 0)
         {
            LB_b.Visible = true;
            TB_b.Visible = true;
         }
         else
         {
            LB_b.Visible = false;
            TB_b.Visible = false;
         }
      }
   }
}
