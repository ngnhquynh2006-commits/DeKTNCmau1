using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Tests
{
    [TestFixture]
    public class TimGTLNTests
    {
        private TimGTLN timGTLN;

        [SetUp]
        public void Setup()
        {
            timGTLN = new TimGTLN();
        }

        // Test mảng bình thường
        [Test]
        public void TimGiaTriLonNhat_MangBinhThuong()
        {
            int[] arr = { 1, 5, 3, 9, 2 };

            int result = timGTLN.TimGiaTriLonNhat(arr);

            Assert.AreEqual(9, result);
        }

        // Test mảng có số âm
        [Test]
        public void TimGiaTriLonNhat_MangSoAm()
        {
            int[] arr = { -5, -2, -10 };

            int result = timGTLN.TimGiaTriLonNhat(arr);

            Assert.AreEqual(-2, result);
        }

        // Test mảng có 1 phần tử
        [Test]
        public void TimGiaTriLonNhat_MotPhanTu()
        {
            int[] arr = { 7 };

            int result = timGTLN.TimGiaTriLonNhat(arr);

            Assert.AreEqual(7, result);
        }

        // Test giá trị lớn nhất ở đầu
        [Test]
        public void TimGiaTriLonNhat_MaxODau()
        {
            int[] arr = { 10, 2, 3, 4 };

            int result = timGTLN.TimGiaTriLonNhat(arr);

            Assert.AreEqual(10, result);
        }

        // Test giá trị lớn nhất ở cuối
        [Test]
        public void TimGiaTriLonNhat_MaxOCuoi()
        {
            int[] arr = { 1, 2, 3, 15 };

            int result = timGTLN.TimGiaTriLonNhat(arr);

            Assert.AreEqual(15, result);
        }

        // Test mảng rỗng (biên)
        [Test]
        public void TimGiaTriLonNhat_MangRong()
        {
            int[] arr = { };

            Assert.Throws<Exception>(() => timGTLN.TimGiaTriLonNhat(arr));
        }
    }
}