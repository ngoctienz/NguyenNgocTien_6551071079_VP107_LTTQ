namespace KiemTra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtSoTinChi = new TextBox();
            txtTenMonHoc = new TextBox();
            txtMaMonHoc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dvgDanhSach = new DataGridView();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgDanhSach).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoTinChi);
            groupBox1.Controls.Add(txtTenMonHoc);
            groupBox1.Controls.Add(txtMaMonHoc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin môn học";
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(19, 193);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(238, 27);
            txtSoTinChi.TabIndex = 5;
            txtSoTinChi.KeyPress += txtSoTinChi_KeyPress;
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(19, 126);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(238, 27);
            txtTenMonHoc.TabIndex = 4;
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(19, 64);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(238, 27);
            txtMaMonHoc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 169);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Số tín chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 103);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên môn học:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã môn học:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgDanhSach);
            groupBox2.Location = new Point(335, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 508);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách môn học";
            // 
            // dvgDanhSach
            // 
            dvgDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDanhSach.Location = new Point(26, 32);
            dvgDanhSach.Name = "dvgDanhSach";
            dvgDanhSach.RowHeadersWidth = 51;
            dvgDanhSach.Size = new Size(629, 460);
            dvgDanhSach.TabIndex = 0;
            dvgDanhSach.CellClick += dvgDanhSach_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(23, 338);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 191);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(154, 111);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(103, 64);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "❎Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(19, 111);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 64);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(154, 26);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(103, 64);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 64);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 541);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản lý Môn học/ Học phần - VP107";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgDanhSach).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtSoTinChi;
        private TextBox txtTenMonHoc;
        private TextBox txtMaMonHoc;
        private DataGridView dvgDanhSach;
        private ErrorProvider errorProvider1;
    }
}
