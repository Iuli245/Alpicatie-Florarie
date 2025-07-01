namespace Alpicatie_Florarie
{
    partial class FormDragDropComenzi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxProduseDisponibile = new System.Windows.Forms.ListBox();
            this.listBoxCosComanda = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxProduseDisponibile
            // 
            this.listBoxProduseDisponibile.FormattingEnabled = true;
            this.listBoxProduseDisponibile.ItemHeight = 20;
            this.listBoxProduseDisponibile.Location = new System.Drawing.Point(24, 38);
            this.listBoxProduseDisponibile.Name = "listBoxProduseDisponibile";
            this.listBoxProduseDisponibile.Size = new System.Drawing.Size(347, 384);
            this.listBoxProduseDisponibile.TabIndex = 0;
            this.listBoxProduseDisponibile.SelectedIndexChanged += new System.EventHandler(this.listBoxProduseDisponibile_SelectedIndexChanged);
            // 
            // listBoxCosComanda
            // 
            this.listBoxCosComanda.FormattingEnabled = true;
            this.listBoxCosComanda.ItemHeight = 20;
            this.listBoxCosComanda.Location = new System.Drawing.Point(423, 38);
            this.listBoxCosComanda.Name = "listBoxCosComanda";
            this.listBoxCosComanda.Size = new System.Drawing.Size(342, 384);
            this.listBoxCosComanda.TabIndex = 1;
            this.listBoxCosComanda.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // FormDragDropComenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCosComanda);
            this.Controls.Add(this.listBoxProduseDisponibile);
            this.Name = "FormDragDropComenzi";
            this.Text = "FormDragDropComenzi";
            this.Load += new System.EventHandler(this.FormDragDropComenzi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProduseDisponibile;
        private System.Windows.Forms.ListBox listBoxCosComanda;
    }
}