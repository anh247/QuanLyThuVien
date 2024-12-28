using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{
    public class ThongTinSach_BUS
    {
          private static ThongTinSach_BUS instance;
            public static ThongTinSach_BUS Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new ThongTinSach_BUS();
                    }
                    return instance;
                }
            }
            private ThongTinSach_BUS() { }
        public void xem(DataGridView data)
        {
            data.DataSource = ThongTinSach_DAO.Instance.xem();

        }
        public void xemconlai(DataGridView data)
        {
            data.DataSource = ThongTinSach_DAO.Instance.xemsachconlai();

        }
        public void timKiemTheoMa(DataGridView data, string masach)
        {
            data.DataSource = ThongTinSach_DAO.Instance.timKiemTheoMa(masach);
        }
        public void timKiemTheoMaTT(DataGridView data, string masach)
        {
            data.DataSource = ThongTinSach_DAO.Instance.timKiemTheoMaTT(masach);
        }
        public void timKiemTheoMaTG(DataGridView data, string tacgia)
        {
            data.DataSource = ThongTinSach_DAO.Instance.timKiemTheoMaTG(tacgia);
        }
        public bool xoaTheoMa(DataGridView data)
        {
            string masach = data.SelectedCells[0].OwningRow.Cells["Mã Sách"].Value.ToString();

            return ThongTinSach_DAO.Instance.xoaTheoMa(masach);
        }
        public bool sua(DataGridView data, string masach, string tensach, string sotrang, string soluong,string namsxb, string lanxb,string maloai,string nhaxb,string tacgia,string ngaynhap)
        {
            return ThongTinSach_DAO.Instance.Sua(masach , tensach, sotrang, soluong, namsxb, lanxb, maloai, nhaxb,tacgia,ngaynhap);
        }
        public bool Them(DataGridView data, string masach, string tensach, string sotrang, string soluong, string namsxb, string lanxb, string maloai, string nhaxb, string tacgia, string ngaynhap)
        {
            
            return ThongTinSach_DAO.Instance.Them(masach, tensach, sotrang, soluong, namsxb, lanxb, maloai, nhaxb, tacgia, ngaynhap);
        }

    }
}
