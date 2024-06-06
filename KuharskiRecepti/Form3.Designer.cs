namespace KuharskiRecepti
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelPrijava = new System.Windows.Forms.Label();
            this.labelPromijeniLozinku = new System.Windows.Forms.Label();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.buttonZapocniPromjenu = new System.Windows.Forms.Button();
            this.groupBoxPrijava = new System.Windows.Forms.GroupBox();
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.textBoxUpisLozinka = new System.Windows.Forms.TextBox();
            this.textBoxUpisKorisnicko = new System.Windows.Forms.TextBox();
            this.labelUpisLozinka = new System.Windows.Forms.Label();
            this.labelUpisKorisnicko = new System.Windows.Forms.Label();
            this.groupBoxPromjenaLozinke = new System.Windows.Forms.GroupBox();
            this.textBoxPromjenaKorisnicko = new System.Windows.Forms.TextBox();
            this.labelPromjenaKorisnicko = new System.Windows.Forms.Label();
            this.buttonPromijeniLozinku = new System.Windows.Forms.Button();
            this.textBoxNovaLozinka = new System.Windows.Forms.TextBox();
            this.textBoxPotvrdiNovu = new System.Windows.Forms.TextBox();
            this.textBoxSadasnjaLozinka = new System.Windows.Forms.TextBox();
            this.labelPotvrdiNovu = new System.Windows.Forms.Label();
            this.labelNovaLozinka = new System.Windows.Forms.Label();
            this.labelLozinkaUpisi = new System.Windows.Forms.Label();
            this.buttomZatvori3 = new System.Windows.Forms.Button();
            this.groupBoxPrijava.SuspendLayout();
            this.groupBoxPromjenaLozinke.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrijava
            // 
            this.labelPrijava.AutoSize = true;
            this.labelPrijava.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrijava.Location = new System.Drawing.Point(84, 30);
            this.labelPrijava.Name = "labelPrijava";
            this.labelPrijava.Size = new System.Drawing.Size(189, 118);
            this.labelPrijava.TabIndex = 0;
            this.labelPrijava.Text = "Prijava";
            this.labelPrijava.Click += new System.EventHandler(this.labelPrijava_Click);
            // 
            // labelPromijeniLozinku
            // 
            this.labelPromijeniLozinku.AutoSize = true;
            this.labelPromijeniLozinku.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPromijeniLozinku.Location = new System.Drawing.Point(431, 30);
            this.labelPromijeniLozinku.Name = "labelPromijeniLozinku";
            this.labelPromijeniLozinku.Size = new System.Drawing.Size(407, 118);
            this.labelPromijeniLozinku.TabIndex = 1;
            this.labelPromijeniLozinku.Text = "Promijeni lozinku";
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrijava.Location = new System.Drawing.Point(104, 177);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(145, 41);
            this.buttonPrijava.TabIndex = 2;
            this.buttonPrijava.Text = "Započni prijavu";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // buttonZapocniPromjenu
            // 
            this.buttonZapocniPromjenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZapocniPromjenu.Location = new System.Drawing.Point(563, 177);
            this.buttonZapocniPromjenu.Name = "buttonZapocniPromjenu";
            this.buttonZapocniPromjenu.Size = new System.Drawing.Size(141, 41);
            this.buttonZapocniPromjenu.TabIndex = 3;
            this.buttonZapocniPromjenu.Text = "Promijeni lozinku";
            this.buttonZapocniPromjenu.UseVisualStyleBackColor = true;
            this.buttonZapocniPromjenu.Click += new System.EventHandler(this.buttonZapocniPromjenu_Click);
            // 
            // groupBoxPrijava
            // 
            this.groupBoxPrijava.Controls.Add(this.buttonPrijaviSe);
            this.groupBoxPrijava.Controls.Add(this.textBoxUpisLozinka);
            this.groupBoxPrijava.Controls.Add(this.textBoxUpisKorisnicko);
            this.groupBoxPrijava.Controls.Add(this.labelUpisLozinka);
            this.groupBoxPrijava.Controls.Add(this.labelUpisKorisnicko);
            this.groupBoxPrijava.Location = new System.Drawing.Point(52, 241);
            this.groupBoxPrijava.Name = "groupBoxPrijava";
            this.groupBoxPrijava.Size = new System.Drawing.Size(287, 211);
            this.groupBoxPrijava.TabIndex = 4;
            this.groupBoxPrijava.TabStop = false;
            this.groupBoxPrijava.Text = "Podatci za prijavu";
            this.groupBoxPrijava.Visible = false;
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrijaviSe.Location = new System.Drawing.Point(79, 155);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(98, 35);
            this.buttonPrijaviSe.TabIndex = 6;
            this.buttonPrijaviSe.Text = "Prijava";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            this.buttonPrijaviSe.Click += new System.EventHandler(this.buttonPrijaviSe_Click);
            // 
            // textBoxUpisLozinka
            // 
            this.textBoxUpisLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpisLozinka.Location = new System.Drawing.Point(137, 108);
            this.textBoxUpisLozinka.Name = "textBoxUpisLozinka";
            this.textBoxUpisLozinka.Size = new System.Drawing.Size(100, 24);
            this.textBoxUpisLozinka.TabIndex = 3;
            // 
            // textBoxUpisKorisnicko
            // 
            this.textBoxUpisKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpisKorisnicko.Location = new System.Drawing.Point(137, 56);
            this.textBoxUpisKorisnicko.Name = "textBoxUpisKorisnicko";
            this.textBoxUpisKorisnicko.Size = new System.Drawing.Size(100, 24);
            this.textBoxUpisKorisnicko.TabIndex = 2;
            // 
            // labelUpisLozinka
            // 
            this.labelUpisLozinka.AutoSize = true;
            this.labelUpisLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpisLozinka.Location = new System.Drawing.Point(58, 110);
            this.labelUpisLozinka.Name = "labelUpisLozinka";
            this.labelUpisLozinka.Size = new System.Drawing.Size(64, 18);
            this.labelUpisLozinka.TabIndex = 1;
            this.labelUpisLozinka.Text = "Lozinka:";
            // 
            // labelUpisKorisnicko
            // 
            this.labelUpisKorisnicko.AutoSize = true;
            this.labelUpisKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpisKorisnicko.Location = new System.Drawing.Point(20, 55);
            this.labelUpisKorisnicko.Name = "labelUpisKorisnicko";
            this.labelUpisKorisnicko.Size = new System.Drawing.Size(111, 18);
            this.labelUpisKorisnicko.TabIndex = 0;
            this.labelUpisKorisnicko.Text = "Korisničko ime:";
            // 
            // groupBoxPromjenaLozinke
            // 
            this.groupBoxPromjenaLozinke.Controls.Add(this.textBoxPromjenaKorisnicko);
            this.groupBoxPromjenaLozinke.Controls.Add(this.labelPromjenaKorisnicko);
            this.groupBoxPromjenaLozinke.Controls.Add(this.buttonPromijeniLozinku);
            this.groupBoxPromjenaLozinke.Controls.Add(this.textBoxNovaLozinka);
            this.groupBoxPromjenaLozinke.Controls.Add(this.textBoxPotvrdiNovu);
            this.groupBoxPromjenaLozinke.Controls.Add(this.textBoxSadasnjaLozinka);
            this.groupBoxPromjenaLozinke.Controls.Add(this.labelPotvrdiNovu);
            this.groupBoxPromjenaLozinke.Controls.Add(this.labelNovaLozinka);
            this.groupBoxPromjenaLozinke.Controls.Add(this.labelLozinkaUpisi);
            this.groupBoxPromjenaLozinke.Location = new System.Drawing.Point(451, 241);
            this.groupBoxPromjenaLozinke.Name = "groupBoxPromjenaLozinke";
            this.groupBoxPromjenaLozinke.Size = new System.Drawing.Size(351, 248);
            this.groupBoxPromjenaLozinke.TabIndex = 5;
            this.groupBoxPromjenaLozinke.TabStop = false;
            this.groupBoxPromjenaLozinke.Text = "Promjena lozinke";
            this.groupBoxPromjenaLozinke.Visible = false;
            // 
            // textBoxPromjenaKorisnicko
            // 
            this.textBoxPromjenaKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromjenaKorisnicko.Location = new System.Drawing.Point(179, 34);
            this.textBoxPromjenaKorisnicko.Name = "textBoxPromjenaKorisnicko";
            this.textBoxPromjenaKorisnicko.Size = new System.Drawing.Size(100, 24);
            this.textBoxPromjenaKorisnicko.TabIndex = 8;
            // 
            // labelPromjenaKorisnicko
            // 
            this.labelPromjenaKorisnicko.AutoSize = true;
            this.labelPromjenaKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromjenaKorisnicko.Location = new System.Drawing.Point(32, 40);
            this.labelPromjenaKorisnicko.Name = "labelPromjenaKorisnicko";
            this.labelPromjenaKorisnicko.Size = new System.Drawing.Size(111, 18);
            this.labelPromjenaKorisnicko.TabIndex = 7;
            this.labelPromjenaKorisnicko.Text = "Korisničko ime:";
            // 
            // buttonPromijeniLozinku
            // 
            this.buttonPromijeniLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromijeniLozinku.Location = new System.Drawing.Point(112, 191);
            this.buttonPromijeniLozinku.Name = "buttonPromijeniLozinku";
            this.buttonPromijeniLozinku.Size = new System.Drawing.Size(110, 43);
            this.buttonPromijeniLozinku.TabIndex = 6;
            this.buttonPromijeniLozinku.Text = "Promijeni";
            this.buttonPromijeniLozinku.UseVisualStyleBackColor = true;
            this.buttonPromijeniLozinku.Click += new System.EventHandler(this.buttonPromijeniLozinku_Click);
            // 
            // textBoxNovaLozinka
            // 
            this.textBoxNovaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovaLozinka.Location = new System.Drawing.Point(179, 108);
            this.textBoxNovaLozinka.Name = "textBoxNovaLozinka";
            this.textBoxNovaLozinka.Size = new System.Drawing.Size(100, 24);
            this.textBoxNovaLozinka.TabIndex = 5;
            // 
            // textBoxPotvrdiNovu
            // 
            this.textBoxPotvrdiNovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPotvrdiNovu.Location = new System.Drawing.Point(179, 146);
            this.textBoxPotvrdiNovu.Name = "textBoxPotvrdiNovu";
            this.textBoxPotvrdiNovu.Size = new System.Drawing.Size(100, 24);
            this.textBoxPotvrdiNovu.TabIndex = 4;
            // 
            // textBoxSadasnjaLozinka
            // 
            this.textBoxSadasnjaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSadasnjaLozinka.Location = new System.Drawing.Point(179, 74);
            this.textBoxSadasnjaLozinka.Name = "textBoxSadasnjaLozinka";
            this.textBoxSadasnjaLozinka.Size = new System.Drawing.Size(100, 24);
            this.textBoxSadasnjaLozinka.TabIndex = 3;
            // 
            // labelPotvrdiNovu
            // 
            this.labelPotvrdiNovu.AutoSize = true;
            this.labelPotvrdiNovu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotvrdiNovu.Location = new System.Drawing.Point(32, 152);
            this.labelPotvrdiNovu.Name = "labelPotvrdiNovu";
            this.labelPotvrdiNovu.Size = new System.Drawing.Size(145, 18);
            this.labelPotvrdiNovu.TabIndex = 2;
            this.labelPotvrdiNovu.Text = "Potvrdi novu lozinku:";
            // 
            // labelNovaLozinka
            // 
            this.labelNovaLozinka.AutoSize = true;
            this.labelNovaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovaLozinka.Location = new System.Drawing.Point(32, 114);
            this.labelNovaLozinka.Name = "labelNovaLozinka";
            this.labelNovaLozinka.Size = new System.Drawing.Size(98, 18);
            this.labelNovaLozinka.TabIndex = 1;
            this.labelNovaLozinka.Text = "Nova lozinka:";
            // 
            // labelLozinkaUpisi
            // 
            this.labelLozinkaUpisi.AutoSize = true;
            this.labelLozinkaUpisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLozinkaUpisi.Location = new System.Drawing.Point(32, 80);
            this.labelLozinkaUpisi.Name = "labelLozinkaUpisi";
            this.labelLozinkaUpisi.Size = new System.Drawing.Size(124, 18);
            this.labelLozinkaUpisi.TabIndex = 0;
            this.labelLozinkaUpisi.Text = "Sadašnja lozinka:";
            // 
            // buttomZatvori3
            // 
            this.buttomZatvori3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttomZatvori3.Location = new System.Drawing.Point(52, 458);
            this.buttomZatvori3.Name = "buttomZatvori3";
            this.buttomZatvori3.Size = new System.Drawing.Size(109, 33);
            this.buttomZatvori3.TabIndex = 6;
            this.buttomZatvori3.Text = "Zatvori";
            this.buttomZatvori3.UseVisualStyleBackColor = true;
            this.buttomZatvori3.Click += new System.EventHandler(this.buttomZatvori3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.buttomZatvori3);
            this.Controls.Add(this.groupBoxPromjenaLozinke);
            this.Controls.Add(this.groupBoxPrijava);
            this.Controls.Add(this.buttonZapocniPromjenu);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.labelPromijeniLozinku);
            this.Controls.Add(this.labelPrijava);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBoxPrijava.ResumeLayout(false);
            this.groupBoxPrijava.PerformLayout();
            this.groupBoxPromjenaLozinke.ResumeLayout(false);
            this.groupBoxPromjenaLozinke.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrijava;
        private System.Windows.Forms.Label labelPromijeniLozinku;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button buttonZapocniPromjenu;
        private System.Windows.Forms.GroupBox groupBoxPrijava;
        private System.Windows.Forms.GroupBox groupBoxPromjenaLozinke;
        private System.Windows.Forms.TextBox textBoxUpisLozinka;
        private System.Windows.Forms.TextBox textBoxUpisKorisnicko;
        private System.Windows.Forms.Label labelUpisLozinka;
        private System.Windows.Forms.Label labelUpisKorisnicko;
        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.Button buttomZatvori3;
        private System.Windows.Forms.Button buttonPromijeniLozinku;
        private System.Windows.Forms.TextBox textBoxNovaLozinka;
        private System.Windows.Forms.TextBox textBoxPotvrdiNovu;
        private System.Windows.Forms.TextBox textBoxSadasnjaLozinka;
        private System.Windows.Forms.Label labelPotvrdiNovu;
        private System.Windows.Forms.Label labelNovaLozinka;
        private System.Windows.Forms.Label labelLozinkaUpisi;
        private System.Windows.Forms.TextBox textBoxPromjenaKorisnicko;
        private System.Windows.Forms.Label labelPromjenaKorisnicko;
    }
}