using System;
using System.Windows.Forms;
using Project.Core.BusinessServices;
using Project.Core.Entities;
using Project.UI.Error;

namespace Project.UI
{
    public partial class FormModel : Form
    {
        private ModelServices modelServices;
        private int result = 0;
        public FormModel()
        {
            InitializeComponent();
            modelServices = new ModelServices();
        }
        private void FormModel_Load(object sender, EventArgs e)
        {
            cmbMarkaAdi.DataSource = modelServices.SelectBrandName();
            dgvModelData.DataSource = modelServices.Select();
            dgvModelData.Columns[0].HeaderText = "Model ID";
            dgvModelData.Columns[1].HeaderText = "Model Adı";
            dgvModelData.Columns[2].HeaderText = "Marka Adı";

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbModelAdi.Text))
            {
                var controlname = modelServices.Count(tbModelAdi.Text.ToUpper(),(cmbMarkaAdi.SelectedValue as Brand).ID);
                if (controlname>0)
                {
                    MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitOncedenEklenmis))}");
                }
                else
                {
                    result = modelServices.Insert(new Model()
                    {
                        Name = tbModelAdi.Text.ToUpper(),
                        Brand_ID = cmbMarkaAdi.SelectedIndex
                    });
                    if (result > 0)
                    {
                        MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitEklendi))}");
                        dgvModelData.DataSource = modelServices.Select();
                    }
                    else
                    {
                        MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitEklenmedi))}");
                    }
                }
            }
            else
            {
                MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.BosAlan))}");
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbModelAdi.Text))
            {
                var controlname = modelServices.Count(tbModelAdi.Text, (cmbMarkaAdi.SelectedValue as Brand).ID);
                if (controlname > 0)
                {
                    MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitOncedenEklenmis))}");
                }
                else
                {
                    var update = modelServices.Find(Convert.ToInt32(dgvModelData.CurrentRow.Cells[0].Value.ToString()));
                    var updateBrand = modelServices.FindBrandID((cmbMarkaAdi.SelectedValue as Brand).ID);
                    if (update != null)
                    {
                        result = modelServices.Update(new Model()
                        {
                            Name = update.Name = tbModelAdi.Text.ToUpper(),
                            Brand_ID= update.Brand_ID = (cmbMarkaAdi.SelectedValue as Brand).ID
                        });
                        if (result > 0)
                        {
                            MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitGuncellendi))}");
                            dgvModelData.DataSource = modelServices.Select();
                        }
                        else
                        {
                            MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitGüncellenmedi))}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitBulunamadı))}");
                    }
                }
                
            }
            else
            {
                MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.BosAlan))}");
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbModelAdi.Text))
            {
                var delete = modelServices.Find(Convert.ToInt32(dgvModelData.CurrentRow.Cells[0].Value.ToString()));
                if (delete != null)
                {
                    result = modelServices.Delete(delete);
                    if (result > 0)
                    {
                        MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitSilindi))}");
                        dgvModelData.DataSource = modelServices.Select();
                    }
                    else
                    {
                        MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitSilinmedi))}");
                    }
                }
                else
                {
                    MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitBulunamadı))}");
                }
            }
            else
            {
                MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.BosAlan))}");
            }
        }
        private void dgvModelData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbModelAdi.Text = dgvModelData.CurrentRow.Cells[1].Value.ToString();
            cmbMarkaAdi.Text = dgvModelData.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
