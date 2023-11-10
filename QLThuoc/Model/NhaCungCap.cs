using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuoc.Model
{
    internal class NhaCungCap
    {
        private string maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChiNhaCungCap;

        public NhaCungCap() 
        { 

        }

        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChiNhaCungCap)
        {
            this.maNhaCungCap = maNhaCungCap;
            this.tenNhaCungCap = tenNhaCungCap;
            this.diaChiNhaCungCap = diaChiNhaCungCap;
        }

        public string getMaNhaCungCap() { return maNhaCungCap; }
        public string getTenNhaCungCap() { return tenNhaCungCap; }
        public string getDiaChiNhaCungCap() { return diaChiNhaCungCap; }

        public void setMaNhaCungCap (string maNhaCungCap) { this.maNhaCungCap = maNhaCungCap; }
        public void setTenNhaCungCap (string tenNhaCungCap) { this.tenNhaCungCap = tenNhaCungCap; }
        public void setDiaChiNhaCungCap (string diaChiNhaCungCap) { this.diaChiNhaCungCap = diaChiNhaCungCap; }
    }
}
