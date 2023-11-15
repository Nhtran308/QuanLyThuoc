using QLThuoc.Controller;
using QLThuoc.Model;
using QLThuoc.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QLThuoc.View
{
    public partial class frmPhieuNhap : Form
    {
        PhieuNhapController pnController;
        List<Thuoc> lstThuoc;

        public frmPhieuNhap()
        {
            InitializeComponent();
            pnController = new PhieuNhapController();
            txtMaNhaCungCap.Enabled = true;
            this.KeyPreview = true;
        }

        private void btnPhieuNhapCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                txtMaPhieu.Focus();
            }
            else
            {
                pnController.CTPNInsert(txtMaPhieu, txtMaHopDong, txtMaNhaCungCap, txtNhaCungCap, txtNguoiNhap, txtNgayHopDong, txtNgayNhap, dgvPhieuNhap);
            }
        }

        private void btnPhieuNhapExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PhieuNhapController.HienThiCombobox(dgvPhieuNhap);
        }

        private void dgvPhieuNhap_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.IsCurrentCellDirty)
            {
                dgvPhieuNhap.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void txtMaNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            PhieuNhapController.HienThiNhaCungCap(txtMaNhaCungCap, txtNhaCungCap);
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            PhieuNhapController.HienThiPhieuNhap(txtMaPhieu, txtMaHopDong, txtMaNhaCungCap, txtNhaCungCap, txtNguoiNhap, txtNgayHopDong, txtNgayNhap);
        }

        private void frmPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtMaPhieu.Clear();
                txtMaHopDong.Clear();
                txtMaNhaCungCap.Clear();
                txtNhaCungCap.Clear();
                txtNguoiNhap.Clear();
                txtNgayHopDong.Clear();
                txtNgayNhap.Clear();
                dgvPhieuNhap.Rows.Clear();
            }
        }

        private void dgvPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietPhieuNhap frmChiTiet = new frmChiTietPhieuNhap();
            DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)frmChiTiet.dgvChiTiet.Columns["maPhieu"];
            ChiTietController ctController = new ChiTietController();
            List<ChiTietPhieuNhap> ct = ctController.Combobox();
            foreach (ChiTietPhieuNhap ctpn in ct)
            {
                string maPhieu = ctpn.getMaPhieuNhap();
                combo.Items.Add(maPhieu);
            }
            frmChiTiet.ShowDialog();
            
        }
    }
}
