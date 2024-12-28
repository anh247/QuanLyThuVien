
namespace GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.ckbHienpass = new System.Windows.Forms.CheckBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbquyenhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbHienpass
            // 
            this.ckbHienpass.AutoSize = true;
            this.ckbHienpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHienpass.Location = new System.Drawing.Point(491, 268);
            this.ckbHienpass.Name = "ckbHienpass";
            this.ckbHienpass.Size = new System.Drawing.Size(108, 17);
            this.ckbHienpass.TabIndex = 19;
            this.ckbHienpass.Text = "Hiện mật khẩu";
            this.ckbHienpass.UseVisualStyleBackColor = true;
            this.ckbHienpass.CheckedChanged += new System.EventHandler(this.ckbHienpass_CheckedChanged);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTHOAT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(247, 364);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(109, 41);
            this.btnTHOAT.TabIndex = 18;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndangnhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(19, 364);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(134, 41);
            this.btndangnhap.TabIndex = 17;
            this.btndangnhap.Text = "ĐĂNG NHẬP";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightCoral;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(148, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(348, 26);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(308, 294);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dành cho Admin - Thủ Thư ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbquyenhan
            // 
            this.cbquyenhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbquyenhan.FormattingEnabled = true;
            this.cbquyenhan.Items.AddRange(new object[] {
            "docgia",
            "admin",
            "thuthu"});
            this.cbquyenhan.Location = new System.Drawing.Point(491, 90);
            this.cbquyenhan.Name = "cbquyenhan";
            this.cbquyenhan.Size = new System.Drawing.Size(100, 21);
            this.cbquyenhan.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Đăng Nhập Dành:";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(491, 214);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 25;
            this.txtpass.Tag = "";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(491, 158);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tài Khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(381, 335);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(235, 92);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dành cho sinh viên";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(48, 29);
            this.btnTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(134, 43);
            this.btnTK.TabIndex = 0;
            this.btnTK.Text = "Tìm kiếm";
            this.toolTip1.SetToolTip(this.btnTK, "Ấn vào đây để tìm kiếm sách");
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::QuanLyThuVienDHCNTT.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(25, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 466);
            this.Controls.Add(this.ckbHienpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbquyenhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckbHienpass;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbquyenhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}