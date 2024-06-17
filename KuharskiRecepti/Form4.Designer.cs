namespace KuharskiRecepti
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.buttonZatvori4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.buttonMoji = new System.Windows.Forms.Button();
            this.buttonGenerirajRecept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonZatvori4
            // 
            this.buttonZatvori4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvori4.Location = new System.Drawing.Point(69, 564);
            this.buttonZatvori4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZatvori4.Name = "buttonZatvori4";
            this.buttonZatvori4.Size = new System.Drawing.Size(145, 41);
            this.buttonZatvori4.TabIndex = 16;
            this.buttonZatvori4.Text = "Zatvori";
            this.buttonZatvori4.UseVisualStyleBackColor = true;
            this.buttonZatvori4.Click += new System.EventHandler(this.buttonZatvori4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 50F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(260, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 155);
            this.label1.TabIndex = 17;
            this.label1.Text = "Moji kuharski recepti";
            // 
            // buttonUnos
            // 
            this.buttonUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonUnos.Location = new System.Drawing.Point(627, 350);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(172, 39);
            this.buttonUnos.TabIndex = 18;
            this.buttonUnos.Text = "Unos recepata";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click_1);
            // 
            // buttonMoji
            // 
            this.buttonMoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonMoji.Location = new System.Drawing.Point(395, 350);
            this.buttonMoji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoji.Name = "buttonMoji";
            this.buttonMoji.Size = new System.Drawing.Size(160, 39);
            this.buttonMoji.TabIndex = 19;
            this.buttonMoji.Text = "Moji recepti";
            this.buttonMoji.UseVisualStyleBackColor = true;
            this.buttonMoji.Click += new System.EventHandler(this.buttonMoji_Click);
            // 
            // buttonGenerirajRecept
            // 
            this.buttonGenerirajRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGenerirajRecept.Location = new System.Drawing.Point(512, 414);
            this.buttonGenerirajRecept.Name = "buttonGenerirajRecept";
            this.buttonGenerirajRecept.Size = new System.Drawing.Size(159, 41);
            this.buttonGenerirajRecept.TabIndex = 20;
            this.buttonGenerirajRecept.Text = "Generiraj recept";
            this.buttonGenerirajRecept.UseVisualStyleBackColor = true;
            this.buttonGenerirajRecept.Click += new System.EventHandler(this.buttonGenerirajRecept_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1179, 617);
            this.Controls.Add(this.buttonGenerirajRecept);
            this.Controls.Add(this.buttonMoji);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZatvori4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZatvori4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Button buttonMoji;
        private System.Windows.Forms.Button buttonGenerirajRecept;
    }
}