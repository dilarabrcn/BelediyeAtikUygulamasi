namespace BelediyeAtikUygulamasi
{
    partial class PersonelForm
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
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtTEL = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblSOYAD = new System.Windows.Forms.Label();
            this.lblGorev = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblTEL = new System.Windows.Forms.Label();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblPosta = new System.Windows.Forms.Label();
            this.lblCocuk = new System.Windows.Forms.Label();
            this.lblMedeni = new System.Windows.Forms.Label();
            this.lblDTarih = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtCocuk = new System.Windows.Forms.TextBox();
            this.txtMedeniDurum = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(161, 20);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(121, 22);
            this.txtTC.TabIndex = 0;
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(161, 68);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(121, 22);
            this.txtAD.TabIndex = 1;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(161, 122);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(121, 22);
            this.txtSOYAD.TabIndex = 2;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(161, 236);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(121, 22);
            this.txtMaas.TabIndex = 4;
            // 
            // txtTEL
            // 
            this.txtTEL.Location = new System.Drawing.Point(161, 289);
            this.txtTEL.Name = "txtTEL";
            this.txtTEL.Size = new System.Drawing.Size(121, 22);
            this.txtTEL.TabIndex = 5;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(12, 26);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(86, 16);
            this.lblTC.TabIndex = 6;
            this.lblTC.Text = "TC Kimlik NO";
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(17, 68);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(26, 16);
            this.lblAD.TabIndex = 7;
            this.lblAD.Text = "AD";
            // 
            // lblSOYAD
            // 
            this.lblSOYAD.AutoSize = true;
            this.lblSOYAD.Location = new System.Drawing.Point(12, 125);
            this.lblSOYAD.Name = "lblSOYAD";
            this.lblSOYAD.Size = new System.Drawing.Size(54, 16);
            this.lblSOYAD.TabIndex = 8;
            this.lblSOYAD.Text = "SOYAD";
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Location = new System.Drawing.Point(12, 178);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(109, 16);
            this.lblGorev.TabIndex = 9;
            this.lblGorev.Text = "GÖREV UNVANI";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(12, 236);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(45, 16);
            this.lblMaas.TabIndex = 10;
            this.lblMaas.Text = "MAAŞ";
            // 
            // lblTEL
            // 
            this.lblTEL.AutoSize = true;
            this.lblTEL.Location = new System.Drawing.Point(12, 292);
            this.lblTEL.Name = "lblTEL";
            this.lblTEL.Size = new System.Drawing.Size(143, 16);
            this.lblTEL.TabIndex = 11;
            this.lblTEL.Text = "TELEFON NUMARASI";
            // 
            // cmbGorev
            // 
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Location = new System.Drawing.Point(161, 178);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(121, 24);
            this.cmbGorev.TabIndex = 12;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(12, 342);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(54, 16);
            this.lblAdres.TabIndex = 13;
            this.lblAdres.Text = "ADRES";
            // 
            // lblPosta
            // 
            this.lblPosta.AutoSize = true;
            this.lblPosta.Location = new System.Drawing.Point(12, 386);
            this.lblPosta.Name = "lblPosta";
            this.lblPosta.Size = new System.Drawing.Size(65, 16);
            this.lblPosta.TabIndex = 14;
            this.lblPosta.Text = "E POSTA";
            // 
            // lblCocuk
            // 
            this.lblCocuk.AutoSize = true;
            this.lblCocuk.Location = new System.Drawing.Point(338, 26);
            this.lblCocuk.Name = "lblCocuk";
            this.lblCocuk.Size = new System.Drawing.Size(98, 16);
            this.lblCocuk.TabIndex = 15;
            this.lblCocuk.Text = "ÇOCUK SAYISI";
            // 
            // lblMedeni
            // 
            this.lblMedeni.AutoSize = true;
            this.lblMedeni.Location = new System.Drawing.Point(338, 74);
            this.lblMedeni.Name = "lblMedeni";
            this.lblMedeni.Size = new System.Drawing.Size(113, 16);
            this.lblMedeni.TabIndex = 16;
            this.lblMedeni.Text = "MEDENİ DURUM";
            // 
            // lblDTarih
            // 
            this.lblDTarih.AutoSize = true;
            this.lblDTarih.Location = new System.Drawing.Point(338, 125);
            this.lblDTarih.Name = "lblDTarih";
            this.lblDTarih.Size = new System.Drawing.Size(105, 16);
            this.lblDTarih.TabIndex = 17;
            this.lblDTarih.Text = "DOĞUM TARİHİ";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(161, 336);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(121, 22);
            this.txtAdres.TabIndex = 18;
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(161, 380);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(121, 22);
            this.txtPosta.TabIndex = 19;
            // 
            // txtCocuk
            // 
            this.txtCocuk.Location = new System.Drawing.Point(486, 23);
            this.txtCocuk.Name = "txtCocuk";
            this.txtCocuk.Size = new System.Drawing.Size(100, 22);
            this.txtCocuk.TabIndex = 20;
            // 
            // txtMedeniDurum
            // 
            this.txtMedeniDurum.Location = new System.Drawing.Point(486, 74);
            this.txtMedeniDurum.Name = "txtMedeniDurum";
            this.txtMedeniDurum.Size = new System.Drawing.Size(100, 22);
            this.txtMedeniDurum.TabIndex = 21;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(486, 125);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(100, 22);
            this.txtDogumTarihi.TabIndex = 22;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(601, 125);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(97, 23);
            this.btnListele.TabIndex = 23;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(713, 125);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(610, 171);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(702, 171);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 23);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Location = new System.Drawing.Point(309, 225);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.Size = new System.Drawing.Size(790, 458);
            this.dgvPersonel.TabIndex = 27;
            this.dgvPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(306, 200);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(88, 16);
            this.lblAra.TabIndex = 29;
            this.lblAra.Text = "Personel Ara:";
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 695);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtMedeniDurum);
            this.Controls.Add(this.txtCocuk);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblDTarih);
            this.Controls.Add(this.lblMedeni);
            this.Controls.Add(this.lblCocuk);
            this.Controls.Add(this.lblPosta);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.cmbGorev);
            this.Controls.Add(this.lblTEL);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblGorev);
            this.Controls.Add(this.lblSOYAD);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtTEL);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.txtTC);
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtTEL;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label lblSOYAD;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblTEL;
        private System.Windows.Forms.ComboBox cmbGorev;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblPosta;
        private System.Windows.Forms.Label lblCocuk;
        private System.Windows.Forms.Label lblMedeni;
        private System.Windows.Forms.Label lblDTarih;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtCocuk;
        private System.Windows.Forms.TextBox txtMedeniDurum;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAra;
    }
}