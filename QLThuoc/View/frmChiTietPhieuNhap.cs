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
            this.KeyPreview = true;
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

        private async void btnCTXuat_Click(object sender, EventArgs e)
        {
            await chiTietController.Export(dgvChiTiet);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTim.Text))
            {
                MessageBox.Show("Nhập mã phiếu để tìm");
                txtTim.Focus();
                return;
            }
            dgvChiTiet.Rows.Clear();
            ChiTietPhieuNhap chitiet = new ChiTietPhieuNhap();
            chitiet.setMaPhieuNhap(txtTim.Text);
            lstChiTiet = chiTietController.FindCTPN(chitiet);
            foreach (ChiTietPhieuNhap ct in lstChiTiet)
            {
                string[] row = { ct.getMaPhieuNhap(), ct.getMaThuoc(), ct.getSoLuong().ToString(), ct.getDonGia().ToString() };
                dgvChiTiet.Rows.Add(row);
            }
        }

        private void frmChiTietPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtTim.Clear();
                ChiTietLoad(sender, e);
            }
        }
    }
}
