using QLThuoc.Controller;
using QLThuoc.Model;
using QLThuoc.View;
using System.Collections.Generic;

namespace QLThuoc
{
    public partial class frmMenu : Form
    {
        ThuocController thuocController;
        List<Thuoc> lstThuoc;
        public frmMenu()
        {
            InitializeComponent();
            thuocController = new ThuocController();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuoc frmthuoc = new frmThuoc();
            frmthuoc.ThuocLoad(sender, e);
            frmthuoc.dgvThuoc.ReadOnly = true;
            frmthuoc.Show();
        }

        private void nhàThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmnhacungcap = new frmNhaCungCap();
            frmnhacungcap.NCCLoad(sender, e);
            frmnhacungcap.dgvNhaCungCap.ReadOnly = true;
            frmnhacungcap.Show();
        }

        private void thêmPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmPhieuNhap = new frmPhieuNhap();
            DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)frmPhieuNhap.dgvPhieuNhap.Columns["maThuoc"];
            PhieuNhapController pnController = new PhieuNhapController();
            List<Thuoc> thuoc = pnController.Combobox();

            foreach (Thuoc t in thuoc)
            {
                string maThuoc = t.getMaThuoc();
                combo.Items.Add(maThuoc);
            }
            frmPhieuNhap.Show();
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuNhap frmChiTiet = new frmChiTietPhieuNhap();
            frmChiTiet.ChiTietLoad(sender, e);
            frmChiTiet.dgvChiTiet.ReadOnly = true;
            frmChiTiet.Show();
        }
    }
}