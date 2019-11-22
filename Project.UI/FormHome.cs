using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            
        }
        private void btnMarkaMenu_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            FormMarka form = new FormMarka();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.MdiParent = form.MdiParent;
            pnlBody.Controls.Add(form);
            form.Show();
        }

        private void btnModelMenu_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            FormModel form = new FormModel();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.MdiParent = form.MdiParent;
            pnlBody.Controls.Add(form);
            form.Show();
        }

        private void btnArabaMenu_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            FormAraba form = new FormAraba();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.MdiParent = form.MdiParent;
            pnlBody.Controls.Add(form);
            form.Show();
        }

        private void btnRaporlamaMenu_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            FormRaporlama form = new FormRaporlama();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.MdiParent = form.MdiParent;
            pnlBody.Controls.Add(form);
            form.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            tmrZaman.Interval = 1000;
            tmrZaman.Tick += TmrZaman_Tick;
            tmrZaman.Start();
        }

        private void TmrZaman_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy  hh:mm");
        }
    }
}
