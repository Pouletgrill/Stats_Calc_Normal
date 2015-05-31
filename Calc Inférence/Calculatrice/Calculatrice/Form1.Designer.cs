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
            this.TB_Rep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_a = new System.Windows.Forms.NumericUpDown();
            this.NUD_b = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_b)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "a :";
            // 
            // NUD_a
            // 
            this.NUD_a.Location = new System.Drawing.Point(72, 39);
            this.NUD_a.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_a.Name = "NUD_a";
            this.NUD_a.Size = new System.Drawing.Size(39, 20);
            this.NUD_a.TabIndex = 11;
            this.NUD_a.ValueChanged += new System.EventHandler(this.NUD_a_b_ValueChanged);
            // 
            // NUD_b
            // 
            this.NUD_b.Location = new System.Drawing.Point(72, 65);
            this.NUD_b.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NUD_b.Name = "NUD_b";
            this.NUD_b.Size = new System.Drawing.Size(39, 20);
            this.NUD_b.TabIndex = 13;
            this.NUD_b.ValueChanged += new System.EventHandler(this.NUD_a_b_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "b :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 215);
            this.Controls.Add(this.NUD_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUD_a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Rep);
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
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox CB_Cas;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button BTN_Calculer;
      private System.Windows.Forms.TextBox TB_Rep;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.NumericUpDown NUD_a;
      private System.Windows.Forms.NumericUpDown NUD_b;
      private System.Windows.Forms.Label label2;
   }
}

