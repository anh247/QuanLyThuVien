using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DocGia_DAO
    {

        private static DocGia_DAO instance;
        public static DocGia_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DocGia_DAO();
                }
                return instance;
            }
        }
        private DocGia_DAO() { }
        public DataTable xem()
        {
            string query = "select MaDocGia as 'Mã đọc giả',HoTen as 'Họ tên',NgaySinh as 'Ngày sinh',DiaChi as 'Địa chỉ',NGAYLAPTHE as 'Ngày lập thẻ',MatKhau as 'Mật Khẩu' from DOCGIA";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable loadma()
        {
            string query = "select MaDocGia from DOCGIA";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable timKiemTheoMa(string madocgia)
        {
            
            string query = "select MaDocGia as 'Mã đọc giả',HoTen as 'Họ tên',NgaySinh as 'Ngày sinh',DiaChi as 'Địa chỉ',NGAYLAPTHE as 'Ngày lập thẻ',MatKhau as 'Mật Khẩu' from DOCGIA where MaDocGia = @madocgia";
            object[] parameter = new object[] { madocgia };
            return DataProvider.Instance.ExcuteQuery(query, parameter);
        }
        /// <summary>
        /// Sửa trường nào có mã độc giả tương ứng.
        /// </summary>
        /// <param name="madocgia"></param>
        /// <returns></returns>
        public bool xoaTheoMa(string madocgia)
        {
            string query = "delete from DOCGIA where MaDocGia = @madocgia";
            object[] para = new object[] {madocgia };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Sua(string madocgia, DocGia_DTO docgia)
        {
           // string query = "update DOCGIA set HoTen = N'" + docgia.Hoten  + "',NgaySinh='" + docgia.Ngaysinh + "',DiaChi=N'" + docgia.Diachi  + "',NgayLapThe='" + docgia.Ngaylapthe  + "' where MaDocGia ='" + madocgia + "'";
            string query = "update DOCGIA set HoTen= @hoten , NgaySinh= @ngaysinh , DiaChi= @diachi , NGAYLAPTHE = @ngaylapthe , MatKhau= @matkhau where MaDocGia = @madocgia ";
            object[] para = new object[] {docgia.Hoten, docgia.Ngaysinh, docgia.Diachi, docgia.Ngaylapthe, docgia.Matkhau, madocgia };
            if(DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Them(string madocgia, string hoten, string namsinh, string diachi, string ngaylapthe)
        {
            // string query = "update DOCGIA set HoTen = N'" + docgia.Hoten  + "',NgaySinh='" + docgia.Ngaysinh + "',DiaChi=N'" + docgia.Diachi  + "',NgayLapThe='" + docgia.Ngaylapthe  + "' where MaDocGia ='" + madocgia + "'";
            string query = "insert into DOCGIA values ( @madocgia , @hoten , @ngaysinh , @diachi , @ngaylapthe , @matkhau )";
            object[] para = new object[] { madocgia, hoten, namsinh, diachi, ngaylapthe ,namsinh};
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    } 
}
