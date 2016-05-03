namespace Lab3
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
            this.gbGolemina = new System.Windows.Forms.GroupBox();
            this.tbGolema = new System.Windows.Forms.TextBox();
            this.tbSredna = new System.Windows.Forms.TextBox();
            this.tbMala = new System.Windows.Forms.TextBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.gbDodatoci = new System.Windows.Forms.GroupBox();
            this.tbKecap = new System.Windows.Forms.TextBox();
            this.tbSirenje = new System.Windows.Forms.TextBox();
            this.tbFeferonki = new System.Windows.Forms.TextBox();
            this.cbKecap = new System.Windows.Forms.CheckBox();
            this.cbSirenje = new System.Windows.Forms.CheckBox();
            this.cbFeferonki = new System.Windows.Forms.CheckBox();
            this.gbPijalok = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVkupnoPivo = new System.Windows.Forms.TextBox();
            this.tbVkupnoPortokal = new System.Windows.Forms.TextBox();
            this.tbVkupnoSprajt = new System.Windows.Forms.TextBox();
            this.tbCenaPivo = new System.Windows.Forms.TextBox();
            this.tbCenaPortokal = new System.Windows.Forms.TextBox();
            this.tbCenaSprajt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPivo = new System.Windows.Forms.TextBox();
            this.tbPortokal = new System.Windows.Forms.TextBox();
            this.tbSprajt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDesert = new System.Windows.Forms.GroupBox();
            this.btOtkazi = new System.Windows.Forms.Button();
            this.btNaracaj = new System.Windows.Forms.Button();
            this.tbDesert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDesert = new System.Windows.Forms.ListBox();
            this.gbNaplata = new System.Windows.Forms.GroupBox();
            this.tbZaVrakjanje = new System.Windows.Forms.TextBox();
            this.tbNaplateno = new System.Windows.Forms.TextBox();
            this.tbVkupnoNaplata = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbGolemina.SuspendLayout();
            this.gbDodatoci.SuspendLayout();
            this.gbPijalok.SuspendLayout();
            this.gbDesert.SuspendLayout();
            this.gbNaplata.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGolemina
            // 
            this.gbGolemina.Controls.Add(this.tbGolema);
            this.gbGolemina.Controls.Add(this.tbSredna);
            this.gbGolemina.Controls.Add(this.tbMala);
            this.gbGolemina.Controls.Add(this.rbGolema);
            this.gbGolemina.Controls.Add(this.rbSredna);
            this.gbGolemina.Controls.Add(this.rbMala);
            this.gbGolemina.Location = new System.Drawing.Point(12, 12);
            this.gbGolemina.Name = "gbGolemina";
            this.gbGolemina.Size = new System.Drawing.Size(268, 126);
            this.gbGolemina.TabIndex = 0;
            this.gbGolemina.TabStop = false;
            this.gbGolemina.Text = "Големина";
            // 
            // tbGolema
            // 
            this.tbGolema.Location = new System.Drawing.Point(156, 92);
            this.tbGolema.Name = "tbGolema";
            this.tbGolema.Size = new System.Drawing.Size(100, 20);
            this.tbGolema.TabIndex = 5;
            this.tbGolema.Text = "500";
            this.tbGolema.TextChanged += new System.EventHandler(this.textGoleminaDodatociChanged_TextChanged);
            // 
            // tbSredna
            // 
            this.tbSredna.Location = new System.Drawing.Point(156, 56);
            this.tbSredna.Name = "tbSredna";
            this.tbSredna.Size = new System.Drawing.Size(100, 20);
            this.tbSredna.TabIndex = 4;
            this.tbSredna.Text = "300";
            this.tbSredna.TextChanged += new System.EventHandler(this.textGoleminaDodatociChanged_TextChanged);
            // 
            // tbMala
            // 
            this.tbMala.Location = new System.Drawing.Point(156, 20);
            this.tbMala.Name = "tbMala";
            this.tbMala.Size = new System.Drawing.Size(100, 20);
            this.tbMala.TabIndex = 3;
            this.tbMala.Text = "200";
            this.tbMala.TextChanged += new System.EventHandler(this.textGoleminaDodatociChanged_TextChanged);
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(7, 92);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(63, 17);
            this.rbGolema.TabIndex = 2;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.buttonChange_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(7, 56);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(62, 17);
            this.rbSredna.TabIndex = 1;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.buttonChange_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Checked = true;
            this.rbMala.Location = new System.Drawing.Point(7, 20);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(52, 17);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.buttonChange_CheckedChanged);
            // 
            // gbDodatoci
            // 
            this.gbDodatoci.Controls.Add(this.tbKecap);
            this.gbDodatoci.Controls.Add(this.tbSirenje);
            this.gbDodatoci.Controls.Add(this.tbFeferonki);
            this.gbDodatoci.Controls.Add(this.cbKecap);
            this.gbDodatoci.Controls.Add(this.cbSirenje);
            this.gbDodatoci.Controls.Add(this.cbFeferonki);
            this.gbDodatoci.Location = new System.Drawing.Point(293, 12);
            this.gbDodatoci.Name = "gbDodatoci";
            this.gbDodatoci.Size = new System.Drawing.Size(283, 126);
            this.gbDodatoci.TabIndex = 1;
            this.gbDodatoci.TabStop = false;
            this.gbDodatoci.Text = "Додатоци";
            // 
            // tbKecap
            // 
            this.tbKecap.Location = new System.Drawing.Point(177, 92);
            this.tbKecap.Name = "tbKecap";
            this.tbKecap.Size = new System.Drawing.Size(100, 20);
            this.tbKecap.TabIndex = 5;
            this.tbKecap.Text = "20";
            this.tbKecap.TextChanged += new System.EventHandler(this.textGoleminaDodatociChanged_TextChanged);
            // 
            // tbSirenje
            // 
            this.tbSirenje.Location = new System.Drawing.Point(177, 56);
            this.tbSirenje.Name = "tbSirenje";
            this.tbSirenje.Size = new System.Drawing.Size(100, 20);
            this.tbSirenje.TabIndex = 4;
            this.tbSirenje.Text = "30";
            this.tbSirenje.TextChanged += new System.EventHandler(this.textGoleminaDodatociChanged_TextChanged);
            // 
            // tbFeferonki
            // 
            this.tbFeferonki.Location = new System.Drawing.Point(177, 17);
            this.tbFeferonki.Name = "tbFeferonki";
            this.tbFeferonki.Size = new System.Drawing.Size(100, 20);
            this.tbFeferonki.TabIndex = 3;
            this.tbFeferonki.Text = "40";
            this.tbFeferonki.TextChanged += new System.EventHandler(this.textGoleminaDodatociChanged_TextChanged);
            // 
            // cbKecap
            // 
            this.cbKecap.AutoSize = true;
            this.cbKecap.Location = new System.Drawing.Point(7, 92);
            this.cbKecap.Name = "cbKecap";
            this.cbKecap.Size = new System.Drawing.Size(56, 17);
            this.cbKecap.TabIndex = 2;
            this.cbKecap.Text = "Кечап";
            this.cbKecap.UseVisualStyleBackColor = true;
            this.cbKecap.CheckedChanged += new System.EventHandler(this.buttonChange_CheckedChanged);
            // 
            // cbSirenje
            // 
            this.cbSirenje.AutoSize = true;
            this.cbSirenje.Location = new System.Drawing.Point(7, 56);
            this.cbSirenje.Name = "cbSirenje";
            this.cbSirenje.Size = new System.Drawing.Size(105, 17);
            this.cbSirenje.TabIndex = 1;
            this.cbSirenje.Text = "Екстра сирење";
            this.cbSirenje.UseVisualStyleBackColor = true;
            this.cbSirenje.CheckedChanged += new System.EventHandler(this.buttonChange_CheckedChanged);
            // 
            // cbFeferonki
            // 
            this.cbFeferonki.AutoSize = true;
            this.cbFeferonki.Location = new System.Drawing.Point(7, 20);
            this.cbFeferonki.Name = "cbFeferonki";
            this.cbFeferonki.Size = new System.Drawing.Size(87, 17);
            this.cbFeferonki.TabIndex = 0;
            this.cbFeferonki.Text = "Феферонки";
            this.cbFeferonki.UseVisualStyleBackColor = true;
            this.cbFeferonki.CheckedChanged += new System.EventHandler(this.buttonChange_CheckedChanged);
            // 
            // gbPijalok
            // 
            this.gbPijalok.Controls.Add(this.label6);
            this.gbPijalok.Controls.Add(this.label5);
            this.gbPijalok.Controls.Add(this.tbVkupnoPivo);
            this.gbPijalok.Controls.Add(this.tbVkupnoPortokal);
            this.gbPijalok.Controls.Add(this.tbVkupnoSprajt);
            this.gbPijalok.Controls.Add(this.tbCenaPivo);
            this.gbPijalok.Controls.Add(this.tbCenaPortokal);
            this.gbPijalok.Controls.Add(this.tbCenaSprajt);
            this.gbPijalok.Controls.Add(this.label4);
            this.gbPijalok.Controls.Add(this.tbPivo);
            this.gbPijalok.Controls.Add(this.tbPortokal);
            this.gbPijalok.Controls.Add(this.tbSprajt);
            this.gbPijalok.Controls.Add(this.label3);
            this.gbPijalok.Controls.Add(this.label2);
            this.gbPijalok.Controls.Add(this.label1);
            this.gbPijalok.Location = new System.Drawing.Point(12, 145);
            this.gbPijalok.Name = "gbPijalok";
            this.gbPijalok.Size = new System.Drawing.Size(564, 125);
            this.gbPijalok.TabIndex = 2;
            this.gbPijalok.TabStop = false;
            this.gbPijalok.Text = "Пијалок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Вкупно";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // tbVkupnoPivo
            // 
            this.tbVkupnoPivo.Location = new System.Drawing.Point(458, 96);
            this.tbVkupnoPivo.Name = "tbVkupnoPivo";
            this.tbVkupnoPivo.ReadOnly = true;
            this.tbVkupnoPivo.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoPivo.TabIndex = 12;
            // 
            // tbVkupnoPortokal
            // 
            this.tbVkupnoPortokal.Location = new System.Drawing.Point(458, 64);
            this.tbVkupnoPortokal.Name = "tbVkupnoPortokal";
            this.tbVkupnoPortokal.ReadOnly = true;
            this.tbVkupnoPortokal.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoPortokal.TabIndex = 11;
            // 
            // tbVkupnoSprajt
            // 
            this.tbVkupnoSprajt.Location = new System.Drawing.Point(458, 32);
            this.tbVkupnoSprajt.Name = "tbVkupnoSprajt";
            this.tbVkupnoSprajt.ReadOnly = true;
            this.tbVkupnoSprajt.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoSprajt.TabIndex = 10;
            // 
            // tbCenaPivo
            // 
            this.tbCenaPivo.Location = new System.Drawing.Point(313, 96);
            this.tbCenaPivo.Name = "tbCenaPivo";
            this.tbCenaPivo.Size = new System.Drawing.Size(100, 20);
            this.tbCenaPivo.TabIndex = 9;
            this.tbCenaPivo.Text = "80";
            this.tbCenaPivo.TextChanged += new System.EventHandler(this.tbPivo_TextChanged);
            // 
            // tbCenaPortokal
            // 
            this.tbCenaPortokal.Location = new System.Drawing.Point(313, 64);
            this.tbCenaPortokal.Name = "tbCenaPortokal";
            this.tbCenaPortokal.Size = new System.Drawing.Size(100, 20);
            this.tbCenaPortokal.TabIndex = 8;
            this.tbCenaPortokal.Text = "70";
            this.tbCenaPortokal.TextChanged += new System.EventHandler(this.tbPortokal_TextChanged);
            // 
            // tbCenaSprajt
            // 
            this.tbCenaSprajt.Location = new System.Drawing.Point(313, 32);
            this.tbCenaSprajt.Name = "tbCenaSprajt";
            this.tbCenaSprajt.Size = new System.Drawing.Size(100, 20);
            this.tbCenaSprajt.TabIndex = 7;
            this.tbCenaSprajt.Text = "60";
            this.tbCenaSprajt.TextChanged += new System.EventHandler(this.tbSprajt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количина";
            // 
            // tbPivo
            // 
            this.tbPivo.Location = new System.Drawing.Point(173, 96);
            this.tbPivo.Name = "tbPivo";
            this.tbPivo.Size = new System.Drawing.Size(95, 20);
            this.tbPivo.TabIndex = 5;
            this.tbPivo.Text = "0";
            this.tbPivo.TextChanged += new System.EventHandler(this.tbPivo_TextChanged);
            // 
            // tbPortokal
            // 
            this.tbPortokal.Location = new System.Drawing.Point(173, 64);
            this.tbPortokal.Name = "tbPortokal";
            this.tbPortokal.Size = new System.Drawing.Size(95, 20);
            this.tbPortokal.TabIndex = 4;
            this.tbPortokal.Text = "0";
            this.tbPortokal.TextChanged += new System.EventHandler(this.tbPortokal_TextChanged);
            // 
            // tbSprajt
            // 
            this.tbSprajt.Location = new System.Drawing.Point(173, 32);
            this.tbSprajt.Name = "tbSprajt";
            this.tbSprajt.Size = new System.Drawing.Size(95, 20);
            this.tbSprajt.TabIndex = 3;
            this.tbSprajt.Text = "0";
            this.tbSprajt.TextChanged += new System.EventHandler(this.tbSprajt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / Портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // gbDesert
            // 
            this.gbDesert.Controls.Add(this.btOtkazi);
            this.gbDesert.Controls.Add(this.btNaracaj);
            this.gbDesert.Controls.Add(this.tbDesert);
            this.gbDesert.Controls.Add(this.label7);
            this.gbDesert.Controls.Add(this.lbDesert);
            this.gbDesert.Location = new System.Drawing.Point(12, 277);
            this.gbDesert.Name = "gbDesert";
            this.gbDesert.Size = new System.Drawing.Size(268, 144);
            this.gbDesert.TabIndex = 3;
            this.gbDesert.TabStop = false;
            this.gbDesert.Text = "Десерт";
            // 
            // btOtkazi
            // 
            this.btOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOtkazi.Location = new System.Drawing.Point(136, 103);
            this.btOtkazi.Name = "btOtkazi";
            this.btOtkazi.Size = new System.Drawing.Size(120, 23);
            this.btOtkazi.TabIndex = 4;
            this.btOtkazi.Text = "Откажи";
            this.btOtkazi.UseVisualStyleBackColor = true;
            this.btOtkazi.Click += new System.EventHandler(this.btOtkazi_Click);
            // 
            // btNaracaj
            // 
            this.btNaracaj.Location = new System.Drawing.Point(136, 71);
            this.btNaracaj.Name = "btNaracaj";
            this.btNaracaj.Size = new System.Drawing.Size(120, 23);
            this.btNaracaj.TabIndex = 3;
            this.btNaracaj.Text = "Нарачај";
            this.btNaracaj.UseVisualStyleBackColor = true;
            this.btNaracaj.Click += new System.EventHandler(this.btNaracaj_Click);
            // 
            // tbDesert
            // 
            this.tbDesert.Location = new System.Drawing.Point(136, 42);
            this.tbDesert.Name = "tbDesert";
            this.tbDesert.Size = new System.Drawing.Size(120, 20);
            this.tbDesert.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цена на десерт:";
            // 
            // lbDesert
            // 
            this.lbDesert.FormattingEnabled = true;
            this.lbDesert.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lbDesert.Location = new System.Drawing.Point(7, 20);
            this.lbDesert.Name = "lbDesert";
            this.lbDesert.Size = new System.Drawing.Size(120, 108);
            this.lbDesert.TabIndex = 0;
            this.lbDesert.SelectedIndexChanged += new System.EventHandler(this.lbDesert_SelectedIndexChanged);
            // 
            // gbNaplata
            // 
            this.gbNaplata.Controls.Add(this.tbZaVrakjanje);
            this.gbNaplata.Controls.Add(this.tbNaplateno);
            this.gbNaplata.Controls.Add(this.tbVkupnoNaplata);
            this.gbNaplata.Controls.Add(this.label10);
            this.gbNaplata.Controls.Add(this.label9);
            this.gbNaplata.Controls.Add(this.label8);
            this.gbNaplata.Location = new System.Drawing.Point(293, 277);
            this.gbNaplata.Name = "gbNaplata";
            this.gbNaplata.Size = new System.Drawing.Size(283, 144);
            this.gbNaplata.TabIndex = 4;
            this.gbNaplata.TabStop = false;
            this.gbNaplata.Text = "Наплата";
            // 
            // tbZaVrakjanje
            // 
            this.tbZaVrakjanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZaVrakjanje.Location = new System.Drawing.Point(134, 106);
            this.tbZaVrakjanje.Name = "tbZaVrakjanje";
            this.tbZaVrakjanje.Size = new System.Drawing.Size(143, 26);
            this.tbZaVrakjanje.TabIndex = 5;
            this.tbZaVrakjanje.Text = "0";
            // 
            // tbNaplateno
            // 
            this.tbNaplateno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaplateno.Location = new System.Drawing.Point(134, 59);
            this.tbNaplateno.Name = "tbNaplateno";
            this.tbNaplateno.Size = new System.Drawing.Size(143, 26);
            this.tbNaplateno.TabIndex = 4;
            this.tbNaplateno.Text = "0";
            this.tbNaplateno.TextChanged += new System.EventHandler(this.tbNaplateno_TextChanged);
            // 
            // tbVkupnoNaplata
            // 
            this.tbVkupnoNaplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVkupnoNaplata.Location = new System.Drawing.Point(134, 12);
            this.tbVkupnoNaplata.Name = "tbVkupnoNaplata";
            this.tbVkupnoNaplata.ReadOnly = true;
            this.tbVkupnoNaplata.Size = new System.Drawing.Size(143, 26);
            this.tbVkupnoNaplata.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "За враќање:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Наплатено:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вкупно за наплаќање:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btNaracaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btOtkazi;
            this.ClientSize = new System.Drawing.Size(588, 433);
            this.Controls.Add(this.gbNaplata);
            this.Controls.Add(this.gbDesert);
            this.Controls.Add(this.gbPijalok);
            this.Controls.Add(this.gbDodatoci);
            this.Controls.Add(this.gbGolemina);
            this.Name = "Form1";
            this.Text = "Нарачка на пица";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGolemina.ResumeLayout(false);
            this.gbGolemina.PerformLayout();
            this.gbDodatoci.ResumeLayout(false);
            this.gbDodatoci.PerformLayout();
            this.gbPijalok.ResumeLayout(false);
            this.gbPijalok.PerformLayout();
            this.gbDesert.ResumeLayout(false);
            this.gbDesert.PerformLayout();
            this.gbNaplata.ResumeLayout(false);
            this.gbNaplata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGolemina;
        private System.Windows.Forms.TextBox tbGolema;
        private System.Windows.Forms.TextBox tbSredna;
        private System.Windows.Forms.TextBox tbMala;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.GroupBox gbDodatoci;
        private System.Windows.Forms.TextBox tbKecap;
        private System.Windows.Forms.TextBox tbSirenje;
        private System.Windows.Forms.TextBox tbFeferonki;
        private System.Windows.Forms.CheckBox cbKecap;
        private System.Windows.Forms.CheckBox cbSirenje;
        private System.Windows.Forms.CheckBox cbFeferonki;
        private System.Windows.Forms.GroupBox gbPijalok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVkupnoPivo;
        private System.Windows.Forms.TextBox tbVkupnoPortokal;
        private System.Windows.Forms.TextBox tbVkupnoSprajt;
        private System.Windows.Forms.TextBox tbCenaPivo;
        private System.Windows.Forms.TextBox tbCenaPortokal;
        private System.Windows.Forms.TextBox tbCenaSprajt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPivo;
        private System.Windows.Forms.TextBox tbPortokal;
        private System.Windows.Forms.TextBox tbSprajt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDesert;
        private System.Windows.Forms.GroupBox gbNaplata;
        private System.Windows.Forms.Button btOtkazi;
        private System.Windows.Forms.Button btNaracaj;
        private System.Windows.Forms.TextBox tbDesert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDesert;
        private System.Windows.Forms.TextBox tbZaVrakjanje;
        private System.Windows.Forms.TextBox tbNaplateno;
        private System.Windows.Forms.TextBox tbVkupnoNaplata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

