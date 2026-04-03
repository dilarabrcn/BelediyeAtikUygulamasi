namespace BelediyeAtikUygulamasi
{
    partial class AracForm
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
            this.lblAracID = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.lblAracTipi = new System.Windows.Forms.Label();
            this.lblRota = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSorumluSofor = new System.Windows.Forms.Label();
            this.txtAracID = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.cmbAracTipi = new System.Windows.Forms.ComboBox();
            this.cmbRota = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbSorumluSofor = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAracID
            // 
            this.lblAracID.AutoSize = true;
            this.lblAracID.Location = new System.Drawing.Point(12, 20);
            this.lblAracID.Name = "lblAracID";
            this.lblAracID.Size = new System.Drawing.Size(60, 16);
            this.lblAracID.TabIndex = 0;
            this.lblAracID.Text = "ARAÇ ID";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(12, 58);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(49, 16);
            this.lblPlaka.TabIndex = 1;
            this.lblPlaka.Text = "PLAKA";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(12, 98);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(54, 16);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "MARKA";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 142);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 16);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "MODEL";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(12, 188);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(98, 16);
            this.lblKapasite.TabIndex = 4;
            this.lblKapasite.Text = "KAPASİTE (kg)";
            // 
            // lblAracTipi
            // 
            this.lblAracTipi.AutoSize = true;
            this.lblAracTipi.Location = new System.Drawing.Point(12, 234);
            this.lblAracTipi.Name = "lblAracTipi";
            this.lblAracTipi.Size = new System.Drawing.Size(71, 16);
            this.lblAracTipi.TabIndex = 5;
            this.lblAracTipi.Text = "ARAÇ TİPİ";
            // 
            // lblRota
            // 
            this.lblRota.AutoSize = true;
            this.lblRota.Location = new System.Drawing.Point(12, 282);
            this.lblRota.Name = "lblRota";
            this.lblRota.Size = new System.Drawing.Size(45, 16);
            this.lblRota.TabIndex = 6;
            this.lblRota.Text = "ROTA";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(12, 330);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(58, 16);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "DURUM";
            // 
            // lblSorumluSofor
            // 
            this.lblSorumluSofor.AutoSize = true;
            this.lblSorumluSofor.Location = new System.Drawing.Point(12, 381);
            this.lblSorumluSofor.Name = "lblSorumluSofor";
            this.lblSorumluSofor.Size = new System.Drawing.Size(124, 16);
            this.lblSorumluSofor.TabIndex = 8;
            this.lblSorumluSofor.Text = "SORUMLU ŞOFÖR";
            // 
            // txtAracID
            // 
            this.txtAracID.Location = new System.Drawing.Point(167, 20);
            this.txtAracID.Name = "txtAracID";
            this.txtAracID.Size = new System.Drawing.Size(100, 22);
            this.txtAracID.TabIndex = 9;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(167, 58);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 22);
            this.txtPlaka.TabIndex = 10;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(167, 92);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 11;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(167, 136);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 12;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(167, 182);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(100, 22);
            this.txtKapasite.TabIndex = 13;
            // 
            // cmbAracTipi
            // 
            this.cmbAracTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAracTipi.FormattingEnabled = true;
            this.cmbAracTipi.Items.AddRange(new object[] {
            "ÇÖP KAMYONU (Organik)",
            "BÖLMELİ KAMYON (Plastik, Metal, Kağıt)",
            "VİNÇLİ KAMYON (Cam)"});
            this.cmbAracTipi.Location = new System.Drawing.Point(167, 231);
            this.cmbAracTipi.Name = "cmbAracTipi";
            this.cmbAracTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbAracTipi.TabIndex = 14;
            // 
            // cmbRota
            // 
            this.cmbRota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRota.FormattingEnabled = true;
            this.cmbRota.Items.AddRange(new object[] {
            "MERKEZ",
            "KUZEY",
            "GÜNEY",
            "DOĞU",
            "BATI"});
            this.cmbRota.Location = new System.Drawing.Point(167, 274);
            this.cmbRota.Name = "cmbRota";
            this.cmbRota.Size = new System.Drawing.Size(121, 24);
            this.cmbRota.TabIndex = 15;
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF",
            "BAKIMDA"});
            this.cmbDurum.Location = new System.Drawing.Point(167, 322);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 24);
            this.cmbDurum.TabIndex = 16;
            // 
            // cmbSorumluSofor
            // 
            this.cmbSorumluSofor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorumluSofor.FormattingEnabled = true;
            this.cmbSorumluSofor.Location = new System.Drawing.Point(167, 373);
            this.cmbSorumluSofor.Name = "cmbSorumluSofor";
            this.cmbSorumluSofor.Size = new System.Drawing.Size(121, 24);
            this.cmbSorumluSofor.TabIndex = 17;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(362, 29);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 18;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(362, 69);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(498, 29);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(498, 69);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 23);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(294, 142);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.RowHeadersWidth = 51;
            this.dgvAraclar.RowTemplate.Height = 24;
            this.dgvAraclar.Size = new System.Drawing.Size(505, 296);
            this.dgvAraclar.TabIndex = 22;
            this.dgvAraclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAraclar_CellClick);
            // 
            // AracForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAraclar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbSorumluSofor);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.cmbRota);
            this.Controls.Add(this.cmbAracTipi);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtAracID);
            this.Controls.Add(this.lblSorumluSofor);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblRota);
            this.Controls.Add(this.lblAracTipi);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.lblAracID);
            this.Name = "AracForm";
            this.Text = "AracForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAracID;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label lblAracTipi;
        private System.Windows.Forms.Label lblRota;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSorumluSofor;
        private System.Windows.Forms.TextBox txtAracID;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.ComboBox cmbAracTipi;
        private System.Windows.Forms.ComboBox cmbRota;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbSorumluSofor;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvAraclar;
    }
}