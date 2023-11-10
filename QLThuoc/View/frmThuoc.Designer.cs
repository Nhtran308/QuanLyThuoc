namespace QLThuoc.View
{
    partial class frmThuoc
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
            btnThuocLoad = new Button();
            lblMaThuoc = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaThuoc = new TextBox();
            txtTenThuoc = new TextBox();
            txtDonViTinh = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnThuocAdd = new Button();
            btnThuocFind = new Button();
            btnThuocDelete = new Button();
            btnThuocEdit = new Button();
            btnThuocCancel = new Button();
            btnThuocExit = new Button();
            dgvThuoc = new DataGridView();
            maThuoc = new DataGridViewTextBoxColumn();
            tenThuoc = new DataGridViewTextBoxColumn();
            donViTinh = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            donGia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).BeginInit();
            SuspendLayout();
            // 
            // btnThuocLoad
            // 
            btnThuocLoad.Location = new Point(387, 328);
            btnThuocLoad.Name = "btnThuocLoad";
            btnThuocLoad.Size = new Size(94, 29);
            btnThuocLoad.TabIndex = 1;
            btnThuocLoad.Text = "Hiển thị";
            btnThuocLoad.UseVisualStyleBackColor = true;
            btnThuocLoad.Click += btnThuocLoad_Click;
            // 
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaThuoc.Location = new Point(12, 337);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new Size(74, 20);
            lblMaThuoc.TabIndex = 2;
            lblMaThuoc.Text = "Mã thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 374);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 414);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 455);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 496);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 6;
            label5.Text = "Đơn giá";
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMaThuoc.Location = new Point(129, 330);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.PlaceholderText = "Mã thuốc";
            txtMaThuoc.Size = new Size(218, 27);
            txtMaThuoc.TabIndex = 7;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtTenThuoc.Location = new Point(129, 367);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.PlaceholderText = "Tên thuốc";
            txtTenThuoc.Size = new Size(218, 27);
            txtTenThuoc.TabIndex = 8;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtDonViTinh.Location = new Point(129, 407);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.PlaceholderText = "Đơn vị tính";
            txtDonViTinh.Size = new Size(218, 27);
            txtDonViTinh.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(129, 448);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.PlaceholderText = "Số lượng";
            txtSoLuong.Size = new Size(218, 27);
            txtSoLuong.TabIndex = 10;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtDonGia.Location = new Point(129, 489);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "Đơn giá";
            txtDonGia.Size = new Size(218, 27);
            txtDonGia.TabIndex = 11;
            // 
            // btnThuocAdd
            // 
            btnThuocAdd.Location = new Point(387, 405);
            btnThuocAdd.Name = "btnThuocAdd";
            btnThuocAdd.Size = new Size(94, 29);
            btnThuocAdd.TabIndex = 12;
            btnThuocAdd.Text = "Thêm";
            btnThuocAdd.UseVisualStyleBackColor = true;
            btnThuocAdd.Click += btnThuocAdd_Click;
            // 
            // btnThuocFind
            // 
            btnThuocFind.Location = new Point(546, 328);
            btnThuocFind.Name = "btnThuocFind";
            btnThuocFind.Size = new Size(94, 29);
            btnThuocFind.TabIndex = 13;
            btnThuocFind.Text = "Tìm";
            btnThuocFind.UseVisualStyleBackColor = true;
            btnThuocFind.Click += btnThuocFind_Click;
            // 
            // btnThuocDelete
            // 
            btnThuocDelete.Location = new Point(546, 405);
            btnThuocDelete.Name = "btnThuocDelete";
            btnThuocDelete.Size = new Size(94, 29);
            btnThuocDelete.TabIndex = 14;
            btnThuocDelete.Text = "Xóa";
            btnThuocDelete.UseVisualStyleBackColor = true;
            btnThuocDelete.Click += btnThuocDelete_Click;
            // 
            // btnThuocEdit
            // 
            btnThuocEdit.Location = new Point(387, 487);
            btnThuocEdit.Name = "btnThuocEdit";
            btnThuocEdit.Size = new Size(94, 29);
            btnThuocEdit.TabIndex = 15;
            btnThuocEdit.Text = "Sửa";
            btnThuocEdit.UseVisualStyleBackColor = true;
            btnThuocEdit.Click += btnThuocEdit_Click;
            // 
            // btnThuocCancel
            // 
            btnThuocCancel.Location = new Point(546, 487);
            btnThuocCancel.Name = "btnThuocCancel";
            btnThuocCancel.Size = new Size(94, 29);
            btnThuocCancel.TabIndex = 16;
            btnThuocCancel.Text = "Hủy";
            btnThuocCancel.UseVisualStyleBackColor = true;
            btnThuocCancel.Click += btnThuocCancel_Click;
            // 
            // btnThuocExit
            // 
            btnThuocExit.Location = new Point(701, 487);
            btnThuocExit.Name = "btnThuocExit";
            btnThuocExit.Size = new Size(94, 29);
            btnThuocExit.TabIndex = 17;
            btnThuocExit.Text = "Thoát";
            btnThuocExit.UseVisualStyleBackColor = true;
            btnThuocExit.Click += btnThuocExit_Click;
            // 
            // dgvThuoc
            // 
            dgvThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuoc.Columns.AddRange(new DataGridViewColumn[] { maThuoc, tenThuoc, donViTinh, soLuong, donGia });
            dgvThuoc.Location = new Point(12, 12);
            dgvThuoc.Name = "dgvThuoc";
            dgvThuoc.RowHeadersWidth = 51;
            dgvThuoc.RowTemplate.Height = 29;
            dgvThuoc.Size = new Size(783, 300);
            dgvThuoc.TabIndex = 18;
            dgvThuoc.CellContentClick += dgvThuoc_CellContentClick;
            // 
            // maThuoc
            // 
            maThuoc.HeaderText = "Mã thuốc";
            maThuoc.MinimumWidth = 6;
            maThuoc.Name = "maThuoc";
            maThuoc.Width = 120;
            // 
            // tenThuoc
            // 
            tenThuoc.HeaderText = "Tên thuốc";
            tenThuoc.MinimumWidth = 6;
            tenThuoc.Name = "tenThuoc";
            tenThuoc.Width = 220;
            // 
            // donViTinh
            // 
            donViTinh.HeaderText = "Đơn vị tính";
            donViTinh.MinimumWidth = 6;
            donViTinh.Name = "donViTinh";
            donViTinh.Width = 150;
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
            donGia.Width = 120;
            // 
            // frmThuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(807, 553);
            Controls.Add(dgvThuoc);
            Controls.Add(btnThuocExit);
            Controls.Add(btnThuocCancel);
            Controls.Add(btnThuocEdit);
            Controls.Add(btnThuocDelete);
            Controls.Add(btnThuocFind);
            Controls.Add(btnThuocAdd);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtTenThuoc);
            Controls.Add(txtMaThuoc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMaThuoc);
            Controls.Add(btnThuocLoad);
            Name = "frmThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thuốc";
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnThuocLoad;
        private Label lblMaThuoc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaThuoc;
        private TextBox txtTenThuoc;
        private TextBox txtDonViTinh;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnThuocAdd;
        private Button btnThuocFind;
        private Button btnThuocDelete;
        private Button btnThuocEdit;
        private Button btnThuocCancel;
        private Button btnThuocExit;
        private DataGridView dgvThuoc;
        private DataGridViewTextBoxColumn maThuoc;
        private DataGridViewTextBoxColumn tenThuoc;
        private DataGridViewTextBoxColumn donViTinh;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
    }
}