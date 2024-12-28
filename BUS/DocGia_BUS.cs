using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace BUS
{

    //SSSSSSDĐ

    //hahaahaahaah

    public class DocGia_BUS
    {
        private static DocGia_BUS instance;
        public static DocGia_BUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DocGia_BUS();
                }
                return instance;
            }
        }
        private DocGia_BUS() { }
        public void xem(DataGridView data)
        {
            data.DataSource = DocGia_DAO.Instance.xem();

        }
        public void timKiemTheoMa(DataGridView data,string madocgia)
        {
            data.DataSource = DocGia_DAO.Instance.timKiemTheoMa(madocgia);
        }
        public bool xoaTheoMa(DataGridView data)
        {
            if (data.SelectedCells.Count > 0)
            {
                string madocgia = data.SelectedCells[0].OwningRow.Cells["Mã đọc giả"].Value.ToString();
                return DocGia_DAO.Instance.xoaTheoMa(madocgia);
            }
            return false;
        }
        public bool sua(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string madocgiacu= row.Cells["Mã đọc giả"].Value.ToString();
            
            string madocgia = row.Cells["Mã đọc giả"].Value.ToString();
            string hoten = row.Cells["Họ tên"].Value.ToString();
            DateTime ngaysinh= (DateTime )row.Cells["Ngày sinh"].Value;
            string diachi = row.Cells["Địa chỉ"].Value.ToString();
            DateTime ngaylapthe= (DateTime )row.Cells["Ngày lập thẻ"].Value;
            string matkhau = row.Cells["Mật khẩu"].Value.ToString();
            DocGia_DTO docgia = new DocGia_DTO() { Madocgia = madocgia, Hoten = hoten, Ngaysinh = ngaysinh,Diachi =diachi , Ngaylapthe = ngaylapthe, Matkhau = matkhau };
            return DocGia_DAO.Instance.Sua(madocgiacu,docgia);
        }
        public bool Them(string madocgia,string hoten,string namsinh,string diachi,string ngaylapthe, string matkhau)
        {
            /*DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string madocgia = row.Cells["Mã đọc giả"].Value.ToString();
            string hoten = row.Cells["Họ tên"].Value.ToString();
            DateTime ngaysinh = (DateTime)row.Cells["Ngày sinh"].Value;
            string diachi = row.Cells["Địa chỉ"].Value.ToString();
            DateTime ngaylapthe = (DateTime)row.Cells["Ngày lập thẻ"].Value;
            string matkhau = row.Cells["Mật khẩu"].Value.ToString();*/
            //  DocGia_DTO docgia = new DocGia_DTO() { Madocgia = madocgia, Hoten = hoten, Ngaysinh = ngaysinh, Diachi = diachi, Ngaylapthe = ngaylapthe, Matkhau = matkhau };
            return DocGia_DAO.Instance.Them(madocgia, hoten, namsinh, diachi, ngaylapthe, matkhau);
        }

       // public bool Them(DataGridView dgvDSTTdocgia, string text1, string text2, string text3)
      //  {
       //     throw new NotImplementedException();
      //  }

       // public void sua(DataGridView dgvDSTTdocgia, object text1, string text2, string text3, object text4, object text5, object text6)
      //  {
       //     throw new NotImplementedException();
       // }

      //  public void sua(DataGridView dgvDSTTdocgia, string text1, string text2, string text3)
       // {
       //     throw new NotImplementedException();
      //  }

      //  public void sua(DataGridView dgvDSTTdocgia, string text1, string text2, string text3, string text4, string text5)
       // {
       //     throw new NotImplementedException();
       // }
        public bool Sua(string madocgia, string hoten, DateTime ngaysinh, string diachi, DateTime ngaylapthe, string matkhau)
        {
            DocGia_DTO docgia = new DocGia_DTO
            {
                Madocgia = madocgia,
                Hoten = hoten,
                Ngaysinh = ngaysinh,
                Diachi = diachi,
                Ngaylapthe = ngaylapthe,
                Matkhau = matkhau

            };
            return DocGia_DAO.Instance.Sua(madocgia, docgia);
        }
    }
}
