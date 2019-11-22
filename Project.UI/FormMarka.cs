using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Core.BusinessServices;
using Project.Core.Entities;
using Project.UI.Error;

namespace Project.UI
{
    public partial class FormMarka : Form
    {
        private BrandServices brandServices;
        private int result = 0;
        public FormMarka()
        {
            InitializeComponent();
            brandServices = new BrandServices();
        }
        private void FormMarka_Load(object sender, EventArgs e)
        {
            dgvMarkaData.DataSource = brandServices.Select();
            dgvMarkaData.Columns[0].HeaderText = "Marka ID";
            dgvMarkaData.Columns[1].HeaderText = "Marka Adı";
            dgvMarkaData.Columns[2].Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbMarkaAdı.Text))
            {
                var controlname = brandServices.Count(tbMarkaAdı.Text);
                if (controlname>0)
                {
                    MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitOncedenEklenmis))}");
                }
                else
                {
                    result = brandServices.Insert(new Brand()
                    {
                        Name = tbMarkaAdı.Text.ToUpper(),
                    });
                    if (result > 0)
                    {
                        MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitEklendi))}");
                        dgvMarkaData.DataSource = brandServices.Select();
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
            if (!string.IsNullOrEmpty(tbMarkaAdı.Text))
            {
                //Aynı isimli marka eklenmemesi için  kontrol
                var controlname = brandServices.Count(tbMarkaAdı.Text);
                if (controlname > 0)
                {
                    MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitOncedenEklenmis))}");
                }
                else
                {
                    var update = brandServices.Find(Convert.ToInt32(dgvMarkaData.CurrentRow.Cells[0].Value.ToString()));
                    if (update != null)
                    {
                        result = brandServices.Update(new Brand()
                        {
                            Name = update.Name = tbMarkaAdı.Text.ToUpper(),
                        });
                        if (result > 0)
                        {
                            MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitGuncellendi))}");
                            dgvMarkaData.DataSource = brandServices.Select();
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
            if (!string.IsNullOrEmpty(tbMarkaAdı.Text))
            {
                var delete = brandServices.Find(Convert.ToInt32(dgvMarkaData.CurrentRow.Cells[0].Value.ToString()));
                if (delete != null)
                {
                    result = brandServices.Delete(delete);
                    if (result > 0)
                    {
                        MessageBox.Show($"{UserError.ErrorMessage(Convert.ToInt32(UserError.ErrorCode.KayitSilindi))}");
                        dgvMarkaData.DataSource = brandServices.Select();
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
        private void dgvMarkaData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMarkaAdı.Text = dgvMarkaData.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
