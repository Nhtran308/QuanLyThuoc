using QLThuoc.Model;
using QLThuoc.Util;
using System.Data.SqlClient;

namespace QLThuoc.Controller
{
    internal class PhieuNhapController
    {
        List<Thuoc> lstThuoc;
        public PhieuNhapController()
        {
            lstThuoc = new List<Thuoc>();
        }

        //Hàm lấy danh sách Mã thuốc
        public List<Thuoc> Combobox()
        {
            lstThuoc.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaThuoc FROM Thuoc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maThuoc = (string)reader["MaThuoc"];
                    Thuoc thuoc = new Thuoc(maThuoc);
                    lstThuoc.Add(thuoc);
                }
            }
            catch (Exception) { MessageBox.Show("Hiển thị không thành công", "Thông báo", MessageBoxButtons.OK); }
            finally { conn.Close(); }
            return lstThuoc;
        }

        //Hàm thêm dữ liệu vào 2 bảng PhieuNhap và ChiTietHangHoa
        public bool CTPNInsert(TextBox txtMaPhieu, TextBox txtMaHopDong, TextBox txtMaNhaCungCap, TextBox txtNhaCungCap,
            TextBox txtNguoiNhap, TextBox txtNgayHopDong, TextBox txtNgayNhap, DataGridView dgvPhieuNhap)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                for (int i = 0; i < dgvPhieuNhap.Rows.Count - 1; i++)
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO PhieuNhap(MaPhieu, MaHopDong, MaNhaCungCap, TenNhaCungCap, NguoiNhap, NgayHopDong, NgayNhap) " +
                        "VALUES ('" + txtMaPhieu.Text + "','"
                        + txtMaHopDong.Text + "','"
                        + txtMaNhaCungCap.Text + "',N'"
                        + txtNhaCungCap.Text + "',N'"
                        + txtNguoiNhap.Text + "','"
                        + txtNgayHopDong.Text + "','"
                        + txtNgayNhap.Text + "') " +
                        "INSERT INTO ChiTietPhieuNhap(MaPhieu, MaThuoc, SoLuong, DonGia) " +
                        "VALUES (" +
                        "(SELECT MaPhieu FROM PhieuNhap WHERE MaPhieu = '" + txtMaPhieu.Text + "'), " +
                        "(SELECT MaThuoc FROM Thuoc WHERE MaThuoc = '" + dgvPhieuNhap.Rows[i].Cells[0].Value + "'), " +
                        "'" + dgvPhieuNhap.Rows[i].Cells[3].Value + "', " +
                        "'" + dgvPhieuNhap.Rows[i].Cells[4].Value + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception) { MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK); }
            finally { conn.Close(); }
            return false;
        }

        //Hàm hiển thị dữ liệu dựa trên tham số truyền vào là giá trị của Combobox
        public static void HienThiCombobox(DataGridView dgvPhieuNhap)
        {
            SqlConnection conn = DataHelper.getConnection();
            for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT *, ('" + dgvPhieuNhap.Rows[i].Cells[3].Value + "' * DonGia) AS 'ThanhTien' FROM Thuoc WHERE MaThuoc = N'" + dgvPhieuNhap.Rows[i].Cells[0].Value + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dgvPhieuNhap.Rows[i].Cells[1].Value = (string)reader["TenThuoc"];
                    dgvPhieuNhap.Rows[i].Cells[2].Value = (string)reader["DonViTinh"];
                    dgvPhieuNhap.Rows[i].Cells[4].Value = (string)reader["DonGia"];
                    dgvPhieuNhap.Rows[i].Cells[5].Value = (string)reader["ThanhTien"];
                }
                conn.Close();
            }
        }

        //Hàm lấy dữ liệu và truyền lên các ô textbox
        public static void HienThiPhieuNhap(TextBox txtMaPhieu, TextBox txtMaHopDong, TextBox txtMaNhaCungCap, TextBox txtNhaCungCap,
            TextBox txtNguoiNhap, TextBox txtNgayHopDong, TextBox txtNgayNhap)
        {
            SqlConnection conn = DataHelper.getConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhap WHERE MaPhieu = N'" + txtMaPhieu.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaPhieu.Text = (string)reader["MaPhieu"];
                txtMaHopDong.Text = (string)reader["MaHopDong"];
                txtMaNhaCungCap.Text = (string)reader["MaNhaCungCap"];
                txtNhaCungCap.Text = (string)reader["TenNhaCungCap"];
                txtNguoiNhap.Text = (string)reader["NguoiNhap"];
                txtNgayHopDong.Text = Convert.ToDateTime(reader["NgayHopDong"]).ToString("dd/MM/yyyy");
                txtNgayNhap.Text = Convert.ToDateTime(reader["NgayNhap"]).ToString("dd/MM/yyyy");
            }
            else
            {
                txtMaHopDong.Text = "";
                txtMaNhaCungCap.Text = "";
                txtNhaCungCap.Text = "";
                txtNguoiNhap.Text = "";
                txtNgayHopDong.Text = "";
                txtNgayNhap.Text = "";
            }
            conn.Close();
        }

        //Hiển thị Mã nhà cung cấp và tên nhà cung cấp khi nhập giá trị vào ô textbox
        public static void HienThiNhaCungCap(TextBox txtMaNhaCungCap, TextBox txtNhaCungCap)
        {
            SqlConnection conn = DataHelper.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap WHERE MaNhaCungCap = N'" + txtMaNhaCungCap.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaNhaCungCap.Text = (string)reader["MaNhaCungCap"];
                txtNhaCungCap.Text = (string)reader["TenNhaCungCap"];
            }
            conn.Close();
        }
    }
}

