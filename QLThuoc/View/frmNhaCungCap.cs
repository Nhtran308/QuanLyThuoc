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

namespace QLThuoc.View
{
    public partial class frmNhaCungCap : Form
    {
        NhaCungCapController nccController;
        List<NhaCungCap> lstNhaCungCap;
        public frmNhaCungCap()
        {
            InitializeComponent();
            nccController = new NhaCungCapController();
        }

        public void btnNCCLoad_Click(object sender, EventArgs e)
        {
            dgvNhaCungCap.Rows.Clear();
            lstNhaCungCap = nccController.NCCLoad();
            foreach (NhaCungCap nhaCungCap in lstNhaCungCap)
            {
                string[] row = { nhaCungCap.getMaNhaCungCap(), nhaCungCap.getTenNhaCungCap(), nhaCungCap.getDiaChiNhaCungCap() };
                dgvNhaCungCap.Rows.Add(row);
            }
        }

        private void btnNCCAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text)
               || string.IsNullOrEmpty(txtTenNCC.Text)
               || string.IsNullOrEmpty(txtDiaChiNCC.Text)
               || txtMaNCC.Text == ""
               || txtTenNCC.Text == ""
               || txtDiaChiNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaNCC.Focus();
                return;
            }
            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.setMaNhaCungCap(txtMaNCC.Text);
            nhacungcap.setTenNhaCungCap(txtTenNCC.Text);
            nhacungcap.setDiaChiNhaCungCap(txtDiaChiNCC.Text);
            nccController.NCCInsert(nhacungcap);
            btnNCCLoad_Click(sender, e);
        }

        private void btnNCCEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text)
                || string.IsNullOrEmpty(txtTenNCC.Text)
                || string.IsNullOrEmpty(txtDiaChiNCC.Text))
            {
                MessageBox.Show("Không có thông tin để sửa");
                txtMaNCC.Focus();
                return;
            }
            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.setMaNhaCungCap(txtMaNCC.Text);
            nhacungcap.setTenNhaCungCap(txtTenNCC.Text);
            nhacungcap.setDiaChiNhaCungCap(txtDiaChiNCC.Text);
            nccController.NCCEdit(nhacungcap);
            btnNCCLoad_Click(sender, e);
        }

        private void btnNCCDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                MessageBox.Show("Không thể xóa");
                return;
            }
            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.setMaNhaCungCap(txtMaNCC.Text);
            nccController.NCCDelete(nhacungcap);
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            btnNCCLoad_Click(sender, e);
        }

        private void btnNCCFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                MessageBox.Show("Nhập mã thuốc để tìm");
                txtMaNCC.Focus();
                return;
            }
            dgvNhaCungCap.Rows.Clear();
            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.setMaNhaCungCap(txtMaNCC.Text);
            lstNhaCungCap = nccController.Find(nhacungcap);
            foreach (NhaCungCap nhaCungCap in lstNhaCungCap)
            {
                string[] row = { nhaCungCap.getMaNhaCungCap(), nhaCungCap.getTenNhaCungCap(), nhaCungCap.getDiaChiNhaCungCap() };
                dgvNhaCungCap.Rows.Add(row);
            }
        }

        private void btnNCCCancel_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
        }

        private void btnNCCExit_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Close();
            frmMenu.ShowDialog();
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChiNCC.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
