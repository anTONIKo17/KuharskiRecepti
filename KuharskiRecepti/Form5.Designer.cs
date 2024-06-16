namespace KuharskiRecepti
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.labelNazivR = new System.Windows.Forms.Label();
            this.textBoxNazivR = new System.Windows.Forms.TextBox();
            this.labelBrojSastojaka = new System.Windows.Forms.Label();
            this.maskedTextBoxBroj = new System.Windows.Forms.MaskedTextBox();
            this.labelUnos = new System.Windows.Forms.Label();
            this.labelVrijeme = new System.Windows.Forms.Label();
            this.buttonSastojci = new System.Windows.Forms.Button();
            this.groupBoxUnosSastojaka = new System.Windows.Forms.GroupBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.comboBoxKolicina = new System.Windows.Forms.ComboBox();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.textBoxSastojak = new System.Windows.Forms.TextBox();
            this.labelSastojak = new System.Windows.Forms.Label();
            this.buttonSpremiSastojak = new System.Windows.Forms.Button();
            this.checkBoxPosljednji = new System.Windows.Forms.CheckBox();
            this.buttonOpis = new System.Windows.Forms.Button();
            this.textBoxOpisPostupka = new System.Windows.Forms.TextBox();
            this.groupBoxOpisPostupka = new System.Windows.Forms.GroupBox();
            this.buttonSpremiPostupak = new System.Windows.Forms.Button();
            this.buttonZatvori5 = new System.Windows.Forms.Button();
            this.buttonSpremiOsnovno = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.labelKorisnicko = new System.Windows.Forms.Label();
            this.textBoxKorisIme = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxUnosSastojaka.SuspendLayout();
            this.groupBoxOpisPostupka.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNazivR
            // 
            this.labelNazivR.AutoSize = true;
            this.labelNazivR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivR.Location = new System.Drawing.Point(18, 230);
            this.labelNazivR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNazivR.Name = "labelNazivR";
            this.labelNazivR.Size = new System.Drawing.Size(165, 29);
            this.labelNazivR.TabIndex = 0;
            this.labelNazivR.Text = "Naziv recepta:";
            // 
            // textBoxNazivR
            // 
            this.textBoxNazivR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazivR.Location = new System.Drawing.Point(225, 231);
            this.textBoxNazivR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNazivR.Name = "textBoxNazivR";
            this.textBoxNazivR.Size = new System.Drawing.Size(205, 29);
            this.textBoxNazivR.TabIndex = 1;
            // 
            // labelBrojSastojaka
            // 
            this.labelBrojSastojaka.AutoSize = true;
            this.labelBrojSastojaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrojSastojaka.Location = new System.Drawing.Point(19, 278);
            this.labelBrojSastojaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrojSastojaka.Name = "labelBrojSastojaka";
            this.labelBrojSastojaka.Size = new System.Drawing.Size(129, 24);
            this.labelBrojSastojaka.TabIndex = 2;
            this.labelBrojSastojaka.Text = "Broj sastojaka:";
            // 
            // maskedTextBoxBroj
            // 
            this.maskedTextBoxBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxBroj.Location = new System.Drawing.Point(191, 275);
            this.maskedTextBoxBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxBroj.Mask = "00";
            this.maskedTextBoxBroj.Name = "maskedTextBoxBroj";
            this.maskedTextBoxBroj.Size = new System.Drawing.Size(29, 29);
            this.maskedTextBoxBroj.TabIndex = 3;
            // 
            // labelUnos
            // 
            this.labelUnos.AutoSize = true;
            this.labelUnos.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnos.Location = new System.Drawing.Point(404, 27);
            this.labelUnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnos.Name = "labelUnos";
            this.labelUnos.Size = new System.Drawing.Size(391, 147);
            this.labelUnos.TabIndex = 4;
            this.labelUnos.Text = "Unos recepta";
            // 
            // labelVrijeme
            // 
            this.labelVrijeme.AutoSize = true;
            this.labelVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrijeme.Location = new System.Drawing.Point(18, 329);
            this.labelVrijeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVrijeme.Name = "labelVrijeme";
            this.labelVrijeme.Size = new System.Drawing.Size(161, 24);
            this.labelVrijeme.TabIndex = 5;
            this.labelVrijeme.Text = "Vrijeme pripreme:";
            // 
            // buttonSastojci
            // 
            this.buttonSastojci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSastojci.Location = new System.Drawing.Point(496, 223);
            this.buttonSastojci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSastojci.Name = "buttonSastojci";
            this.buttonSastojci.Size = new System.Drawing.Size(153, 47);
            this.buttonSastojci.TabIndex = 11;
            this.buttonSastojci.Text = "Unesi sastojke";
            this.buttonSastojci.UseVisualStyleBackColor = true;
            this.buttonSastojci.Click += new System.EventHandler(this.buttonSastojci_Click);
            // 
            // groupBoxUnosSastojaka
            // 
            this.groupBoxUnosSastojaka.Controls.Add(this.textBoxKolicina);
            this.groupBoxUnosSastojaka.Controls.Add(this.comboBoxKolicina);
            this.groupBoxUnosSastojaka.Controls.Add(this.labelKolicina);
            this.groupBoxUnosSastojaka.Controls.Add(this.textBoxSastojak);
            this.groupBoxUnosSastojaka.Controls.Add(this.labelSastojak);
            this.groupBoxUnosSastojaka.Controls.Add(this.buttonSpremiSastojak);
            this.groupBoxUnosSastojaka.Controls.Add(this.checkBoxPosljednji);
            this.groupBoxUnosSastojaka.Location = new System.Drawing.Point(399, 293);
            this.groupBoxUnosSastojaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUnosSastojaka.Name = "groupBoxUnosSastojaka";
            this.groupBoxUnosSastojaka.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUnosSastojaka.Size = new System.Drawing.Size(380, 293);
            this.groupBoxUnosSastojaka.TabIndex = 12;
            this.groupBoxUnosSastojaka.TabStop = false;
            this.groupBoxUnosSastojaka.Text = "Unos sastojaka";
            this.groupBoxUnosSastojaka.Visible = false;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKolicina.Location = new System.Drawing.Point(20, 149);
            this.textBoxKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(132, 29);
            this.textBoxKolicina.TabIndex = 7;
            // 
            // comboBoxKolicina
            // 
            this.comboBoxKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKolicina.FormattingEnabled = true;
            this.comboBoxKolicina.Items.AddRange(new object[] {
            "kg",
            "dag",
            "g",
            "L",
            "dL",
            "mL",
            "žlica",
            "žličica",
            "čaša",
            "prstohvat",
            "/"});
            this.comboBoxKolicina.Location = new System.Drawing.Point(184, 149);
            this.comboBoxKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKolicina.Name = "comboBoxKolicina";
            this.comboBoxKolicina.Size = new System.Drawing.Size(160, 32);
            this.comboBoxKolicina.TabIndex = 6;
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKolicina.Location = new System.Drawing.Point(133, 95);
            this.labelKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(81, 24);
            this.labelKolicina.TabIndex = 5;
            this.labelKolicina.Text = "Količina:";
            // 
            // textBoxSastojak
            // 
            this.textBoxSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSastojak.Location = new System.Drawing.Point(117, 36);
            this.textBoxSastojak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSastojak.Name = "textBoxSastojak";
            this.textBoxSastojak.Size = new System.Drawing.Size(132, 29);
            this.textBoxSastojak.TabIndex = 4;
            // 
            // labelSastojak
            // 
            this.labelSastojak.AutoSize = true;
            this.labelSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSastojak.Location = new System.Drawing.Point(16, 39);
            this.labelSastojak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSastojak.Name = "labelSastojak";
            this.labelSastojak.Size = new System.Drawing.Size(84, 24);
            this.labelSastojak.TabIndex = 3;
            this.labelSastojak.Text = "Sastojak:";
            // 
            // buttonSpremiSastojak
            // 
            this.buttonSpremiSastojak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpremiSastojak.Location = new System.Drawing.Point(97, 251);
            this.buttonSpremiSastojak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSpremiSastojak.Name = "buttonSpremiSastojak";
            this.buttonSpremiSastojak.Size = new System.Drawing.Size(149, 28);
            this.buttonSpremiSastojak.TabIndex = 1;
            this.buttonSpremiSastojak.Text = "Spremi sastojak";
            this.buttonSpremiSastojak.UseVisualStyleBackColor = true;
            this.buttonSpremiSastojak.Click += new System.EventHandler(this.buttonSpremiSastojak_Click);
            // 
            // checkBoxPosljednji
            // 
            this.checkBoxPosljednji.AutoSize = true;
            this.checkBoxPosljednji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPosljednji.Location = new System.Drawing.Point(20, 220);
            this.checkBoxPosljednji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPosljednji.Name = "checkBoxPosljednji";
            this.checkBoxPosljednji.Size = new System.Drawing.Size(206, 22);
            this.checkBoxPosljednji.TabIndex = 0;
            this.checkBoxPosljednji.Text = "Unesen posljednji sastojak";
            this.checkBoxPosljednji.UseVisualStyleBackColor = true;
            // 
            // buttonOpis
            // 
            this.buttonOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpis.Location = new System.Drawing.Point(865, 230);
            this.buttonOpis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpis.Name = "buttonOpis";
            this.buttonOpis.Size = new System.Drawing.Size(205, 39);
            this.buttonOpis.TabIndex = 13;
            this.buttonOpis.Text = "Unesi opis postupka";
            this.buttonOpis.UseVisualStyleBackColor = true;
            this.buttonOpis.Click += new System.EventHandler(this.buttonOpis_Click);
            // 
            // textBoxOpisPostupka
            // 
            this.textBoxOpisPostupka.Location = new System.Drawing.Point(11, 23);
            this.textBoxOpisPostupka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOpisPostupka.Multiline = true;
            this.textBoxOpisPostupka.Name = "textBoxOpisPostupka";
            this.textBoxOpisPostupka.Size = new System.Drawing.Size(283, 197);
            this.textBoxOpisPostupka.TabIndex = 14;
            // 
            // groupBoxOpisPostupka
            // 
            this.groupBoxOpisPostupka.Controls.Add(this.buttonSpremiPostupak);
            this.groupBoxOpisPostupka.Controls.Add(this.textBoxOpisPostupka);
            this.groupBoxOpisPostupka.Location = new System.Drawing.Point(832, 293);
            this.groupBoxOpisPostupka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOpisPostupka.Name = "groupBoxOpisPostupka";
            this.groupBoxOpisPostupka.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOpisPostupka.Size = new System.Drawing.Size(303, 262);
            this.groupBoxOpisPostupka.TabIndex = 16;
            this.groupBoxOpisPostupka.TabStop = false;
            this.groupBoxOpisPostupka.Text = "Opis postupka";
            this.groupBoxOpisPostupka.Visible = false;
            // 
            // buttonSpremiPostupak
            // 
            this.buttonSpremiPostupak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpremiPostupak.Location = new System.Drawing.Point(33, 226);
            this.buttonSpremiPostupak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSpremiPostupak.Name = "buttonSpremiPostupak";
            this.buttonSpremiPostupak.Size = new System.Drawing.Size(153, 28);
            this.buttonSpremiPostupak.TabIndex = 15;
            this.buttonSpremiPostupak.Text = "Spremi postupak";
            this.buttonSpremiPostupak.UseVisualStyleBackColor = true;
            this.buttonSpremiPostupak.Click += new System.EventHandler(this.buttonSpremiPostupak_Click);
            // 
            // buttonZatvori5
            // 
            this.buttonZatvori5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvori5.Location = new System.Drawing.Point(1032, 570);
            this.buttonZatvori5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZatvori5.Name = "buttonZatvori5";
            this.buttonZatvori5.Size = new System.Drawing.Size(95, 32);
            this.buttonZatvori5.TabIndex = 18;
            this.buttonZatvori5.Text = "Zatvori";
            this.buttonZatvori5.UseVisualStyleBackColor = true;
            this.buttonZatvori5.Click += new System.EventHandler(this.buttonZatvori5_Click);
            // 
            // buttonSpremiOsnovno
            // 
            this.buttonSpremiOsnovno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpremiOsnovno.Location = new System.Drawing.Point(16, 558);
            this.buttonSpremiOsnovno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSpremiOsnovno.Name = "buttonSpremiOsnovno";
            this.buttonSpremiOsnovno.Size = new System.Drawing.Size(167, 44);
            this.buttonSpremiOsnovno.TabIndex = 19;
            this.buttonSpremiOsnovno.Text = "Spremi osnovno";
            this.buttonSpremiOsnovno.UseVisualStyleBackColor = true;
            this.buttonSpremiOsnovno.Click += new System.EventHandler(this.buttonSpremiOsnovno_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(191, 329);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 28);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "<30 min";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(191, 383);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 28);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30 min - 1 h";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(191, 431);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 28);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1 h - 1:30 h";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(191, 476);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(124, 28);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1:30 h - 2 h";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(191, 519);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 28);
            this.radioButton5.TabIndex = 24;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = ">2 h";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // labelKorisnicko
            // 
            this.labelKorisnicko.AutoSize = true;
            this.labelKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorisnicko.Location = new System.Drawing.Point(19, 27);
            this.labelKorisnicko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKorisnicko.Name = "labelKorisnicko";
            this.labelKorisnicko.Size = new System.Drawing.Size(237, 24);
            this.labelKorisnicko.TabIndex = 25;
            this.labelKorisnicko.Text = "Unesi svoje korisničko ime:";
            // 
            // textBoxKorisIme
            // 
            this.textBoxKorisIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKorisIme.Location = new System.Drawing.Point(23, 80);
            this.textBoxKorisIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKorisIme.Name = "textBoxKorisIme";
            this.textBoxKorisIme.Size = new System.Drawing.Size(248, 29);
            this.textBoxKorisIme.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 617);
            this.Controls.Add(this.textBoxKorisIme);
            this.Controls.Add(this.labelKorisnicko);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonSpremiOsnovno);
            this.Controls.Add(this.buttonZatvori5);
            this.Controls.Add(this.groupBoxOpisPostupka);
            this.Controls.Add(this.buttonOpis);
            this.Controls.Add(this.groupBoxUnosSastojaka);
            this.Controls.Add(this.buttonSastojci);
            this.Controls.Add(this.labelVrijeme);
            this.Controls.Add(this.labelUnos);
            this.Controls.Add(this.maskedTextBoxBroj);
            this.Controls.Add(this.labelBrojSastojaka);
            this.Controls.Add(this.textBoxNazivR);
            this.Controls.Add(this.labelNazivR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBoxUnosSastojaka.ResumeLayout(false);
            this.groupBoxUnosSastojaka.PerformLayout();
            this.groupBoxOpisPostupka.ResumeLayout(false);
            this.groupBoxOpisPostupka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNazivR;
        private System.Windows.Forms.TextBox textBoxNazivR;
        private System.Windows.Forms.Label labelBrojSastojaka;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBroj;
        private System.Windows.Forms.Label labelUnos;
        private System.Windows.Forms.Label labelVrijeme;
        private System.Windows.Forms.Button buttonSastojci;
        private System.Windows.Forms.GroupBox groupBoxUnosSastojaka;
        private System.Windows.Forms.Button buttonOpis;
        private System.Windows.Forms.CheckBox checkBoxPosljednji;
        private System.Windows.Forms.TextBox textBoxOpisPostupka;
        private System.Windows.Forms.Button buttonSpremiSastojak;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.ComboBox comboBoxKolicina;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.TextBox textBoxSastojak;
        private System.Windows.Forms.Label labelSastojak;
        private System.Windows.Forms.GroupBox groupBoxOpisPostupka;
        private System.Windows.Forms.Button buttonSpremiPostupak;
        private System.Windows.Forms.Button buttonZatvori5;
        private System.Windows.Forms.Button buttonSpremiOsnovno;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label labelKorisnicko;
        private System.Windows.Forms.TextBox textBoxKorisIme;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}