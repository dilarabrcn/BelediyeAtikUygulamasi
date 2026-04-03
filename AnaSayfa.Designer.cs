namespace BelediyeAtikUygulamasi
{
    partial class AnaSayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnArac = new System.Windows.Forms.Button();
            this.btnAtik = new System.Windows.Forms.Button();
            this.btnBakim = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BELEDİYE ATIK YÖNETİM SİSTEMİ";
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(12, 117);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(200, 100);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "Personel Yönetimi";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnArac
            // 
            this.btnArac.Location = new System.Drawing.Point(299, 117);
            this.btnArac.Name = "btnArac";
            this.btnArac.Size = new System.Drawing.Size(200, 100);
            this.btnArac.TabIndex = 2;
            this.btnArac.Text = "Araç Yönetimi";
            this.btnArac.UseVisualStyleBackColor = true;
            this.btnArac.Click += new System.EventHandler(this.btnArac_Click);
            // 
            // btnAtik
            // 
            this.btnAtik.Location = new System.Drawing.Point(588, 117);
            this.btnAtik.Name = "btnAtik";
            this.btnAtik.Size = new System.Drawing.Size(200, 100);
            this.btnAtik.TabIndex = 3;
            this.btnAtik.Text = "Atık Girişi";
            this.btnAtik.UseVisualStyleBackColor = true;
            this.btnAtik.Click += new System.EventHandler(this.btnAtik_Click);
            // 
            // btnBakim
            // 
            this.btnBakim.Location = new System.Drawing.Point(12, 295);
            this.btnBakim.Name = "btnBakim";
            this.btnBakim.Size = new System.Drawing.Size(200, 100);
            this.btnBakim.TabIndex = 4;
            this.btnBakim.Text = "Araç Bakımı";
            this.btnBakim.UseVisualStyleBackColor = true;
            this.btnBakim.Click += new System.EventHandler(this.btnBakim_Click);
            // 
            // btnMaas
            // 
            this.btnMaas.Location = new System.Drawing.Point(299, 295);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(200, 100);
            this.btnMaas.TabIndex = 5;
            this.btnMaas.Text = "Maaş ve Muhasebe";
            this.btnMaas.UseVisualStyleBackColor = true;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCikis.Location = new System.Drawing.Point(588, 295);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(200, 100);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Uygulamadan Çık";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMaas);
            this.Controls.Add(this.btnBakim);
            this.Controls.Add(this.btnAtik);
            this.Controls.Add(this.btnArac);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.panel1);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnArac;
        private System.Windows.Forms.Button btnAtik;
        private System.Windows.Forms.Button btnBakim;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnCikis;
    }
}