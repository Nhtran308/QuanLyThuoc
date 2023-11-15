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
            maPhieu = new DataGridViewComboBoxColumn();
            maThuoc = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            donGia = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnCTXuat = new Button();
            txtTim = new TextBox();
            btnTim = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { maPhieu, maThuoc, soLuong, donGia });
            dgvChiTiet.Location = new Point(13, 128);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 29;
            dgvChiTiet.Size = new Size(518, 188);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.CellValueChanged += dgvChiTiet_CellValueChanged;
            dgvChiTiet.CurrentCellDirtyStateChanged += dgvChiTiet_CurrentCellDirtyStateChanged;
            // 
            // maPhieu
            // 
            maPhieu.HeaderText = "Mã phiếu";
            maPhieu.MinimumWidth = 6;
            maPhieu.Name = "maPhieu";
            maPhieu.Resizable = DataGridViewTriState.True;
            maPhieu.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // btnCTXuat
            // 
            btnCTXuat.Location = new Point(437, 331);
            btnCTXuat.Name = "btnCTXuat";
            btnCTXuat.Size = new Size(94, 29);
            btnCTXuat.TabIndex = 31;
            btnCTXuat.Text = "Xuất";
            btnCTXuat.UseVisualStyleBackColor = true;
            btnCTXuat.Click += btnCTXuat_Click;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(304, 86);
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Tìm";
            txtTim.Size = new Size(113, 27);
            txtTim.TabIndex = 32;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(437, 84);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 33;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // frmChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(543, 372);
            Controls.Add(btnTim);
            Controls.Add(txtTim);
            Controls.Add(btnCTXuat);
            Controls.Add(label1);
            Controls.Add(dgvChiTiet);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            KeyDown += frmChiTietPhieuNhap_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvChiTiet;
        private Label label1;
        private Button btnCTXuat;
        private TextBox txtTim;
        private Button btnTim;
        private DataGridViewComboBoxColumn maPhieu;
        private DataGridViewTextBoxColumn maThuoc;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
    }
}