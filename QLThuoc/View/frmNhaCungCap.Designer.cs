namespace QLThuoc.View
{
    partial class frmNhaCungCap
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
            dgvNhaCungCap = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            btnNCCExit = new Button();
            btnNCCCancel = new Button();
            btnNCCEdit = new Button();
            btnNCCDelete = new Button();
            btnNCCFind = new Button();
            btnNCCAdd = new Button();
            txtDiaChiNCC = new TextBox();
            txtTenNCC = new TextBox();
            txtMaNCC = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblMaThuoc = new Label();
            btnNCCLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvNhaCungCap.Location = new Point(12, 12);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.RowTemplate.Height = 29;
            dgvNhaCungCap.Size = new Size(783, 300);
            dgvNhaCungCap.TabIndex = 2;
            dgvNhaCungCap.CellContentClick += dgvNhaCungCap_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã nhà cung cấp";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên nhà cung cấp";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 310;
            // 
            // btnNCCExit
            // 
            btnNCCExit.Location = new Point(701, 487);
            btnNCCExit.Name = "btnNCCExit";
            btnNCCExit.Size = new Size(94, 29);
            btnNCCExit.TabIndex = 34;
            btnNCCExit.Text = "Thoát";
            btnNCCExit.UseVisualStyleBackColor = true;
            btnNCCExit.Click += btnNCCExit_Click;
            // 
            // btnNCCCancel
            // 
            btnNCCCancel.Location = new Point(546, 487);
            btnNCCCancel.Name = "btnNCCCancel";
            btnNCCCancel.Size = new Size(94, 29);
            btnNCCCancel.TabIndex = 33;
            btnNCCCancel.Text = "Hủy";
            btnNCCCancel.UseVisualStyleBackColor = true;
            btnNCCCancel.Click += btnNCCCancel_Click;
            // 
            // btnNCCEdit
            // 
            btnNCCEdit.Location = new Point(387, 487);
            btnNCCEdit.Name = "btnNCCEdit";
            btnNCCEdit.Size = new Size(94, 29);
            btnNCCEdit.TabIndex = 32;
            btnNCCEdit.Text = "Sửa";
            btnNCCEdit.UseVisualStyleBackColor = true;
            btnNCCEdit.Click += btnNCCEdit_Click;
            // 
            // btnNCCDelete
            // 
            btnNCCDelete.Location = new Point(546, 405);
            btnNCCDelete.Name = "btnNCCDelete";
            btnNCCDelete.Size = new Size(94, 29);
            btnNCCDelete.TabIndex = 31;
            btnNCCDelete.Text = "Xóa";
            btnNCCDelete.UseVisualStyleBackColor = true;
            btnNCCDelete.Click += btnNCCDelete_Click;
            // 
            // btnNCCFind
            // 
            btnNCCFind.Location = new Point(546, 328);
            btnNCCFind.Name = "btnNCCFind";
            btnNCCFind.Size = new Size(94, 29);
            btnNCCFind.TabIndex = 30;
            btnNCCFind.Text = "Tìm";
            btnNCCFind.UseVisualStyleBackColor = true;
            btnNCCFind.Click += btnNCCFind_Click;
            // 
            // btnNCCAdd
            // 
            btnNCCAdd.Location = new Point(387, 405);
            btnNCCAdd.Name = "btnNCCAdd";
            btnNCCAdd.Size = new Size(94, 29);
            btnNCCAdd.TabIndex = 29;
            btnNCCAdd.Text = "Thêm";
            btnNCCAdd.UseVisualStyleBackColor = true;
            btnNCCAdd.Click += btnNCCAdd_Click;
            // 
            // txtDiaChiNCC
            // 
            txtDiaChiNCC.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtDiaChiNCC.Location = new Point(129, 407);
            txtDiaChiNCC.Name = "txtDiaChiNCC";
            txtDiaChiNCC.PlaceholderText = "Địa chỉ nhà cung cấp";
            txtDiaChiNCC.Size = new Size(218, 27);
            txtDiaChiNCC.TabIndex = 26;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtTenNCC.Location = new Point(129, 367);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.PlaceholderText = "Tên nhà cung cấp";
            txtTenNCC.Size = new Size(218, 27);
            txtTenNCC.TabIndex = 25;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMaNCC.Location = new Point(129, 330);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.PlaceholderText = "Mã nhà cung cấp";
            txtMaNCC.Size = new Size(218, 27);
            txtMaNCC.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 414);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 21;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 374);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 20;
            label2.Text = "Tên NCC";
            // 
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaThuoc.Location = new Point(12, 337);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new Size(65, 20);
            lblMaThuoc.TabIndex = 19;
            lblMaThuoc.Text = "Mã NCC";
            // 
            // btnNCCLoad
            // 
            btnNCCLoad.Location = new Point(387, 328);
            btnNCCLoad.Name = "btnNCCLoad";
            btnNCCLoad.Size = new Size(94, 29);
            btnNCCLoad.TabIndex = 18;
            btnNCCLoad.Text = "Hiển thị";
            btnNCCLoad.UseVisualStyleBackColor = true;
            btnNCCLoad.Click += btnNCCLoad_Click;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(807, 553);
            Controls.Add(btnNCCExit);
            Controls.Add(btnNCCCancel);
            Controls.Add(btnNCCEdit);
            Controls.Add(btnNCCDelete);
            Controls.Add(btnNCCFind);
            Controls.Add(btnNCCAdd);
            Controls.Add(txtDiaChiNCC);
            Controls.Add(txtTenNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMaThuoc);
            Controls.Add(btnNCCLoad);
            Controls.Add(dgvNhaCungCap);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvNhaCungCap;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btnNCCExit;
        private Button btnNCCCancel;
        private Button btnNCCEdit;
        private Button btnNCCDelete;
        private Button btnNCCFind;
        private Button btnNCCAdd;
        private TextBox txtDiaChiNCC;
        private TextBox txtTenNCC;
        private TextBox txtMaNCC;
        private Label label3;
        private Label label2;
        private Label lblMaThuoc;
        private Button btnNCCLoad;
    }
}