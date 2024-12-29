using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
namespace GUI
{
    public partial class frmQLTTDocGia : Form
    {
        
        public frmQLTTDocGia()
        {
            InitializeComponent();
        }
        private void load()
        {
            DocGia_BUS.Instance.xem(dgvDSTTdocgia);
        }
        private void frmQLTTDocGia_Load(object sender, EventArgs e)
        {
            load();
            dtpngaylapthe.Value = DateTime.Today;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            DocGia_BUS.Instance.timKiemTheoMa(dgvDSTTdocgia, txtTK.Text);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                try
                {
                    DocGia_BUS.Instance.xoaTheoMa(dgvDSTTdocgia);
                    MessageBox.Show("Xóa thành công ");
                    load();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công ");
                }
            }
                
          
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmdg.Text == "" || txthoten.Text == "" || txtdiachi.Text == "")
            {
                MessageBox.Show("Thông thông tin trường sửa không nên bỏ trống !");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    try
                    {
                        DocGia_BUS.Instance.sua(dgvDSTTdocgia);
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ngaysinh = dtpNgaysinh.Value.Year + "/" + dtpNgaysinh.Value.Month + "/" + dtpNgaysinh.Value.Day;
            string ngaylapthe = dtpngaylapthe.Value.Year + "/" + dtpngaylapthe.Value.Month + "/" + dtpngaylapthe.Value.Day;
            DateTime ngaysinhcheck = Convert.ToDateTime(dtpNgaysinh.Value.ToString());
            DateTime ngaylapthecheck = Convert.ToDateTime(dtpngaylapthe.Value.ToString());
            DateTime nams = Convert.ToDateTime(dtpNgaysinh.Value.ToString());
            int Ngt = int.Parse(DateTime.Now.Year.ToString());
            int nn = int.Parse(nams.Year.ToString());
            int tuoi = Ngt - nn;
           // string matkhau = ngaysinh;
            if (ngaysinhcheck >= ngaylapthecheck)
            {
                MessageBox.Show("Ngày lập thẻ phải sau ngày sinh");
            }
            else if (txtmdg.Text == "" || txthoten.Text == "" || txtdiachi.Text == "")
            {
                MessageBox.Show("Thông thông tin trường thêm không nên bỏ trống !");
            }
            if (tuoi < 18)
            {
                errorProvider1.SetError(dtpNgaysinh, "Đọc giả phải đủ 18 tuổi");
                return;
            }
            else
            if (tuoi > 100)
            {
                errorProvider1.SetError(dtpNgaysinh, "Đọc giả phải nhỏ hơn 100 tuổi");
                return;
            }
            else
            {
                try
                {
                    DocGia_BUS.Instance.Them(dgvDSTTdocgia, txtmdg.Text,txthoten.Text,ngaysinh, txtdiachi.Text,ngaylapthe,ngaysinh);
                    MessageBox.Show("Thêm thành công");
                    errorProvider1.Clear();
                    load();
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtmdg.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtmdg.Focus();
            dtpNgaysinh.Value = DateTime.Today;
            dtpngaylapthe.Value = DateTime.Today;
            load();
        }

        private void dgvDSTTdocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSTTdocgia.Rows[e.RowIndex];

                txtmdg.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                dtpNgaysinh.Text = row.Cells[2].Value.ToString();
                txtdiachi.Text = row.Cells[3].Value.ToString();
                dtpngaylapthe.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDSTTdocgia.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvDSTTdocgia.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvDSTTdocgia.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvDSTTdocgia.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDSTTdocgia.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvDSTTdocgia.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

