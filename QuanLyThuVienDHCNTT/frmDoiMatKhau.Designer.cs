
namespace GUI
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btndoimk = new System.Windows.Forms.Button();
            this.txtnhaplaimkmoi = new System.Windows.Forms.TextBox();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.lblnhaplaimkmoi = new System.Windows.Forms.Label();
            this.lblmkmoi = new System.Windows.Forms.Label();
            this.lblmkcu = new System.Windows.Forms.Label();
            this.txttdn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "CẬP NHẬT MẬT KHẨU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BackColor = System.Drawing.Color.Gray;
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Location = new System.Drawing.Point(306, 348);
            this.btnQuaylai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(168, 46);
            this.btnQuaylai.TabIndex = 22;
            this.btnQuaylai.Text = "QUAY LẠI";
            this.btnQuaylai.UseVisualStyleBackColor = false;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btndoimk
            // 
            this.btndoimk.BackColor = System.Drawing.Color.Gray;
            this.btndoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimk.Location = new System.Drawing.Point(30, 348);
            this.btndoimk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(168, 46);
            this.btndoimk.TabIndex = 21;
            this.btndoimk.Text = "ĐỔI MẬT KHẨU";
            this.btndoimk.UseVisualStyleBackColor = false;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // txtnhaplaimkmoi
            // 
            this.txtnhaplaimkmoi.Location = new System.Drawing.Point(306, 287);
            this.txtnhaplaimkmoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnhaplaimkmoi.Name = "txtnhaplaimkmoi";
            this.txtnhaplaimkmoi.PasswordChar = '*';
            this.txtnhaplaimkmoi.Size = new System.Drawing.Size(151, 22);
            this.txtnhaplaimkmoi.TabIndex = 20;
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(306, 227);
            this.txtmkmoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.PasswordChar = '*';
            this.txtmkmoi.Size = new System.Drawing.Size(151, 22);
            this.txtmkmoi.TabIndex = 19;
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(306, 167);
            this.txtmkcu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.PasswordChar = '*';
            this.txtmkcu.Size = new System.Drawing.Size(151, 22);
            this.txtmkcu.TabIndex = 18;
            // 
            // lblnhaplaimkmoi
            // 
            this.lblnhaplaimkmoi.AutoSize = true;
            this.lblnhaplaimkmoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhaplaimkmoi.Location = new System.Drawing.Point(84, 290);
            this.lblnhaplaimkmoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnhaplaimkmoi.Name = "lblnhaplaimkmoi";
            this.lblnhaplaimkmoi.Size = new System.Drawing.Size(197, 22);
            this.lblnhaplaimkmoi.TabIndex = 17;
            this.lblnhaplaimkmoi.Text = "Nhập lại mật khẩu mới";
            // 
            // lblmkmoi
            // 
            this.lblmkmoi.AutoSize = true;
            this.lblmkmoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkmoi.Location = new System.Drawing.Point(84, 227);
            this.lblmkmoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmkmoi.Name = "lblmkmoi";
            this.lblmkmoi.Size = new System.Drawing.Size(126, 22);
            this.lblmkmoi.TabIndex = 16;
            this.lblmkmoi.Text = "Mật khẩu mới";
            // 
            // lblmkcu
            // 
            this.lblmkcu.AutoSize = true;
            this.lblmkcu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkcu.Location = new System.Drawing.Point(84, 167);
            this.lblmkcu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmkcu.Name = "lblmkcu";
            this.lblmkcu.Size = new System.Drawing.Size(114, 22);
            this.lblmkcu.TabIndex = 15;
            this.lblmkcu.Text = "Mật khẩu cũ";
            // 
            // txttdn
            // 
            this.txttdn.Location = new System.Drawing.Point(306, 117);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(151, 22);
            this.txttdn.TabIndex = 26;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(527, 405);
            this.Controls.Add(this.txttdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.btndoimk);
            this.Controls.Add(this.txtnhaplaimkmoi);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.lblnhaplaimkmoi);
            this.Controls.Add(this.lblmkmoi);
            this.Controls.Add(this.lblmkcu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.TextBox txtnhaplaimkmoi;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.Label lblnhaplaimkmoi;
        private System.Windows.Forms.Label lblmkmoi;
        private System.Windows.Forms.Label lblmkcu;
        private System.Windows.Forms.TextBox txttdn;
    }
}