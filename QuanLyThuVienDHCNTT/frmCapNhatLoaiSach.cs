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
    public partial class frmCapNhatLoaiSach : Form
    {
        public frmCapNhatLoaiSach()
        {
            InitializeComponent();
        }
        private void load()
        {
            CapNhatSach_BUS.Instance.xem(dgvloaisach);
        }
        private void frmCapNhatLoaiSach_Load(object sender, EventArgs e)
        {
            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmaloai.Text == "" || txttenloai.Text == "")
            {
                MessageBox.Show("Thông tin loại không được bỏ trống!!!");
            }
            else
            {
                try
                {
                    CapNhatSach_BUS.Instance.Them(txtmaloai.Text, txttenloai.Text);
                    MessageBox.Show("Thêm thành công");
                    load();
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công, trùng mã loại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txttenloai.Text == "")
            {
                MessageBox.Show("Trường thêm không nên để trống ");
            }else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    try
                    {
                        CapNhatSach_BUS.Instance.sua( txtmaloai.Text, txttenloai.Text);
                        MessageBox.Show("Sửa thành công");
                        load();
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Thông tin cần xóa hiện không tồn tại! ");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    try
                    {
                        CapNhatSach_BUS.Instance.xoaTheoMa(dgvloaisach);
                        MessageBox.Show("Xóa thành công");
                        load();
                    }catch{
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            CapNhatSach_BUS.Instance.timKiemTheoMa(dgvloaisach, txtTK.Text);
            
        }

        private void dgvloaisach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvloaisach.Rows[e.RowIndex];

                txtmaloai.Text = row.Cells[0].Value.ToString();
                txttenloai.Text = row.Cells[1].Value.ToString();
                
            }
        }

        private void txtmaloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttenloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
