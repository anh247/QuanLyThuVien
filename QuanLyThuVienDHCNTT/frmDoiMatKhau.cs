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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {




        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttdn.Text) ||
                string.IsNullOrWhiteSpace(txtmkcu.Text) ||
                string.IsNullOrWhiteSpace(txtmkmoi.Text) ||
                string.IsNullOrWhiteSpace(txtnhaplaimkmoi.Text))
            {
                MessageBox.Show("Các thông tin không được để trống!");
                return;
            }

            if (txtmkmoi.Text != txtnhaplaimkmoi.Text)
            {
                MessageBox.Show("Mật khẩu mới nhập lại không trùng khớp!");
                return;
            }

            try
            {
                bool isChanged = ThuThu_BUS.Instance.Doimk(txttdn.Text, txtmkcu.Text, txtmkmoi.Text);
                if (isChanged)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công! Vui lòng kiểm tra lại thông tin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
