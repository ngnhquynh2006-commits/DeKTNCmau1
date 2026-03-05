using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    [TestFixture]
    public class NhanVienServicesTests
    {
        private NhanVienServices service;

        [SetUp]
        public void Setup()
        {
            service = new NhanVienServices();
        }

        // Test sửa nhân viên hợp lệ
        [Test]
        public void SuaNhanVien_HopLe()
        {
            NhanVien nv = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "An",
                Tuoi = 25,
                Luong = 1000,
                NamKinhNghiem = 2,
                PhongBan = "IT"
            };

            service.ThemNhanVien(nv);

            NhanVien nvMoi = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "Binh",
                Tuoi = 26,
                Luong = 1500,
                NamKinhNghiem = 3,
                PhongBan = "HR"
            };

            bool result = service.SuaNhanVien("NV01", nvMoi);

            Assert.IsTrue(result);
        }

        // Test mã nhân viên không tồn tại
        [Test]
        public void SuaNhanVien_KhongTonTai()
        {
            NhanVien nvMoi = new NhanVien()
            {
                MaNV = "NV02",
                Ten = "Binh",
                Tuoi = 26,
                Luong = 1500,
                NamKinhNghiem = 3,
                PhongBan = "HR"
            };

            bool result = service.SuaNhanVien("NV02", nvMoi);

            Assert.IsFalse(result);
        }

        // Test tuổi nhỏ hơn biên
        [Test]
        public void SuaNhanVien_TuoiNhoHon18()
        {
            NhanVien nv = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "An",
                Tuoi = 25,
                Luong = 1000,
                NamKinhNghiem = 2,
                PhongBan = "IT"
            };

            service.ThemNhanVien(nv);

            NhanVien nvMoi = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "Binh",
                Tuoi = 17,
                Luong = 1500,
                NamKinhNghiem = 3,
                PhongBan = "HR"
            };

            Assert.Throws<Exception>(() => service.SuaNhanVien("NV01", nvMoi));
        }

        // Test lương âm
        [Test]
        public void SuaNhanVien_LuongAm()
        {
            NhanVien nv = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "An",
                Tuoi = 25,
                Luong = 1000,
                NamKinhNghiem = 2,
                PhongBan = "IT"
            };

            service.ThemNhanVien(nv);

            NhanVien nvMoi = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "Binh",
                Tuoi = 25,
                Luong = -500,
                NamKinhNghiem = 3,
                PhongBan = "HR"
            };

            Assert.Throws<Exception>(() => service.SuaNhanVien("NV01", nvMoi));
        }

        // Test trường rỗng
        [Test]
        public void SuaNhanVien_TenRong()
        {
            NhanVien nv = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "An",
                Tuoi = 25,
                Luong = 1000,
                NamKinhNghiem = 2,
                PhongBan = "IT"
            };

            service.ThemNhanVien(nv);

            NhanVien nvMoi = new NhanVien()
            {
                MaNV = "NV01",
                Ten = "",
                Tuoi = 25,
                Luong = 1200,
                NamKinhNghiem = 3,
                PhongBan = "HR"
            };

            Assert.Throws<Exception>(() => service.SuaNhanVien("NV01", nvMoi));
        }
    }
}
