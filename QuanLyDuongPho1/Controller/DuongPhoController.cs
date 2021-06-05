using System;
using System.Collections.Generic;
using System.ComponentModel;
using QuanLyDuongPho1.Entity;
using QuanLyDuongPho1.Model;

namespace QuanLyDuongPho1.Controller
{
    public class DuongPhoController
    {
        private DuongPhoModel _duongPho = new DuongPhoModel();
        private List<DuongPho> _duongPhos = new List<DuongPho>();

        public void TaoDuongPho()
        {
            DuongPho duongPho = new DuongPho();
            Console.WriteLine("Vui long nhap ma: ");
            duongPho.Ma = Console.ReadLine();
            Console.WriteLine("Nhap ten duong: ");
            duongPho.Ten = Console.ReadLine();
            Console.WriteLine("Nhap mo ta: ");
            duongPho.MoTa = Console.ReadLine();
            Console.WriteLine("Nhap ngay su dung: ");
            duongPho.NgaySuDung = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap lich su: ");
            duongPho.LichSu = Console.ReadLine();
            Console.WriteLine("Nhap ten quan: ");
            duongPho.TenQuan = Console.ReadLine();
            Console.WriteLine("Nhap trang thai: ");
            duongPho.TrangThai = Convert.ToInt32(Console.ReadLine());
            _duongPho.Save(duongPho);

        }

        public void Hienthi()
        {
            // thằng này được rồi này update thì sai cả model rồi nên tự làm lại đi tý fix tiếp
            var listDuongPho = _duongPho.FindAll();
            for (var i = 0; i < listDuongPho.Count; i++)
            {
                var duongPho = listDuongPho[i];
                Console.WriteLine(
                    $"Ma: {duongPho.Ma}. Ten: {duongPho.Ten}.MoTa:{duongPho.MoTa}.Ngaysudung:{duongPho.NgaySuDung}. Lichsu:{duongPho.LichSu}. TenQuan:{duongPho.TenQuan}.Trangthai:{duongPho.TrangThai}");
            }
        }

        public void SuaThongTinduongpho()
        {
            Console.WriteLine(
                "Vui lòng nhập mã duong pho cần sửa: "); // thằng này sai xem lại video của thầy hoặc thằng sinhviendbmodel 
            var ma = Console.ReadLine();
            DuongPho duongPho1 = null;
            for (int i = 0; i < _duongPhos.Count; i++)
            {
                var duongPho = _duongPhos[i];
                if (duongPho1.Ma == ma)
                {
                    duongPho = _duongPhos[i];
                    break;
                }
            }

            if (duongPho1 == null)
            {
                Console.WriteLine("không tìm thấy duong pho: ");
                return;
            }

            Console.WriteLine(" thông tin duong pho cần sửa.");
            Console.WriteLine("Vui lòng nhập tên duong pho: ");
            var ten = Console.ReadLine();
            duongPho1.Ten = ten;
            Console.WriteLine("Vui lòng nhập ma duong pho: ");
            var Ma = Console.ReadLine();
            duongPho1.Ma = Ma;
            Console.WriteLine("Vui lòng nhập mo ta: ");
            var MoTa = Console.ReadLine();
            duongPho1.MoTa = MoTa;
            Console.WriteLine("Vui lòng nhập ngay bat dau su dung: ");
            var ngaysudung = Console.ReadLine();
            duongPho1.NgaySuDung = Convert.ToDateTime(ngaysudung);
            Console.WriteLine("Vui lòng nhập lich su : ");
            var Lichsu = Console.ReadLine();
            duongPho1.LichSu = Lichsu;
            Console.WriteLine("Vui lòng nhập tên ten quan: ");
            var Tenquan = Console.ReadLine();
            duongPho1.TenQuan = Tenquan;
            Console.WriteLine("Vui lòng nhập trạng thái duong pho: ");
            var trangThai = Console.ReadLine();
            duongPho1.TrangThai = Convert.ToInt32(trangThai);
            Console.WriteLine("Sửa thông tin khach hang thành công!");
        }

        public void xoathongtinduongpho()
        {
            Console.WriteLine("Nhập mã khachhang cần xóa "); // sai luôn
            var makhachhang = Console.ReadLine();
            var index = -1;
            for (int i = 0; i < _duongPhos.Count; i++)
            {
                var custmer = _duongPhos[i];
                if (custmer.Ma == makhachhang)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("khong tim thay khach hang");
                return;
            }

            _duongPhos.RemoveAt(index);
            Console.WriteLine("xoa thanh cong");
        }
    }
}

