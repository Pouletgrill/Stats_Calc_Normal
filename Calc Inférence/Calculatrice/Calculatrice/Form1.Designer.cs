namespace Calculatrice
{
   partial class Form1
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
            this.CB_Cas = new System.Windows.Forms.ComboBox();
            this.LB_b = new System.Windows.Forms.Label();
            this.TB_b = new System.Windows.Forms.TextBox();
            this.TB_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Moy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.TB_Rep = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Cas
            // 
            this.CB_Cas.FormattingEnabled = true;
            this.CB_Cas.Items.AddRange(new object[] {
            "P( a < X < b )",
            "P( X < a )",
            "P( X > a )"});
            this.CB_Cas.Location = new System.Drawing.Point(115, 12);
            this.CB_Cas.Name = "CB_Cas";
            this.CB_Cas.Size = new System.Drawing.Size(121, 21);
            this.CB_Cas.TabIndex = 7;
            this.CB_Cas.SelectedIndexChanged += new System.EventHandler(this.CB_Cas_SelectedIndexChanged);
            // 
            // LB_b
            // 
            this.LB_b.AutoSize = true;
            this.LB_b.Location = new System.Drawing.Point(74, 84);
            this.LB_b.Name = "LB_b";
            this.LB_b.Size = new System.Drawing.Size(19, 13);
            this.LB_b.TabIndex = 1;
            this.LB_b.Text = "b :";
            // 
            // TB_b
            // 
            this.TB_b.Location = new System.Drawing.Point(99, 81);
            this.TB_b.Name = "TB_b";
            this.TB_b.Size = new System.Drawing.Size(100, 20);
            this.TB_b.TabIndex = 4;
            this.TB_b.TextChanged += new System.EventHandler(this.Moy_ET_a_b_Text_Changed);
            this.TB_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Moy_ET_a_b_KeyPress);
            // 
            // TB_a
            // 
            this.TB_a.Location = new System.Drawing.Point(99, 55);
            this.TB_a.Name = "TB_a";
            this.TB_a.Size = new System.Drawing.Size(100, 20);
            this.TB_a.TabIndex = 3;
            this.TB_a.TextChanged += new System.EventHandler(this.Moy_ET_a_b_Text_Changed);
            this.TB_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Moy_ET_a_b_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a :";
            // 
            // TB_Moy
            // 
            this.TB_Moy.Location = new System.Drawing.Point(99, 3);
            this.TB_Moy.Name = "TB_Moy";
            this.TB_Moy.Size = new System.Drawing.Size(100, 20);
            this.TB_Moy.TabIndex = 1;
            this.TB_Moy.TextChanged += new System.EventHandler(this.Moy_ET_a_b_Text_Changed);
            this.TB_Moy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Moy_ET_a_b_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "moyenne :";
            // 
            // TB_ET
            // 
            this.TB_ET.Location = new System.Drawing.Point(99, 29);
            this.TB_ET.Name = "TB_ET";
            this.TB_ET.Size = new System.Drawing.Size(100, 20);
            this.TB_ET.TabIndex = 2;
            this.TB_ET.TextChanged += new System.EventHandler(this.Moy_ET_a_b_Text_Changed);
            this.TB_ET.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Moy_ET_a_b_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Écart type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cas de probabilité :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TB_Moy);
            this.panel1.Controls.Add(this.LB_b);
            this.panel1.Controls.Add(this.TB_ET);
            this.panel1.Controls.Add(this.TB_b);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_a);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 107);
            this.panel1.TabIndex = 10;
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Enabled = false;
            this.BTN_Calculer.Location = new System.Drawing.Point(15, 153);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(221, 23);
            this.BTN_Calculer.TabIndex = 5;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // TB_Rep
            // 
            this.TB_Rep.Location = new System.Drawing.Point(15, 183);
            this.TB_Rep.Name = "TB_Rep";
            this.TB_Rep.ReadOnly = true;
            this.TB_Rep.Size = new System.Drawing.Size(221, 20);
            this.TB_Rep.TabIndex = 6;
            this.TB_Rep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 215);
            this.Controls.Add(this.TB_Rep);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Cas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox CB_Cas;
      private System.Windows.Forms.Label LB_b;
      private System.Windows.Forms.TextBox TB_b;
      private System.Windows.Forms.TextBox TB_a;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox TB_Moy;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox TB_ET;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button BTN_Calculer;
      private System.Windows.Forms.TextBox TB_Rep;
   }
}

