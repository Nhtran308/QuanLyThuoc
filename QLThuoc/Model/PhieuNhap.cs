namespace QLThuoc.Model
{
    internal class PhieuNhap
    {
        private string maPhieuNhap;
        private string maHopDong;
        private NhaCungCap maNhaCungCap;
        private NhaCungCap tenNhaCungCap;
        private string tenNguoiNhap;
        private DateTime ngayHopDong;
        private DateTime ngayNhap;

        public PhieuNhap()
        {

        }

        public PhieuNhap (string maPhieuNhap, string maHopDong, NhaCungCap maNhaCungCap, NhaCungCap tenNhaCungCap, string tenNguoiNhap, DateTime ngayHopDong, DateTime ngayNhap)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maHopDong = maHopDong;
            this.maNhaCungCap = maNhaCungCap;
            this.tenNhaCungCap = tenNhaCungCap;
            this.tenNguoiNhap = tenNguoiNhap;
            this.ngayHopDong = ngayHopDong;
            this.ngayNhap = ngayNhap;
        }

        public string getMaPhieuNhap ( ) { return maPhieuNhap; }
        public string getMaHopDong( ) { return maHopDong; }
        public NhaCungCap getMaNhaCungCap ( ) { return maNhaCungCap; }
        public NhaCungCap getTenNhaCungCap ( ) { return tenNhaCungCap; }
        public string getTenNguoiNhap ( ) { return tenNguoiNhap; }
        public DateTime getNgayHopDong( ) { return ngayHopDong; }
        public DateTime getNgayNhap ( ) { return ngayNhap; }


        public void setMaPhieuNhap ( string maPhieuNhap ) { this.maPhieuNhap = maPhieuNhap;  }
        public void setMaHopDong( string maHopDong) { this.maHopDong = maHopDong;  }
        public void setMaNhaCungCap ( NhaCungCap maNhaCungCap ) { this.maNhaCungCap = maNhaCungCap;  }
        public void setTenNhaCungCap ( NhaCungCap tenNhaCungCap ) { this.tenNhaCungCap = tenNhaCungCap;  }
        public void setTenNguoiNhap( string tenNguoiNhap ) { this.tenNguoiNhap = tenNguoiNhap;  }
        public void setNgayHopDong ( DateTime ngayHopDong ) { this.ngayHopDong = ngayHopDong;  }
        public void setNgayNhap (DateTime ngayNhap ) { this.ngayNhap = ngayNhap;  }
    }
}
