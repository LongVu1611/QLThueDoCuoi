using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLThue
{
    internal class Modify
    {
        public Modify() { 
        
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;//doc dữ liệu trong bảng
        SqlDataAdapter dataAdapter;//sẽ truy xuất toàn bộ dữ liệu và datatable
        public List<TaiKhoan> TaiKhoans(string query)
        { 
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(1),dataReader.GetString(2)));
                }
                sqlConnection.Close();
            }    
            return taiKhoans;
        }
        
        public DataTable GetAllSanPham() 
            { 
            DataTable dataTable = new DataTable();
            string query = "select * from sanphamthue";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) 
            {
                sqlConnection.Open() ;
                dataAdapter = new SqlDataAdapter(query,sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close() ;
            }
            return dataTable; 
            }
        public DataTable GetAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from khachhang";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable GetAllChiTietPhieuThue()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from chitietphieuthue";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable GetAllPhieuThue()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from thue";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insert(SanPham sanPham)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "insert into sanphamthue values (@masp,@tensp,@nuocsx,@tinhtrangsp,@giavon,@giathue1ngay)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand (query,sqlConnection);
                sqlCommand.Parameters.Add("@masp", SqlDbType.Int).Value= sanPham.Id;
                sqlCommand.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = sanPham.Name;
                sqlCommand.Parameters.Add("@nuocsx", SqlDbType.NVarChar).Value = sanPham.Country;
                sqlCommand.Parameters.Add("@tinhtrangsp", SqlDbType.NVarChar).Value = sanPham.Info;
                sqlCommand.Parameters.Add("@giavon", SqlDbType.Int).Value = sanPham.Von;
                sqlCommand.Parameters.Add("@giathue1ngay", SqlDbType.Decimal).Value = sanPham.Giathue;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { sqlConnection.Close(); 
            }
            return true;
        }
        public bool update(SanPham sanPham)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "update sanphamthue set tensp = @tensp,nuocsx = @nuocsx,tinhtrangsp = @tinhtrangsp,giavon = @giavon,giathue1ngay = @giathue1ngay Where masp = @masp";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@masp", SqlDbType.Int).Value = sanPham.Id;
                sqlCommand.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = sanPham.Name;
                sqlCommand.Parameters.Add("@nuocsx", SqlDbType.NVarChar).Value = sanPham.Country;
                sqlCommand.Parameters.Add("@tinhtrangsp", SqlDbType.NVarChar).Value = sanPham.Info;
                sqlCommand.Parameters.Add("@giavon", SqlDbType.Int).Value = sanPham.Von;
                sqlCommand.Parameters.Add("@giathue1ngay", SqlDbType.Decimal).Value = sanPham.Giathue;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete sanphamthue Where masp = @masp";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@masp", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool insert(KhachHang khachHang)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "insert into khachhang values (@makh,@tenkh,@diachi,@sodienthoai)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value =   khachHang.Idkh;
                sqlCommand.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = khachHang.Namekh;
                sqlCommand.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = khachHang.Addresskh;
                sqlCommand.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = khachHang.Numberkh;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(KhachHang khachHang)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "update khachhang set tenkh = @tenkh,diachi = @diachi,sodienthoai = @sodienthoai Where makh = @makh";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = khachHang.Idkh;
                sqlCommand.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = khachHang.Namekh;
                sqlCommand.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = khachHang.Addresskh;
                sqlCommand.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = khachHang.Numberkh;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deletekh(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete khachhang Where makh = @makh";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool insert(TTChoThue tTChoThue)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "insert into chitietphieuthue values (@chitietphieuthue,@sophieu,@masp,@soluong,@hoadon)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@chitietphieuthue", SqlDbType.Int).Value = tTChoThue.Ctpt;
                sqlCommand.Parameters.Add("@sophieu", SqlDbType.Int).Value = tTChoThue.Idphieu;
                sqlCommand.Parameters.Add("@masp", SqlDbType.Int).Value = tTChoThue.Idsp;
                sqlCommand.Parameters.Add("@soluong", SqlDbType.Int).Value = tTChoThue.Soluong;
                sqlCommand.Parameters.Add("@hoadon", SqlDbType.Decimal).Value = tTChoThue.Bill;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(TTChoThue tTChoThue)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "update chitietphieuthue set sophieu = @sophieu, masp = @masp, soluong = @soluong, hoadon = @hoadon Where chitietphieuthue = @chitietphieuthue)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@chitietphieuthue", SqlDbType.Int).Value = tTChoThue.Ctpt;
                sqlCommand.Parameters.Add("@sophieu", SqlDbType.Int).Value = tTChoThue.Idphieu;
                sqlCommand.Parameters.Add("@masp", SqlDbType.Int).Value = tTChoThue.Idsp;
                sqlCommand.Parameters.Add("@soluong", SqlDbType.Int).Value = tTChoThue.Soluong;
                sqlCommand.Parameters.Add("@hoadon", SqlDbType.Decimal).Value = tTChoThue.Bill;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deletectpt(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete chitietphieuthue Where chitietphieuthue = @chitietphieuthue";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@chitietphieuthue", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool insert(Thuê thuê)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "insert into thue values (@sophieu,@makh,@ngaychothue,@ngaytra,@tientradutinh)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);               
                sqlCommand.Parameters.Add("@sophieu", SqlDbType.Int).Value = thuê.Id;
                sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = thuê.Idkh;
                sqlCommand.Parameters.Add("@ngaychothue", SqlDbType.NVarChar).Value = thuê.Datego.ToShortDateString();
                sqlCommand.Parameters.Add("@ngaytra", SqlDbType.NVarChar).Value = thuê.Dateback.ToShortDateString();
                sqlCommand.Parameters.Add("@tientradutinh", SqlDbType.Decimal).Value = thuê.Bill;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(Thuê thuê)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "update thue set  makh = @makh, ngaychothue = @ngaychothue, ngaytra = @ngaytra, tientradutinh = @tientradutinh  Where sophieu = @sophieu)";
            try
            {
                sqlConnection.Open();
                sqlCommand.Parameters.Add("@sophieu", SqlDbType.Int).Value = thuê.Id;
                sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = thuê.Idkh;
                sqlCommand.Parameters.Add("@ngaychothue", SqlDbType.NVarChar).Value = thuê.Datego.ToShortDateString();
                sqlCommand.Parameters.Add("@ngaytra", SqlDbType.NVarChar).Value = thuê.Dateback.ToShortDateString();
                sqlCommand.Parameters.Add("@tientradutinh", SqlDbType.Decimal).Value = thuê.Bill;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deletethue(string id)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "delete thue Where sophioeu = @sophieu";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@sophieu", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();//thực thi lệnh truy vấn
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
        
        
}
