
namespace PileWinformLibrary
{
    partial class FrmConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.mskNbAConvertir = new System.Windows.Forms.MaskedTextBox();
            this.nudNouvelleBase = new System.Windows.Forms.NumericUpDown();
            this.btnConversion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNouvelleBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre à convertir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nouvelle base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Résultat";
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(328, 334);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 20);
            this.txtResultat.TabIndex = 3;
            // 
            // mskNbAConvertir
            // 
            this.mskNbAConvertir.Location = new System.Drawing.Point(174, 98);
            this.mskNbAConvertir.Mask = "9999999";
            this.mskNbAConvertir.Name = "mskNbAConvertir";
            this.mskNbAConvertir.Size = new System.Drawing.Size(114, 20);
            this.mskNbAConvertir.TabIndex = 4;
            // 
            // nudNouvelleBase
            // 
            this.nudNouvelleBase.Location = new System.Drawing.Point(467, 98);
            this.nudNouvelleBase.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudNouvelleBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNouvelleBase.Name = "nudNouvelleBase";
            this.nudNouvelleBase.Size = new System.Drawing.Size(120, 20);
            this.nudNouvelleBase.TabIndex = 5;
            this.nudNouvelleBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(306, 193);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(155, 60);
            this.btnConversion.TabIndex = 6;
            this.btnConversion.Text = "Convertir";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // FrmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.nudNouvelleBase);
            this.Controls.Add(this.mskNbAConvertir);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConversion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmConversion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNouvelleBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.MaskedTextBox mskNbAConvertir;
        private System.Windows.Forms.NumericUpDown nudNouvelleBase;
        private System.Windows.Forms.Button btnConversion;
    }
}

