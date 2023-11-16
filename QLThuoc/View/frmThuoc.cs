using QLThuoc.Controller;
using QLThuoc.Model;

namespace QLThuoc.View
{
    public partial class frmThuoc : Form
    {
        ThuocController thuocController;
        List<Thuoc> lstThuoc;
        public frmThuoc()
        {
            InitializeComponent();
            thuocController = new ThuocController();
            this.KeyPreview = true;
        }

        //Hàm hiển thị thuốc
        public void ThuocLoad(object sender, EventArgs e)
        {
            dgvThuoc.Rows.Clear();
            lstThuoc = thuocController.ThuocLoad();
            foreach (Thuoc thuoc in lstThuoc)
            {
                string[] row = { thuoc.getMaThuoc(), thuoc.getTenThuoc(), thuoc.getDonViTinh(), thuoc.getSoLuong().ToString(), thuoc.getDonGia().ToString() };
                dgvThuoc.Rows.Add(row);
            }
        }

        //Nút thêm thuốc
        private void btnThuocAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text)
               || string.IsNullOrEmpty(txtTenThuoc.Text)
               || string.IsNullOrEmpty(txtDonViTinh.Text)
               || string.IsNullOrEmpty(txtSoLuong.Text)
               || string.IsNullOrEmpty(txtDonGia.Text)
               || txtMaThuoc.Text == ""
               || txtTenThuoc.Text == ""
               || txtDonViTinh.Text == ""
               || txtSoLuong.Text == ""
               || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtMaThuoc.Focus();
                return;
            }
            Thuoc thuoc = new Thuoc();
            thuoc.setMaThuoc(txtMaThuoc.Text);
            thuoc.setTenThuoc(txtTenThuoc.Text);
            thuoc.setDonViTinh(txtDonViTinh.Text);
            thuoc.setSoLuong(int.Parse(txtSoLuong.Text));
            thuoc.setDonGia(float.Parse(txtDonGia.Text));
            thuocController.ThuocInsert(thuoc);
            ThuocLoad(sender, e);
        }

        //Nút sửa thông tin thuốc
        private void btnThuocEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text)
              || string.IsNullOrEmpty(txtTenThuoc.Text)
              || string.IsNullOrEmpty(txtDonViTinh.Text)
              || string.IsNullOrEmpty(txtSoLuong.Text)
              || string.IsNullOrEmpty(txtDonGia.Text)
              || txtMaThuoc.Text == ""
              || txtTenThuoc.Text == ""
              || txtDonViTinh.Text == ""
              || txtSoLuong.Text == ""
              || txtDonGia.Text == "")
            {
                MessageBox.Show("Không có thông tin để sửa");
                txtMaThuoc.Focus();
                return;
            }
            Thuoc thuoc = new Thuoc();
            thuoc.setTenThuoc(txtTenThuoc.Text);
            thuoc.setDonViTinh(txtDonViTinh.Text);
            thuoc.setSoLuong(int.Parse(txtSoLuong.Text));
            thuoc.setDonGia(float.Parse(txtDonGia.Text));
            thuoc.setMaThuoc(txtMaThuoc.Text);
            thuocController.ThuocEdit(thuoc);
            ThuocLoad(sender, e);
        }

        //Nút xóa thuốc
        private void btnThuocDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Không có thông tin để xóa");
                return;
            }
            Thuoc thuoc = new Thuoc();
            thuoc.setMaThuoc(txtMaThuoc.Text);
            thuocController.ThuocDelete(thuoc);
            txtMaThuoc.Clear();
            txtTenThuoc.Clear();
            txtDonViTinh.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            ThuocLoad(sender, e);
        }

        //Nút tìm thuốc
        private void btnThuocFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuoc.Text))
            {
                MessageBox.Show("Nhập mã thuốc để tìm");
                txtMaThuoc.Focus();
                return;
            }
            dgvThuoc.Rows.Clear();
            Thuoc thuoc = new Thuoc();
            thuoc.setMaThuoc(txtMaThuoc.Text);
            lstThuoc = thuocController.ThuocFind(thuoc);
            foreach (Thuoc t in lstThuoc)
            {
                string[] row = { t.getMaThuoc(), t.getTenThuoc(), t.getDonViTinh(), t.getSoLuong().ToString(), t.getDonGia().ToString() };
                dgvThuoc.Rows.Add(row);
            }
        }

        //Nút thoát
        private void btnThuocExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Nút hiển thị giá trị lên textbox khi chọn ô datagridview
        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThuoc.Rows[e.RowIndex];
                txtMaThuoc.Text = row.Cells[0].Value.ToString();
                txtTenThuoc.Text = row.Cells[1].Value.ToString();
                txtDonViTinh.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[4].Value.ToString();
            }
        }

        //Khi bấm Esc dữ liệu hiển thị trên textbox và datagridview bị xóa
        private void frmThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtMaThuoc.Clear();
                txtTenThuoc.Clear();
                txtDonViTinh.Clear();
                txtSoLuong.Clear();
                txtDonGia.Clear();
                ThuocLoad(sender, e);
            }
        }
    }
}
