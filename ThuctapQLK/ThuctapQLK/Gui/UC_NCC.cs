using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuctapQLK.DT0;
using ThuctapQLK.BUS;

namespace ThuctapQLK.Gui
{
    public partial class UC_NCC : UserControl
    {
        
        public UC_NCC()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgvNCC.DataSource = BUS.BUS.xuat_ncc();
        }
        private void NCC_Load(object sender, EventArgs e)
        {
            xuat();
        }
        private void dgvnhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txt_tenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
           
            txt_diaChi.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
             txt_SDT.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
             txt_email.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txt_maNCC.Text = string.Empty;
            txt_tenNCC.Text = string.Empty;
           
            txt_diaChi.Text = string.Empty;
            txt_SDT.Text = string.Empty;
            txt_email.Text = string.Empty;

     
       

        }

       private void btnsua_Click(object sender, EventArgs e)
        {
            if ( txt_SDT.Text == "" || txt_email.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            NCC a = new NCC();
            a.MaNCC = txt_maNCC.Text;
            a.TenNCC = txt_tenNCC.Text;
            a.DiaChi = txt_diaChi.Text;
            a.SoDT = txt_SDT.Text;
            a.Email = txt_email.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn sửa ma ncc {0} ", a.MaNCC),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BUS.BUS.sua_NCC(a) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    NCC_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }

            
       }

       private void btnluu_Click(object sender, EventArgs e)
       {
           if (txt_maNCC.Text == " " || txt_tenNCC.Text == " ")
           {
               MessageBox.Show("Hihi");
               return;
           }
           NCC a = new NCC();
           a.MaNCC = txt_maNCC.Text;
           a.TenNCC = txt_tenNCC.Text;
           a.DiaChi = txt_diaChi.Text;
           a.SoDT = txt_SDT.Text;
           a.Email = txt_email.Text;
           if (MessageBox.Show(string.Format("Ban co muon them ncc {0} tên ncc {1}", a.MaNCC, a.TenNCC), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {

               if (BUS.BUS.them_NCC(a) > 0)
               {
                   MessageBox.Show("Them thanh cong");
                   NCC_Load(sender, e);
               }
               else
               { MessageBox.Show("Loi"); }
           }
       }

       private void btnxoa_Click(object sender, EventArgs e)
       {
           if (txt_maNCC.Text == "" || txt_tenNCC.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            NCC a = new NCC();
           a.MaNCC = txtmaNCC.Text;
           a.TenNCC = txt_tenNCC.Text;
           a.DiaChi = txt_diaChi.Text;
           a.SoDT = txt_SDT.Text;
           a.Email = txt_email.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa vị trí kệ sách {0} ", a.MaNCC),
                                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BUS.BUS.xoa_NCC(a) > 0)

                {
                    MessageBox.Show("Xóa thành công!");
                    NCC_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }


       }
    }

