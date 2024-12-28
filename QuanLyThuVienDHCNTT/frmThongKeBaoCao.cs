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
    public partial class frmThongKeBaoCao : Form
    {
        public frmThongKeBaoCao()
        {
            InitializeComponent();
        }
        private void load()
        {
            MuonTra_BUS.Instance.xem(dgvThongkebaocao);
        }
        private void frmThongKeBaoCao_Load(object sender, EventArgs e)
        {
            load();
            
        }

        private void cbphanloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbphanloai.Text.CompareTo("Sách đang được mượn") == 0)
            {
                MuonTra_BUS.Instance.xemdangmuon(dgvThongkebaocao);
                // sachdangmuon();
                //  dgvThongkebaocao.DataSource = sachdangmuon();
                // phansachtheoloai();
            }
            else
                if (cbphanloai.Text.CompareTo("Sách còn lại") == 0)
            {
                ThongTinSach_BUS.Instance.xemconlai(dgvThongkebaocao);
            }
            else
               if (cbphanloai.Text.CompareTo("Sách quá hạn") == 0)
            {
                // dgvThongkebaocao.DataSource = Thongtinsachquahan();
            }
        }

        private void dgvThongkebaocao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
