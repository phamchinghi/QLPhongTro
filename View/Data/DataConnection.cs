using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_PhongTro
{
    public class DataConnection
    {
        SqlConnection connect = new SqlConnection("Data source =.\\SQLEXPRESS;initial catalog=QuanLyPhongTro;integrated security=True");
        //mở kết nối đến DB
        public static DataConnection instance;//Tạo 1 instance để sử dụng lại nhiều lần mà không cần khai báo DataConnection = new DataConnection();

        public static DataConnection Instance
        {
            get { if (instance == null) instance = new DataConnection(); return DataConnection.instance;}
            private set { DataConnection.instance = value; }
        }
        private DataConnection() { }
        private void openConnect()
        {
            if(connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }
        //Đóng kết nối DB(cần phải đóng sau khi thực hiện 1 thao tác nào đó)
        private void closeConnect()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }
        //Thực thi câu query sql
        public bool ExcData(string command)
        {
            openConnect();
            Boolean check = false;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, connect);//command: là câu query cần thực thi và connect là chỉ đến DB để thực thi câu query đó
                sqlCommand.ExecuteNonQuery();//Thực thi câu query 
                check = true;
            }
            catch(Exception)
            {
                check = false;
            }
            closeConnect();//đóng connect sau khi thực thi
            return check;
        }
        public DataTable readData(string command)
        {
            openConnect();
            DataTable dataTable = new DataTable();//Tạo 1 kho DB ảo
            try
            {
                SqlCommand sqlCommand = new SqlCommand(command, connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);//dùng dataAdapter để lưu dữ liệu từ câu query trả về
                dataAdapter.Fill(dataTable);//đổ dữ liệu từ adapter vào dataTable
                //dataAdapter.Dispose();
            }
            catch(Exception)
            {
                dataTable = null;
            }
            closeConnect();
            return dataTable;//trả về bảng đã truy vấn dữ liệu
        }
    }
}
