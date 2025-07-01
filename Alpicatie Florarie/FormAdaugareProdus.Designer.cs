namespace Alpicatie_Florarie
{
    partial class FormAdaugareProdus
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
            this.components = new System.ComponentModel.Container();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.numCantitate = new System.Windows.Forms.NumericUpDown();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaProdusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricComenziToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.livrariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionareLivrariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorRapidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareGraficProdusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragDropFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuProduse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetareCampuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaProduseDinFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numCantitate)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.contextMenuProduse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(41, 63);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(82, 20);
            this.lblDenumire.TabIndex = 0;
            this.lblDenumire.Text = "&Denumire:";
            this.lblDenumire.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(44, 101);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(82, 20);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "&Categorie:";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(44, 144);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(42, 20);
            this.lblPret.TabIndex = 4;
            this.lblPret.Text = "&Pret:";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(44, 192);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(78, 20);
            this.lblCantitate.TabIndex = 6;
            this.lblCantitate.Text = "C&antitate:";
            this.lblCantitate.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(41, 229);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(81, 20);
            this.lblDescriere.TabIndex = 8;
            this.lblDescriere.Text = "D&escriere:";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(176, 57);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(254, 26);
            this.txtDenumire.TabIndex = 1;
            this.txtDenumire.TextChanged += new System.EventHandler(this.txtDenumire_TextChanged);
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "Buchet",
            "Ghiveci",
            "Aranjament Floral",
            "Coroana Inmormantari",
            "Coronita Premiant",
            "Decoratiuni Evenimente"});
            this.cmbCategorie.Location = new System.Drawing.Point(176, 98);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(254, 28);
            this.cmbCategorie.TabIndex = 3;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(176, 141);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(254, 26);
            this.txtPret.TabIndex = 5;
            // 
            // numCantitate
            // 
            this.numCantitate.Location = new System.Drawing.Point(176, 190);
            this.numCantitate.Name = "numCantitate";
            this.numCantitate.Size = new System.Drawing.Size(254, 26);
            this.numCantitate.TabIndex = 7;
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(176, 229);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(254, 26);
            this.txtDescriere.TabIndex = 9;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(176, 285);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(172, 43);
            this.btnSalvare.TabIndex = 10;
            this.btnSalvare.Text = "&Salveaza produs";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.comenziToolStripMenuItem,
            this.livrariToolStripMenuItem,
            this.ajutorToolStripMenuItem,
            this.afisareGraficToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 33);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaProdusToolStripMenuItem,
            this.afiseazaProdusToolStripMenuItem1,
            this.iesireToolStripMenuItem1});
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // adaugaProdusToolStripMenuItem
            // 
            this.adaugaProdusToolStripMenuItem.Name = "adaugaProdusToolStripMenuItem";
            this.adaugaProdusToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.adaugaProdusToolStripMenuItem.Text = "Adauga produs";
            this.adaugaProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugaProdusToolStripMenuItem_Click);
            // 
            // afiseazaProdusToolStripMenuItem1
            // 
            this.afiseazaProdusToolStripMenuItem1.Name = "afiseazaProdusToolStripMenuItem1";
            this.afiseazaProdusToolStripMenuItem1.Size = new System.Drawing.Size(241, 34);
            this.afiseazaProdusToolStripMenuItem1.Text = "Afiseaza produs";
            this.afiseazaProdusToolStripMenuItem1.Click += new System.EventHandler(this.afiseazaProdusToolStripMenuItem1_Click);
            // 
            // iesireToolStripMenuItem1
            // 
            this.iesireToolStripMenuItem1.Name = "iesireToolStripMenuItem1";
            this.iesireToolStripMenuItem1.Size = new System.Drawing.Size(241, 34);
            this.iesireToolStripMenuItem1.Text = "Iesire";
            this.iesireToolStripMenuItem1.Click += new System.EventHandler(this.iesireToolStripMenuItem1_Click);
            // 
            // comenziToolStripMenuItem
            // 
            this.comenziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaComandaToolStripMenuItem,
            this.istoricComenziToolStripMenuItem1});
            this.comenziToolStripMenuItem.Name = "comenziToolStripMenuItem";
            this.comenziToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.comenziToolStripMenuItem.Text = "Comenzi";
            // 
            // adaugaComandaToolStripMenuItem
            // 
            this.adaugaComandaToolStripMenuItem.Name = "adaugaComandaToolStripMenuItem";
            this.adaugaComandaToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.adaugaComandaToolStripMenuItem.Text = "Adauga comanda";
            this.adaugaComandaToolStripMenuItem.Click += new System.EventHandler(this.adaugaComandaToolStripMenuItem_Click);
            // 
            // istoricComenziToolStripMenuItem1
            // 
            this.istoricComenziToolStripMenuItem1.Name = "istoricComenziToolStripMenuItem1";
            this.istoricComenziToolStripMenuItem1.Size = new System.Drawing.Size(255, 34);
            this.istoricComenziToolStripMenuItem1.Text = "Istoric comenzi";
            this.istoricComenziToolStripMenuItem1.Click += new System.EventHandler(this.istoricComenziToolStripMenuItem1_Click);
            // 
            // livrariToolStripMenuItem
            // 
            this.livrariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionareLivrariToolStripMenuItem});
            this.livrariToolStripMenuItem.Name = "livrariToolStripMenuItem";
            this.livrariToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.livrariToolStripMenuItem.Text = "Livrari";
            // 
            // gestionareLivrariToolStripMenuItem
            // 
            this.gestionareLivrariToolStripMenuItem.Name = "gestionareLivrariToolStripMenuItem";
            this.gestionareLivrariToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.gestionareLivrariToolStripMenuItem.Text = "Gestionare livrari";
            this.gestionareLivrariToolStripMenuItem.Click += new System.EventHandler(this.gestionareLivrariToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem,
            this.ajutorRapidToolStripMenuItem1});
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // ajutorRapidToolStripMenuItem1
            // 
            this.ajutorRapidToolStripMenuItem1.Name = "ajutorRapidToolStripMenuItem1";
            this.ajutorRapidToolStripMenuItem1.Size = new System.Drawing.Size(209, 34);
            this.ajutorRapidToolStripMenuItem1.Text = "Ajutor rapid";
            this.ajutorRapidToolStripMenuItem1.Click += new System.EventHandler(this.ajutorRapidToolStripMenuItem1_Click);
            // 
            // afisareGraficToolStripMenuItem
            // 
            this.afisareGraficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareGraficProdusesToolStripMenuItem,
            this.imprimareProduseToolStripMenuItem,
            this.dragDropFilesToolStripMenuItem});
            this.afisareGraficToolStripMenuItem.Name = "afisareGraficToolStripMenuItem";
            this.afisareGraficToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.afisareGraficToolStripMenuItem.Text = "Instrumente(P2)";
            this.afisareGraficToolStripMenuItem.Click += new System.EventHandler(this.afisareGraficToolStripMenuItem_Click);
            // 
            // afisareGraficProdusesToolStripMenuItem
            // 
            this.afisareGraficProdusesToolStripMenuItem.Name = "afisareGraficProdusesToolStripMenuItem";
            this.afisareGraficProdusesToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.afisareGraficProdusesToolStripMenuItem.Text = "Afisare grafic produse";
            this.afisareGraficProdusesToolStripMenuItem.Click += new System.EventHandler(this.afisareGraficProdusesToolStripMenuItem_Click);
            // 
            // imprimareProduseToolStripMenuItem
            // 
            this.imprimareProduseToolStripMenuItem.Name = "imprimareProduseToolStripMenuItem";
            this.imprimareProduseToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.imprimareProduseToolStripMenuItem.Text = "Imprimare produse";
            this.imprimareProduseToolStripMenuItem.Click += new System.EventHandler(this.imprimareProduseToolStripMenuItem_Click);
            // 
            // dragDropFilesToolStripMenuItem
            // 
            this.dragDropFilesToolStripMenuItem.Name = "dragDropFilesToolStripMenuItem";
            this.dragDropFilesToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.dragDropFilesToolStripMenuItem.Text = "Drag & Drop comenzi";
            this.dragDropFilesToolStripMenuItem.Click += new System.EventHandler(this.dragDropFilesToolStripMenuItem_Click);
            // 
            // contextMenuProduse
            // 
            this.contextMenuProduse.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuProduse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetareCampuriToolStripMenuItem,
            this.incarcaProduseDinFisierToolStripMenuItem,
            this.salveazaPToolStripMenuItem});
            this.contextMenuProduse.Name = "contextMenuProduse";
            this.contextMenuProduse.Size = new System.Drawing.Size(284, 100);
            this.contextMenuProduse.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // resetareCampuriToolStripMenuItem
            // 
            this.resetareCampuriToolStripMenuItem.Name = "resetareCampuriToolStripMenuItem";
            this.resetareCampuriToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.resetareCampuriToolStripMenuItem.Text = "Resetare campuri";
            this.resetareCampuriToolStripMenuItem.Click += new System.EventHandler(this.resetareCampuriToolStripMenuItem_Click);
            // 
            // incarcaProduseDinFisierToolStripMenuItem
            // 
            this.incarcaProduseDinFisierToolStripMenuItem.Name = "incarcaProduseDinFisierToolStripMenuItem";
            this.incarcaProduseDinFisierToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.incarcaProduseDinFisierToolStripMenuItem.Text = "Incarca produse din fisier";
            this.incarcaProduseDinFisierToolStripMenuItem.Click += new System.EventHandler(this.incarcaProduseDinFisierToolStripMenuItem_Click);
            // 
            // salveazaPToolStripMenuItem
            // 
            this.salveazaPToolStripMenuItem.Name = "salveazaPToolStripMenuItem";
            this.salveazaPToolStripMenuItem.Size = new System.Drawing.Size(283, 32);
            this.salveazaPToolStripMenuItem.Text = "Salveaza produse in fisier";
            this.salveazaPToolStripMenuItem.Click += new System.EventHandler(this.salveazaPToolStripMenuItem_Click);
            // 
            // FormAdaugareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1067, 578);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.numCantitate);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Teal;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormAdaugareProdus";
            this.Text = "FormAdaugareProdus";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.FormAdaugareProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantitate)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuProduse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.NumericUpDown numCantitate;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comenziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionareLivrariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaProdusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem istoricComenziToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajutorRapidToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuProduse;
        private System.Windows.Forms.ToolStripMenuItem resetareCampuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaProduseDinFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareGraficProdusesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dragDropFilesToolStripMenuItem;
    }
}