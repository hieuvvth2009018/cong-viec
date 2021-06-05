using System;
using System.Text;
using QuanLyDuongPho1.Controller;
using QuanLyDuongPho1.View;

namespace QuanLyDuongPho1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //var duongPho = new DuongPho();
            //var duongPhoModel = new DuongPhoModel();
            //duongPhoModel.Save(duongPho);
            // DuongPhoController duongPhoController = new DuongPhoController();
            // duongPhoController.TaoDuongPho();
            DuongPhoView duongPhoView = new DuongPhoView();
            duongPhoView.ShowMenu();
        }
    }
}