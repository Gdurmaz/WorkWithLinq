using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Project.Core.Helper;
using Project.Core.Entities;
using Project.Core.BusinessServices;
using Project.UI.Error;

namespace Project.UI
{
    public partial class FormAraba : Form
    {
        private CarServices carServices;
        public FormAraba()
        {
            InitializeComponent();
            carServices = new CarServices();
        }

        private void FormAraba_Load(object sender, EventArgs e)
        {
            cmbKasaTipi.DataSource = Method.GetVehicleBodies();
            cmbRenk.DataSource = Method.GetColors();
            cmbYil.DataSource = Method.GetYears();
            cmbModelAdı.DataSource = carServices.SelectModelName();
            dgvAracData.DataSource = carServices.Select();
            dgvAracData.Columns[0].HeaderText = "ID";
            dgvAracData.Columns[1].HeaderText = "Marka Adı";
            dgvAracData.Columns[2].HeaderText = "Model Adı";
            dgvAracData.Columns[3].HeaderText = "Kasa Tipi";
            dgvAracData.Columns[4].HeaderText = "Renk";
            dgvAracData.Columns[5].HeaderText = "Yıl";
            dgvAracData.Columns[6].HeaderText = "Satış Fiyatı";
            dgvAracData.Columns[7].HeaderText = "Kiralık Mı";
        }

        private void cmbModelAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModelAdı.SelectedIndex!=-1)
            {
                string worth = carServices.SelectBrandName((cmbModelAdı.SelectedValue as Model).Brand_ID).ToString();
                if (worth!=null)
                {
                    tbMarkaAdi.Text = worth;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSatisFiyati.Text))
            {
                var controlcar = carServices.Control((cmbModelAdı.SelectedValue as Model).Name, tbMarkaAdi.Text,
                    (cmbKasaTipi.SelectedValue as VehicleBody), (cmbRenk.SelectedValue as Core.Entities.Color), 
                    (cmbYil.SelectedValue as Year).Years);
                if (controlcar>0)
                {
                    MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitOncedenEklenmis)));
                }
                else
                {
                    var insert = carServices.Insert(new Car() {
                        Model_ID = (cmbModelAdı.SelectedValue as Model).ID,
                        BodyType = (cmbKasaTipi.SelectedValue as VehicleBody),
                        ColorID= (cmbRenk.SelectedValue as Core.Entities.Color),
                        Years = (cmbYil.SelectedValue as Year).Years,
                        SalePrice = Convert.ToDecimal(tbSatisFiyati.Text),
                        IsRental = checkKiralık.Checked
                    });
                    if (insert>0)
                    {
                        MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitEklendi)));
                        dgvAracData.DataSource = carServices.Select();
                    }
                    else
                    {
                        MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitEklenmedi)));
                        dgvAracData.DataSource = carServices.Select();

                    }
                }
            }
            else
            {

            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var controlcar = carServices.Control((cmbModelAdı.SelectedValue as Model).Name, tbMarkaAdi.Text,
                    (cmbKasaTipi.SelectedValue as VehicleBody), (cmbRenk.SelectedValue as Core.Entities.Color),
                    (cmbYil.SelectedValue as Year).Years);
            if (controlcar > 0)
            {
                MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitOncedenEklenmis)));
            }
            else
            {
                var updatedID = carServices.Find(Convert.ToInt32(dgvAracData.CurrentRow.Cells[0].Value.ToString()));
                if (updatedID!=null)
                {
                    var update = carServices.Update(new Car()
                    {
                        Model_ID =updatedID.Model_ID =(cmbModelAdı.SelectedValue as Model).ID,
                        BodyType = updatedID.BodyType = (cmbKasaTipi.SelectedValue as VehicleBody),
                        ColorID = updatedID.ColorID = (cmbRenk.SelectedValue as Core.Entities.Color),
                        Years = updatedID.Years = (cmbYil.SelectedValue as Year).Years,
                        SalePrice = updatedID.SalePrice = Convert.ToDecimal(tbSatisFiyati.Text),
                        IsRental = updatedID.IsRental = checkKiralık.Checked
                    });
                    if (update > 0)
                    {
                        MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitGuncellendi)));
                        dgvAracData.DataSource = carServices.Select();
                    }
                    else
                    {
                        MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitGuncellendi)));
                        dgvAracData.DataSource = carServices.Select();
                    }
                }
                else
                {
                    MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitBulunamadı)));
                }

            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            var controlcar = carServices.Control((cmbModelAdı.SelectedValue as Model).Name, tbMarkaAdi.Text,
                    (cmbKasaTipi.SelectedValue as VehicleBody), (cmbRenk.SelectedValue as Core.Entities.Color),
                    (cmbYil.SelectedValue as Year).Years);
            if (controlcar > 0)
            {
                MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitOncedenEklenmis)));
            }
            else
            {
                var deleteID = carServices.Find(Convert.ToInt32(dgvAracData.CurrentRow.Cells[0].Value.ToString()));
                if (deleteID != null)
                {
                    var delete = carServices.Delete(deleteID);
                    if (delete > 0)
                    {
                        MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitSilindi)));
                        dgvAracData.DataSource = carServices.Select();
                    }
                    else
                    {
                        MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitSilinmedi)));
                        dgvAracData.DataSource = carServices.Select();
                    }
                }
                else
                {
                    MessageBox.Show(Error.UserError.ErrorMessage(Convert.ToInt32(Error.UserError.ErrorCode.KayitBulunamadı)));
                }

            }
        }
        private void tbSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    if (e.KeyChar == (','))
                    {
                        e.Handled = false;
                        if (tbSatisFiyati.Text.IndexOf(',') != -1)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    if (e.KeyChar == (','))
                    {
                        e.Handled = false;
                        if (tbSatisFiyati.Text.IndexOf(',') != -1)
                        {
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
