using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QL_PhongTro.Data;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using DataTable = System.Data.DataTable;

namespace QL_PhongTro
{
    public partial class FormDSKhachTro : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DB_QLPhongTro DB = new DB_QLPhongTro();
        public FormDSKhachTro()
        {
            InitializeComponent();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
        }
        private void DFormDSKhachTro_Load(object sender, EventArgs e)
        {
            skin();
            try
            {
                //List<Khách_hàng> listKhachHangs = DB.Khách_hàng.ToList();//goi danh sach khach hang
                //BindingGrid(listKhachHangs);
                BindingGrid();
            }
            catch(Exception)
            {
                MessageBox.Show("Tải dữ liệu thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        //private void BindingGrid(List<Khách_hàng> khách_Hàngs)
        //{
        private void BindingGrid()
        {
                //dgvDSKhachTro.Rows.Clear();
                //foreach (var item in khách_Hàngs)
                //{
                //    int index = dgvDSKhachTro.Rows.Add();//them vao tung vi tri
                //    //xac dinh vi tri cac cot de them du lieu
                //    //dgvDSKhachTro.Rows[index].Cells[0].Value = item.Mã_KH;
                //    //dgvDSKhachTro.Rows[index].Cells[1].Value = item.Tên_KH;
                //    //dgvDSKhachTro.Rows[index].Cells[2].Value = item.Năm_sinh.ToShortDateString();//format sang kiểu date không có time
                //    //dgvDSKhachTro.Rows[index].Cells[3].Value = item.Sđt;
                //    //dgvDSKhachTro.Rows[index].Cells[4].Value = item.Giới_tính;
                //    //dgvDSKhachTro.Rows[index].Cells[5].Value = item.Quê_quán;
                //    //dgvDSKhachTro.Rows[index].Cells[6].Value = item.CMND;
                //    dgvDSKhachTro.DataSource = khách_Hàngs;
                //}

            string query = "select * from DSKhachHang";
            DataConnection.Instance.ExcData(query);
            DataConnection.Instance.readData(query);
            dgvDSKhachTro.DataSource = DataConnection.Instance.readData(query);
        }
        private void BtnDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Ribbon_Click(object sender, EventArgs e)
        {

        }

        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            try
            {
                string saveExcelFile = @"C:\Users\HP\Desktop\DSKH.xlsx";
                Excel.Application xlApp = new Excel.Application();
                if(xlApp == null)
                {
                    MessageBox.Show("Failed to load","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                xlApp.Visible = false;
                object missValue = System.Reflection.Missing.Value;
                Workbook workBook = xlApp.Workbooks.Add(missValue);
                Worksheet workSheet = (Worksheet)workBook.Worksheets[1];

                if(workSheet == null)
                {
                    MessageBox.Show("Can not create Worksheet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //set hiển thị cho các trường cột ở excel
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                //Xuất dong tiêu đề
                Range row1_TieuDe_DanhSachKhachTro = workSheet.get_Range("A1", "H1");//Lấy dòng 1 từ cột A đến E
                //sắp xếp trộn các dòng
                row1_TieuDe_DanhSachKhachTro.Merge();
                row1_TieuDe_DanhSachKhachTro.Font.Size = fontSizeTieuDe;
                row1_TieuDe_DanhSachKhachTro.Font.Name = fontName;
                //set chữ nằm ở giữa cái cell
                row1_TieuDe_DanhSachKhachTro.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1_TieuDe_DanhSachKhachTro.Value2 = "Danh sách khách trọ";

                //Tạo ô STT
                Range row2_STT = workSheet.get_Range("A2");//Dòng 2 lấy cột A
                row2_STT.Merge();
                row2_STT.Font.Size = fontSizeTenTruong;
                row2_STT.Font.Name = fontName;
                row2_STT.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_STT.Value2 = "STT";

                //Tạo ô mã KH
                Range row2_MaKH = workSheet.get_Range("B2");//Dòng 2 lấy cột B
                row2_MaKH.Merge();
                row2_MaKH.Font.Size = fontSizeTenTruong;
                row2_MaKH.Font.Name = fontName;
                row2_MaKH.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_MaKH.Value2 = "Mã KH";
                row2_MaKH.ColumnWidth = 20;//set độ dài cột

                //Tạo ô Họ tên
                Range row2_HoTen = workSheet.get_Range("C2");//Dòng 2 lấy cột C
                row2_HoTen.Merge();
                row2_HoTen.Font.Size = fontSizeTenTruong;
                row2_HoTen.Font.Name = fontName;
                row2_HoTen.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_HoTen.Value2 = "Họ tên";
                row2_HoTen.ColumnWidth = 20;

                //Tạo ô Năm sinh
                Range row2_NamSinh = workSheet.get_Range("D2");//Dòng 2 lấy cột D
                row2_NamSinh.Merge();
                row2_NamSinh.Font.Size = fontSizeTenTruong;
                row2_NamSinh.Font.Name = fontName;
                row2_NamSinh.NumberFormat = "d/m/yy";
                row2_NamSinh.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_NamSinh.Value2 = "Năm sinh";
                row2_NamSinh.ColumnWidth = 20;

                //Tạo ô SDT
                Range row2_SDT = workSheet.get_Range("E2");//Dòng 2 lấy cột E
                row2_SDT.Merge();
                row2_SDT.Font.Size = fontSizeTenTruong;
                row2_SDT.Font.Name = fontName;
                row2_SDT.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_SDT.Value2 = "SDT";
                row2_SDT.ColumnWidth = 15;

                //Tạo ô giới tính
                Range row2_gender = workSheet.get_Range("F2");//Dòng 2 lấy cột F
                row2_gender.Merge();
                row2_gender.Font.Size = fontSizeTenTruong;
                row2_gender.Font.Name = fontName;
                row2_gender.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_gender.Value2 = "Giới tính";

                //Tạo ô quê quán
                Range row2_queQuan = workSheet.get_Range("G2");//Dòng 2 lấy cột G
                row2_queQuan.Merge();
                row2_queQuan.Font.Size = fontSizeTenTruong;
                row2_queQuan.Font.Name = fontName;
                row2_queQuan.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_queQuan.Value2 = "Quê quán";
                row2_queQuan.ColumnWidth = 20;

                //Tạo ô CMND
                Range row2_CMND = workSheet.get_Range("H2");//Dòng 2 lấy cột H
                row2_CMND.Merge();
                row2_CMND.Font.Size = fontSizeTenTruong;
                row2_CMND.Font.Name = fontName;
                row2_CMND.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2_CMND.Value2 = "CMND";
                row2_CMND.ColumnWidth = 20;

                //set chữ đậm cho tiêu đề
                row1_TieuDe_DanhSachKhachTro.Font.Bold = true;
                //chữ đen
                row1_TieuDe_DanhSachKhachTro.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;

                row = 2;//dữ liệu bắt đầu từ dong số 3, khai báo 2 khi vào foreach nó ++ lên thành 3
                
                foreach(Khách_hàng KH in DB.Khách_hàng)
                {
                    stt++;
                    row++;
                    //Các đối tượng thuộc kiểu dynamic sẽ không xác định được kiểu cho đến khi chương trình được thực thi. Tức là trình biên dịch sẽ bỏ qua tất cả lỗi về cú pháp, việc kiểm tra này sẽ thực hiện khi chương trình thực thi
                    dynamic[] arr = { stt, KH.Mã_KH, KH.Tên_KH, KH.Năm_sinh.ToShortDateString(), KH.Sđt,KH.Giới_tính, KH.Quê_quán, KH.CMND };
                    Range rowData = workSheet.get_Range("A" + row, "H" + row);//lấy dòng thứ row để bỏ 
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Value2 = arr;
                }

                //kẻ khung
                BorderAround(workSheet.get_Range("A2","H" + row));

                //Lưu file
                workBook.SaveAs(saveExcelFile);

                //Đóng file
                workBook.Close(true, missValue, missValue);
                //Thoát và thu hồi bộ nhớ COM
                xlApp.Quit();
                releaseObject(workSheet);
                releaseObject(workBook);
                releaseObject(xlApp);
                //Mở file sau khi thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}