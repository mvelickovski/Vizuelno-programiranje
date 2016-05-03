namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbListaProdukti = new System.Windows.Forms.ListBox();
            this.btnIsprazniListaProdukti = new System.Windows.Forms.Button();
            this.lbKosnicka = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCenaProdukt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKategorijaProdukt = new System.Windows.Forms.TextBox();
            this.tbImeProdukt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodadiVoKosnicka = new System.Windows.Forms.Button();
            this.btnIzbrisiOdKosnicka = new System.Windows.Forms.Button();
            this.btnDodadiNovProdukt = new System.Windows.Forms.Button();
            this.btnIzbrisiProdukt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVkupnoSuma = new System.Windows.Forms.TextBox();
            this.btnIsprazniKosnicka = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на продукти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кошничка";
            // 
            // lbListaProdukti
            // 
            this.lbListaProdukti.FormattingEnabled = true;
            this.lbListaProdukti.Location = new System.Drawing.Point(13, 30);
            this.lbListaProdukti.Name = "lbListaProdukti";
            this.lbListaProdukti.Size = new System.Drawing.Size(210, 316);
            this.lbListaProdukti.TabIndex = 2;
            this.lbListaProdukti.SelectedIndexChanged += new System.EventHandler(this.listaProduktiChange);
            // 
            // btnIsprazniListaProdukti
            // 
            this.btnIsprazniListaProdukti.Location = new System.Drawing.Point(13, 352);
            this.btnIsprazniListaProdukti.Name = "btnIsprazniListaProdukti";
            this.btnIsprazniListaProdukti.Size = new System.Drawing.Size(210, 23);
            this.btnIsprazniListaProdukti.TabIndex = 3;
            this.btnIsprazniListaProdukti.Text = "Испразни ја листата со продукти?";
            this.btnIsprazniListaProdukti.UseVisualStyleBackColor = true;
            this.btnIsprazniListaProdukti.Click += new System.EventHandler(this.btnIsprazniListaProdukti_Click);
            // 
            // lbKosnicka
            // 
            this.lbKosnicka.FormattingEnabled = true;
            this.lbKosnicka.Location = new System.Drawing.Point(457, 30);
            this.lbKosnicka.Name = "lbKosnicka";
            this.lbKosnicka.Size = new System.Drawing.Size(210, 277);
            this.lbKosnicka.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCenaProdukt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbKategorijaProdukt);
            this.groupBox1.Controls.Add(this.tbImeProdukt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(230, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // tbCenaProdukt
            // 
            this.tbCenaProdukt.Enabled = false;
            this.tbCenaProdukt.Location = new System.Drawing.Point(6, 129);
            this.tbCenaProdukt.Name = "tbCenaProdukt";
            this.tbCenaProdukt.Size = new System.Drawing.Size(100, 20);
            this.tbCenaProdukt.TabIndex = 13;
            this.tbCenaProdukt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена:";
            // 
            // tbKategorijaProdukt
            // 
            this.tbKategorijaProdukt.Enabled = false;
            this.tbKategorijaProdukt.Location = new System.Drawing.Point(6, 80);
            this.tbKategorijaProdukt.Name = "tbKategorijaProdukt";
            this.tbKategorijaProdukt.Size = new System.Drawing.Size(208, 20);
            this.tbKategorijaProdukt.TabIndex = 12;
            // 
            // tbImeProdukt
            // 
            this.tbImeProdukt.Enabled = false;
            this.tbImeProdukt.Location = new System.Drawing.Point(6, 32);
            this.tbImeProdukt.Name = "tbImeProdukt";
            this.tbImeProdukt.Size = new System.Drawing.Size(208, 20);
            this.tbImeProdukt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Категорија";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Име";
            // 
            // btnDodadiVoKosnicka
            // 
            this.btnDodadiVoKosnicka.Location = new System.Drawing.Point(230, 204);
            this.btnDodadiVoKosnicka.Name = "btnDodadiVoKosnicka";
            this.btnDodadiVoKosnicka.Size = new System.Drawing.Size(221, 23);
            this.btnDodadiVoKosnicka.TabIndex = 6;
            this.btnDodadiVoKosnicka.Text = "Додади во кошничка >>";
            this.btnDodadiVoKosnicka.UseVisualStyleBackColor = true;
            this.btnDodadiVoKosnicka.Click += new System.EventHandler(this.btnDodadiVoKosnicka_Click);
            // 
            // btnIzbrisiOdKosnicka
            // 
            this.btnIzbrisiOdKosnicka.Location = new System.Drawing.Point(230, 241);
            this.btnIzbrisiOdKosnicka.Name = "btnIzbrisiOdKosnicka";
            this.btnIzbrisiOdKosnicka.Size = new System.Drawing.Size(221, 23);
            this.btnIzbrisiOdKosnicka.TabIndex = 7;
            this.btnIzbrisiOdKosnicka.Text = "Избриши од кошничка";
            this.btnIzbrisiOdKosnicka.UseVisualStyleBackColor = true;
            this.btnIzbrisiOdKosnicka.Click += new System.EventHandler(this.btnIzbrisiOdKosnicka_Click);
            // 
            // btnDodadiNovProdukt
            // 
            this.btnDodadiNovProdukt.Location = new System.Drawing.Point(230, 278);
            this.btnDodadiNovProdukt.Name = "btnDodadiNovProdukt";
            this.btnDodadiNovProdukt.Size = new System.Drawing.Size(221, 23);
            this.btnDodadiNovProdukt.TabIndex = 8;
            this.btnDodadiNovProdukt.Text = "Додади нов продукт";
            this.btnDodadiNovProdukt.UseVisualStyleBackColor = true;
            this.btnDodadiNovProdukt.Click += new System.EventHandler(this.btnDodadiNovProdukt_Click);
            // 
            // btnIzbrisiProdukt
            // 
            this.btnIzbrisiProdukt.Location = new System.Drawing.Point(230, 315);
            this.btnIzbrisiProdukt.Name = "btnIzbrisiProdukt";
            this.btnIzbrisiProdukt.Size = new System.Drawing.Size(221, 23);
            this.btnIzbrisiProdukt.TabIndex = 9;
            this.btnIzbrisiProdukt.Text = "Избриши продукт";
            this.btnIzbrisiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrisiProdukt.Click += new System.EventHandler(this.btnIzbrisiProdukt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Вкупно:";
            // 
            // tbVkupnoSuma
            // 
            this.tbVkupnoSuma.Enabled = false;
            this.tbVkupnoSuma.Location = new System.Drawing.Point(510, 319);
            this.tbVkupnoSuma.Name = "tbVkupnoSuma";
            this.tbVkupnoSuma.Size = new System.Drawing.Size(157, 20);
            this.tbVkupnoSuma.TabIndex = 11;
            this.tbVkupnoSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIsprazniKosnicka
            // 
            this.btnIsprazniKosnicka.Location = new System.Drawing.Point(457, 352);
            this.btnIsprazniKosnicka.Name = "btnIsprazniKosnicka";
            this.btnIsprazniKosnicka.Size = new System.Drawing.Size(210, 23);
            this.btnIsprazniKosnicka.TabIndex = 12;
            this.btnIsprazniKosnicka.Text = "Испразни ја кошничката?";
            this.btnIsprazniKosnicka.UseVisualStyleBackColor = true;
            this.btnIsprazniKosnicka.Click += new System.EventHandler(this.btnIsprazniKosnicka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 387);
            this.Controls.Add(this.btnIsprazniKosnicka);
            this.Controls.Add(this.tbVkupnoSuma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIzbrisiProdukt);
            this.Controls.Add(this.btnDodadiNovProdukt);
            this.Controls.Add(this.btnIzbrisiOdKosnicka);
            this.Controls.Add(this.btnDodadiVoKosnicka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKosnicka);
            this.Controls.Add(this.btnIsprazniListaProdukti);
            this.Controls.Add(this.lbListaProdukti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbListaProdukti;
        private System.Windows.Forms.Button btnIsprazniListaProdukti;
        private System.Windows.Forms.ListBox lbKosnicka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCenaProdukt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKategorijaProdukt;
        private System.Windows.Forms.TextBox tbImeProdukt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodadiVoKosnicka;
        private System.Windows.Forms.Button btnIzbrisiOdKosnicka;
        private System.Windows.Forms.Button btnDodadiNovProdukt;
        private System.Windows.Forms.Button btnIzbrisiProdukt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVkupnoSuma;
        private System.Windows.Forms.Button btnIsprazniKosnicka;
    }
}

