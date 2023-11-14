using QLThuoc.Controller;
using QLThuoc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLThuoc.View
{
    public partial class frmChiTietPhieuNhap : Form
    {
        ChiTietController chiTietController;
        List<ChiTietPhieuNhap> lstChiTiet;
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
            chiTietController = new ChiTietController();
        }
        public void ChiTietLoad(object sender, EventArgs e)
        {
            dgvChiTiet.Rows.Clear();
            lstChiTiet = chiTietController.LoadCTPN();
            foreach (ChiTietPhieuNhap ct in lstChiTiet)
            {
                string[] row = { ct.getMaPhieuNhap(), ct.getMaThuoc(), ct.getSoLuong().ToString(), ct.getDonGia().ToString() };
                dgvChiTiet.Rows.Add(row);
            }
        }
        private void btnChiTietExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCTXuat_Click(object sender, EventArgs e)
        {
            await chiTietController.Export(dgvChiTiet);
        }
    }
}
