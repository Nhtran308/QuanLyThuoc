using QLThuoc.Controller;
using QLThuoc.Model;

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
            KeyPreview = true;
        }

        //Hàm hiển thị nhà cung cấp
        public void NCCLoad(object sender, EventArgs e)
        {
            dgvNhaCungCap.Rows.Clear();
            lstNhaCungCap = nccController.NCCLoad();
            foreach (NhaCungCap nhaCungCap in lstNhaCungCap)
            {
                string[] row = { nhaCungCap.getMaNhaCungCap(), nhaCungCap.getTenNhaCungCap(), nhaCungCap.getDiaChiNhaCungCap() };
                dgvNhaCungCap.Rows.Add(row);
            }
        }

        //Nút thêm nhà cung cấp
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
            NCCLoad(sender, e);
        }

        //Nút sửa thông tin nhà cung cấp
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
            NCCLoad(sender, e);
        }

        //Nút xóa nhà cung cấp
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
            NCCLoad(sender, e);
        }

        //Nút tìm nhà cung cấp
        private void btnNCCFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                MessageBox.Show("Nhập mã nhà cung cấp để tìm");
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

        //Nút thoát
        private void btnNCCExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hàm hiển thị dữ liệu lên textbox khi bấm vào ô datagridview
        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChiNCC.Text = row.Cells[2].Value.ToString();
            }
        }

        //Khi bấm nút Esc sẽ xóa dữ liệu hiển thị trên txt và dgv
        private void frmNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtDiaChiNCC.Clear();
                NCCLoad(sender, e);
            }
        }
    }
}
