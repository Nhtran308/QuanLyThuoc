using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.Model
{
    internal class ChiTietPhieuNhap
    {
        private string maPhieuNhap;
        private string maThuoc;
        private int soLuong;
        private float donGia;


        public ChiTietPhieuNhap(string maPhieuNhap) { }

        public ChiTietPhieuNhap(string maPhieuNhap, string maThuoc, int soLuong, float donGia)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maThuoc = maThuoc;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public string getMaPhieuNhap() { return maPhieuNhap; }
        public string getMaThuoc() { return maThuoc; }
        public int getSoLuong() { return soLuong; }
        public float getDonGia() { return donGia; }

        public void setMaPhieuNhap(string maPhieuNhap) { this.maPhieuNhap = maPhieuNhap; }
        public void setMaThuoc(string maThuoc) { this.maThuoc = maThuoc; }
        public void setSoLuong(int soLuong) { this.soLuong = soLuong; }
        public void setDonGia(float donGia) { this.donGia = donGia; }
    }
}
