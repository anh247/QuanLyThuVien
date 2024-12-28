
namespace GUI
{
    partial class frmQuanTriNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanTriNguoiDung));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSthuthu = new System.Windows.Forms.DataGridView();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbquyenhan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSthuthu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(830, 239);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 47);
            this.btnThoat.TabIndex = 58;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(650, 239);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 47);
            this.btnXoa.TabIndex = 57;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(474, 239);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(150, 47);
            this.btnsua.TabIndex = 56;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(290, 239);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(150, 47);
            this.btnthem.TabIndex = 55;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSthuthu);
            this.groupBox1.Location = new System.Drawing.Point(7, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1066, 213);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG TIN  ";
            // 
            // dgvDSthuthu
            // 
            this.dgvDSthuthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSthuthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSthuthu.Location = new System.Drawing.Point(14, 22);
            this.dgvDSthuthu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDSthuthu.Name = "dgvDSthuthu";
            this.dgvDSthuthu.RowHeadersWidth = 51;
            this.dgvDSthuthu.Size = new System.Drawing.Size(1044, 183);
            this.dgvDSthuthu.TabIndex = 0;
            this.dgvDSthuthu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSthuthu_CellContentClick);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(116, 239);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(150, 47);
            this.btnLammoi.TabIndex = 59;
            this.btnLammoi.Text = "LÀM MỚI ";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbquyenhan);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txttendn);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txtmatkhau);
            this.groupBox2.Controls.Add(this.txthoten);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtmnv);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(7, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1048, 160);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN THỦ THƯ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbquyenhan
            // 
            this.cbquyenhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbquyenhan.FormattingEnabled = true;
            this.cbquyenhan.Items.AddRange(new object[] {
            "thuthu",
            "admin"});
            this.cbquyenhan.Location = new System.Drawing.Point(740, 120);
            this.cbquyenhan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbquyenhan.Name = "cbquyenhan";
            this.cbquyenhan.Size = new System.Drawing.Size(218, 25);
            this.cbquyenhan.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(564, 124);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Quyền hạn";
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(741, 32);
            this.txttendn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(217, 25);
            this.txttendn.TabIndex = 28;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(244, 120);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(220, 28);
            this.txtdiachi.TabIndex = 27;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(741, 78);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(217, 25);
            this.txtmatkhau.TabIndex = 26;
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(248, 73);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(217, 28);
            this.txthoten.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa chỉ";
            // 
            // txtmnv
            // 
            this.txtmnv.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmnv.Location = new System.Drawing.Point(248, 32);
            this.txtmnv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(217, 28);
            this.txtmnv.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(825, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Thủ Thư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mật khẩu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(178, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 23);
            this.label12.TabIndex = 53;
            this.label12.Text = "Nhập mã cần tìm";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(686, 17);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(112, 35);
            this.btnTK.TabIndex = 52;
            this.btnTK.Text = "TÌM KIẾM";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(350, 17);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(217, 34);
            this.txtTK.TabIndex = 51;
            // 
            // frmQuanTriNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 515);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanTriNguoiDung";
            this.Text = "Quản trị người dùng";
            this.Load += new System.EventHandler(this.frmQuanTriNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSthuthu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSthuthu;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbquyenhan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
    }
}