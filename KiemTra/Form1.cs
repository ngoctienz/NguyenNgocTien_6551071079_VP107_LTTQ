using Microsoft.EntityFrameworkCore;
using KiemTra.Models;

namespace KiemTra
{
    public partial class Form1 : Form
    {

        private ApplicationDbContext Context = new ApplicationDbContext();
        private MonHoc? monHocDangChon = null;

        public Form1()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            dvgDanhSach.DataSource = Context.MonHocs.ToList();

            dvgDanhSach.Columns["MaMonHoc"]!.HeaderText = "Mã Môn Học";
            dvgDanhSach.Columns["TenMonHoc"]!.HeaderText = "Tên Môn Học";
            dvgDanhSach.Columns["SoTinChi"]!.HeaderText = "Số Tín Chỉ";

            dvgDanhSach.Columns["MaMonHoc"]!.Width = 150;
            dvgDanhSach.Columns["TenMonHoc"]!.Width = 250;
            dvgDanhSach.Columns["SoTinChi"]!.Width = 110;

            dvgDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgDanhSach.MultiSelect = false;
            dvgDanhSach.ReadOnly = true;
            dvgDanhSach.AllowUserToAddRows = false;
            dvgDanhSach.ClearSelection();

            monHocDangChon = null;
            setButtonState();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            setButtonState();
        }

        private void dvgDanhSach_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dvgDanhSach.Rows[e.RowIndex].DataBoundItem is MonHoc mh)
            {
                monHocDangChon = mh;
                txtMaMonHoc.Text = mh.MaMonHoc;
                txtTenMonHoc.Text = mh.TenMonHoc;
                txtSoTinChi.Text = mh.SoTinChi;
                errorProvider1.Clear();
                setButtonState();
            }
        }

        private void txtSoTinChi_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                if (txtSoTinChi.Text.Contains('.') || txtSoTinChi.Text.Contains(','))
                    e.Handled = true;
                return;
            }

            e.Handled = true;
        }

        private bool KiemTraDuLieu()
        {
            errorProvider1.Clear();
            bool hopLe = true;

            string maMonHoc = txtMaMonHoc.Text.Trim();
            string tenMonHoc = txtTenMonHoc.Text.Trim();
            string soTinChi = txtSoTinChi.Text.Trim();

            if (string.IsNullOrEmpty(maMonHoc))
            {
                errorProvider1.SetError(txtMaMonHoc, "Mã môn học không được để trống");
                hopLe = false;
            }
            else if (maMonHoc.Length > 10)
            {
                errorProvider1.SetError(txtMaMonHoc, "Mã môn học tối đa 10 ký tự");
                hopLe = false;
            }

            if (string.IsNullOrEmpty(tenMonHoc))
            {
                errorProvider1.SetError(txtTenMonHoc, "Tên môn học không được để trống");
                hopLe = false;
            }

            if (string.IsNullOrEmpty(soTinChi))
            {
                errorProvider1.SetError(txtSoTinChi, "Số tín chỉ không được để trống");
                hopLe = false;
            }
            else if (!double.TryParse(soTinChi.Replace(',', '.'), System.Globalization.NumberStyles.Float,
                         System.Globalization.CultureInfo.InvariantCulture, out double so) || so < 0)
            {
                errorProvider1.SetError(txtSoTinChi, "Số tín chỉ phải là số nguyên hoặc số thực không âm");
                hopLe = false;
            }

            return hopLe;
        }

        private void XoaTrang()
        {
            txtMaMonHoc.Clear();
            txtTenMonHoc.Clear();
            txtSoTinChi.Clear();
            errorProvider1.Clear();
            txtMaMonHoc.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            try
            {
                string maMonHoc = txtMaMonHoc.Text.Trim();

                if (Context.MonHocs.Any(mh => mh.MaMonHoc == maMonHoc))
                {
                    errorProvider1.SetError(txtMaMonHoc, "Mã môn học đã tồn tại");
                    txtMaMonHoc.Focus();
                    return;
                }

                var monHoc = new MonHoc
                {
                    MaMonHoc = maMonHoc,
                    TenMonHoc = txtTenMonHoc.Text.Trim(),
                    SoTinChi = txtSoTinChi.Text.Trim()
                };

                Context.MonHocs.Add(monHoc);
                Context.SaveChanges();

                LoadData();
                XoaTrang();

                MessageBox.Show("Thêm môn học thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (monHocDangChon == null) return;
            if (!KiemTraDuLieu()) return;

            string maMonHocCu = monHocDangChon.MaMonHoc;
            string maMonHocMoi = txtMaMonHoc.Text.Trim();

            if (maMonHocMoi != maMonHocCu &&
                Context.MonHocs.Any(mh => mh.MaMonHoc == maMonHocMoi))
            {
                errorProvider1.SetError(txtMaMonHoc, "Mã môn học đã tồn tại");
                txtMaMonHoc.Focus();
                return;
            }

            try
            {
                var monHoc = Context.MonHocs.Find(maMonHocCu);
                if (monHoc == null)
                {
                    MessageBox.Show("Môn học không còn tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    monHocDangChon = null;
                    LoadData();
                    XoaTrang();
                    setButtonState();
                    return;
                }

                monHoc.MaMonHoc = maMonHocMoi;
                monHoc.TenMonHoc = txtTenMonHoc.Text.Trim();
                monHoc.SoTinChi = txtSoTinChi.Text.Trim();

                Context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi sửa", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            monHocDangChon = null;
            LoadData();
            XoaTrang();
            dvgDanhSach.ClearSelection();
            setButtonState();

            MessageBox.Show("Cập nhật môn học thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (monHocDangChon == null) return;

            var traLoi = MessageBox.Show(
                "Bạn có muốn xóa môn học này không?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traLoi != DialogResult.Yes) return;

  
                var monHoc = Context.MonHocs.Find(monHocDangChon.MaMonHoc);
                if (monHoc != null)
                {
                    Context.MonHocs.Remove(monHoc);
                    Context.SaveChanges();
                }

                LoadData();
                XoaTrang();

                MessageBox.Show("Xóa môn học thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var traLoi = MessageBox.Show("Bạn có muốn thoát không", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traLoi == DialogResult.Yes)
                Close();
        }

        private void setButtonState()
        {
            bool coChon = monHocDangChon != null;

            btnSua.Enabled = coChon;
            btnXoa.Enabled = coChon;
            btnThem.Enabled = true;
        }
    }
}
