namespace Project.UI
{
    partial class FormModel
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
            this.tbModelAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvModelData = new System.Windows.Forms.DataGridView();
            this.cmbMarkaAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAracInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAracInfo
            // 
            this.gbAracInfo.Controls.Add(this.cmbMarkaAdi);
            this.gbAracInfo.Controls.Add(this.label1);
            this.gbAracInfo.Controls.Add(this.tbModelAdi);
            this.gbAracInfo.Controls.Add(this.btnSil);
            this.gbAracInfo.Controls.Add(this.btnGuncelle);
            this.gbAracInfo.Controls.Add(this.btnKaydet);
            this.gbAracInfo.Controls.Add(this.label2);
            this.gbAracInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAracInfo.Location = new System.Drawing.Point(12, 12);
            this.gbAracInfo.Name = "gbAracInfo";
            this.gbAracInfo.Size = new System.Drawing.Size(229, 194);
            this.gbAracInfo.TabIndex = 8;
            this.gbAracInfo.TabStop = false;
            // 
            // tbModelAdi
            // 
            this.tbModelAdi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbModelAdi.Location = new System.Drawing.Point(85, 27);
            this.tbModelAdi.Name = "tbModelAdi";
            this.tbModelAdi.Size = new System.Drawing.Size(120, 22);
            this.tbModelAdi.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Azure;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(85, 156);
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
            this.btnGuncelle.Location = new System.Drawing.Point(85, 124);
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
            this.btnKaydet.Location = new System.Drawing.Point(85, 93);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 25);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvModelData);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 201);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dgvModelData
            // 
            this.dgvModelData.AllowUserToAddRows = false;
            this.dgvModelData.AllowUserToDeleteRows = false;
            this.dgvModelData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModelData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModelData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvModelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModelData.Location = new System.Drawing.Point(3, 18);
            this.dgvModelData.Name = "dgvModelData";
            this.dgvModelData.ReadOnly = true;
            this.dgvModelData.Size = new System.Drawing.Size(508, 180);
            this.dgvModelData.TabIndex = 0;
            this.dgvModelData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModelData_CellContentClick);
            // 
            // cmbMarkaAdi
            // 
            this.cmbMarkaAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarkaAdi.FormattingEnabled = true;
            this.cmbMarkaAdi.Location = new System.Drawing.Point(84, 55);
            this.cmbMarkaAdi.Name = "cmbMarkaAdi";
            this.cmbMarkaAdi.Size = new System.Drawing.Size(121, 22);
            this.cmbMarkaAdi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marka Adı";
            // 
            // FormModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(770, 222);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAracInfo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormModel";
            this.Load += new System.EventHandler(this.FormModel_Load);
            this.gbAracInfo.ResumeLayout(false);
            this.gbAracInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAracInfo;
        private System.Windows.Forms.TextBox tbModelAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvModelData;
        private System.Windows.Forms.ComboBox cmbMarkaAdi;
        private System.Windows.Forms.Label label1;
    }
}