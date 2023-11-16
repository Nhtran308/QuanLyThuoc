using QLThuoc.Controller;
using QLThuoc.Model;

namespace QLThuoc.View
{
    public partial class frmPhieuNhap : Form
    {
        PhieuNhapController pnController;

        public frmPhieuNhap()
        {
            InitializeComponent();
            pnController = new PhieuNhapController();
            txtMaNhaCungCap.Enabled = true;
            KeyPreview = true;
        }

        //Nút tạo phiếu nhập mới
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

        //Nút thoát
        private void btnPhieuNhapExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Khi giá trị trong ô datagridview thay đổi thì tải dữ liệu lên đó
        private void dgvPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PhieuNhapController.HienThiCombobox(dgvPhieuNhap);
        }

        //Hàm xử lý dữ liệu khi ô hiện tại thay đổi giá trị
        private void dgvPhieuNhap_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.IsCurrentCellDirty)
            {
                dgvPhieuNhap.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //Khi giá trị trong textbox Mã nhà cung cấp thay đổi thì tải dữ liệu liên quan lên ô Tên nhà cung cấp
        private void txtMaNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            PhieuNhapController.HienThiNhaCungCap(txtMaNhaCungCap, txtNhaCungCap);
        }
        
        //Khi giá trị trong textbox Mã phiếu thay đổi thì tải dữ liệu liên quan lên các ô textbox còn lại
        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            PhieuNhapController.HienThiPhieuNhap(txtMaPhieu, txtMaHopDong, txtMaNhaCungCap, txtNhaCungCap, txtNguoiNhap, txtNgayHopDong, txtNgayNhap);
        }

        //Khi bấm nút Esc xóa các thông tin hiển thị trên textbox và datagridview
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

        //Khi bấm 2 lần thì hiển thị trang Chi tiết phiếu nhập
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
