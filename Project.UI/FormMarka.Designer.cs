namespace Project.UI
{
    partial class FormMarka
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
            this.gbAracInfo = new System.Windows.Forms.GroupBox();
            this.tbMarkaAdı = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMarkaData = new System.Windows.Forms.DataGridView();
            this.gbAracInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAracInfo
            // 
            this.gbAracInfo.Controls.Add(this.tbMarkaAdı);
            this.gbAracInfo.Controls.Add(this.btnSil);
            this.gbAracInfo.Controls.Add(this.btnGuncelle);
            this.gbAracInfo.Controls.Add(this.btnKaydet);
            this.gbAracInfo.Controls.Add(this.label1);
            this.gbAracInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAracInfo.Location = new System.Drawing.Point(12, 12);
            this.gbAracInfo.Name = "gbAracInfo";
            this.gbAracInfo.Size = new System.Drawing.Size(229, 224);
            this.gbAracInfo.TabIndex = 7;
            this.gbAracInfo.TabStop = false;
            // 
            // tbMarkaAdı
            // 
            this.tbMarkaAdı.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMarkaAdı.Location = new System.Drawing.Point(85, 27);
            this.tbMarkaAdı.Name = "tbMarkaAdı";
            this.tbMarkaAdı.Size = new System.Drawing.Size(120, 22);
            this.tbMarkaAdı.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Azure;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(85, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 25);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Azure;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(85, 148);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 25);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Azure;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(85, 117);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 25);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMarkaData);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 224);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dgvMarkaData
            // 
            this.dgvMarkaData.AllowUserToAddRows = false;
            this.dgvMarkaData.AllowUserToDeleteRows = false;
            this.dgvMarkaData.AllowUserToResizeColumns = false;
            this.dgvMarkaData.AllowUserToResizeRows = false;
            this.dgvMarkaData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarkaData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMarkaData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMarkaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarkaData.Location = new System.Drawing.Point(3, 18);
            this.dgvMarkaData.Name = "dgvMarkaData";
            this.dgvMarkaData.ReadOnly = true;
            this.dgvMarkaData.Size = new System.Drawing.Size(508, 203);
            this.dgvMarkaData.TabIndex = 0;
            this.dgvMarkaData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkaData_CellContentClick);
            // 
            // FormMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(769, 246);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAracInfo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMarka";
            this.Load += new System.EventHandler(this.FormMarka_Load);
            this.gbAracInfo.ResumeLayout(false);
            this.gbAracInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkaData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracInfo;
        private System.Windows.Forms.TextBox tbMarkaAdı;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMarkaData;
    }
}