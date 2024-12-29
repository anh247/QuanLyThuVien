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

namespace QuanLyThuVienDHCNTT
{
    public partial class frmQuanLyDocGia : Form
    {
        public frmQuanLyDocGia()
        {
            InitializeComponent();
        }
        private void load()
        {
            DocGia_BUS.Instance.xem(dgvDSTTdocgia);
        }
        private void frmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            load();
            
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (DocGia_BUS.Instance.Them(
                dgvDSTTdocgia,
                txtMadocgia.Text,
                txthoten.Text,
                dtpNgaysinh.Value.ToString("yyyy-MM-dd"),
                txtdiachi.Text,
                txtmk.Text,
                dtpngaylapthe.Value.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Thêm thành công");
                load(); // Tải lại danh sách
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                try
                {
                    // Gọi hàm sửa từ BUS
                    if (DocGia_BUS.Instance.Sua(
                       dgvDSTTdocgia,
                        txtMadocgia.Text,
                         txthoten.Text,
                        dtpNgaysinh.Value,
                        txtdiachi.Text,
                       //  txtmk.Text,
                        dtpngaylapthe.Value,
                        txtmk.Text
                        ))
                    {
                        MessageBox.Show("Sửa thành công");
                        load(); // Tải lại danh sách sau khi sửa
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                try
                {
                    DocGia_BUS.Instance.xoaTheoMa(dgvDSTTdocgia);
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            DocGia_BUS.Instance.timKiemTheoMa(dgvDSTTdocgia, txtTK.Text);
        }

        private void dgvDSTTdocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSTTdocgia.Rows[e.RowIndex];

                txtMadocgia.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
               
                txtdiachi.Text = row.Cells[3].Value.ToString();
                ;

            }
        }

        private void txtMadocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmk_Click(object sender, EventArgs e)
        {

        }
    }
}
