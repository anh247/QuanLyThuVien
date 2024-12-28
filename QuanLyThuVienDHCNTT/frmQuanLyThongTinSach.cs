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
//using Microsoft.Office.Interop.Excel;
namespace GUI
{
    public partial class frmQuanLyThongTinSach : Form
    {
        public frmQuanLyThongTinSach()
        {
            InitializeComponent();
        }
        private void load()
        {
            ThongTinSach_BUS.Instance.xem(dgvdsthongtinsach);
        }
        private void frmQuanLyThongTinSach_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtms.Clear();
            txtnhande.Clear();
            txtnhaxb.Clear();
            txtsoluong.Clear();
            txtsotrang.Clear();
            txttgia.Clear();
            cbmaloai.Text = "ML1";
            dtpNgaynhap.Value = DateTime.Today;
            txtms.Focus();
            txtlanxb.Clear();
            frmQuanLyThongTinSach_Load(sender, e);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            ThongTinSach_BUS.Instance.timKiemTheoMa(dgvdsthongtinsach, txtTK.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                try
                {
                    ThongTinSach_BUS.Instance.xoaTheoMa(dgvdsthongtinsach);
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
            string namxb = dtNamXB.Value.Year + "/" + dtNamXB.Value.Month + "/" + dtNamXB.Value.Day;
            string ngaynhap = dtpNgaynhap.Value.Year + "/" + dtpNgaynhap.Value.Month + "/" + dtpNgaynhap.Value.Day;
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dlr)
            {
                try
                {
                    ThongTinSach_BUS.Instance.sua(dgvdsthongtinsach, txtms.Text, txtnhande.Text, txtsotrang.Text, txtsoluong.Text, namxb, txtlanxb.Text, cbmaloai.Text, txtnhaxb.Text, txttgia.Text, ngaynhap);
                    MessageBox.Show("Sửa thành công");
                    load();
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
                
        }

        private void dgvdsthongtinsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvdsthongtinsach.Rows[e.RowIndex];

                txtms.Text = row.Cells[0].Value.ToString();
                txtnhande.Text = row.Cells[1].Value.ToString();
                txtsotrang.Text = row.Cells[2].Value.ToString();
                txtsoluong.Text = row.Cells[3].Value.ToString();
                dtNamXB.Text = row.Cells[4].Value.ToString();
                txtlanxb.Text = row.Cells[5].Value.ToString();
                cbmaloai.Text = row.Cells[6].Value.ToString();
                txtnhaxb.Text = row.Cells[7].Value.ToString();
                txttgia.Text = row.Cells[8].Value.ToString();
                dtpNgaynhap.Text = row.Cells[9].Value.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string namxb = dtNamXB.Value.Year + "/" + dtNamXB.Value.Month + "/" + dtNamXB.Value.Day;
            string ngaynhap = dtpNgaynhap.Value.Year + "/" + dtpNgaynhap.Value.Month + "/" + dtpNgaynhap.Value.Day;
            if(txtms.Text=="" || txtnhande.Text == "" || txtnhaxb.Text == "" || txtlanxb.Text == "" || txttgia.Text == "")
            {
                MessageBox.Show("Các trường thông tin thêm không được phép để trống ");
            }
            try
            {
                ThongTinSach_BUS.Instance.Them(dgvdsthongtinsach, txtms.Text, txtnhande.Text, txtsotrang.Text, txtsoluong.Text, namxb, txtlanxb.Text, cbmaloai.Text, txtnhaxb.Text, txttgia.Text, ngaynhap);
                MessageBox.Show("Thêm thành công");
                load();
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
           
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvdsthongtinsach, saveFileDialog1.FileName);
            }*/
            if (dgvdsthongtinsach.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgvdsthongtinsach.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvdsthongtinsach.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvdsthongtinsach.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvdsthongtinsach.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvdsthongtinsach.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //}
        /* private void ToExcel(DataGridView dataGridView1, string fileName)
         {
             Microsoft.Office.Interop.Excel.Application excel;
             Microsoft.Office.Interop.Excel.Workbook workbook;
             Microsoft.Office.Interop.Excel.Worksheet worksheet;

             try
             {
                 excel = new Microsoft.Office.Interop.Excel.Application();
                 excel.Visible = false;
                 excel.DisplayAlerts = false;

                 workbook = excel.Workbooks.Add(Type.Missing);

                 worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                 worksheet.Name = "ThongTinSach";

                 // export header
                 for (int i = 0; i < dataGridView1.ColumnCount; i++)
                 {
                     worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                 }

                 // export content
                 for (int i = 0; i < dataGridView1.RowCount; i++)
                 {
                     for (int j = 0; j < dataGridView1.ColumnCount; j++)
                     {
                         worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                     }
                 }

                 // save workbook
                 workbook.SaveAs(fileName);
                 workbook.Close();
                 excel.Quit();
                 MessageBox.Show("Tạo file excel thành công ");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 workbook = null;
                 worksheet = null;
             }
         }*/
    }
    }
    

