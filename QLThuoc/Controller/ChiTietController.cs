﻿using QLThuoc.Model;
using QLThuoc.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLThuoc.Controller
{
    internal class ChiTietController
    {
        List<ChiTietPhieuNhap> lstCTPN;

        public ChiTietController()
        {
            lstCTPN = new List<ChiTietPhieuNhap>();
        }

        public List<ChiTietPhieuNhap> LoadCTPN()
        {
            lstCTPN.Clear();
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
                    ChiTietPhieuNhap ct = new ChiTietPhieuNhap(maThuoc, maThuoc, soLuong, donGia);
                    lstCTPN.Add(ct);
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

            return lstCTPN;
        }

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