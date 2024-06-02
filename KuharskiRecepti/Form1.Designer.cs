namespace KuharskiRecepti
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uporabaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaLozinkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrukcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oKreatorimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.buttonZatvori1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uporabaToolStripMenuItem,
            this.instrukcijeToolStripMenuItem,
            this.oAplikacijiToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uporabaToolStripMenuItem
            // 
            this.uporabaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaToolStripMenuItem,
            this.registracijaToolStripMenuItem,
            this.promjenaLozinkeToolStripMenuItem});
            this.uporabaToolStripMenuItem.Name = "uporabaToolStripMenuItem";
            this.uporabaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.uporabaToolStripMenuItem.Text = "Uporaba";
            // 
            // prijavaToolStripMenuItem
            // 
            this.prijavaToolStripMenuItem.Name = "prijavaToolStripMenuItem";
            this.prijavaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prijavaToolStripMenuItem.Text = "Prijava";
            this.prijavaToolStripMenuItem.Click += new System.EventHandler(this.prijavaToolStripMenuItem_Click);
            // 
            // registracijaToolStripMenuItem
            // 
            this.registracijaToolStripMenuItem.Name = "registracijaToolStripMenuItem";
            this.registracijaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registracijaToolStripMenuItem.Text = "Registracija";
            this.registracijaToolStripMenuItem.Click += new System.EventHandler(this.registracijaToolStripMenuItem_Click);
            // 
            // promjenaLozinkeToolStripMenuItem
            // 
            this.promjenaLozinkeToolStripMenuItem.Name = "promjenaLozinkeToolStripMenuItem";
            this.promjenaLozinkeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.promjenaLozinkeToolStripMenuItem.Text = "Promjena lozinke";
            this.promjenaLozinkeToolStripMenuItem.Click += new System.EventHandler(this.promjenaLozinkeToolStripMenuItem_Click);
            // 
            // instrukcijeToolStripMenuItem
            // 
            this.instrukcijeToolStripMenuItem.Name = "instrukcijeToolStripMenuItem";
            this.instrukcijeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.instrukcijeToolStripMenuItem.Text = "Instrukcije";
            this.instrukcijeToolStripMenuItem.Click += new System.EventHandler(this.instrukcijeToolStripMenuItem_Click);
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oKreatorimaToolStripMenuItem});
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            this.oAplikacijiToolStripMenuItem.Click += new System.EventHandler(this.oAplikacijiToolStripMenuItem_Click);
            // 
            // oKreatorimaToolStripMenuItem
            // 
            this.oKreatorimaToolStripMenuItem.Name = "oKreatorimaToolStripMenuItem";
            this.oKreatorimaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.oKreatorimaToolStripMenuItem.Text = "O kreatorima";
            this.oKreatorimaToolStripMenuItem.Click += new System.EventHandler(this.oKreatorimaToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Gabriola", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(89, 122);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(714, 176);
            this.labelNaziv.TabIndex = 2;
            this.labelNaziv.Text = "Moji kuharski recepti";
            // 
            // buttonZatvori1
            // 
            this.buttonZatvori1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvori1.Location = new System.Drawing.Point(705, 440);
            this.buttonZatvori1.Name = "buttonZatvori1";
            this.buttonZatvori1.Size = new System.Drawing.Size(98, 30);
            this.buttonZatvori1.TabIndex = 4;
            this.buttonZatvori1.Text = "Zatvori";
            this.buttonZatvori1.UseVisualStyleBackColor = true;
            this.buttonZatvori1.Click += new System.EventHandler(this.buttonZatvori1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.buttonZatvori1);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uporabaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaLozinkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instrukcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oKreatorimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button buttonZatvori1;
    }
}

