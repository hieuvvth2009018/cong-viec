using System;
using QuanLyDuongPho1.Controller;

namespace QuanLyDuongPho1.View
{
    public class DuongPhoView
    {
        private DuongPhoController _duongPhoController = new DuongPhoController();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Quản lý đường phố.");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Tạo mới đường phố.");
                Console.WriteLine("2. Hiển thị danh sách đường phố.");
                Console.WriteLine("3. Sửa thông tin.");
                Console.WriteLine("4. Xóa thông tin đường phố.");
                Console.WriteLine("5. Thóat chương trình.");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Vui long chon tu (1->5): ");
                int luachon = Convert.ToInt32(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        _duongPhoController.TaoDuongPho();
                        Console.WriteLine("lua chon 1");
                        break;
                    case 2:
                        Console.WriteLine("lua chon 2");
                        _duongPhoController.Hienthi();
                        break;
                    case 3:
                        Console.WriteLine("lua chon 3");
                        _duongPhoController.SuaThongTinduongpho();
                        break;
                    case 4:
                        Console.WriteLine("lua chon 4");
                        _duongPhoController.xoathongtinduongpho();
                        break;
                    case 5:
                        Console.WriteLine("lua chon 5");
                        break;
                }

                if (luachon == 5)
                {
                    Console.WriteLine("ĐÃ THOÁT CHƯƠNG TÌNH ");
                    break;
                }
            }
        }

    }
}
       