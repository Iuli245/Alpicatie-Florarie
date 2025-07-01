namespace Alpicatie_Florarie
{
    partial class ProdusControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(53, 37);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(78, 20);
            this.lblDenumire.TabIndex = 0;
            this.lblDenumire.Text = "Denumire";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(53, 147);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(78, 20);
            this.lblCategorie.TabIndex = 1;
            this.lblCategorie.Text = "Categorie";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(53, 96);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(38, 20);
            this.lblPret.TabIndex = 2;
            this.lblPret.Text = "Pret";
            // 
            // ProdusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblDenumire);
            this.Name = "ProdusControl";
            this.Size = new System.Drawing.Size(734, 485);
            this.Load += new System.EventHandler(this.ProdusControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblPret;
    }
}
