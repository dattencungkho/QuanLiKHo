using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuctapQLK.Gui
{
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void rdb_hh_CheckedChanged(object sender, EventArgs e)
        {
            dgvtkhh.DataSource = BUS.BUS.tk_hh();
        }

        private void rdb_nhap_CheckedChanged(object sender, EventArgs e)
        {
            dgvtkhh.DataSource = BUS.BUS.tk_nhap();
        }

        private void rdb_xuat_CheckedChanged(object sender, EventArgs e)
        {
            dgvtkhh.DataSource = BUS.BUS.tk_xuat();
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
