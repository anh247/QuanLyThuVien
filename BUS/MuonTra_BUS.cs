using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{
    public class MuonTra_BUS
    {
        private static MuonTra_BUS instance;
        public static MuonTra_BUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MuonTra_BUS();
                }
                return instance;
            }
        }
        private MuonTra_BUS() { }
        public void xem(DataGridView data)
        {
            data.DataSource = MuonTra_DAO.Instance.xem();

        }
        public void xemdangmuon(DataGridView data)
        {
            data.DataSource = MuonTra_DAO.Instance.xemdangmuon();

        }
        public void timKiemTheoMa(DataGridView data, string madocgia)
        {
            data.DataSource = MuonTra_DAO.Instance.timKiemTheoMa(madocgia);
        }
        public bool xoaTheoMa(DataGridView data)
        {
            string madocgia = data.SelectedCells[0].OwningRow.Cells["Mã độc giả"].Value.ToString();

            return MuonTra_DAO.Instance.xoaTheoMa(madocgia);
        }
        public bool sua(DataGridView data, string madocgia , string ngaymuon , string masach , string mathuthu , string soluong , string trangthai ,string ngaytra)
        {
            return MuonTra_DAO.Instance.Sua(madocgia , ngaymuon , masach , mathuthu , soluong , trangthai , ngaytra );
        }
        public bool Them(DataGridView data, string madocgia, string ngaymuon, string masach, string mathuthu, string soluong, string trangthai, string ngaytra)
        {

            return MuonTra_DAO.Instance.Them(madocgia, ngaymuon, masach, mathuthu, soluong, trangthai, ngaytra);
        }
        public bool capNhatkhimuon(DataGridView data, string soluong ,string masach)
        {

            return MuonTra_DAO.Instance.capNhatkhimuon(soluong,masach);
        }
        public bool capNhatkhitra(DataGridView data, string soluong, string masach)
        {

            return MuonTra_DAO.Instance.capNhatkhitra(soluong, masach);
        }
        public bool Giahan(DataGridView data, string madocgia, string mathuthu, string giahan)
        {
            return MuonTra_DAO.Instance.Giahan(madocgia, mathuthu,giahan);
        }

    }
}
