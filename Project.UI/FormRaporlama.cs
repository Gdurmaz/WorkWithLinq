using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Project.Core.BusinessServices;
using Project.Core.Helper;
using Project.Core.Entities;

namespace Project.UI
{
    public partial class FormRaporlama : Form
    {
        private ReportServices reportServices;
        private ModelServices modelServices;
        private CarServices carServices;
        public FormRaporlama()
        {
            InitializeComponent();
            reportServices = new ReportServices();
            modelServices = new ModelServices();
            carServices = new CarServices();
        }

        private void FormRaporlama_Load(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            dgvRaporlama.DataSource=reportServices.Select();
            cmbYıl.DataSource = Method.GetYears();
            cmbModel.DataSource = modelServices.SelectBrandName();
            cmbMarka.DataSource = carServices.SelectModelName();
            cmbKasaTipi.DataSource = Method.GetVehicleBodies();
            cmbRenk.DataSource = Method.GetColors();
        }

        private void btnAylikKazanc_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            lbData.Items.Add("Aylık Kazancınız:"+reportServices.MonthlyIncome()+" TL'dir'");
        }

        private void btnSecilenYılaGöre_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            lbData.Items.Clear();
            object result = reportServices.SelectYears((cmbYıl.SelectedValue as Year).Years);
            if (result!=null)
            {
                lbData.Items.Add("Seçilen Yıla Göre Kazancınız" +result +" TL'dir");
            }
            else
            {
                lbData.Items.Add("Seçilen Yıla Göre Kazancınız bulunmamaktadır");
            }
        }

        private void btnModelArama_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            lbData.Items.Clear();
            object result = reportServices.SelectBrand((cmbModel.SelectedValue as Brand).ID);
            if (result != null)
            {
                lbData.Items.Add("Seçilen Markaya Göre Kazancınız" + result + " TL'dir");
            }
            else
            {
                lbData.Items.Add("Seçilen Markaya Göre Kazancınız bulunmamaktadır");
            }
        }

        private void btnMarkaArama_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            lbData.Items.Clear();
            object result = reportServices.SelectModel((cmbModel.SelectedValue as Brand).ID);
            if (result != null)
            {
                lbData.Items.Add("Seçilen Modele Göre Kazancınız" + result + " TL'dir");
            }
            else
            {
                lbData.Items.Add("Seçilen Modele Göre Kazancınız bulunmamaktadır");
            }
        }

        private void btnKasaTipineGore_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            lbData.Items.Clear();
            object result = reportServices.SelectVehicles((cmbKasaTipi.SelectedValue as VehicleBody));
            if (result != null)
            {
                lbData.Items.Add("Seçilen Yıla Göre Kazancınız" + result + " TL'dir");
            }
            else
            {
                lbData.Items.Add("Seçilen Yıla Göre Kazancınız bulunmamaktadır");
            }
        }

        private void btnRengeGore_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            lbData.Items.Clear();
            object result = reportServices.SelectColor((cmbRenk.SelectedValue as Core.Entities.Color));
            if (result != null)
            {
                lbData.Items.Add("Seçilen Yıla Göre Kazancınız" + result + " TL'dir");
            }
            else
            {
                lbData.Items.Add("Seçilen Yıla Göre Kazancınız bulunmamaktadır");
            }
        }
    }
}
