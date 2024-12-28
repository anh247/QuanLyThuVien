using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia_DTO
    {
        private string madocgia;

        public string Madocgia { get => madocgia; set => madocgia = value; }
        private string hoten;
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaylapthe { get => ngaylapthe; set => ngaylapthe = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }

        private DateTime ngaysinh;
        private string diachi;
        private DateTime ngaylapthe;
        private string matkhau;


        
    }
}
