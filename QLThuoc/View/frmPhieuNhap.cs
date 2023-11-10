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
        }

        private void btnPhieuNhapSave_Click(object sender, EventArgs e)
        {
            pnController.CTPNInsert(txtMaPhieu, dgvPhieuNhap);
        }

        private void btnPhieuNhapCancel_Click(object sender, EventArgs e)
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

        private void btnPhieuNhapExit_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
            frmMenu.ShowDialog();
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

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            PhieuNhapController.HienThiPhieuNhap(txtMaPhieu, txtMaHopDong, txtMaNhaCungCap, txtNhaCungCap, txtNguoiNhap, txtNgayHopDong, txtNgayNhap);
        }
    }
}
