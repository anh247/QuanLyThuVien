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
    public partial class frmDangNhap : Form
    {
        public static string quyenhan = "";
        public static string aidangdangnhap = "";
        public static string UsertName = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            // xuly xl = new xuly();
            // Connection cn = new Connection();
            string USER = txtuser.Text.Replace(" ", " ");
            string PASSWORD = txtpass.Text.Replace(" ", " ");

            if (USER == "" || PASSWORD == "")
            {
                MessageBox.Show("Thông tin đang nhập không được phép để trống!!!");
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();
            }
            else
            if (cbquyenhan.Text.CompareTo("admin") == 0)
            {
                //string sql = "SELECT Count(*) FROM THUTHU WHERE TenDangNhap='" + txtuser.Text + "'and MatKhau='" + txtpass.Text + "' and QuyenHan=N'" + cbquyenhan.Text + "'";
                try
                {
                    // cn.OpenConn();
                    if (DangNhap_BUS.Instance.dangNhap(txtuser.Text, txtpass.Text, cbquyenhan.Text))
                    {
                        //quyenhan = xl.quyenhan(cbquyenhan.Text);
                        aidangdangnhap = cbquyenhan.Text;
                        this.Hide();
                        GUI.frmChinh f = new GUI.frmChinh();
                        f.Show();
                        //frmdoimk.UsertName = txtuser.Text;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công tên đăng nhập hoặc mật khẩu không đúng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtuser.Clear();
                        txtpass.Clear();
                        txtuser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else if (cbquyenhan.Text.CompareTo("thuthu") == 0)
            {

                try
                {
                    if (DangNhap_BUS.Instance.dangNhap(txtuser.Text, txtpass.Text, cbquyenhan.Text))
                    {
                        //quyenhan = xl.quyenhan(cbquyenhan.Text);
                        aidangdangnhap = cbquyenhan.Text;
                        this.Hide();
                        GUI.frmChinh f = new GUI.frmChinh();
                        f.Show();
                        //frmdoimk.UsertName = txtuser.Text;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công tên đăng nhập hoặc mật khẩu không đúng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtuser.Clear();
                        txtpass.Clear();
                        txtuser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else if (cbquyenhan.Text.CompareTo("docgia") == 0)
            {

                try
                {
                    if (DangNhap_BUS.Instance.dangNhap1(txtuser.Text, txtpass.Text, cbquyenhan.Text))
                    {
                        //quyenhan = xl.quyenhan(cbquyenhan.Text);
                        aidangdangnhap = cbquyenhan.Text;
                        this.Hide();
                        GUI.frmChinh f = new GUI.frmChinh();
                        f.Show();
                        //frmdoimk.UsertName = txtuser.Text;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công tên đăng nhập hoặc mật khẩu không đúng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtuser.Clear();
                        txtpass.Clear();
                        txtuser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi trong CSDL" + ex);
                }
            }
        }

    


        private void ckbHienpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienpass.Checked)
            {
                txtuser.PasswordChar = '\0';
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtuser.PasswordChar = '\0';
                txtpass.PasswordChar = '*';
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            this.Hide();
           // f.MdiParent = this;
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

