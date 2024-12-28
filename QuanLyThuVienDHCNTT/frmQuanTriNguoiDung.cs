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
    public partial class frmQuanTriNguoiDung : Form
    {
        public frmQuanTriNguoiDung()
        {
            InitializeComponent();
        }
        private void load()
        {
            ThuThu_BUS.Instance.xem(dgvDSthuthu);
        }
        private void frmQuanTriNguoiDung_Load(object sender, EventArgs e)
        {
            
            load();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ThuThu_BUS.Instance.timKiemTheoMa(dgvDSthuthu, txtTK.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                try
                {
                    ThuThu_BUS.Instance.xoaTheoMa(dgvDSthuthu);
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
                
        }

        private void btnsua_Click(object sender, EventArgs e)
        {


            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                try
                {
                    ThuThu_BUS.Instance.sua(dgvDSthuthu, txtmnv.Text, txthoten.Text, txtdiachi.Text, txttendn.Text, txtmatkhau.Text, cbquyenhan.Text);
                    MessageBox.Show("Sửa thành công");
                    load();
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (ThuThu_BUS.Instance.Them(dgvDSthuthu, txtmnv.Text, txthoten.Text, txtdiachi.Text, txttendn.Text,txtmatkhau.Text,cbquyenhan.Text) == true)
            {
                MessageBox.Show("Thêm thành công");
                load();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void dgvDSthuthu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSthuthu.Rows[e.RowIndex];

                txtmnv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                txttendn.Text = row.Cells[3].Value.ToString();
                txtmatkhau.Text = row.Cells[4].Value.ToString();
                cbquyenhan.Text = row.Cells[5].Value.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            // Đặt lại các ô nhập liệu về trạng thái mặc định hoặc trống
            txtmnv.Text = "";       // Xóa mã nhân viên
            txthoten.Text = "";      // Xóa họ tên
            txtdiachi.Text = "";     // Xóa địa chỉ
            txttendn.Text = "";      // Xóa tên đăng nhập
            txtmatkhau.Text = "";    // Xóa mật khẩu
            cbquyenhan.SelectedIndex = -1; // Đặt combobox về trạng thái chưa chọn

            // Làm mới lại bảng dữ liệu nếu cần
            load();
        }
    }

    internal class Connection
    {
        internal void OpenConn()
        {
            throw new NotImplementedException();
        }
    }
}
