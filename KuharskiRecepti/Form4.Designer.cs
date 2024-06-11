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
            this.SuspendLayout();
            // 
            // buttonZatvori4
            // 
            this.buttonZatvori4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvori4.Location = new System.Drawing.Point(52, 458);
            this.buttonZatvori4.Name = "buttonZatvori4";
            this.buttonZatvori4.Size = new System.Drawing.Size(109, 33);
            this.buttonZatvori4.TabIndex = 16;
            this.buttonZatvori4.Text = "Zatvori";
            this.buttonZatvori4.UseVisualStyleBackColor = true;
            this.buttonZatvori4.Click += new System.EventHandler(this.buttonZatvori4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 50F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(195, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 124);
            this.label1.TabIndex = 17;
            this.label1.Text = "Moji kuharski recepti";
            // 
            // buttonUnos
            // 
            this.buttonUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonUnos.Location = new System.Drawing.Point(470, 284);
            this.buttonUnos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(129, 32);
            this.buttonUnos.TabIndex = 18;
            this.buttonUnos.Text = "Unos recepata";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click_1);
            // 
            // buttonMoji
            // 
            this.buttonMoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonMoji.Location = new System.Drawing.Point(296, 284);
            this.buttonMoji.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoji.Name = "buttonMoji";
            this.buttonMoji.Size = new System.Drawing.Size(120, 32);
            this.buttonMoji.TabIndex = 19;
            this.buttonMoji.Text = "Moji recepti";
            this.buttonMoji.UseVisualStyleBackColor = true;
            this.buttonMoji.Click += new System.EventHandler(this.buttonMoji_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.buttonMoji);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZatvori4);
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
    }
}