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
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.TB_RepEstimateurPonc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_a = new System.Windows.Forms.NumericUpDown();
            this.NUD_b = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_RepIntervalConfiance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_RepME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_RepAireSousCourbe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_RepME_ASC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_RepIntervalle_ASC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_b)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Cas
            // 
            this.CB_Cas.FormattingEnabled = true;
            this.CB_Cas.Items.AddRange(new object[] {
            "Fonction 1",
            "Fonction 2",
            "Fonction 3",
            "Fonction 4",
            "Fonction 5"});
            this.CB_Cas.Location = new System.Drawing.Point(72, 12);
            this.CB_Cas.Name = "CB_Cas";
            this.CB_Cas.Size = new System.Drawing.Size(121, 21);
            this.CB_Cas.TabIndex = 7;
            this.CB_Cas.SelectedIndexChanged += new System.EventHandler(this.CB_Cas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fonction :";
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Location = new System.Drawing.Point(12, 39);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(483, 23);
            this.BTN_Calculer.TabIndex = 5;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // TB_RepEstimateurPonc
            // 
            this.TB_RepEstimateurPonc.Location = new System.Drawing.Point(133, 15);
            this.TB_RepEstimateurPonc.Name = "TB_RepEstimateurPonc";
            this.TB_RepEstimateurPonc.ReadOnly = true;
            this.TB_RepEstimateurPonc.Size = new System.Drawing.Size(90, 20);
            this.TB_RepEstimateurPonc.TabIndex = 6;
            this.TB_RepEstimateurPonc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "a :";
            // 
            // NUD_a
            // 
            this.NUD_a.DecimalPlaces = 2;
            this.NUD_a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUD_a.Location = new System.Drawing.Point(225, 13);
            this.NUD_a.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_a.Name = "NUD_a";
            this.NUD_a.Size = new System.Drawing.Size(49, 20);
            this.NUD_a.TabIndex = 11;
            this.NUD_a.ValueChanged += new System.EventHandler(this.NUD_a_b_ValueChanged);
            // 
            // NUD_b
            // 
            this.NUD_b.DecimalPlaces = 2;
            this.NUD_b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUD_b.Location = new System.Drawing.Point(305, 13);
            this.NUD_b.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_b.Name = "NUD_b";
            this.NUD_b.Size = new System.Drawing.Size(49, 20);
            this.NUD_b.TabIndex = 13;
            this.NUD_b.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_b.ValueChanged += new System.EventHandler(this.NUD_a_b_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "b :";
            // 
            // TB_RepIntervalConfiance
            // 
            this.TB_RepIntervalConfiance.Location = new System.Drawing.Point(133, 67);
            this.TB_RepIntervalConfiance.Name = "TB_RepIntervalConfiance";
            this.TB_RepIntervalConfiance.ReadOnly = true;
            this.TB_RepIntervalConfiance.Size = new System.Drawing.Size(90, 20);
            this.TB_RepIntervalConfiance.TabIndex = 14;
            this.TB_RepIntervalConfiance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estimation ponctuel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ME :";
            // 
            // TB_RepME
            // 
            this.TB_RepME.Location = new System.Drawing.Point(133, 41);
            this.TB_RepME.Name = "TB_RepME";
            this.TB_RepME.ReadOnly = true;
            this.TB_RepME.Size = new System.Drawing.Size(90, 20);
            this.TB_RepME.TabIndex = 17;
            this.TB_RepME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Intervalle de confiance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Estimation ponctuel :";
            // 
            // TB_RepAireSousCourbe
            // 
            this.TB_RepAireSousCourbe.Location = new System.Drawing.Point(133, 15);
            this.TB_RepAireSousCourbe.Name = "TB_RepAireSousCourbe";
            this.TB_RepAireSousCourbe.ReadOnly = true;
            this.TB_RepAireSousCourbe.Size = new System.Drawing.Size(100, 20);
            this.TB_RepAireSousCourbe.TabIndex = 20;
            this.TB_RepAireSousCourbe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Intervalle de confiance :";
            // 
            // TB_RepME_ASC
            // 
            this.TB_RepME_ASC.Location = new System.Drawing.Point(133, 41);
            this.TB_RepME_ASC.Name = "TB_RepME_ASC";
            this.TB_RepME_ASC.ReadOnly = true;
            this.TB_RepME_ASC.Size = new System.Drawing.Size(100, 20);
            this.TB_RepME_ASC.TabIndex = 23;
            this.TB_RepME_ASC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ME :";
            // 
            // TB_RepIntervalle_ASC
            // 
            this.TB_RepIntervalle_ASC.Location = new System.Drawing.Point(133, 67);
            this.TB_RepIntervalle_ASC.Name = "TB_RepIntervalle_ASC";
            this.TB_RepIntervalle_ASC.ReadOnly = true;
            this.TB_RepIntervalle_ASC.Size = new System.Drawing.Size(100, 20);
            this.TB_RepIntervalle_ASC.TabIndex = 21;
            this.TB_RepIntervalle_ASC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_RepEstimateurPonc);
            this.groupBox1.Controls.Add(this.TB_RepIntervalConfiance);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TB_RepME);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 98);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proportion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TB_RepAireSousCourbe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TB_RepIntervalle_ASC);
            this.groupBox2.Controls.Add(this.TB_RepME_ASC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(253, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 98);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aire sous la courbe ( unité² )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 177);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NUD_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUD_a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Cas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_b)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox CB_Cas;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button BTN_Calculer;
      private System.Windows.Forms.TextBox TB_RepEstimateurPonc;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.NumericUpDown NUD_a;
      private System.Windows.Forms.NumericUpDown NUD_b;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox TB_RepIntervalConfiance;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox TB_RepME;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox TB_RepAireSousCourbe;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox TB_RepME_ASC;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox TB_RepIntervalle_ASC;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
   }
}

