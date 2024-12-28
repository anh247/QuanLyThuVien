
namespace GUI
{
    partial class frmCapNhatLoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatLoaiSach));
            this.label12 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvloaisach = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(124, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 23);
            this.label12.TabIndex = 66;
            this.label12.Text = "Nhập mã cần tìm:";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(603, 184);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(100, 33);
            this.btnTK.TabIndex = 65;
            this.btnTK.Text = "TÌM KIẾM";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(290, 184);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(209, 32);
            this.txtTK.TabIndex = 64;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(52, 114);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 43);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(478, 47);
            this.txttenloai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttenloai.Multiline = true;
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(223, 34);
            this.txttenloai.TabIndex = 62;
            this.txttenloai.TextChanged += new System.EventHandler(this.txttenloai_TextChanged);
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(108, 47);
            this.txtmaloai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmaloai.Multiline = true;
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(223, 34);
            this.txtmaloai.TabIndex = 61;
            this.txtmaloai.TextChanged += new System.EventHandler(this.txtmaloai_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tên loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mã loại:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvloaisach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-4, 240);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(827, 298);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG TIN  ";
            // 
            // dgvloaisach
            // 
            this.dgvloaisach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvloaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaisach.Location = new System.Drawing.Point(15, 27);
            this.dgvloaisach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvloaisach.Name = "dgvloaisach";
            this.dgvloaisach.RowHeadersWidth = 51;
            this.dgvloaisach.Size = new System.Drawing.Size(796, 265);
            this.dgvloaisach.TabIndex = 0;
            this.dgvloaisach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaisach_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(620, 114);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 43);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(426, 114);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 43);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(240, 114);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 43);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmCapNhatLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCapNhatLoaiSach";
            this.Text = "Cập nhật loại sách";
            this.Load += new System.EventHandler(this.frmCapNhatLoaiSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvloaisach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}