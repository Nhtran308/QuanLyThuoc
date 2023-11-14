using Microsoft.VisualBasic;
using QLThuoc.Model;
using QLThuoc.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLThuoc.Controller
{
    internal class PhieuNhapController
    {
        List<PhieuNhap> lstPhieuNhap;
        List<Thuoc> lstThuoc;
        PhieuNhapController pnController;
        public PhieuNhapController () 
        {
            lstPhieuNhap = new List<PhieuNhap>();
            lstThuoc = new List<Thuoc>();
        }

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
                    string maThuoc = reader["MaThuoc"].ToString();
                    Thuoc thuoc = new Thuoc(maThuoc);
                    lstThuoc.Add(thuoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiển thị không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return lstThuoc;
        }

        public bool CTPNInsert(System.Windows.Forms.TextBox txtMaPhieu, 
            System.Windows.Forms.TextBox txtMaHopDong, 
            System.Windows.Forms.TextBox txtMaNhaCungCap, 
            System.Windows.Forms.TextBox txtNhaCungCap, 
            System.Windows.Forms.TextBox txtNguoiNhap, 
            System.Windows.Forms.TextBox txtNgayHopDong, 
            System.Windows.Forms.TextBox txtNgayNhap, 
            DataGridView dgvPhieuNhap)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                for (int i = 0; i < dgvPhieuNhap.Rows.Count-1; i++)
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
            catch (Exception ex)
            {
                MessageBox.Show("Thông tin bị trùng hoặc không đúng", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

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
                    dgvPhieuNhap.Rows[i].Cells[1].Value = reader["TenThuoc"].ToString();
                    dgvPhieuNhap.Rows[i].Cells[2].Value = reader["DonViTinh"].ToString();
                    dgvPhieuNhap.Rows[i].Cells[4].Value = reader["DonGia"].ToString();
                    dgvPhieuNhap.Rows[i].Cells[5].Value = reader["ThanhTien"].ToString();
                }
                conn.Close();
            }
        }

        public static void HienThiPhieuNhap(System.Windows.Forms.TextBox txtMaPhieu, 
            System.Windows.Forms.TextBox txtMaHopDong,
            System.Windows.Forms.TextBox txtMaNhaCungCap,
            System.Windows.Forms.TextBox txtNhaCungCap,
            System.Windows.Forms.TextBox txtNguoiNhap,
            System.Windows.Forms.TextBox txtNgayHopDong,
            System.Windows.Forms.TextBox txtNgayNhap
            )
        {
            SqlConnection conn = DataHelper.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhieuNhap WHERE MaPhieu = N'" + txtMaPhieu.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaPhieu.Text = reader["MaPhieu"].ToString();
                txtMaHopDong.Text = reader["MaHopDong"].ToString();
                txtMaNhaCungCap.Text = reader["MaNhaCungCap"].ToString();
                txtNhaCungCap.Text = reader["TenNhaCungCap"].ToString();
                txtNguoiNhap.Text = reader["NguoiNhap"].ToString();
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

        public static void HienThiNhaCungCap(System.Windows.Forms.TextBox txtMaNhaCungCap, System.Windows.Forms.TextBox txtNhaCungCap)
        {
            SqlConnection conn = DataHelper.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap WHERE MaNhaCungCap = N'" + txtMaNhaCungCap.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaNhaCungCap.Text = reader["MaNhaCungCap"].ToString();
                txtNhaCungCap.Text = reader["TenNhaCungCap"].ToString();
            }
            conn.Close();
        }
    }
}

