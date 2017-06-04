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
    public partial class UC_HangHoa : UserControl
    {
        public UC_HangHoa()
        {
            InitializeComponent();
        }
        private void xuat()
        {
            dgvhangHoa.DataSource = BUS.BUS.xuat_hh();
        }
        private void HangHoa_Load(object sender, EventArgs e)
        {
            xuat();
        }
        private void dgvhangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaHH.Text = dgvhangHoa.CurrentRow.Cells[0].Value.ToString();
            txttenHH.Text = dgvhangHoa.CurrentRow.Cells[1].Value.ToString();
            txtnhaCC.Text = dgvhangHoa.CurrentRow.Cells[2].Value.ToString();
         //   dgvhangHoa.DataSource = BUS.BUS.xuat_ctn(txtsoLuong.Text);
         //  txtsoLuong.Text = dgvhangHoa.CurrentRow.Cells[3].Value.ToString();
           //.DataSource = BUS.BUS.xuat_ctn(txtsoLuong.Text);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmaHH.Text = string.Empty;
            txttenHH.Text = string.Empty;

            txtnhaCC.Text = string.Empty;
            txtsoLuong.Text = string.Empty;
            

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmaHH.Text == " " || txttenHH.Text == " ")
            {
                MessageBox.Show("Hihi");
                return;
            }
            HangHoa a = new HangHoa();
            a.MaHH = txtmaHH.Text;
            a.TenHH = txttenHH.Text;
            a.MaNCC = txtnhaCC.Text;
            a.SoLuong = txtsoLuong.Text;

            if (MessageBox.Show(string.Format("Ban co muon them ncc {0} tên ncc {1}", a.MaHH, a.TenHH), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (BUS.BUS.them_HH(a) > 0)
                {
                    MessageBox.Show("Them thanh cong");
                    HangHoa_Load(sender, e);
                }
                else
                { MessageBox.Show("Loi"); }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmaHH.Text == "" || txttenHH.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            HangHoa a = new HangHoa();
            a.MaHH = txtmaHH.Text;
            a.TenHH = txttenHH.Text;
            a.MaNCC = txtnhaCC.Text;
            a.SoLuong = txtsoLuong.Text;
            

            if (MessageBox.Show(string.Format("Bạn có muốn sửa ma hh {0} ", a.MaHH),
                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BUS.BUS.sua_HH(a) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    HangHoa_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }

            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmaHH.Text == "" || txttenHH.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            HangHoa a = new HangHoa();
            a.MaHH = txtmaHH.Text;
            a.TenHH = txttenHH.Text;
            a.MaNCC = txtnhaCC.Text;
            a.SoLuong = txtsoLuong.Text;

            if (MessageBox.Show(string.Format("Bạn có muốn xóa vị trí mã {0} ", a.MaNCC),
                                "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BUS.BUS.xoa_HH(a) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    HangHoa_Load(sender, e);
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
