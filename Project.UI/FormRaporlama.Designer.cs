namespace Project.UI
{
    partial class FormRaporlama
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
            this.dgvRaporlama = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSecilenYılaGöre = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAylikKazanc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMarkaArama = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnModelArama = new System.Windows.Forms.Button();
            this.cmbYıl = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.btnRengeGore = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbKasaTipi = new System.Windows.Forms.ComboBox();
            this.btnKasaTipineGore = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlama)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRaporlama
            // 
            this.dgvRaporlama.AllowUserToAddRows = false;
            this.dgvRaporlama.AllowUserToDeleteRows = false;
            this.dgvRaporlama.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRaporlama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporlama.Location = new System.Drawing.Point(12, 182);
            this.dgvRaporlama.Name = "dgvRaporlama";
            this.dgvRaporlama.ReadOnly = true;
            this.dgvRaporlama.Size = new System.Drawing.Size(675, 222);
            this.dgvRaporlama.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbYıl);
            this.groupBox1.Controls.Add(this.btnSecilenYılaGöre);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Yılla Göre";
            // 
            // btnSecilenYılaGöre
            // 
            this.btnSecilenYılaGöre.Location = new System.Drawing.Point(6, 43);
            this.btnSecilenYılaGöre.Name = "btnSecilenYılaGöre";
            this.btnSecilenYılaGöre.Size = new System.Drawing.Size(138, 23);
            this.btnSecilenYılaGöre.TabIndex = 3;
            this.btnSecilenYılaGöre.Text = "Listeleme";
            this.btnSecilenYılaGöre.UseVisualStyleBackColor = true;
            this.btnSecilenYılaGöre.Click += new System.EventHandler(this.btnSecilenYılaGöre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAylikKazanc);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aylık Kazanç";
            // 
            // btnAylikKazanc
            // 
            this.btnAylikKazanc.Location = new System.Drawing.Point(6, 21);
            this.btnAylikKazanc.Name = "btnAylikKazanc";
            this.btnAylikKazanc.Size = new System.Drawing.Size(138, 23);
            this.btnAylikKazanc.TabIndex = 3;
            this.btnAylikKazanc.Text = "Net Kazanç";
            this.btnAylikKazanc.UseVisualStyleBackColor = true;
            this.btnAylikKazanc.Click += new System.EventHandler(this.btnAylikKazanc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbMarka);
            this.groupBox3.Controls.Add(this.btnMarkaArama);
            this.groupBox3.Location = new System.Drawing.Point(171, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modele Göre Kazanç";
            // 
            // btnMarkaArama
            // 
            this.btnMarkaArama.Location = new System.Drawing.Point(6, 45);
            this.btnMarkaArama.Name = "btnMarkaArama";
            this.btnMarkaArama.Size = new System.Drawing.Size(130, 23);
            this.btnMarkaArama.TabIndex = 3;
            this.btnMarkaArama.Text = "Listeleme";
            this.btnMarkaArama.UseVisualStyleBackColor = true;
            this.btnMarkaArama.Click += new System.EventHandler(this.btnMarkaArama_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbModel);
            this.groupBox4.Controls.Add(this.btnModelArama);
            this.groupBox4.Location = new System.Drawing.Point(171, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(161, 74);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Markaya Göre Kazanç";
            // 
            // btnModelArama
            // 
            this.btnModelArama.Location = new System.Drawing.Point(6, 44);
            this.btnModelArama.Name = "btnModelArama";
            this.btnModelArama.Size = new System.Drawing.Size(129, 23);
            this.btnModelArama.TabIndex = 3;
            this.btnModelArama.Text = "Listeleme";
            this.btnModelArama.UseVisualStyleBackColor = true;
            this.btnModelArama.Click += new System.EventHandler(this.btnModelArama_Click);
            // 
            // cmbYıl
            // 
            this.cmbYıl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYıl.FormattingEnabled = true;
            this.cmbYıl.Location = new System.Drawing.Point(7, 16);
            this.cmbYıl.Name = "cmbYıl";
            this.cmbYıl.Size = new System.Drawing.Size(137, 22);
            this.cmbYıl.TabIndex = 4;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(7, 21);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(129, 22);
            this.cmbMarka.TabIndex = 5;
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(6, 16);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(129, 22);
            this.cmbModel.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbRenk);
            this.groupBox6.Controls.Add(this.btnRengeGore);
            this.groupBox6.Location = new System.Drawing.Point(338, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(167, 74);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Renge Göre Kazanç";
            // 
            // cmbRenk
            // 
            this.cmbRenk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Location = new System.Drawing.Point(6, 16);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(129, 22);
            this.cmbRenk.TabIndex = 6;
            // 
            // btnRengeGore
            // 
            this.btnRengeGore.Location = new System.Drawing.Point(6, 44);
            this.btnRengeGore.Name = "btnRengeGore";
            this.btnRengeGore.Size = new System.Drawing.Size(129, 23);
            this.btnRengeGore.TabIndex = 3;
            this.btnRengeGore.Text = "Listeleme";
            this.btnRengeGore.UseVisualStyleBackColor = true;
            this.btnRengeGore.Click += new System.EventHandler(this.btnRengeGore_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbKasaTipi);
            this.groupBox7.Controls.Add(this.btnKasaTipineGore);
            this.groupBox7.Location = new System.Drawing.Point(511, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(176, 74);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kasa Tipine Göre Kazanç";
            // 
            // cmbKasaTipi
            // 
            this.cmbKasaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKasaTipi.FormattingEnabled = true;
            this.cmbKasaTipi.Location = new System.Drawing.Point(14, 16);
            this.cmbKasaTipi.Name = "cmbKasaTipi";
            this.cmbKasaTipi.Size = new System.Drawing.Size(129, 22);
            this.cmbKasaTipi.TabIndex = 6;
            // 
            // btnKasaTipineGore
            // 
            this.btnKasaTipineGore.Location = new System.Drawing.Point(14, 44);
            this.btnKasaTipineGore.Name = "btnKasaTipineGore";
            this.btnKasaTipineGore.Size = new System.Drawing.Size(129, 23);
            this.btnKasaTipineGore.TabIndex = 3;
            this.btnKasaTipineGore.Text = "Listeleme";
            this.btnKasaTipineGore.UseVisualStyleBackColor = true;
            this.btnKasaTipineGore.Click += new System.EventHandler(this.btnKasaTipineGore_Click);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 14;
            this.lbData.Location = new System.Drawing.Point(344, 100);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(343, 60);
            this.lbData.TabIndex = 8;
            // 
            // FormRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(700, 416);
            this.ControlBox = false;
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRaporlama);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRaporlama";
            this.Load += new System.EventHandler(this.FormRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlama)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaporlama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbYıl;
        private System.Windows.Forms.Button btnSecilenYılaGöre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAylikKazanc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Button btnMarkaArama;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Button btnModelArama;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.Button btnRengeGore;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbKasaTipi;
        private System.Windows.Forms.Button btnKasaTipineGore;
        private System.Windows.Forms.ListBox lbData;
    }
}