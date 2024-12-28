using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
namespace BUS
{
    public class ThuThu_BUS
    {
        private static ThuThu_BUS instance;
        public static ThuThu_BUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThuThu_BUS();
                }
                return instance;
            }
        }
        private ThuThu_BUS() { }
        public void xem(DataGridView data)
        {
            data.DataSource = ThuThu_DAO.Instance.xem();

        }
        public void timKiemTheoMa(DataGridView data, string mathuthu)
        {
            data.DataSource = ThuThu_DAO.Instance.timKiemTheoMa(mathuthu);
        }
        public bool xoaTheoMa(DataGridView data)
        {
            string mathuthu = data.SelectedCells[0].OwningRow.Cells["Mã Thủ Thư"].Value.ToString();

            return ThuThu_DAO.Instance.xoaTheoMa(mathuthu);
        }
        public bool sua(DataGridView data, string mathuthu, string hoten, string diachi, string tendangnhap, string matkhau, string quyen)
        {
           /* DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string mathuthucu = row.Cells["Mã Thủ Thư"].Value.ToString();

            string mathuthu = row.Cells["Mã Thủ Thư"].Value.ToString();
            string hoten = row.Cells["Họ tên"].Value.ToString();
            string diachi = row.Cells["Địa chỉ"].Value.ToString();
            string tendangnhap=row.Cells["Tên đăng nhập"].Value.ToString();
            string matkhau = row.Cells["Mật khẩu"].Value.ToString();
            string quen = row.Cells["Quyền hạn"].Value.ToString();*/
            //ThuThu_DTO  thuthu = new ThuThu_DTO () { Mathuthu  = mathuthu , Hoten = hoten, Diachi = diachi,Tendangnhap=tendangnhap , Matkhau = matkhau ,Quyen =quen  };
            return ThuThu_DAO.Instance.Sua(mathuthu, hoten, diachi, tendangnhap, matkhau, quyen);
        }
        public bool Doimk(string tendangnhap, string matkhaucu, string matkhaumoi)
        {
            
            return ThuThu_DAO.Instance.Doimk(tendangnhap,matkhaucu,matkhaumoi);
        }
        public bool Them(DataGridView data, string mathuthu, string hoten, string diachi, string tendangnhap, string matkhau, string quyen)
        {
           /* DataGridViewRow row = data.SelectedCells[0].OwningRow;

            mathuthu = row.Cells["Mã Thủ Thư"].Value.ToString();
            hoten = row.Cells["Họ tên"].Value.ToString();
            diachi = row.Cells["Địa chỉ"].Value.ToString();
            tendangnhap = row.Cells["Tên đăng nhập"].Value.ToString();
            matkhau = row.Cells["Mật khẩu"].Value.ToString();
            quyen = row.Cells["Quyền hạn"].Value.ToString();*/

           // ThuThu_DTO  thuthu = new ThuThu_DTO () { Mathuthu =mathuthu  , Hoten = hoten, Diachi = diachi, Tendangnhap=tendangnhap, Matkhau = matkhau, Quyen=quyen };
            return ThuThu_DAO.Instance.Them(mathuthu ,hoten ,diachi ,tendangnhap , matkhau ,quyen );
        }
    }
}
