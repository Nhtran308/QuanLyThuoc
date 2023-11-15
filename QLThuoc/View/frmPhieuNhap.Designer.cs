namespace QLThuoc.View
{
    partial class frmPhieuNhap
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
            label1 = new Label();
            dgvPhieuNhap = new DataGridView();
            maThuoc = new DataGridViewComboBoxColumn();
            tenThuoc = new DataGridViewTextBoxColumn();
            donViTinh = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            donGia = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            lblMaThuoc = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnPhieuNhapCreate = new Button();
            btnPhieuNhapExit = new Button();
            txtMaPhieu = new TextBox();
            txtMaNhaCungCap = new TextBox();
            txtMaHopDong = new TextBox();
            txtNhaCungCap = new TextBox();
            txtNguoiNhap = new TextBox();
            txtNgayHopDong = new TextBox();
            txtNgayNhap = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 62);
            label1.TabIndex = 0;
            label1.Text = "Phiếu Nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { maThuoc, tenThuoc, donViTinh, soLuong, donGia, Column1 });
            dgvPhieuNhap.Location = new Point(12, 310);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.RowTemplate.Height = 29;
            dgvPhieuNhap.Size = new Size(783, 185);
            dgvPhieuNhap.TabIndex = 19;
            dgvPhieuNhap.CellContentDoubleClick += dgvPhieuNhap_CellContentDoubleClick;
            dgvPhieuNhap.CellDoubleClick += dgvPhieuNhap_CellDoubleClick;
            dgvPhieuNhap.CellValueChanged += dgvPhieuNhap_CellValueChanged;
            dgvPhieuNhap.CurrentCellDirtyStateChanged += dgvPhieuNhap_CurrentCellDirtyStateChanged;
            // 
            // maThuoc
            // 
            maThuoc.HeaderText = "Mã thuốc";
            maThuoc.MinimumWidth = 6;
            maThuoc.Name = "maThuoc";
            maThuoc.Resizable = DataGridViewTriState.True;
            maThuoc.SortMode = DataGridViewColumnSortMode.Automatic;
            maThuoc.Width = 105;
            // 
            // tenThuoc
            // 
            tenThuoc.HeaderText = "Tên thuốc";
            tenThuoc.MinimumWidth = 6;
            tenThuoc.Name = "tenThuoc";
            tenThuoc.Width = 160;
            // 
            // donViTinh
            // 
            donViTinh.HeaderText = "Đơn vị tính";
            donViTinh.MinimumWidth = 6;
            donViTinh.Name = "donViTinh";
            donViTinh.Width = 120;
            // 
            // soLuong
            // 
            soLuong.HeaderText = "Số lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.Width = 125;
            // 
            // donGia
            // 
            donGia.HeaderText = "Đơn giá";
            donGia.MinimumWidth = 6;
            donGia.Name = "donGia";
            donGia.Width = 95;
            // 
            // Column1
            // 
            Column1.HeaderText = "Thành tiền";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaThuoc.Location = new Point(14, 112);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new Size(69, 20);
            lblMaThuoc.TabIndex = 20;
            lblMaThuoc.Text = "Số phiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(466, 112);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 21;
            label2.Text = "Hợp đồng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 163);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 22;
            label3.Text = "Mã nhà cung cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(466, 163);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 23;
            label4.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(466, 265);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 24;
            label5.Text = "Ngày nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 265);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 25;
            label6.Text = "Ngày hợp đồng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 217);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 26;
            label7.Text = "Nhân viên";
            // 
            // btnPhieuNhapCreate
            // 
            btnPhieuNhapCreate.Location = new Point(538, 512);
            btnPhieuNhapCreate.Name = "btnPhieuNhapCreate";
            btnPhieuNhapCreate.Size = new Size(94, 29);
            btnPhieuNhapCreate.TabIndex = 27;
            btnPhieuNhapCreate.Text = "Tạo";
            btnPhieuNhapCreate.UseVisualStyleBackColor = true;
            btnPhieuNhapCreate.Click += btnPhieuNhapCreate_Click;
            // 
            // btnPhieuNhapExit
            // 
            btnPhieuNhapExit.Location = new Point(701, 512);
            btnPhieuNhapExit.Name = "btnPhieuNhapExit";
            btnPhieuNhapExit.Size = new Size(94, 29);
            btnPhieuNhapExit.TabIndex = 29;
            btnPhieuNhapExit.Text = "Thoát";
            btnPhieuNhapExit.UseVisualStyleBackColor = true;
            btnPhieuNhapExit.Click += btnPhieuNhapExit_Click;
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMaPhieu.Location = new Point(144, 109);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.PlaceholderText = "Số phiếu";
            txtMaPhieu.Size = new Size(218, 27);
            txtMaPhieu.TabIndex = 30;
            txtMaPhieu.TextChanged += txtMaPhieu_TextChanged;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMaNhaCungCap.Location = new Point(144, 160);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.PlaceholderText = "Mã nhà cung cấp";
            txtMaNhaCungCap.Size = new Size(218, 27);
            txtMaNhaCungCap.TabIndex = 31;
            txtMaNhaCungCap.TextChanged += txtMaNhaCungCap_TextChanged;
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMaHopDong.Location = new Point(576, 109);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.PlaceholderText = "Số hợp đồng";
            txtMaHopDong.Size = new Size(218, 27);
            txtMaHopDong.TabIndex = 32;
            // 
            // txtNhaCungCap
            // 
            txtNhaCungCap.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtNhaCungCap.Location = new Point(576, 160);
            txtNhaCungCap.Name = "txtNhaCungCap";
            txtNhaCungCap.PlaceholderText = "Tên nhà cung cấp";
            txtNhaCungCap.Size = new Size(218, 27);
            txtNhaCungCap.TabIndex = 33;
            // 
            // txtNguoiNhap
            // 
            txtNguoiNhap.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtNguoiNhap.Location = new Point(144, 214);
            txtNguoiNhap.Name = "txtNguoiNhap";
            txtNguoiNhap.PlaceholderText = "Nhân viên";
            txtNguoiNhap.Size = new Size(218, 27);
            txtNguoiNhap.TabIndex = 34;
            // 
            // txtNgayHopDong
            // 
            txtNgayHopDong.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtNgayHopDong.Location = new Point(144, 262);
            txtNgayHopDong.Name = "txtNgayHopDong";
            txtNgayHopDong.PlaceholderText = "Tháng /Ngày /Năm";
            txtNgayHopDong.Size = new Size(218, 27);
            txtNgayHopDong.TabIndex = 35;
            // 
            // txtNgayNhap
            // 
            txtNgayNhap.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtNgayNhap.Location = new Point(576, 262);
            txtNgayNhap.Name = "txtNgayNhap";
            txtNgayNhap.PlaceholderText = "Tháng /Ngày /Năm";
            txtNgayNhap.Size = new Size(218, 27);
            txtNgayNhap.TabIndex = 36;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(807, 553);
            Controls.Add(txtNgayNhap);
            Controls.Add(txtNgayHopDong);
            Controls.Add(txtNguoiNhap);
            Controls.Add(txtNhaCungCap);
            Controls.Add(txtMaHopDong);
            Controls.Add(txtMaNhaCungCap);
            Controls.Add(txtMaPhieu);
            Controls.Add(btnPhieuNhapExit);
            Controls.Add(btnPhieuNhapCreate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMaThuoc);
            Controls.Add(dgvPhieuNhap);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu Nhập";
            KeyDown += frmPhieuNhap_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView dgvPhieuNhap;
        private Label lblMaThuoc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnPhieuNhapCreate;
        private Button btnPhieuNhapExit;
        private TextBox txtMaPhieu;
        private TextBox txtMaNhaCungCap;
        private TextBox txtMaHopDong;
        private TextBox txtNhaCungCap;
        private TextBox txtNguoiNhap;
        private TextBox txtNgayHopDong;
        private TextBox txtNgayNhap;
        private DataGridViewComboBoxColumn maThuoc;
        private DataGridViewTextBoxColumn tenThuoc;
        private DataGridViewTextBoxColumn donViTinh;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn Column1;
    }
}