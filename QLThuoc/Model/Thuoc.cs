using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.Model
{
    internal class Thuoc
    {
        //Khai báo biến
        private string maThuoc;
        private string tenThuoc;
        private string donViTinh;
        private int soLuong;
        private float donGia;
        private float thanhTien;

        //Constructor rỗng
        public Thuoc ()
        {

        }

        public Thuoc (string maThuoc)
        {
            this.maThuoc = maThuoc;
        }

        //Constructor Thuoc
        public Thuoc (string maThuoc, string tenThuoc, string donViTinh, int soLuong, float donGia)
        {
            this.maThuoc = maThuoc;
            this.tenThuoc = tenThuoc;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public Thuoc( string tenThuoc, string donViTinh, int soLuong, float donGia, float thanhTien)
        {
            this.tenThuoc = tenThuoc;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        //Getter
        public string getMaThuoc () { return maThuoc; }
        public string getTenThuoc () { return tenThuoc; }
        public string getDonViTinh () { return donViTinh; }
        public int getSoLuong () { return soLuong; }
        public float getDonGia () { return donGia; }
        public float getThanhTien () { return thanhTien; }

        //Setter
        public void setMaThuoc (string maThuoc) { this.maThuoc = maThuoc; }
        public void setTenThuoc (string tenThuoc) { this.tenThuoc = tenThuoc; }
        public void setDonViTinh (string donViTinh) { this.donViTinh = donViTinh; }
        public void setSoLuong (int soLuong) { this.soLuong = soLuong; }
        public void setDonGia (float donGia) { this.donGia = donGia; }
        public void setThanhTien (float thanhTien) { this.thanhTien = thanhTien; }
    }
}
