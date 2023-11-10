using QLThuoc.Model;
using QLThuoc.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.Controller
{
    internal class NhaCungCapController
    {
        List<NhaCungCap> lstNhaCungCap;

        public NhaCungCapController ()
        {
            lstNhaCungCap = new List<NhaCungCap>();
        }

        public List<NhaCungCap> NCCLoad()
        {
            lstNhaCungCap.Clear();
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maNhaCungCap = reader["MaNhaCungCap"].ToString();
                    string tenNhaCungCap = reader["TenNhaCungCap"].ToString();
                    string diaChiNhaCungCap = reader["DiaChiNhaCungCap"].ToString();
                    NhaCungCap nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, diaChiNhaCungCap);
                    lstNhaCungCap.Add(nhaCungCap);
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
            return lstNhaCungCap;
        }

        public bool NCCInsert(NhaCungCap nhaCungCap)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChiNhaCungCap) " +
                    "VALUES('" + nhaCungCap.getMaNhaCungCap() + "',N'" + nhaCungCap.getTenNhaCungCap() + "',N'" + nhaCungCap.getDiaChiNhaCungCap() + "');", conn);
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

        public bool NCCEdit(NhaCungCap nhaCungCap)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NhaCungCap SET TenNhaCungCap = N'" + nhaCungCap.getTenNhaCungCap() + "', DiaChiNhaCungCap = N'"
                    + nhaCungCap.getDiaChiNhaCungCap() + "' WHERE MaNhaCungCap = '" + nhaCungCap.getMaNhaCungCap() + "';", conn);
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

        public bool NCCDelete(NhaCungCap nhaCungCap)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM NhaCungCap WHERE MaNhaCungCap = '" + nhaCungCap.getMaNhaCungCap() + "';", conn);
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

        public List<NhaCungCap> Find(NhaCungCap nhaCungCap)
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                lstNhaCungCap.Clear();
                int count = 0;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap WHERE MaNhaCungCap = '" + nhaCungCap.getMaNhaCungCap() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maNhaCungCap = reader["MaNhaCungCap"].ToString();
                    string tenNhaCungCap = reader["TenNhaCungCap"].ToString();
                    string diaChiNhaCungCap = reader["DiaChiNhaCungCap"].ToString();
                    nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap, diaChiNhaCungCap);
                    lstNhaCungCap.Add(nhaCungCap);
                    count++;
                }

                if (count > 0)
                {
                    return lstNhaCungCap;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!!!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return lstNhaCungCap;
        }
    }
}
