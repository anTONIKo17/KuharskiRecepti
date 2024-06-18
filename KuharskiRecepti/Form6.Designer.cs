namespace KuharskiRecepti
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.labelMojiRecepti = new System.Windows.Forms.Label();
            this.labelUnesiKorisnicko = new System.Windows.Forms.Label();
            this.textBoxKorisnickoMoji = new System.Windows.Forms.TextBox();
            this.listBoxMojiRecepti = new System.Windows.Forms.ListBox();
            this.labelRecepti = new System.Windows.Forms.Label();
            this.buttonZatvori6 = new System.Windows.Forms.Button();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.labelSortiraj = new System.Windows.Forms.Label();
            this.radioButtonUzlazno = new System.Windows.Forms.RadioButton();
            this.radioButtonSilazno = new System.Windows.Forms.RadioButton();
            this.groupBoxRecept = new System.Windows.Forms.GroupBox();
            this.textBoxPostupak6 = new System.Windows.Forms.TextBox();
            this.textBoxSastojci = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.buttonSortiraj = new System.Windows.Forms.Button();
            this.textBoxBrojSastojaka = new System.Windows.Forms.TextBox();
            this.textBoxVrijeme = new System.Windows.Forms.TextBox();
            this.groupBoxRecept.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMojiRecepti
            // 
            this.labelMojiRecepti.AutoSize = true;
            this.labelMojiRecepti.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMojiRecepti.Location = new System.Drawing.Point(323, 9);
            this.labelMojiRecepti.Name = "labelMojiRecepti";
            this.labelMojiRecepti.Size = new System.Drawing.Size(357, 147);
            this.labelMojiRecepti.TabIndex = 0;
            this.labelMojiRecepti.Text = "Moji recepti";
            // 
            // labelUnesiKorisnicko
            // 
            this.labelUnesiKorisnicko.AutoSize = true;
            this.labelUnesiKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUnesiKorisnicko.Location = new System.Drawing.Point(44, 31);
            this.labelUnesiKorisnicko.Name = "labelUnesiKorisnicko";
            this.labelUnesiKorisnicko.Size = new System.Drawing.Size(226, 22);
            this.labelUnesiKorisnicko.TabIndex = 1;
            this.labelUnesiKorisnicko.Text = "Unesi svoje korisničko ime:";
            // 
            // textBoxKorisnickoMoji
            // 
            this.textBoxKorisnickoMoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKorisnickoMoji.Location = new System.Drawing.Point(48, 69);
            this.textBoxKorisnickoMoji.Name = "textBoxKorisnickoMoji";
            this.textBoxKorisnickoMoji.Size = new System.Drawing.Size(100, 28);
            this.textBoxKorisnickoMoji.TabIndex = 2;
            // 
            // listBoxMojiRecepti
            // 
            this.listBoxMojiRecepti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxMojiRecepti.FormattingEnabled = true;
            this.listBoxMojiRecepti.ItemHeight = 18;
            this.listBoxMojiRecepti.Location = new System.Drawing.Point(33, 207);
            this.listBoxMojiRecepti.Name = "listBoxMojiRecepti";
            this.listBoxMojiRecepti.Size = new System.Drawing.Size(326, 364);
            this.listBoxMojiRecepti.TabIndex = 3;
            this.listBoxMojiRecepti.SelectedIndexChanged += new System.EventHandler(this.listBoxMojiRecepti_SelectedIndexChanged);
            // 
            // labelRecepti
            // 
            this.labelRecepti.AutoSize = true;
            this.labelRecepti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecepti.Location = new System.Drawing.Point(136, 156);
            this.labelRecepti.Name = "labelRecepti";
            this.labelRecepti.Size = new System.Drawing.Size(111, 32);
            this.labelRecepti.TabIndex = 4;
            this.labelRecepti.Text = "Recepti";
            // 
            // buttonZatvori6
            // 
            this.buttonZatvori6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZatvori6.Location = new System.Drawing.Point(1062, 577);
            this.buttonZatvori6.Name = "buttonZatvori6";
            this.buttonZatvori6.Size = new System.Drawing.Size(105, 39);
            this.buttonZatvori6.TabIndex = 5;
            this.buttonZatvori6.Text = "Zatvori";
            this.buttonZatvori6.UseVisualStyleBackColor = true;
            this.buttonZatvori6.Click += new System.EventHandler(this.buttonZatvori6_Click);
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPotvrdi.Location = new System.Drawing.Point(212, 66);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(105, 35);
            this.buttonPotvrdi.TabIndex = 6;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // labelSortiraj
            // 
            this.labelSortiraj.AutoSize = true;
            this.labelSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSortiraj.Location = new System.Drawing.Point(394, 207);
            this.labelSortiraj.Name = "labelSortiraj";
            this.labelSortiraj.Size = new System.Drawing.Size(72, 22);
            this.labelSortiraj.TabIndex = 7;
            this.labelSortiraj.Text = "Sortiraj:";
            // 
            // radioButtonUzlazno
            // 
            this.radioButtonUzlazno.AutoSize = true;
            this.radioButtonUzlazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonUzlazno.Location = new System.Drawing.Point(432, 252);
            this.radioButtonUzlazno.Name = "radioButtonUzlazno";
            this.radioButtonUzlazno.Size = new System.Drawing.Size(94, 26);
            this.radioButtonUzlazno.TabIndex = 8;
            this.radioButtonUzlazno.TabStop = true;
            this.radioButtonUzlazno.Text = "Uzlazno";
            this.radioButtonUzlazno.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilazno
            // 
            this.radioButtonSilazno.AutoSize = true;
            this.radioButtonSilazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSilazno.Location = new System.Drawing.Point(432, 297);
            this.radioButtonSilazno.Name = "radioButtonSilazno";
            this.radioButtonSilazno.Size = new System.Drawing.Size(89, 26);
            this.radioButtonSilazno.TabIndex = 9;
            this.radioButtonSilazno.TabStop = true;
            this.radioButtonSilazno.Text = "Silazno";
            this.radioButtonSilazno.UseVisualStyleBackColor = true;
            // 
            // groupBoxRecept
            // 
            this.groupBoxRecept.Controls.Add(this.textBoxVrijeme);
            this.groupBoxRecept.Controls.Add(this.textBoxBrojSastojaka);
            this.groupBoxRecept.Controls.Add(this.textBoxPostupak6);
            this.groupBoxRecept.Controls.Add(this.textBoxSastojci);
            this.groupBoxRecept.Controls.Add(this.textBoxNaziv);
            this.groupBoxRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRecept.Location = new System.Drawing.Point(638, 114);
            this.groupBoxRecept.Name = "groupBoxRecept";
            this.groupBoxRecept.Size = new System.Drawing.Size(529, 462);
            this.groupBoxRecept.TabIndex = 12;
            this.groupBoxRecept.TabStop = false;
            this.groupBoxRecept.Text = "Recept";
            this.groupBoxRecept.Visible = false;
            // 
            // textBoxPostupak6
            // 
            this.textBoxPostupak6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPostupak6.Location = new System.Drawing.Point(35, 268);
            this.textBoxPostupak6.Multiline = true;
            this.textBoxPostupak6.Name = "textBoxPostupak6";
            this.textBoxPostupak6.Size = new System.Drawing.Size(473, 159);
            this.textBoxPostupak6.TabIndex = 2;
            // 
            // textBoxSastojci
            // 
            this.textBoxSastojci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSastojci.Location = new System.Drawing.Point(35, 93);
            this.textBoxSastojci.Multiline = true;
            this.textBoxSastojci.Name = "textBoxSastojci";
            this.textBoxSastojci.Size = new System.Drawing.Size(473, 146);
            this.textBoxSastojci.TabIndex = 1;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNaziv.Location = new System.Drawing.Point(35, 47);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(178, 28);
            this.textBoxNaziv.TabIndex = 0;
            // 
            // buttonSortiraj
            // 
            this.buttonSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSortiraj.Location = new System.Drawing.Point(502, 197);
            this.buttonSortiraj.Name = "buttonSortiraj";
            this.buttonSortiraj.Size = new System.Drawing.Size(96, 42);
            this.buttonSortiraj.TabIndex = 15;
            this.buttonSortiraj.Text = "Sortiraj";
            this.buttonSortiraj.UseVisualStyleBackColor = true;
            this.buttonSortiraj.Click += new System.EventHandler(this.buttonSortiraj_Click);
            // 
            // textBoxBrojSastojaka
            // 
            this.textBoxBrojSastojaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBrojSastojaka.Location = new System.Drawing.Point(250, 47);
            this.textBoxBrojSastojaka.Name = "textBoxBrojSastojaka";
            this.textBoxBrojSastojaka.Size = new System.Drawing.Size(100, 28);
            this.textBoxBrojSastojaka.TabIndex = 3;
            // 
            // textBoxVrijeme
            // 
            this.textBoxVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVrijeme.Location = new System.Drawing.Point(382, 47);
            this.textBoxVrijeme.Name = "textBoxVrijeme";
            this.textBoxVrijeme.Size = new System.Drawing.Size(100, 28);
            this.textBoxVrijeme.TabIndex = 4;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 617);
            this.Controls.Add(this.buttonSortiraj);
            this.Controls.Add(this.groupBoxRecept);
            this.Controls.Add(this.radioButtonSilazno);
            this.Controls.Add(this.radioButtonUzlazno);
            this.Controls.Add(this.labelSortiraj);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.buttonZatvori6);
            this.Controls.Add(this.labelRecepti);
            this.Controls.Add(this.listBoxMojiRecepti);
            this.Controls.Add(this.textBoxKorisnickoMoji);
            this.Controls.Add(this.labelUnesiKorisnicko);
            this.Controls.Add(this.labelMojiRecepti);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBoxRecept.ResumeLayout(false);
            this.groupBoxRecept.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMojiRecepti;
        private System.Windows.Forms.Label labelUnesiKorisnicko;
        private System.Windows.Forms.TextBox textBoxKorisnickoMoji;
        private System.Windows.Forms.ListBox listBoxMojiRecepti;
        private System.Windows.Forms.Label labelRecepti;
        private System.Windows.Forms.Button buttonZatvori6;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Label labelSortiraj;
        private System.Windows.Forms.RadioButton radioButtonUzlazno;
        private System.Windows.Forms.RadioButton radioButtonSilazno;
        private System.Windows.Forms.GroupBox groupBoxRecept;
        private System.Windows.Forms.TextBox textBoxPostupak6;
        private System.Windows.Forms.TextBox textBoxSastojci;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Button buttonSortiraj;
        private System.Windows.Forms.TextBox textBoxVrijeme;
        private System.Windows.Forms.TextBox textBoxBrojSastojaka;
    }
}