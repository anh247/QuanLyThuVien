
namespace GUI
{
    partial class frmThongKeBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeBaoCao));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.cbphanloai = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvThongkebaocao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkebaocao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "CHỌN PHÂN LOẠI";
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.Silver;
            this.btnTHOAT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(864, 18);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(4);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(170, 48);
            this.btnTHOAT.TabIndex = 36;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // cbphanloai
            // 
            this.cbphanloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbphanloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbphanloai.FormattingEnabled = true;
            this.cbphanloai.Items.AddRange(new object[] {
            "Sách đang được mượn",
            "Sách còn lại",
            ""});
            this.cbphanloai.Location = new System.Drawing.Point(367, 64);
            this.cbphanloai.Margin = new System.Windows.Forms.Padding(4);
            this.cbphanloai.Name = "cbphanloai";
            this.cbphanloai.Size = new System.Drawing.Size(382, 31);
            this.cbphanloai.TabIndex = 35;
            this.cbphanloai.SelectedIndexChanged += new System.EventHandler(this.cbphanloai_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(864, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 44);
            this.button1.TabIndex = 39;
            this.button1.Text = "Kiểm Tra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvThongkebaocao
            // 
            this.dgvThongkebaocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongkebaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongkebaocao.Location = new System.Drawing.Point(9, 169);
            this.dgvThongkebaocao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvThongkebaocao.Name = "dgvThongkebaocao";
            this.dgvThongkebaocao.RowHeadersWidth = 51;
            this.dgvThongkebaocao.RowTemplate.Height = 24;
            this.dgvThongkebaocao.Size = new System.Drawing.Size(1092, 338);
            this.dgvThongkebaocao.TabIndex = 38;
            this.dgvThongkebaocao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongkebaocao_CellContentClick);
            // 
            // frmThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvThongkebaocao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.cbphanloai);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThongKeBaoCao";
            this.Text = "Thống kê báo cáo";
            this.Load += new System.EventHandler(this.frmThongKeBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongkebaocao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.ComboBox cbphanloai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvThongkebaocao;
    }
}