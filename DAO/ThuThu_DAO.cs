using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ThuThu_DAO
    {
        private static ThuThu_DAO instance;
        public static ThuThu_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThuThu_DAO();
                }
                return instance;
            }
        }
        private ThuThu_DAO() { }
        public DataTable xem()
        {
            string query = "select MaThuThu as 'Mã Thủ Thư',HoTen as 'Họ tên',DiaChi as 'Địa chỉ',TenDangNhap as 'Tên đăng nhập',MatKhau as 'Mật khẩu',QuyenHan as 'Quyền hạn' from THUTHU";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable timKiemTheoMa(string mathuthu)
        {

            string query = "select HoTen as 'Họ tên',DiaChi as 'Địa chỉ',TenDangNhap as 'Tên đăng nhập',MatKhau as 'Mật khẩu',QuyenHan as 'Quyền hạn' from THUTHU where MaThuThu = @mathuthu ";
            object[] parameter = new object[] { mathuthu };
            return DataProvider.Instance.ExcuteQuery(query, parameter);
        }
        
        public bool xoaTheoMa(string mathuthu)
        {
            string query = "delete from THUTHU where MaThuThu = @mathuthu";
            object[] para = new object[] { mathuthu  };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Sua(string mathuthu, string hoten, string diachi, string tendangnhap, string matkhau, string quyen)
        { 
            string query = "update THUTHU set HoTen= @hoten , DiaChi= @diachi ,TenDangNhap= @tendangnhap , MatKhau= @matkhau , QuyenHan = @quenhan where MaThuThu = @mathuthu ";
            object[] para = new object[] { hoten , diachi , tendangnhap , matkhau , quyen  , mathuthu };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Them(string ma,string hoten, string diachi, string tendangnhap, string matkhau, string quyen )
        { 
            string query = "insert into THUTHU values ( @mathuthu , @hoten , @diachi , @tendangnhap , @matkhau , @quyen )";
            object[] para = new object[] {  ma , hoten , diachi , tendangnhap , matkhau , quyen  };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Doimk(string tendangnhap, string matkhaucu,string matkhaumoi)
        {
            string query = "update  THUTHU set MatKhau= @matkhaumoi where MaThuThu= @mathuthu and MatKhau = @matkhaucu";
            object[] para = new object[] { matkhaumoi,tendangnhap,matkhaucu };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
