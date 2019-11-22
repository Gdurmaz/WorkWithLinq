namespace Project.UI
{
    partial class FormAraba
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
            this.cmbModelAdı = new System.Windows.Forms.ComboBox();
            this.cmbKasaTipi = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.checkKiralık = new System.Windows.Forms.CheckBox();
            this.tbSatisFiyati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAracData = new System.Windows.Forms.DataGridView();
            this.gbAracInfo = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMarkaAdi = new System.Windows.Forms.TextBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracData)).BeginInit();
            this.gbAracInfo.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbModelAdı
            // 
            this.cmbModelAdı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelAdı.FormattingEnabled = true;
            this.cmbModelAdı.Location = new System.Drawing.Point(79, 22);
            this.cmbModelAdı.Name = "cmbModelAdı";
            this.cmbModelAdı.Size = new System.Drawing.Size(139, 23);
            this.cmbModelAdı.TabIndex = 0;
            this.cmbModelAdı.SelectedIndexChanged += new System.EventHandler(this.cmbModelAdı_SelectedIndexChanged);
            // 
            // cmbKasaTipi
            // 
            this.cmbKasaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKasaTipi.FormattingEnabled = true;
            this.cmbKasaTipi.Location = new System.Drawing.Point(79, 97);
            this.cmbKasaTipi.Name = "cmbKasaTipi";
            this.cmbKasaTipi.Size = new System.Drawing.Size(139, 23);
            this.cmbKasaTipi.TabIndex = 0;
            // 
            // cmbYil
            // 
            this.cmbYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(79, 126);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(139, 23);
            this.cmbYil.TabIndex = 0;
            // 
            // checkKiralık
            // 
            this.checkKiralık.AutoSize = true;
            this.checkKiralık.Location = new System.Drawing.Point(79, 242);
            this.checkKiralık.Name = "checkKiralık";
            this.checkKiralık.Size = new System.Drawing.Size(109, 19);
            this.checkKiralık.TabIndex = 1;
            this.checkKiralık.Text = "Aracı Kiraya Ver";
            this.checkKiralık.UseVisualStyleBackColor = true;
            // 
            // tbSatisFiyati
            // 
            this.tbSatisFiyati.Location = new System.Drawing.Point(79, 201);
            this.tbSatisFiyati.Name = "tbSatisFiyati";
            this.tbSatisFiyati.Size = new System.Drawing.Size(139, 23);
            this.tbSatisFiyati.TabIndex = 2;
            this.tbSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSatisFiyati_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kasa Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yıl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Renk";
            // 
            // cmbRenk
            // 
            this.cmbRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Location = new System.Drawing.Point(79, 163);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(139, 23);
            this.cmbRenk.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Satış Fiyatı";
            // 
            // dgvAracData
            // 
            this.dgvAracData.AllowUserToAddRows = false;
            this.dgvAracData.AllowUserToDeleteRows = false;
            this.dgvAracData.AllowUserToResizeColumns = false;
            this.dgvAracData.AllowUserToResizeRows = false;
            this.dgvAracData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAracData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAracData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAracData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAracData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAracData.Location = new System.Drawing.Point(3, 19);
            this.dgvAracData.Name = "dgvAracData";
            this.dgvAracData.ReadOnly = true;
            this.dgvAracData.Size = new System.Drawing.Size(643, 371);
            this.dgvAracData.TabIndex = 4;
            // 
            // gbAracInfo
            // 
            this.gbAracInfo.Controls.Add(this.btnSil);
            this.gbAracInfo.Controls.Add(this.btnGuncelle);
            this.gbAracInfo.Controls.Add(this.btnKaydet);
            this.gbAracInfo.Controls.Add(this.label1);
            this.gbAracInfo.Controls.Add(this.cmbModelAdı);
            this.gbAracInfo.Controls.Add(this.label6);
            this.gbAracInfo.Controls.Add(this.label5);
            this.gbAracInfo.Controls.Add(this.cmbKasaTipi);
            this.gbAracInfo.Controls.Add(this.label4);
            this.gbAracInfo.Controls.Add(this.cmbYil);
            this.gbAracInfo.Controls.Add(this.label3);
            this.gbAracInfo.Controls.Add(this.cmbRenk);
            this.gbAracInfo.Controls.Add(this.label2);
            this.gbAracInfo.Controls.Add(this.checkKiralık);
            this.gbAracInfo.Controls.Add(this.tbMarkaAdi);
            this.gbAracInfo.Controls.Add(this.tbSatisFiyati);
            this.gbAracInfo.Location = new System.Drawing.Point(12, 12);
            this.gbAracInfo.Name = "gbAracInfo";
            this.gbAracInfo.Size = new System.Drawing.Size(231, 393);
            this.gbAracInfo.TabIndex = 5;
            this.gbAracInfo.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Azure;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(85, 350);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(139, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Azure;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(85, 321);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(139, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Azure;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(85, 292);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(139, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Marka Adı";
            // 
            // tbMarkaAdi
            // 
            this.tbMarkaAdi.Location = new System.Drawing.Point(79, 57);
            this.tbMarkaAdi.Name = "tbMarkaAdi";
            this.tbMarkaAdi.ReadOnly = true;
            this.tbMarkaAdi.Size = new System.Drawing.Size(139, 23);
            this.tbMarkaAdi.TabIndex = 2;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.dgvAracData);
            this.gbData.Location = new System.Drawing.Point(249, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(649, 393);
            this.gbData.TabIndex = 6;
            this.gbData.TabStop = false;
            // 
            // FormAraba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(910, 417);
            this.ControlBox = false;
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbAracInfo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAraba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAraba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracData)).EndInit();
            this.gbAracInfo.ResumeLayout(false);
            this.gbAracInfo.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModelAdı;
        private System.Windows.Forms.ComboBox cmbKasaTipi;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.CheckBox checkKiralık;
        private System.Windows.Forms.TextBox tbSatisFiyati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAracData;
        private System.Windows.Forms.GroupBox gbAracInfo;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMarkaAdi;
    }
}