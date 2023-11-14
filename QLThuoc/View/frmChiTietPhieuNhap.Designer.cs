namespace QLThuoc.View
{
    partial class frmChiTietPhieuNhap
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
            dgvChiTiet = new DataGridView();
            maPhieu = new DataGridViewTextBoxColumn();
            maThuoc = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            donGia = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnChiTietExit = new Button();
            btnCTXuat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { maPhieu, maThuoc, soLuong, donGia });
            dgvChiTiet.Location = new Point(12, 88);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 29;
            dgvChiTiet.Size = new Size(518, 188);
            dgvChiTiet.TabIndex = 0;
            // 
            // maPhieu
            // 
            maPhieu.HeaderText = "Mã phiếu";
            maPhieu.MinimumWidth = 6;
            maPhieu.Name = "maPhieu";
            maPhieu.Width = 125;
            // 
            // maThuoc
            // 
            maThuoc.HeaderText = "Thuốc";
            maThuoc.MinimumWidth = 6;
            maThuoc.Name = "maThuoc";
            maThuoc.Width = 110;
            // 
            // soLuong
            // 
            soLuong.HeaderText = "Số lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.Width = 120;
            // 
            // donGia
            // 
            donGia.HeaderText = "Đơn giá";
            donGia.MinimumWidth = 6;
            donGia.Name = "donGia";
            donGia.Width = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 62);
            label1.TabIndex = 1;
            label1.Text = "Chi Tiết Phiếu Nhập";
            // 
            // btnChiTietExit
            // 
            btnChiTietExit.Location = new Point(437, 298);
            btnChiTietExit.Name = "btnChiTietExit";
            btnChiTietExit.Size = new Size(94, 29);
            btnChiTietExit.TabIndex = 30;
            btnChiTietExit.Text = "Thoát";
            btnChiTietExit.UseVisualStyleBackColor = true;
            btnChiTietExit.Click += btnChiTietExit_Click;
            // 
            // btnCTXuat
            // 
            btnCTXuat.Location = new Point(305, 298);
            btnCTXuat.Name = "btnCTXuat";
            btnCTXuat.Size = new Size(94, 29);
            btnCTXuat.TabIndex = 31;
            btnCTXuat.Text = "Xuất";
            btnCTXuat.UseVisualStyleBackColor = true;
            btnCTXuat.Click += btnCTXuat_Click;
            // 
            // frmChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(543, 339);
            Controls.Add(btnCTXuat);
            Controls.Add(btnChiTietExit);
            Controls.Add(label1);
            Controls.Add(dgvChiTiet);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvChiTiet;
        private Label label1;
        private Button btnChiTietExit;
        private Button btnCTXuat;
        private DataGridViewTextBoxColumn maPhieu;
        private DataGridViewTextBoxColumn maThuoc;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
    }
}