using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{
    public class CapNhatSach_BUS
    {
        private static CapNhatSach_BUS instance;
        public static CapNhatSach_BUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CapNhatSach_BUS();
                }
                return instance;
            }
        }
        private CapNhatSach_BUS() { }
        public void xem(DataGridView data)
        {
            data.DataSource = CapNhatSach_DAO.Instance.xem();

        }
        public void timKiemTheoMa(DataGridView data, string maloai)
        {
            data.DataSource = CapNhatSach_DAO.Instance.timKiemTheoMa(maloai);
        }
        public bool xoaTheoMa(DataGridView data)
        {
            string maloai = data.SelectedCells[0].OwningRow.Cells["Mã Loại"].Value.ToString();

            return CapNhatSach_DAO.Instance.xoaTheoMa(maloai);
        }
        public bool sua(string maloai,string tenloai)
        {
           
            return CapNhatSach_DAO.Instance.Sua(maloai, tenloai) ;
        }
       public bool Them(string maloai,string tenloai)
        {
            
            return CapNhatSach_DAO.Instance.Them(maloai,tenloai);
        }

        public void sua(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }
    }
}
