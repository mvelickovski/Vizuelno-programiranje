namespace Lab4
{
    partial class DodavanjeProdukt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbImeProduktDodavanje = new System.Windows.Forms.TextBox();
            this.tbKategorijaProduktDodavanje = new System.Windows.Forms.TextBox();
            this.tbCenaProduktDodavanje = new System.Windows.Forms.TextBox();
            this.btnDodadiProdukt = new System.Windows.Forms.Button();
            this.btnOtkaziProdukt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категорија:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // tbImeProduktDodavanje
            // 
            this.tbImeProduktDodavanje.Location = new System.Drawing.Point(13, 30);
            this.tbImeProduktDodavanje.Name = "tbImeProduktDodavanje";
            this.tbImeProduktDodavanje.Size = new System.Drawing.Size(268, 20);
            this.tbImeProduktDodavanje.TabIndex = 3;
            this.tbImeProduktDodavanje.Validating += new System.ComponentModel.CancelEventHandler(this.tbImeProduktDodavanje_Validating);
            // 
            // tbKategorijaProduktDodavanje
            // 
            this.tbKategorijaProduktDodavanje.Location = new System.Drawing.Point(12, 82);
            this.tbKategorijaProduktDodavanje.Name = "tbKategorijaProduktDodavanje";
            this.tbKategorijaProduktDodavanje.Size = new System.Drawing.Size(268, 20);
            this.tbKategorijaProduktDodavanje.TabIndex = 4;
            this.tbKategorijaProduktDodavanje.Validating += new System.ComponentModel.CancelEventHandler(this.tbKategorijaProduktDodavanje_Validating);
            // 
            // tbCenaProduktDodavanje
            // 
            this.tbCenaProduktDodavanje.Location = new System.Drawing.Point(12, 132);
            this.tbCenaProduktDodavanje.Name = "tbCenaProduktDodavanje";
            this.tbCenaProduktDodavanje.Size = new System.Drawing.Size(140, 20);
            this.tbCenaProduktDodavanje.TabIndex = 5;
            this.tbCenaProduktDodavanje.Validating += new System.ComponentModel.CancelEventHandler(this.tbCenaProduktDodavanje_Validating);
            // 
            // btnDodadiProdukt
            // 
            this.btnDodadiProdukt.Location = new System.Drawing.Point(217, 161);
            this.btnDodadiProdukt.Name = "btnDodadiProdukt";
            this.btnDodadiProdukt.Size = new System.Drawing.Size(75, 23);
            this.btnDodadiProdukt.TabIndex = 6;
            this.btnDodadiProdukt.Text = "Додади";
            this.btnDodadiProdukt.UseVisualStyleBackColor = true;
            this.btnDodadiProdukt.Click += new System.EventHandler(this.btnDodadiProdukt_Click);
            // 
            // btnOtkaziProdukt
            // 
            this.btnOtkaziProdukt.Location = new System.Drawing.Point(136, 161);
            this.btnOtkaziProdukt.Name = "btnOtkaziProdukt";
            this.btnOtkaziProdukt.Size = new System.Drawing.Size(75, 23);
            this.btnOtkaziProdukt.TabIndex = 7;
            this.btnOtkaziProdukt.Text = "Откажи";
            this.btnOtkaziProdukt.UseVisualStyleBackColor = true;
            this.btnOtkaziProdukt.Click += new System.EventHandler(this.btnOtkaziProdukt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodavanjeProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 196);
            this.Controls.Add(this.btnOtkaziProdukt);
            this.Controls.Add(this.btnDodadiProdukt);
            this.Controls.Add(this.tbCenaProduktDodavanje);
            this.Controls.Add(this.tbKategorijaProduktDodavanje);
            this.Controls.Add(this.tbImeProduktDodavanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjeProdukt";
            this.Text = "Цена:";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbImeProduktDodavanje;
        private System.Windows.Forms.TextBox tbKategorijaProduktDodavanje;
        private System.Windows.Forms.TextBox tbCenaProduktDodavanje;
        private System.Windows.Forms.Button btnDodadiProdukt;
        private System.Windows.Forms.Button btnOtkaziProdukt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}