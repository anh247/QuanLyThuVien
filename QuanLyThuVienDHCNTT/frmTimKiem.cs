using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        private void load()
        {
            ThongTinSach_BUS.Instance.xem(dgvthongtin);
        }
        
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbtimkiem.Text == "Mã sách")
                ThongTinSach_BUS.Instance.timKiemTheoMa(dgvthongtin, txttimkiem.Text.Trim());
            if (cbtimkiem.Text == "Tên sách")
                ThongTinSach_BUS.Instance.timKiemTheoMaTT(dgvthongtin, txttimkiem.Text.Trim());
            if (cbtimkiem.Text == "Tác giả")
                    ThongTinSach_BUS.Instance.timKiemTheoMaTG(dgvthongtin, txttimkiem.Text.Trim());
        }
            private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.Show();
        }

        private void dgvthongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
