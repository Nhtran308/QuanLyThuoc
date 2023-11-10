using QLThuoc.Controller;
using QLThuoc.Model;
using QLThuoc.View;
using System.Collections.Generic;

namespace QLThuoc
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuoc frmthuoc = new frmThuoc();
            this.Hide();
            frmthuoc.btnThuocLoad_Click(sender, e);
            frmthuoc.Show();
        }

        private void nhàThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmnhacungcap = new frmNhaCungCap();
            this.Hide();
            frmnhacungcap.btnNCCLoad_Click(sender, e);
            frmnhacungcap.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
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

            this.Hide();
            frmPhieuNhap.Show();
        }
    }
}