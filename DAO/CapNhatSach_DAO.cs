using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class CapNhatSach_DAO
    {
        private static CapNhatSach_DAO instance;
        public static CapNhatSach_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CapNhatSach_DAO();
                }
                return instance;
            }
        }
        private CapNhatSach_DAO() { }
        public DataTable xem()
        {
            string query = "select maloai as 'Mã Loại',tenloai as 'Tên loại' from phanloai";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable timKiemTheoMa(string maloai)
        {

            string query = "select maloai as 'Mã Loại',tenloai as 'Tên loại' from phanloai where maloai = @maloai ";
            object[] parameter = new object[] { maloai };
            return DataProvider.Instance.ExcuteQuery(query, parameter);
        }

        public bool xoaTheoMa(string maloai)
        {
            string query = "delete from phanloai where maloai = @maloai";
            object[] para = new object[] { maloai };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Sua(string maloai,string tenloai)
        {
            string query = "update phanloai set tenloai = @tenloai where maloai = @maloai ";
            object[] para = new object[] { tenloai,maloai };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
        public bool Them(string maloai,string tenloai)
        {
            string query = "insert into phanloai values ( @maloai , @tenloai )";
            object[] para = new object[] { maloai,tenloai };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
