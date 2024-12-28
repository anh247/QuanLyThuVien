
namespace GUI
{
    partial class frmMuonTraSach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTraSach));
            this.btnGiahan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvmuontra = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.NumericUpDown();
            this.numgiahan = new System.Windows.Forms.NumericUpDown();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTVDataSet = new QuanLyThuVienDHCNTT.QuanLyTVDataSet();
            this.tHUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTVDataSet2 = new QuanLyThuVienDHCNTT.QuanLyTVDataSet2();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTVDataSet1 = new QuanLyThuVienDHCNTT.QuanLyTVDataSet1();
            this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmtrangthai = new System.Windows.Forms.ComboBox();
            this.dtpngaynuon = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.dOCGIATableAdapter = new QuanLyThuVienDHCNTT.QuanLyTVDataSetTableAdapters.DOCGIATableAdapter();
            this.dOCGIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new QuanLyThuVienDHCNTT.QuanLyTVDataSet1TableAdapters.SACHTableAdapter();
            this.tHUTHUTableAdapter = new QuanLyThuVienDHCNTT.QuanLyTVDataSet2TableAdapters.THUTHUTableAdapter();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.txtmathuthu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuontra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgiahan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUTHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiahan
            // 
            this.btnGiahan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiahan.Location = new System.Drawing.Point(852, 315);
            this.btnGiahan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGiahan.Name = "btnGiahan";
            this.btnGiahan.Size = new System.Drawing.Size(130, 42);
            this.btnGiahan.TabIndex = 62;
            this.btnGiahan.Text = "GIA HẠN";
            this.btnGiahan.UseVisualStyleBackColor = true;
            this.btnGiahan.Click += new System.EventHandler(this.btnGiahan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(672, 315);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 42);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(496, 315);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(130, 42);
            this.btnsua.TabIndex = 57;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(321, 315);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(130, 42);
            this.btnthem.TabIndex = 56;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(139, 315);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(130, 42);
            this.btnLammoi.TabIndex = 60;
            this.btnLammoi.Text = "LÀM MỚI ";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1021, 315);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 42);
            this.btnThoat.TabIndex = 59;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvmuontra);
            this.groupBox1.Location = new System.Drawing.Point(13, 363);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1277, 284);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG TIN  ";
            // 
            // dgvmuontra
            // 
            this.dgvmuontra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmuontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmuontra.Location = new System.Drawing.Point(14, 19);
            this.dgvmuontra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvmuontra.Name = "dgvmuontra";
            this.dgvmuontra.RowHeadersWidth = 51;
            this.dgvmuontra.Size = new System.Drawing.Size(1255, 259);
            this.dgvmuontra.TabIndex = 0;
            this.dgvmuontra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmuontra_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmathuthu);
            this.groupBox2.Controls.Add(this.txtmasach);
            this.groupBox2.Controls.Add(this.txtmadg);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.numgiahan);
            this.groupBox2.Controls.Add(this.dtpNgaytra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbmtrangthai);
            this.groupBox2.Controls.Add(this.dtpngaynuon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1277, 225);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN MƯỢN TRẢ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(726, 31);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsoluong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(225, 24);
            this.txtsoluong.TabIndex = 37;
            this.txtsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numgiahan
            // 
            this.numgiahan.Location = new System.Drawing.Point(730, 188);
            this.numgiahan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numgiahan.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numgiahan.Name = "numgiahan";
            this.numgiahan.Size = new System.Drawing.Size(225, 24);
            this.numgiahan.TabIndex = 36;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.quanLyTVDataSet;
            // 
            // quanLyTVDataSet
            // 
            this.quanLyTVDataSet.DataSetName = "QuanLyTVDataSet";
            this.quanLyTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHUTHUBindingSource
            // 
            this.tHUTHUBindingSource.DataMember = "THUTHU";
            this.tHUTHUBindingSource.DataSource = this.quanLyTVDataSet2;
            // 
            // quanLyTVDataSet2
            // 
            this.quanLyTVDataSet2.DataSetName = "QuanLyTVDataSet2";
            this.quanLyTVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.quanLyTVDataSet1;
            // 
            // quanLyTVDataSet1
            // 
            this.quanLyTVDataSet1.DataSetName = "QuanLyTVDataSet1";
            this.quanLyTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.CustomFormat = "";
            this.dtpNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytra.Location = new System.Drawing.Point(734, 135);
            this.dtpNgaytra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.Size = new System.Drawing.Size(220, 24);
            this.dtpNgaytra.TabIndex = 32;
            this.dtpNgaytra.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ngày gia hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ngày trả";
            // 
            // cbmtrangthai
            // 
            this.cbmtrangthai.FormattingEnabled = true;
            this.cbmtrangthai.Items.AddRange(new object[] {
            "Đã trả",
            "Đang mượn"});
            this.cbmtrangthai.Location = new System.Drawing.Point(730, 87);
            this.cbmtrangthai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbmtrangthai.Name = "cbmtrangthai";
            this.cbmtrangthai.Size = new System.Drawing.Size(220, 25);
            this.cbmtrangthai.TabIndex = 30;
            this.cbmtrangthai.Tag = "";
            // 
            // dtpngaynuon
            // 
            this.dtpngaynuon.CustomFormat = "";
            this.dtpngaynuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynuon.Location = new System.Drawing.Point(238, 83);
            this.dtpngaynuon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpngaynuon.Name = "dtpngaynuon";
            this.dtpngaynuon.Size = new System.Drawing.Size(220, 24);
            this.dtpngaynuon.TabIndex = 23;
            this.dtpngaynuon.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            this.dtpngaynuon.ValueChanged += new System.EventHandler(this.dtpngaynuon_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã sách ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Thủ Thư";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trạng thái ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số lượng ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(273, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 19);
            this.label12.TabIndex = 54;
            this.label12.Text = "Nhập mã cần tìm";
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(780, 23);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(154, 35);
            this.btnTK.TabIndex = 53;
            this.btnTK.Text = "TÌM KIẾM";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(445, 23);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(217, 34);
            this.txtTK.TabIndex = 52;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // dOCGIABindingSource1
            // 
            this.dOCGIABindingSource1.DataMember = "DOCGIA";
            this.dOCGIABindingSource1.DataSource = this.quanLyTVDataSet;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // tHUTHUTableAdapter
            // 
            this.tHUTHUTableAdapter.ClearBeforeFill = true;
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(238, 31);
            this.txtmadg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmadg.Multiline = true;
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(208, 29);
            this.txtmadg.TabIndex = 53;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(238, 131);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmasach.Multiline = true;
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(208, 29);
            this.txtmasach.TabIndex = 54;
            // 
            // txtmathuthu
            // 
            this.txtmathuthu.Location = new System.Drawing.Point(238, 176);
            this.txtmathuthu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmathuthu.Multiline = true;
            this.txtmathuthu.Name = "txtmathuthu";
            this.txtmathuthu.Size = new System.Drawing.Size(208, 29);
            this.txtmathuthu.TabIndex = 55;
            // 
            // frmMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1303, 648);
            this.Controls.Add(this.btnGiahan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMuonTraSach";
            this.Text = "Mượn - Trả sách";
            this.Load += new System.EventHandler(this.frmMuonTraSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuontra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgiahan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUTHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiahan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvmuontra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtsoluong;
        private System.Windows.Forms.NumericUpDown numgiahan;
        private System.Windows.Forms.DateTimePicker dtpNgaytra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmtrangthai;
        private System.Windows.Forms.DateTimePicker dtpngaynuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private QuanLyThuVienDHCNTT.QuanLyTVDataSet quanLyTVDataSet;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QuanLyThuVienDHCNTT.QuanLyTVDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private System.Windows.Forms.BindingSource dOCGIABindingSource1;
        private QuanLyThuVienDHCNTT.QuanLyTVDataSet1 quanLyTVDataSet1;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QuanLyThuVienDHCNTT.QuanLyTVDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
        private QuanLyThuVienDHCNTT.QuanLyTVDataSet2 quanLyTVDataSet2;
        private System.Windows.Forms.BindingSource tHUTHUBindingSource;
        private QuanLyThuVienDHCNTT.QuanLyTVDataSet2TableAdapters.THUTHUTableAdapter tHUTHUTableAdapter;
        private System.Windows.Forms.TextBox txtmathuthu;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txtmadg;
    }
}