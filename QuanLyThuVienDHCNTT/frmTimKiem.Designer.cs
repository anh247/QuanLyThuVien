
namespace GUI
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.label1 = new System.Windows.Forms.Label();
            this.cbtimkiem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvthongtin = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "TÌM TỪ ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbtimkiem
            // 
            this.cbtimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtimkiem.FormattingEnabled = true;
            this.cbtimkiem.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tác giả"});
            this.cbtimkiem.Location = new System.Drawing.Point(96, 48);
            this.cbtimkiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbtimkiem.Name = "cbtimkiem";
            this.cbtimkiem.Size = new System.Drawing.Size(160, 24);
            this.cbtimkiem.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvthongtin);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1396, 494);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG TIN  ";
            // 
            // dgvthongtin
            // 
            this.dgvthongtin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtin.Location = new System.Drawing.Point(8, 22);
            this.dgvthongtin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvthongtin.Name = "dgvthongtin";
            this.dgvthongtin.RowHeadersWidth = 51;
            this.dgvthongtin.Size = new System.Drawing.Size(1388, 472);
            this.dgvthongtin.TabIndex = 0;
            this.dgvthongtin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthongtin_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(297, 23);
            this.label12.TabIndex = 52;
            this.label12.Text = "CHỌN THUỘC TÍNH CẦN TÌM ";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(704, 20);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(329, 33);
            this.txttimkiem.TabIndex = 51;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1268, 48);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 32);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1053, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 32);
            this.button1.TabIndex = 57;
            this.button1.Text = "MƯỢN SÁCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1420, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnThoat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvthongtin;
        private System.Windows.Forms.Button button1;
    }
}