using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuoc.Model;
using QLThuoc.Util;

namespace QLThuoc.Controller
{
    internal class ThuocController
    {
        //Khởi tạo danh sách Thuốc
        List<Thuoc> lstThuoc;

        public ThuocController()
        {
            lstThuoc = new List<Thuoc>();
        }

        //Hàm hiển thị danh sách lên DataGridView
        public List<Thuoc> ThuocLoad()
        {
            lstThuoc.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Thuoc", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maThuoc = (string)reader["MaThuoc"];
                    string tenThuoc = (string)reader["TenThuoc"];
                    string donViTinh = (string)reader["DonViTinh"];
                    int soLuong = (int)reader["SoLuong"];
                    float donGia = float.Parse(reader["DonGia"].ToString());
                    Thuoc thuoc = new Thuoc (maThuoc, tenThuoc, donViTinh, soLuong, donGia);
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

        //Hàm thêm dữ liệu
        public bool ThuocInsert(Thuoc thuoc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Thuoc( MaThuoc, TenThuoc, DonViTinh, SoLuong, DonGia) " +
                    "VALUES('" + thuoc.getMaThuoc() + "',N'" + thuoc.getTenThuoc() + 
                    "',N'" + thuoc.getDonViTinh() + "','" + thuoc.getSoLuong() + "','" + thuoc.getDonGia() + "');", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                return true;
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

        public bool ThuocEdit(Thuoc thuoc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Thuoc SET TenThuoc = N'" + thuoc.getTenThuoc() + "', DonViTinh = N'"
                    + thuoc.getDonViTinh() + "', SoLuong = " + thuoc.getSoLuong() + ", DonGia = '" + thuoc.getDonGia() + "' WHERE MaThuoc = '" + thuoc.getMaThuoc() + "';", conn);
                if (MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool ThuocDelete(Thuoc thuoc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Thuoc WHERE MaThuoc = '" + thuoc.getMaThuoc() + "';", conn);
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public List<Thuoc> ThuocFind(Thuoc thuoc)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                lstThuoc.Clear();
                int count = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Thuoc WHERE MaThuoc = '" + thuoc.getMaThuoc() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maThuoc = (string)reader["MaThuoc"];
                    string tenThuoc = (string)reader["TenThuoc"];
                    string donViTinh = (string)reader["DonViTinh"];
                    int soLuong = (int)reader["SoLuong"];
                    float donGia = float.Parse(reader["DonGia"].ToString());
                    thuoc = new Thuoc(maThuoc, tenThuoc, donViTinh, soLuong, donGia);
                    lstThuoc.Add(thuoc);
                    count++;
                }

                if (count > 0)
                {
                    return lstThuoc;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return lstThuoc;
        }
    }
}
