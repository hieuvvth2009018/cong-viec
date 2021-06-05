using System;
using System.Collections.Generic;
using System.Management;
using MySql.Data.MySqlClient;
using QuanLyDuongPho1.Entity;
using QuanLyDuongPho1.Helper;

namespace QuanLyDuongPho1.Model
{
    public class DuongPhoModel
    {
        private List<DuongPho> _listdp = new List<DuongPho>();

        public bool Save(DuongPho duongPho)
        {
            var connection = ConnectionHelper.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"INSERT INTO duongphos (Ma,Ten,MoTa,NgaySuDung,LichSu,TenQuan,TrangThai) " +
                                       $"VALUES ('{duongPho.Ma}', '{duongPho.Ten}', '{duongPho.MoTa}', '{duongPho.NgaySuDung}','{duongPho.LichSu}', '{duongPho.TenQuan}', {duongPho.TrangThai});";
            var result = mySqlCommand.ExecuteNonQuery();
            connection.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public List<DuongPho> FindAll()
        {
            List<DuongPho> listdp = new List<DuongPho>();
            MySqlConnection connection = ConnectionHelper.GetConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $" select * from duongphos";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string Ma = mySqlDataReader.GetString("Ma");
                string Ten = mySqlDataReader.GetString("Ten");
                string MoTa = mySqlDataReader.GetString("MoTa");
                DateTime Ngaysudung = mySqlDataReader.GetDateTime("NgaySuDung");
                string LichSu = mySqlDataReader.GetString("LichSu");
                string TenQuan = mySqlDataReader.GetString("TenQuan");
                int trangthai = mySqlDataReader.GetInt32("TrangThai");
                DuongPho _duongPho = new DuongPho();
                _duongPho.Ma = Ma;
                _duongPho.Ten = Ten;
                _duongPho.MoTa = MoTa;
                _duongPho.NgaySuDung = Ngaysudung;
                _duongPho.LichSu = LichSu;
                _duongPho.TenQuan = TenQuan;
                _duongPho.TrangThai = trangthai;
                listdp.Add(_duongPho);
                
            }
            mySqlDataReader.Close();

            return listdp;
        }

        public DuongPho FindById(string id)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = $"server=127.0.1.1;database=duongphos;UID=root;password=;port=3306";
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"select * from ma where Ma = '{id}'";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            mySqlDataReader.Read();
            string Ma = mySqlDataReader.GetString("ma");
            string Ten = mySqlDataReader.GetString("Ten");
            string MoTa = mySqlDataReader.GetString("Ho");
            DateTime Ngaysudung = Convert.ToDateTime(mySqlDataReader.GetString("ngaysudung"));
            string LichSu = mySqlDataReader.GetString("lichsu");
            string TenQuan = mySqlDataReader.GetString("tenquan");
            int trangthai = mySqlDataReader.GetInt32("Trangthai");
            DuongPho _duongPho = new DuongPho();
            _duongPho.Ma = Ma;
            _duongPho.Ten = Ten;
            _duongPho.MoTa = MoTa;
            _duongPho.NgaySuDung = Ngaysudung;
            _duongPho.LichSu = LichSu;
            _duongPho.TenQuan = TenQuan;
            _duongPho.TrangThai = trangthai;
            return _duongPho;
        }

        public bool Update(string id, DuongPho updateDuongPho)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = $"server=127.0.1.1;database=duongphos;UID=root;password=;port=3306";
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText =
                $"Ma: {updateDuongPho.Ma}. Ten: {updateDuongPho.Ten}.MoTa:{updateDuongPho.MoTa}.Ngaysudung:{updateDuongPho.NgaySuDung}. Lichsu:{updateDuongPho.LichSu}. TenQuan:{updateDuongPho.TenQuan}.Trangthai:{updateDuongPho.TrangThai}  where Ma = '{id}'";
            mySqlCommand.ExecuteNonQuery();
            return true;
        }

        public bool Delete(string id,DuongPhoModel phoModel)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.Open();
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = $"delecte from duongphos where ma = '{phoModel}'";
            mySqlCommand.ExecuteNonQuery();
            return true;
        }
    } 
}