using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            if (GUI.frmDangNhap.aidangdangnhap.CompareTo("admin") == 0)
            {
              
                label2.Text = "";
                //nguoiToolStripMenuItem.Text = xl.XinChao1(frmDangnhap.aidangdangnhap);
            }
            else if (GUI.frmDangNhap.aidangdangnhap.CompareTo("docgia") == 0)
            {
                // nguoiToolStripMenuItem.Text = xl.XinChao2(frmDangnhap.aidangdangnhap);
                // MessageBox.Show("Toi da vao if doc gia");
                qUẢNLÝSÁCHToolStripMenuItem.Visible = false;
                qUẢNLÝMƯỢNTRẢToolStripMenuItem.Visible = false;
                qUẢNLÝĐỌCGIẢToolStripMenuItem.Visible = false;
                tKBCToolStripMenuItem.Visible = false;
                qUẢNTRỊHỆTHỐNGToolStripMenuItem.Visible = false;
                nguoiToolStripMenuItem.Visible = true;
                //nguoiToolStripMenuItem.Text = xl.XinChao2(frmDangnhap.aidangdangnhap);
                // tÌMKIẾMToolStripMenuItem.Visible = false;
            }
            else if (GUI.frmDangNhap.aidangdangnhap.CompareTo("thuthu") == 0)
            {

                qUẢNTRỊHỆTHỐNGToolStripMenuItem.Visible = false;
                xemThôngTinToolStripMenuItem.Visible = false;
                //label2.Text = xl.XinChao1(frmDangnhap.aidangdangnhap);
                //nguoiToolStripMenuItem.Text = xl.XinChao1(frmDangnhap.aidangdangnhap);
            }
        }

        private void quảnLýThôngTinĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GUI.frmQLTTDocGia f = new frmQLTTDocGia();
            GUI.frmQLTTDocGia f = new frmQLTTDocGia();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnTrịNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmQuanTriNguoiDung f = new frmQuanTriNguoiDung();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                GUI.frmDangNhap f = new GUI.frmDangNhap();
                f.Show();
                this.Close();
            }
        }

        private void cậpNhậtLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmCapNhatLoaiSach f = new GUI.frmCapNhatLoaiSach();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmQuanLyThongTinSach f = new GUI.frmQuanLyThongTinSach();
            f.MdiParent = this;
            f.Show();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmMuonTraSach f = new GUI.frmMuonTraSach();
            f.MdiParent = this;
            f.Show();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tKBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeBaoCao f = new frmThongKeBaoCao();
            f.MdiParent = this;
            f.Show();
        }

        private void tÌMKIẾMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.MdiParent = this;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();

            f.MdiParent = this;
            f.Show();
        }
    }
}
