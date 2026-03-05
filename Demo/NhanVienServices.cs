using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class NhanVienServices
    {
        List<NhanVien> listNhanVien = new List<NhanVien>();

        public void ThemNhanVien(NhanVien nv)
        {
            listNhanVien.Add(nv);
        }

        public bool SuaNhanVien(string maNV, NhanVien nvMoi)
        {
            // Validate
            if (string.IsNullOrEmpty(nvMoi.MaNV) ||
                string.IsNullOrEmpty(nvMoi.Ten) ||
                string.IsNullOrEmpty(nvMoi.PhongBan))
            {
                throw new Exception("Các trường không được để trống");
            }

            if (nvMoi.Tuoi < 18 || nvMoi.Tuoi > 60)
            {
                throw new Exception("Tuổi không hợp lệ");
            }

            if (nvMoi.Luong < 0)
            {
                throw new Exception("Lương không hợp lệ");
            }

            // tìm nhân viên
            var nv = listNhanVien.FirstOrDefault(x => x.MaNV == maNV);

            if (nv == null)
            {
                return false;
            }

            // cập nhật
            nv.MaNV = nvMoi.MaNV;
            nv.Ten = nvMoi.Ten;
            nv.Tuoi = nvMoi.Tuoi;
            nv.Luong = nvMoi.Luong;
            nv.NamKinhNghiem = nvMoi.NamKinhNghiem;
            nv.PhongBan = nvMoi.PhongBan;

            return true;
        }
    }
}