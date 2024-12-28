using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhap_DAO
    {
        DataSet ds = new DataSet();
        Connection cn = new Connection();
        SqlCommand cm, cm1;
        SqlDataAdapter da;
        SqlDataReader dr;
        private static DangNhap_DAO instance;
        public static DangNhap_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DangNhap_DAO();
                }
                return instance;
            }
        }
        private DangNhap_DAO() { }
        public bool KTdangnhap(string USER, string PASSWORD,string quyen)
        {

            cn.OpenConn();
            cm = new SqlCommand("select MaThuThu from THUTHU where MaThuThu='" + USER + "' and MatKhau='" + PASSWORD + "'", cn.con);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
                return false;
            cm.Dispose();
            dr.Dispose();
            cn.CloseConn();

        }
        public bool KTdangnhap2(string USER, string PASSWORD,string quyen)
        {

            cn.OpenConn();
            cm = new SqlCommand("select MaDocGia from DOCGIA where MaDocGia='" + USER + "' and MatKhau='" + PASSWORD + "'", cn.con);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
                return false;
            cm.Dispose();
            dr.Dispose();
            cn.CloseConn();

        }
        public string quyenhan(string USER)
        {
            cn.OpenConn();
            string a = "select QuyenHan from THUTHU where MaThuThu='" + USER + "'";
            SqlDataReader dr = cn.executeSQL(a);
            string quyen = "";
            while (dr.Read())
            {
                quyen = dr[0].ToString();
            }
            cn.CloseConn();
            return quyen;
        }


        public DataTable thongtincanhan(string ai)
        {
            cn.OpenConn();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select MaThuThu as 'Mã thủ Thư',HoTen as 'Họ tên',DiaChi as 'Địa chỉ',TenDangNhap as 'Tên đăng nhập',MatKhau as 'Mật khẩu',QuyenHan as 'Quyền hạn' from THUTHU where MaThuThu='" + ai + "'", cn.con);
            da.Fill(dt);
            cn.CloseConn();
            return dt;
        }
        public DataTable thongtincanhan2(string ai)
        {
            cn.OpenConn();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select MaDocGia as 'Mã đọc giả',HoTen as 'Họ tên',NgaySinh as 'Ngày sinh',DiaChi as 'Địa chỉ',NgayLapThe as 'Ngày lập thẻ' from DOCGIA where MaDocGia='" + ai + "'", cn.con);
            da.Fill(dt);
            cn.CloseConn();
            return dt;
        }
        public string XinChao1(string mathuthu)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            SqlCommand cm = new SqlCommand("select HoTen from THUTHU where MaThuThu='" + mathuthu + "'", cn.con);
            string hoten = cm.ExecuteScalar() as string;
            cn.CloseConn();
            return hoten;
        }
        public string XinChao2(string madocgia)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            SqlCommand cm = new SqlCommand("select HoTen from DOCGIA where MaDocGia='" + madocgia + "'", cn.con);
            string hoten = cm.ExecuteScalar() as string;
            cn.CloseConn();
            return hoten;
        }

    }
}
