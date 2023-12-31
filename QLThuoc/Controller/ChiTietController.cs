﻿using QLThuoc.Model;
using QLThuoc.Util;
using System.Data.SqlClient;
using System.Text;

namespace QLThuoc.Controller
{
    internal class ChiTietController
    {
        List<ChiTietPhieuNhap> lstCTPN;
        public ChiTietController()
        {
            lstCTPN = new List<ChiTietPhieuNhap>();
        }

        //Hàm tải dữ liệu từ Database lên Datagridview trong màn hình ChiTietHoaDon
        public List<ChiTietPhieuNhap> LoadCTPN()
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("USE demo SELECT MaPhieu, MaThuoc, SoLuong, DonGia FROM ChiTietPhieuNhap ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maPhieu = (string)reader["MaPhieu"];
                    string maThuoc = (string)reader["MaThuoc"];
                    int soLuong = (int)reader["SoLuong"];
                    float donGia = float.Parse(reader["DonGia"].ToString());

                    ChiTietPhieuNhap ct = new ChiTietPhieuNhap( maPhieu, maThuoc, soLuong, donGia );
                    lstCTPN.Add(ct);
                }
            }
            catch (Exception) { MessageBox.Show("Hiển thị không thành công", "Thông báo", MessageBoxButtons.OK); }
            finally { conn.Close(); }
            return lstCTPN;
        }

        //Hàm tìm dữ liệu bằng mã phiếu nhập
        public List<ChiTietPhieuNhap> FindCTPN(ChiTietPhieuNhap chitiet)
        {
            lstCTPN.Clear();

            SqlConnection conn = DataHelper.getConnection();
            try
            {
                //Hàm count để hiển thị thông báo khi không tìm được dữ liệu
                int count = 0;
                conn.Open();

                SqlCommand cmd = new SqlCommand("USE demo SELECT MaPhieu, MaThuoc, SoLuong, DonGia FROM ChiTietPhieuNhap WHERE MaPhieu = '" + chitiet.getMaPhieuNhap() + "';", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maPhieu = (string)reader["MaPhieu"];
                    string maThuoc = (string)reader["MaThuoc"];
                    int soLuong = (int)reader["SoLuong"];
                    float donGia = float.Parse(reader["DonGia"].ToString());

                    ChiTietPhieuNhap ct = new ChiTietPhieuNhap(maPhieu, maThuoc, soLuong, donGia);
                    lstCTPN.Add(ct);
                    count++;
                }
                if (count > 0)
                {
                    return lstCTPN;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo!", MessageBoxButtons.OK);
                }
            }
            catch (Exception) { }
            finally { conn.Close(); }
            return lstCTPN;
        }

        //Hàm lấy dánh sách mã phiếu để truyền vào Combobox
        public List<ChiTietPhieuNhap> Combobox()
        {
            SqlConnection conn = DataHelper.getConnection();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MaPhieu FROM ChiTietPhieuNhap", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string maPhieu = reader["MaPhieu"].ToString();

                    ChiTietPhieuNhap chitiet = new ChiTietPhieuNhap(maPhieu);
                    lstCTPN.Add(chitiet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hiển thị không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
            return lstCTPN;
        }

        //Hàm lấy dữ liệu theo giá trị mà combobox truyền vào
        public static void HienThiCombobox(DataGridView dgvChiTiet)
        {
            SqlConnection conn = DataHelper.getConnection();
            for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT DISTINCT MaPhieu, MaThuoc, SoLuong, DonGia FROM ChiTietPhieuNhap WHERE MaPhieu = N'" + dgvChiTiet.Rows[i].Cells[0].Value + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dgvChiTiet.Rows[i].Cells[1].Value = reader["MaThuoc"].ToString();
                    dgvChiTiet.Rows[i].Cells[2].Value = reader["SoLuong"].ToString();
                    dgvChiTiet.Rows[i].Cells[3].Value = reader["DonGia"].ToString();
                }
                conn.Close();
            }
        }

        //Hàm in file txt
        public async Task Export(DataGridView dgvChiTiet)
        {
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sdf.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (DataGridViewRow row in dgvChiTiet.Rows)
                        {
                            if(row.Cells[0].Value == null)
                            {
                                break;
                            }
                            await tw.WriteLineAsync($"Mã phiếu nhập: {row.Cells[0].Value}" +
                                $"\nMã thuốc: {row.Cells[1].Value}" +
                                $"\nSố lượng: {row.Cells[2].Value}" +
                                $"\nĐơn giá: {row.Cells[3].Value}" +
                                $"\n----------------------------------------");
                        }
                        MessageBox.Show("Xuất thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

    }
}
