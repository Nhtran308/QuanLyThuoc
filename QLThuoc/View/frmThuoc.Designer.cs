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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuoc));
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
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaThuoc.Location = new Point(12, 9);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new Size(74, 20);
            lblMaThuoc.TabIndex = 2;
            lblMaThuoc.Text = "Mã thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(344, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 50);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(344, 50);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(528, 50);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 6;
            label5.Text = "Đơn giá";
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMaThuoc.Location = new Point(104, 6);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.PlaceholderText = "Mã thuốc";
            txtMaThuoc.Size = new Size(218, 27);
            txtMaThuoc.TabIndex = 7;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtTenThuoc.Location = new Point(426, 6);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.PlaceholderText = "Tên thuốc";
            txtTenThuoc.Size = new Size(316, 27);
            txtTenThuoc.TabIndex = 8;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtDonViTinh.Location = new Point(104, 47);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.PlaceholderText = "Đơn vị tính";
            txtDonViTinh.Size = new Size(218, 27);
            txtDonViTinh.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(426, 47);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.PlaceholderText = "Số lượng";
            txtSoLuong.Size = new Size(67, 27);
            txtSoLuong.TabIndex = 10;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtDonGia.Location = new Point(620, 47);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.PlaceholderText = "Đơn giá";
            txtDonGia.Size = new Size(122, 27);
            txtDonGia.TabIndex = 11;
            // 
            // btnThuocAdd
            // 
            btnThuocAdd.Location = new Point(12, 412);
            btnThuocAdd.Name = "btnThuocAdd";
            btnThuocAdd.Size = new Size(94, 29);
            btnThuocAdd.TabIndex = 12;
            btnThuocAdd.Text = "Thêm";
            btnThuocAdd.UseVisualStyleBackColor = true;
            btnThuocAdd.Click += btnThuocAdd_Click;
            // 
            // btnThuocFind
            // 
            btnThuocFind.Location = new Point(528, 412);
            btnThuocFind.Name = "btnThuocFind";
            btnThuocFind.Size = new Size(94, 29);
            btnThuocFind.TabIndex = 13;
            btnThuocFind.Text = "Tìm";
            btnThuocFind.UseVisualStyleBackColor = true;
            btnThuocFind.Click += btnThuocFind_Click;
            // 
            // btnThuocDelete
            // 
            btnThuocDelete.Location = new Point(177, 412);
            btnThuocDelete.Name = "btnThuocDelete";
            btnThuocDelete.Size = new Size(94, 29);
            btnThuocDelete.TabIndex = 14;
            btnThuocDelete.Text = "Xóa";
            btnThuocDelete.UseVisualStyleBackColor = true;
            btnThuocDelete.Click += btnThuocDelete_Click;
            // 
            // btnThuocEdit
            // 
            btnThuocEdit.Location = new Point(354, 412);
            btnThuocEdit.Name = "btnThuocEdit";
            btnThuocEdit.Size = new Size(94, 29);
            btnThuocEdit.TabIndex = 15;
            btnThuocEdit.Text = "Sửa";
            btnThuocEdit.UseVisualStyleBackColor = true;
            btnThuocEdit.Click += btnThuocEdit_Click;
            // 
            // btnThuocExit
            // 
            btnThuocExit.Location = new Point(701, 412);
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
            dgvThuoc.Location = new Point(12, 97);
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
            ClientSize = new Size(807, 453);
            Controls.Add(dgvThuoc);
            Controls.Add(btnThuocExit);
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
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thuốc";
            KeyDown += frmThuoc_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnThuocExit;
        public DataGridView dgvThuoc;
        private DataGridViewTextBoxColumn maThuoc;
        private DataGridViewTextBoxColumn tenThuoc;
        private DataGridViewTextBoxColumn donViTinh;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
    }
}