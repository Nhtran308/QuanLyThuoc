using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.Model
{
    internal class ChiTietPhieuNhap
    {
        private PhieuNhap maPhieuNhap;
        private Thuoc maThuoc;
        private int soLuong;
        private float donGia;

        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(PhieuNhap maPhieuNhap, Thuoc maThuoc, int soLuong, float donGia)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maThuoc = maThuoc;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public PhieuNhap getMaPhieuNhap() { return maPhieuNhap; }
        public Thuoc getMaThuoc() { return maThuoc; }
        public int getSoLuong() { return soLuong; }
        public float getDonGia() { return donGia; }

        public void setMaPhieuNhap (PhieuNhap phieuNhap) { this.maPhieuNhap = maPhieuNhap; }
        public void setMaThuoc (Thuoc maThuoc) { this.maThuoc = maThuoc; }
        public void setSoLuong (int soLuong) { this.soLuong = soLuong; }
        public void setDonGia (float donGia) { this.donGia = donGia; }
    }
}
