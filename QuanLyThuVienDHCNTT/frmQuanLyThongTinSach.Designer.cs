
namespace GUI
{
    partial class frmQuanLyThongTinSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyThongTinSach));
            this.label12 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdsthongtinsach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtNamXB = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtlanxb = new System.Windows.Forms.TextBox();
            this.cbmaloai = new System.Windows.Forms.ComboBox();
            this.txttgia = new System.Windows.Forms.TextBox();
            this.txtnhaxb = new System.Windows.Forms.TextBox();
            this.txtsotrang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtnhande = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtms = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsthongtinsach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 23);
            this.label12.TabIndex = 40;
            this.label12.Text = "Nhập mã cần tìm";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(384, 22);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(120, 33);
            this.btnTK.TabIndex = 39;
            this.btnTK.Text = "TÌM KIẾM";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(172, 14);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(193, 32);
            this.txtTK.TabIndex = 38;
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(538, 21);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(161, 33);
            this.btnLammoi.TabIndex = 37;
            this.btnLammoi.Text = "LÀM MỚI ";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1011, 21);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 33);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(874, 21);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 33);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(737, 21);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 33);
            this.btnthem.TabIndex = 33;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdsthongtinsach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1241, 312);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG TIN SÁCH ";
            // 
            // dgvdsthongtinsach
            // 
            this.dgvdsthongtinsach.AllowUserToAddRows = false;
            this.dgvdsthongtinsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdsthongtinsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsthongtinsach.Location = new System.Drawing.Point(8, 29);
            this.dgvdsthongtinsach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvdsthongtinsach.Name = "dgvdsthongtinsach";
            this.dgvdsthongtinsach.RowHeadersWidth = 51;
            this.dgvdsthongtinsach.Size = new System.Drawing.Size(1225, 277);
            this.dgvdsthongtinsach.TabIndex = 0;
            this.dgvdsthongtinsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsthongtinsach_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtNamXB);
            this.groupBox2.Controls.Add(this.dtpNgaynhap);
            this.groupBox2.Controls.Add(this.txtlanxb);
            this.groupBox2.Controls.Add(this.cbmaloai);
            this.groupBox2.Controls.Add(this.txttgia);
            this.groupBox2.Controls.Add(this.txtnhaxb);
            this.groupBox2.Controls.Add(this.txtsotrang);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.txtnhande);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtms);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1241, 270);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN SÁCH";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1096, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 33);
            this.button1.TabIndex = 40;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtNamXB
            // 
            this.dtNamXB.CustomFormat = "";
            this.dtNamXB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNamXB.Location = new System.Drawing.Point(347, 177);
            this.dtNamXB.Name = "dtNamXB";
            this.dtNamXB.Size = new System.Drawing.Size(200, 30);
            this.dtNamXB.TabIndex = 34;
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.CustomFormat = "";
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaynhap.Location = new System.Drawing.Point(841, 187);
            this.dtpNgaynhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(196, 30);
            this.dtpNgaynhap.TabIndex = 33;
            // 
            // txtlanxb
            // 
            this.txtlanxb.Location = new System.Drawing.Point(347, 215);
            this.txtlanxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtlanxb.Name = "txtlanxb";
            this.txtlanxb.Size = new System.Drawing.Size(193, 30);
            this.txtlanxb.TabIndex = 32;
            // 
            // cbmaloai
            // 
            this.cbmaloai.AutoCompleteCustomSource.AddRange(new string[] {
            "ML01",
            "ML02"});
            this.cbmaloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaloai.FormattingEnabled = true;
            this.cbmaloai.Items.AddRange(new object[] {
            "ML01",
            "ML02"});
            this.cbmaloai.Location = new System.Drawing.Point(841, 37);
            this.cbmaloai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbmaloai.Name = "cbmaloai";
            this.cbmaloai.Size = new System.Drawing.Size(196, 31);
            this.cbmaloai.TabIndex = 30;
            // 
            // txttgia
            // 
            this.txttgia.Location = new System.Drawing.Point(841, 127);
            this.txttgia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttgia.Name = "txttgia";
            this.txttgia.Size = new System.Drawing.Size(196, 30);
            this.txttgia.TabIndex = 29;
            // 
            // txtnhaxb
            // 
            this.txtnhaxb.Location = new System.Drawing.Point(841, 87);
            this.txtnhaxb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnhaxb.Name = "txtnhaxb";
            this.txtnhaxb.Size = new System.Drawing.Size(196, 30);
            this.txtnhaxb.TabIndex = 28;
            // 
            // txtsotrang
            // 
            this.txtsotrang.Location = new System.Drawing.Point(347, 98);
            this.txtsotrang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsotrang.Name = "txtsotrang";
            this.txtsotrang.Size = new System.Drawing.Size(193, 30);
            this.txtsotrang.TabIndex = 26;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(347, 132);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(193, 30);
            this.txtsoluong.TabIndex = 25;
            // 
            // txtnhande
            // 
            this.txtnhande.Location = new System.Drawing.Point(347, 62);
            this.txtnhande.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnhande.Name = "txtnhande";
            this.txtnhande.Size = new System.Drawing.Size(193, 30);
            this.txtnhande.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Năm xuất bản";
            // 
            // txtms
            // 
            this.txtms.Location = new System.Drawing.Point(347, 21);
            this.txtms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(193, 30);
            this.txtms.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 127);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lần xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số trang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(695, 183);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhà xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã loại";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2016|*.xls";
            // 
            // frmQuanLyThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1270, 660);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyThongTinSach";
            this.Text = "Quản lý thông tin sách";
            this.Load += new System.EventHandler(this.frmQuanLyThongTinSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsthongtinsach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdsthongtinsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNamXB;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
        private System.Windows.Forms.TextBox txtlanxb;
        private System.Windows.Forms.ComboBox cbmaloai;
        private System.Windows.Forms.TextBox txttgia;
        private System.Windows.Forms.TextBox txtnhaxb;
        private System.Windows.Forms.TextBox txtsotrang;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtnhande;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}