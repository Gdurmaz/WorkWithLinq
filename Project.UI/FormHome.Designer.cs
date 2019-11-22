namespace Project.UI
{
    partial class FormHome
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRaporlamaMenu = new System.Windows.Forms.Button();
            this.btnArabaMenu = new System.Windows.Forms.Button();
            this.btnModelMenu = new System.Windows.Forms.Button();
            this.btnMarkaMenu = new System.Windows.Forms.Button();
            this.pnlTaskBar = new System.Windows.Forms.Panel();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuBar.SuspendLayout();
            this.pnlTaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(135, 41);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(896, 437);
            this.pnlBody.TabIndex = 0;
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.Azure;
            this.pnlMenuBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenuBar.Controls.Add(this.label1);
            this.pnlMenuBar.Controls.Add(this.btnRaporlamaMenu);
            this.pnlMenuBar.Controls.Add(this.btnArabaMenu);
            this.pnlMenuBar.Controls.Add(this.btnModelMenu);
            this.pnlMenuBar.Controls.Add(this.btnMarkaMenu);
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 30);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(135, 460);
            this.pnlMenuBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnRaporlamaMenu
            // 
            this.btnRaporlamaMenu.BackColor = System.Drawing.Color.Azure;
            this.btnRaporlamaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlamaMenu.Location = new System.Drawing.Point(10, 105);
            this.btnRaporlamaMenu.Name = "btnRaporlamaMenu";
            this.btnRaporlamaMenu.Size = new System.Drawing.Size(117, 23);
            this.btnRaporlamaMenu.TabIndex = 0;
            this.btnRaporlamaMenu.Text = "Raporlama Menu";
            this.btnRaporlamaMenu.UseVisualStyleBackColor = false;
            this.btnRaporlamaMenu.Click += new System.EventHandler(this.btnRaporlamaMenu_Click);
            // 
            // btnArabaMenu
            // 
            this.btnArabaMenu.BackColor = System.Drawing.Color.Azure;
            this.btnArabaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArabaMenu.Location = new System.Drawing.Point(10, 76);
            this.btnArabaMenu.Name = "btnArabaMenu";
            this.btnArabaMenu.Size = new System.Drawing.Size(117, 23);
            this.btnArabaMenu.TabIndex = 0;
            this.btnArabaMenu.Text = "Araba Menu";
            this.btnArabaMenu.UseVisualStyleBackColor = false;
            this.btnArabaMenu.Click += new System.EventHandler(this.btnArabaMenu_Click);
            // 
            // btnModelMenu
            // 
            this.btnModelMenu.BackColor = System.Drawing.Color.Azure;
            this.btnModelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelMenu.Location = new System.Drawing.Point(10, 47);
            this.btnModelMenu.Name = "btnModelMenu";
            this.btnModelMenu.Size = new System.Drawing.Size(117, 23);
            this.btnModelMenu.TabIndex = 0;
            this.btnModelMenu.Text = "Model Menu";
            this.btnModelMenu.UseVisualStyleBackColor = false;
            this.btnModelMenu.Click += new System.EventHandler(this.btnModelMenu_Click);
            // 
            // btnMarkaMenu
            // 
            this.btnMarkaMenu.BackColor = System.Drawing.Color.Azure;
            this.btnMarkaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaMenu.Location = new System.Drawing.Point(10, 18);
            this.btnMarkaMenu.Name = "btnMarkaMenu";
            this.btnMarkaMenu.Size = new System.Drawing.Size(117, 23);
            this.btnMarkaMenu.TabIndex = 0;
            this.btnMarkaMenu.Text = "Marka Menu";
            this.btnMarkaMenu.UseVisualStyleBackColor = false;
            this.btnMarkaMenu.Click += new System.EventHandler(this.btnMarkaMenu_Click);
            // 
            // pnlTaskBar
            // 
            this.pnlTaskBar.BackColor = System.Drawing.Color.Azure;
            this.pnlTaskBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTaskBar.Controls.Add(this.btnKucult);
            this.pnlTaskBar.Controls.Add(this.btnKapat);
            this.pnlTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTaskBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskBar.Name = "pnlTaskBar";
            this.pnlTaskBar.Size = new System.Drawing.Size(1035, 40);
            this.pnlTaskBar.TabIndex = 2;
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.Azure;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Location = new System.Drawing.Point(958, 3);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(32, 30);
            this.btnKucult.TabIndex = 3;
            this.btnKucult.Text = "__";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Azure;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(996, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(32, 30);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1035, 490);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTaskBar);
            this.Controls.Add(this.pnlMenuBar);
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.pnlTaskBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Panel pnlTaskBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporlamaMenu;
        private System.Windows.Forms.Button btnArabaMenu;
        private System.Windows.Forms.Button btnModelMenu;
        private System.Windows.Forms.Button btnMarkaMenu;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Timer tmrZaman;
    }
}