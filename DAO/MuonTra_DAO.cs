using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MuonTra_DAO
    {
        private static MuonTra_DAO instance;
        public static MuonTra_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MuonTra_DAO();
                }
                return instance;
            }
        }
        private MuonTra_DAO() { }
        public DataTable xem()
        {
            string query = "select MaDocGia as 'Mã độc giả',NgayMuon as 'Ngày mượn',MaSach as 'Mã sách',MaThuThu as 'Mã thủ thư',SoLuong as 'Số lượng',TrangThai as 'Trạng thái',NgayTra as 'Ngày trả' from PHIEUMUON";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable xemdangmuon()
        {
           
            string query = "select MaDocGia as 'Mã độc giả',NgayMuon as 'Ngày mượn',p.MaSach as 'Mã sách',MaThuThu as 'Mã thủ thư',p.SoLuong as 'Số lượng',TrangThai as 'Trạng thái',NgayTra as 'Ngày trả' from PHIEUMUON p,SACH where TrangThai LIKE N'Đang mượn' and SACH.MaSach = p.MaSach";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable xemquahan()
        {

            string query = "select MaDocGia as 'Mã độc giả',NgayMuon as 'Ngày mượn',MaSach as 'Mã sách',MaThuThu as 'Mã thủ thư',SoLuong as 'Số lượng',TrangThai as 'Trạng thái',NgayTra as 'Ngày trả' from PHIEUMUON where TrangThai = ' Đang mượn ' and SACH.MaSach = PHIEUMUON.MaSach and PHIEUMUON.NgayTra<GetDate() ";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable timKiemTheoMa(string madocgia)
        {

            string query = "select MaDocGia as 'Mã độc giả',NgayMuon as 'Ngày mượn',MaSach as 'Mã sách',MaThuThu as 'Mã thủ thư',SoLuong as 'Số lượng',TrangThai as 'Trạng thái',NgayTra as 'Ngày trả' from PHIEUMUON where MaDocGia = @madocgia ";
            object[] parameter = new object[] { madocgia };
            return DataProvider.Instance.ExcuteQuery(query, parameter);
        }

        public bool xoaTheoMa(string madocgia)
        {
            string query = "delete from PHIEUMUON where madocgia = @madocgia";
            object[] para = new object[] { madocgia };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Sua(string madocgia, string ngaymuon, string masach, string mathuthu, string soluong, string trangthai ,string ngaytra)
        {
            string query = "update PHIEUMUON set MaSach = @masach , NgayMuon = @ngaymuon , SoLuong = @soluong , TrangThai = @trangthai , NgayTra = @ngaytra  where MaDocGia = @madocgia and MaThuThu = @mathuthu ";
            object[] para = new object[] { masach,ngaymuon,soluong,trangthai,ngaytra,madocgia,mathuthu};
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Them(string madocgia, string ngaymuon, string masach, string mathuthu, string soluong, string trangthai, string ngaytra)
        {
            string query = "insert into PHIEUMUON values ( @madocgia , @ngaymuon , @masach , @mathuthu , @soluong , @trangthai , @ngaytra )";

            
            object[] para = new object[] { madocgia, ngaymuon, masach, mathuthu, soluong, trangthai, ngaytra };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool capNhatkhimuon(string soluong , string masach)
        {
            

            string query = "update SACH set SoLuong = SACH.SoLuong - @SoLuong  where MaSach = @masach ";
            object[] para = new object[] { soluong , masach};
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool capNhatkhitra(string soluong, string masach)
        {


            string query = "update SACH set SoLuong = SACH.SoLuong + @SoLuong  where MaSach = @masach ";
            object[] para = new object[] { soluong, masach };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Giahan(string madocgia, string mathuthu,string giahan)
        {
            string query = "update PHIEUMUON set NgayTra = DATEADD(day, @giahan ,NgayTra) where MaDocGia = @madocgia and MaThuThu =  @mathuthu ";
            object[] para = new object[] { giahan, madocgia, mathuthu };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
