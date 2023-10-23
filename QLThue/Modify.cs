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
    }
}
