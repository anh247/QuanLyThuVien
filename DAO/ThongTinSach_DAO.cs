using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongTinSach_DAO
    {
        private static ThongTinSach_DAO instance;
        public static ThongTinSach_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongTinSach_DAO();
                }
                return instance;
            }
        }
        private ThongTinSach_DAO() { }
        public DataTable xem()
        {
            string query = "select MaSach as 'Mã Sách',TenSach as 'Tên Sách',SoTrang as 'Số trang',SoLuong as 'Số lượng',NamXB as 'Năm xuất bản',LanXB as 'Lần xuất bản',MaLoai as 'Mã loại',NXB as 'Nhà xuất bản',TacGia as 'Tác giả',NgayNhap as 'Ngày nhập' from SACH";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable xemsachconlai()
        {
            string query = "select MaSach as 'Mã Sách',TenSach as 'Tên Sách',SoTrang as 'Số trang',SoLuong as 'Số lượng còn lại',NamXB as 'Năm xuất bản',LanXB as 'Lần xuất bản',MaLoai as 'Mã loại',NXB as 'Nhà xuất bản',TacGia as 'Tác giả',NgayNhap as 'Ngày nhập' from SACH";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable timKiemTheoMa(string masach)
        {

            string query = "select MaSach as 'Mã Sách',TenSach as 'Tên Sách',SoTrang as 'Số trang',SoLuong as 'Số lượng',NamXB as 'Năm xuất bản',LanXB as 'Lần xuất bản',MaLoai as 'Mã loại',NXB as 'Nhà xuất bản',TacGia as 'Tác giả',NgayNhap as 'Ngày nhập' from SACH where MaSach = @masach";
            object[] parameter = new object[] { masach };
            return DataProvider.Instance.ExcuteQuery(query, parameter);
        }
        public bool xoaTheoMa(string masach)
        {
            string query = "delete from SACH where MaSach = @masach";
            object[] para = new object[] { masach };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Sua(string masach, string tensach, string sotrang, string soluong,string namsxb, string lanxb, string maloai,string nhaxb, string tacgia, string ngaynhap)
        {
            string query = "update SACH set TenSach= @tensach , SoTrang= @sotrang , SoLuong = @SoLuong , NamXB= @namxb , LanXB = @lanxb , MaLoai = @maloai , NXB = @nxb , TacGia = @tacgia , NgayNhap = @ngayNhap where MaSach = @masach ";
            object[] para = new object[] { tensach, sotrang, soluong, namsxb, lanxb , maloai ,nhaxb,tacgia ,ngaynhap, masach  };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Them(string masach, string tensach, string sotrang, string soluong, string namsxb, string lanxb, string maloai, string nhaxb, string tacgia, string ngaynhap)
        {
            string query = "insert into SACH values ( @masach , @tensach , @sotrang , @soluong , @namxb , @lanxb , @maloai , @nxb , @tacgia , @ngaynhap )";
            object[] para = new object[] { masach, tensach, sotrang, soluong, namsxb, lanxb ,maloai,nhaxb,tacgia,ngaynhap };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable timKiemTheoMaTT(string masach)
        {

            string query = "select MaSach as 'Mã Sách',TenSach as 'Tên Sách',SoTrang as 'Số trang',SoLuong as 'Số lượng',NamXB as 'Năm xuất bản',LanXB as 'Lần xuất bản',MaLoai as 'Mã loại',NXB as 'Nhà xuất bản',TacGia as 'Tác giả',NgayNhap as 'Ngày nhập' from SACH where TenSach = @masach ";
            object[] parameter = new object[] { masach };
            return DataProvider.Instance.ExcuteQuery(query, parameter);
        }
        public DataTable timKiemTheoMaTG(string tacgia)
        {

            string query = "select MaSach as 'Mã Sách',TenSach as 'Tên Sách',SoTrang as 'Số trang',SoLuong as 'Số lượng',NamXB as 'Năm xuất bản',LanXB as 'Lần xuất bản',MaLoai as 'Mã loại',NXB as 'Nhà xuất bản',TacGia as 'Tác giả',NgayNhap as 'Ngày nhập' from SACH where TacGia  = @tacgia ";
            object[] parameter = new object[] { tacgia };
            return DataProvider.Instance.ExcuteQuery(query, parameter);
        }

    }
}
