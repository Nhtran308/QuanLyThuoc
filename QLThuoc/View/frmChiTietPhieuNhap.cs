using QLThuoc.Controller;
using QLThuoc.Model;

namespace QLThuoc.View
{
    public partial class frmChiTietPhieuNhap : Form
    {
        ChiTietController chiTietController;
        List<ChiTietPhieuNhap> lstChiTiet;
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
            KeyPreview = true;
            chiTietController = new ChiTietController();
        }

        //Hàm sử dụng hàm hiển thị tại Controller
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

        //Nút xuất
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

        //Hàm khi bấm nút Esc thì xóa các dữ liệu hiển thị trên datagridview
        private void frmChiTietPhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtTim.Clear();
                dgvChiTiet.Rows.Clear();
            }
        }

        //Hàm tải dữ liệu sau khi giá trị trong combobox thay đổi
        private void dgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietController.HienThiCombobox(dgvChiTiet);
        }

        //Hàm xử lý dữ liệu khi ô thay đổi giá trị
        private void dgvChiTiet_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvChiTiet.IsCurrentCellDirty)
            {
                dgvChiTiet.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
