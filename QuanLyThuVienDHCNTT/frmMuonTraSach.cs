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
    public partial class frmMuonTraSach : Form
    {
        public frmMuonTraSach()
        {
            InitializeComponent();
            dtpngaynuon.Value = DateTime.Today;
            dtpNgaytra.Value = DateTime.Today;
        }
        private void load()
        {
            MuonTra_BUS.Instance.xem(dgvmuontra);
        }
        private void frmMuonTraSach_Load(object sender, EventArgs e)
        {
           
            load();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            dtpngaynuon.Value = DateTime.Today;
            txtmathuthu.Text = "";
            txtmasach.Text = "";
           
            //  txtsoluong.Clear();
            //  cbmtrangthai.Text = "ĐANG MUON";
            dtpNgaytra.Value = DateTime.Today;
            frmMuonTraSach_Load(sender, e);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
          
            string ngaytra = dtpNgaytra.Value.Year + "/" + dtpNgaytra.Value.Month + "/" + dtpNgaytra.Value.Day;
            string ngaymuon = dtpngaynuon.Value.Year + "/" + dtpngaynuon.Value.Month + "/" + dtpngaynuon.Value.Day;
            DateTime ngaymuonck = Convert.ToDateTime(dtpngaynuon.Value);
            DateTime ngaytrack = Convert.ToDateTime(dtpNgaytra.Value);
            
            if (ngaymuonck > ngaytrack)
            {
                MessageBox.Show("Ngày trả phải sau ngày mượn");
            }
            else
            {
                try
                {
                    MuonTra_BUS.Instance.Them(dgvmuontra, txtmadg.Text, ngaymuon, txtmasach.Text, txtmathuthu.Text, txtsoluong.Text, cbmtrangthai.Text, ngaytra);
                    MuonTra_BUS.Instance.capNhatkhimuon(dgvmuontra, txtsoluong.Text , txtmasach.Text);
                    MessageBox.Show("Thêm thành công");
                    load();
                }
                catch
                {
                    
                    MessageBox.Show("Thêm thất bại có thể mã đã bị trùng!");
                }
            }
            

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ngaytra = dtpNgaytra.Value.Year + "/" + dtpNgaytra.Value.Month + "/" + dtpNgaytra.Value.Day;
            string ngaymuon = dtpngaynuon.Value.Year + "/" + dtpngaynuon.Value.Month + "/" + dtpngaynuon.Value.Day;
            DateTime ngaymuonck = Convert.ToDateTime(dtpngaynuon.Value);
            DateTime ngaytrack = Convert.ToDateTime(dtpNgaytra.Value);
            if (ngaymuonck >= ngaytrack)
            {
                MessageBox.Show("Ngày trả phải sau ngày mượn");
            }
            else
            {
                try
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dlr)
                        MuonTra_BUS.Instance.sua(dgvmuontra, txtmadg.Text, ngaymuon, txtmasach.Text, txtmathuthu.Text, txtsoluong.Text, cbmtrangthai.Text, ngaytra);
                     
                    MessageBox.Show("Sửa thành công");
                    load();
                }
                catch
                {
                 
                    MessageBox.Show("Sửa thất bại!");
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
                    MuonTra_BUS.Instance.xoaTheoMa(dgvmuontra);
                    MuonTra_BUS.Instance.capNhatkhitra(dgvmuontra, txtsoluong.Text, txtmasach.Text);
                    MessageBox.Show("Xóa thành công");
                    load();
                    }
                    catch(Exception ei)
                    {
                        MessageBox.Show("Xóa thất bại!" + ei);
                    }
                
            }
        }

        private void btnGiahan_Click(object sender, EventArgs e)
        {
            string giahan = numgiahan.Text;
         
            string ngaytra = dtpNgaytra.Value.Year + "/" + dtpNgaytra.Value.Month + "/" + dtpNgaytra.Value.Day;
            string ngaymuon = dtpngaynuon.Value.Year + "/" + dtpngaynuon.Value.Month + "/" + dtpngaynuon.Value.Day;
            DateTime ngaymuonck = Convert.ToDateTime(dtpngaynuon.Value);
            DateTime ngaytrack = Convert.ToDateTime(dtpNgaytra.Value);
            if (ngaymuonck >= ngaytrack)
            {
                MessageBox.Show("Ngày trả phải sau ngày mượn");
            }
            else
            {
                try
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc muốn gia hạn?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dlr)
                    {
                        MuonTra_BUS.Instance.Giahan(dgvmuontra, txtmadg.Text, txtmathuthu.Text, giahan);
                        MessageBox.Show("Gia hạn thành công");
                        load();
                    }

                    
                }
                catch(Exception ee)
                {

                    MessageBox.Show("Gia hạn thất bại!"+ee);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvmuontra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvmuontra.Rows[e.RowIndex];

                txtmadg.Text = row.Cells[0].Value.ToString();
                dtpngaynuon.Text = row.Cells[1].Value.ToString();
                txtmasach.Text = row.Cells[2].Value.ToString();
                txtmathuthu.Text = row.Cells[3].Value.ToString();
                txtsoluong.Text = row.Cells[4].Value.ToString();
                cbmtrangthai.Text = row.Cells[5].Value.ToString();
                dtpNgaytra.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            MuonTra_BUS.Instance.timKiemTheoMa(dgvmuontra, txtTK.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtpngaynuon_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
