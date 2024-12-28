using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class DangNhap_BUS
    {
        private static DangNhap_BUS instance;
        public static DangNhap_BUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DangNhap_BUS();
                }
                return instance;
            }
        }
        private DangNhap_BUS() { }
        public bool dangNhap(string taikhoan, string matkhau,string quyen)
        {

            return DangNhap_DAO.Instance.KTdangnhap(taikhoan, matkhau, quyen);

        }
        public bool dangNhap1(string taikhoan, string matkhau,string quyen)
        {

            return DangNhap_DAO.Instance.KTdangnhap2(taikhoan, matkhau, quyen);

        }
        
    }
}
