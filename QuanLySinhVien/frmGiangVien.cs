using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLySinhVien.Class;

namespace QuanLySinhVien
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        DataTable tblHP, tblHome, tblTim, tblKT, tblQLDiem;


        /////// FUNCTIONS TAB HOME
        
        private void LoadDataGridViewHome()
        {
            string sql;
            sql = "SELECT Lop, Khoa, NienKhoa FROM tblSinhVien";
            tblHome = Functions.GetDataToTable(sql);
            DTGVHome.DataSource = tblHome;
            DTGVHome.Columns[0].HeaderText = "Lớp";
            DTGVHome.Columns[1].HeaderText = "Khoa";
            DTGVHome.Columns[2].HeaderText = "Khóa";
            DTGVHome.Columns[0].Width = 140;
            DTGVHome.Columns[1].Width = 140;
            DTGVHome.Columns[2].Width = 140;
            DTGVHome.AllowUserToAddRows = false;
            DTGVHome.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void tabHome_Click(object sender, EventArgs e)
        {
            LoadDataGridViewHome();
        }

        private void btnKhoaNN_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Lop, Khoa, NienKhoa FROM tblLop WHERE Khoa = N'Ngoại Ngữ'";
            Functions.RunSQL(sql);
            tblHome = Functions.GetDataToTable(sql);
            DTGVHome.DataSource = tblHome;
        }

        private void btnKhoaDL_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Lop, Khoa, NienKhoa FROM tblLop WHERE Khoa = N'Du Lịch'";
            Class.Functions.RunSQL(sql);
            tblHome = Functions.GetDataToTable(sql);
            DTGVHome.DataSource = tblHome;
        }

        private void btnKhoaCN_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Lop, Khoa, NienKhoa FROM tblLop WHERE Khoa = N'Công Nghệ'";
            Functions.RunSQL(sql);
            tblHome = Functions.GetDataToTable(sql);
            DTGVHome.DataSource = tblHome;
        }

        private void btnKhoaTC_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Lop, Khoa, NienKhoa FROM tblLop WHERE Khoa = N'Tài Chính'";
            Functions.RunSQL(sql);
            tblHome = Functions.GetDataToTable(sql);
            DTGVHome.DataSource = tblHome;
        }

        private void btnKhoaLuat_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Lop, Khoa, NienKhoa FROM tblLop WHERE Khoa = N'Luật'";
            Functions.RunSQL(sql);
            tblHome = Functions.GetDataToTable(sql);
            DTGVHome.DataSource = tblHome;
        }


        //////// FUNCTIONS TAB HỒ SƠ SINH VIÊN


        private void LoadData()
        {
            string MaSV = txtSearchMSSV_HS.Text;
            string sqlGetMssv = "select MSSV from tblSinhVien where MSSV = '" + MaSV + "'";
            txtMSSV_HS.Text = Functions.GetFieldValues(sqlGetMssv);

            string sqlGetName = "select TenSinhVien from tblSinhVien where MSSV = '" + MaSV + "'";
            txtTenSV_HS.Text = Functions.GetFieldValues(sqlGetName);

            string sqlGetGender = "select GioiTinh from tblDanhGia where MSSV = '" + MaSV + "'";
            txtGioiTinh_HS.Text = Functions.GetFieldValues(sqlGetGender);

            string sqlGetNoiSinh = "select NoiSinh from tblSinhVien where MSSV = '" + MaSV + "'";
            txtNoiSinh_HS.Text = Functions.GetFieldValues(sqlGetNoiSinh);

            string sqlGetLop = "select Lop from tblSinhVien where MSSV = '" + MaSV + "'";
            txtLop_HS.Text = Functions.GetFieldValues(sqlGetLop);

            string sqlGetFaculty = "select Khoa from tblSinhVien where MSSV = '" + MaSV + "'";
            txtKhoa_HS.Text = Functions.GetFieldValues(sqlGetFaculty);

            string sqlGetEmail = "select Email from tblSinhVien where MSSV = '" + MaSV + "'";
            txtEmail_HS.Text = Functions.GetFieldValues(sqlGetEmail);

            string sqlGetKhoa = "select NienKhoa from tblSinhVien where MSSV = '" + MaSV + "'";
            txtNienKhoa_HS.Text = Functions.GetFieldValues(sqlGetKhoa);

            string sqlGetNgaySinh = "select NgaySinh from tblSinhVien where MSSV = '" + MaSV + "'";
            txtNgaySinh_HS.Text = Functions.GetFieldValues(sqlGetNgaySinh);

            string sqlGetAddress = "select DiaChi from tblSinhVien where MSSV = '" + MaSV + "'";
            txtDiaChi_HS.Text = Functions.GetFieldValues(sqlGetAddress);

            string sqlGetSDT = "select SDT from tblSinhVien where MSSV = '" + MaSV + "'";
            mskSDT_HS.Text = Functions.GetFieldValues(sqlGetSDT);

            string sqlGetTenMe = "select TenMe from tblGiaDinh where MSSV = '" + MaSV + "'";
            txtTenMe_HS.Text = Functions.GetFieldValues(sqlGetTenMe);

            string sqlGetTenCha = "select TenCha from tblGiaDinh where MSSV = '" + MaSV + "'";
            txtTenCha_HS.Text = Functions.GetFieldValues(sqlGetTenCha);

            string sqlGetSDTMe = "select SDTMe from tblGiaDinh where MSSV = '" + MaSV + "'";
            mskSDTMe_HS.Text = Functions.GetFieldValues(sqlGetSDTMe);

            string sqlGetSDTCha = "select SDTCha from tblGiaDinh where MSSV = '" + MaSV + "'";
            mskSDTCha_HS.Text = Functions.GetFieldValues(sqlGetSDTCha);

            string sqlGetNgheMe = "select NgheNghiepMe from tblGiaDinh where MSSV = '" + MaSV + "'";
            txtNgheMe_HS.Text = Functions.GetFieldValues(sqlGetNgheMe);

            string sqlGetNgheCha = "select NgheNghiepCha from tblGiaDinh where MSSV = '" + MaSV + "'";
            txtNgheCha_HS.Text = Functions.GetFieldValues(sqlGetNgheCha);

            string sqlGetAddressMe = "select DiaChiMe from tblGiaDinh where MSSV = '" + MaSV + "'";
            txtDiaChiMe_HS.Text = Functions.GetFieldValues(sqlGetAddressMe);

            string sqlGetAddressCha = "select DiaChiCha from tblGiaDinh where MSSV = '" + MaSV + "'";
            txtDiaChiCha_HS.Text = Functions.GetFieldValues(sqlGetAddressCha);

        }
        private void btnTimKiem_HS_Click(object sender, EventArgs e)
        {  
            if (txtSearchMSSV_HS.Text == "")
            {
                MessageBox.Show("Hãy nhập mã số sinh viên!", "Yêu cầu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchMSSV_HS.Focus();
                return;
            }
            LoadData();
        }

        private void ResetValuesHS()
        {
            txtMSSV_HS.Text = "";
            txtTenSV_HS.Text = "";
            txtLop_HS.Text = "";
            txtKhoa_HS.Text = "";
            txtNgaySinh_HS.Text = "";
            txtNienKhoa_HS.Text = "";
            txtNoiSinh_HS.Text = "";
            mskSDT_HS.Text = "";
            txtDiaChi_HS.Text = "";
            txtEmail_HS.Text = "";
            txtTenCha_HS.Text = "";
            txtTenMe_HS.Text = "";
            mskSDTCha_HS.Text = "";
            mskSDTMe_HS.Text = "";
            txtNgheCha_HS.Text = "";
            txtNgheMe_HS.Text = "";
            txtDiaChiCha_HS.Text = "";
            txtDiaChiMe_HS.Text = "";
            txtGioiTinh_HS.Text = "";
            txtSearchMSSV_HS.Text = "";
        }
        private void btnThem_HS_Click(object sender, EventArgs e)
        {
            btnThem_HS.Enabled = false;
            btnSua_HS.Enabled = false;
            btnLuu_HS.Enabled = true;
            btnTimKiem_HS.Enabled = false;
            ResetValuesHS();
            txtMSSV_HS.Enabled = true;
            txtMSSV_HS.Focus();
        }

        private void btnLuu_HS_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMSSV_HS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã số sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV_HS.Focus();
                return;
            }
            if (txtTenSV_HS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSV_HS.Focus();
                return;
            }
            if (txtLop_HS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLop_HS.Focus();
                return;
            }
            if (txtKhoa_HS.Text == "")
            {
                MessageBox.Show("Bạn phải nhập khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoa_HS.Focus();
                return;
            }
            if (txtNgaySinh_HS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh_HS.Focus();
                return;
            }
            if (txtNienKhoa_HS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNienKhoa_HS.Focus();
                return;
            }
            if (txtNoiSinh_HS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nơi sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiSinh_HS.Focus();
                return;
            }
            if (mskSDT_HS.Text == "    .   .   ")
            {
                MessageBox.Show("Bạn phải nhập số diện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSDT_HS.Focus();
                return;
            }
            if (txtEmail_HS.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail_HS.Focus();
                return;
            }
            sql = "SELECT MSSV FROM tblSinhVien WHERE MSSV=N'" + txtMSSV_HS.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sinh viên này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV_HS.Focus();
                txtMSSV_HS.Text = "";
                return;
            }
            sql = "INSERT INTO tblSinhVien(MSSV,TenSinhVien,NgaySinh,NoiSinh,Lop,Khoa,NienKhoa,SDT,Email,DiaChi) VALUES ('" +
                txtMSSV_HS.Text + "', N'" + txtTenSV_HS.Text + "', '" + txtNgaySinh_HS.Text + "', N'" + txtNoiSinh_HS.Text + "','" +
                txtLop_HS.Text + "', N'" + txtKhoa_HS.Text + "', '" + txtNienKhoa_HS.Text + "','" + mskSDT_HS.Text + "','" +
                txtEmail_HS.Text + "', N'" + txtDiaChi_HS.Text + "')";
            Functions.RunSQL(sql);
            ResetValuesHS();
            btnThem_HS.Enabled = true;
            btnSua_HS.Enabled = true;
            btnLuu_HS.Enabled = false;
            txtMSSV_HS.Enabled = false;
        }


        //////// FUNCTIONS TAB TÌM KIẾM
        private void LoadDataGridViewTim()
        {
            string sql;
            sql = "SELECT MSSV, TenSinhVien, GioiTinh, SDT, Lop, Khoa, DiemTB, DiemRL, HocLuc FROM tblDanhGia"; 
            tblTim = Functions.GetDataToTable(sql);
            DTGVSearch.DataSource = tblTim;
            DTGVSearch.Columns[0].HeaderText = "MSSV";
            DTGVSearch.Columns[1].HeaderText = "Họ Tên";
            DTGVSearch.Columns[2].HeaderText = "Giới Tính";
            DTGVSearch.Columns[3].HeaderText = "SĐT";
            DTGVSearch.Columns[4].HeaderText = "Lớp";
            DTGVSearch.Columns[5].HeaderText = "Khoa";
            DTGVSearch.Columns[6].HeaderText = "Điểm Trung Bình";
            DTGVSearch.Columns[7].HeaderText = "Điểm Rèn Luyện";
            DTGVSearch.Columns[8].HeaderText = "Học Lực";
            DTGVSearch.Columns[0].Width = 100;
            DTGVSearch.Columns[1].Width = 100;
            DTGVSearch.Columns[2].Width = 100;
            DTGVSearch.Columns[3].Width = 100;
            DTGVSearch.Columns[4].Width = 100;
            DTGVSearch.Columns[5].Width = 100;
            DTGVSearch.Columns[6].Width = 120;
            DTGVSearch.Columns[7].Width = 120;
            DTGVSearch.Columns[8].Width = 100;
            DTGVSearch.AllowUserToAddRows = false;
            DTGVSearch.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void tabTim_Click(object sender, EventArgs e)
        {
            txtMSSV_Search.Enabled = false;
            btnHuy_Search.Enabled = false;
            btnTim_Search.Enabled = false;
            LoadDataGridViewTim();
        }
        private void ResetValuesTim()
        {
            txtMSSV_Search.Text = "";
            txtTenSV_Search.Text = "";
            txtGioiTinh_Search.Text = "";
            txtLop_Search.Text = "";
            txtKhoa_Search.Text = "";
            mskSDT_Search.Text = "";
        }
        private void DTGVSearch_Click(object sender, EventArgs e)
        {
            if (tblTim.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV_Search.Focus();
                return;
            }
            txtMSSV_Search.Text = DTGVSearch.CurrentRow.Cells["MSSV"].Value.ToString();
            txtTenSV_Search.Text = DTGVSearch.CurrentRow.Cells["TenSinhVien"].Value.ToString();
            txtGioiTinh_Search.Text = DTGVSearch.CurrentRow.Cells["GioiTinh"].Value.ToString();
            mskSDT_Search.Text = DTGVSearch.CurrentRow.Cells["SDT"].Value.ToString();
            txtLop_Search.Text = DTGVSearch.CurrentRow.Cells["Lop"].Value.ToString();
            txtKhoa_Search.Text = DTGVSearch.CurrentRow.Cells["Khoa"].Value.ToString();
        }

        private void btnTim_Search_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMSSV_Search.Text == "") && (txtTenSV_Search.Text == "") && (txtGioiTinh_Search.Text == "") &&
               (mskSDT_Search.Text == "") && (txtLop_Search.Text == "") && (txtKhoa_Search.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Yêu cầu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT MSSV, TenSinhVien, GioiTinh, SDT, Lop, Khoa, DiemTB, DiemRL, HocLuc FROM tblDanhGia WHERE 1=1";  
            if (txtMSSV_Search.Text != "")
                sql = sql + " and MSSV Like '%" + txtMSSV_Search.Text + "%'";
            if (txtTenSV_Search.Text != "")
                sql = sql + " and TenSinhVien Like N'%" + txtTenSV_Search.Text + "%'";
            if (txtGioiTinh_Search.Text != "")
                sql = sql + " and GioiTinh Like N'%" + txtGioiTinh_Search.Text + "%'";
            if (mskSDT_Search.Text != "")
                sql = sql + " and SDT Like '%" + mskSDT_Search.Text + "%'";
            if (txtLop_Search.Text != "")
                sql = sql + " and Lop Like N'%" + txtLop_Search.Text + "%'";
            if (txtKhoa_Search.Text != "")
                sql = sql + " and Khoa Like N'%" + txtKhoa_Search.Text + "%'";
            tblTim = Functions.GetDataToTable(sql);
            if (tblTim.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblTim.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTGVSearch.DataSource = tblTim;
            ResetValuesTim();
        }

        private void btnHuy_Search_Click(object sender, EventArgs e)
        {
            ResetValuesTim();
            DTGVSearch.DataSource = null;
            DTGVSearch.Refresh();
        }



        //////// FUNCTIONS TAB QUẢN LÝ ĐIỂM
        private void LoadDataGridViewQLDiem()
        {
            string sql;
            sql = "SELECT MSSV, TenSinhVien, MaHocPhan, TenHocPhan, DiemThi, KetQua FROM tblDiemThi";      
            tblQLDiem = Functions.GetDataToTable(sql);
            DTGVDiem.DataSource = tblQLDiem;
            DTGVDiem.Columns[0].HeaderText = "Mã Sinh Viên";
            DTGVDiem.Columns[1].HeaderText = "Tên Sinh Viên";
            DTGVDiem.Columns[2].HeaderText = "Mã học phần";
            DTGVDiem.Columns[3].HeaderText = "Tên Học Phần";
            DTGVDiem.Columns[4].HeaderText = "Điểm thi";
            DTGVDiem.Columns[5].HeaderText = "Kết Quả";
            DTGVDiem.Columns[0].Width = 125;
            DTGVDiem.Columns[1].Width = 160;
            DTGVDiem.Columns[2].Width = 110;
            DTGVDiem.Columns[3].Width = 145;
            DTGVDiem.Columns[4].Width = 110;
            DTGVDiem.Columns[5].Width = 100;
            DTGVDiem.AllowUserToAddRows = false;
            DTGVDiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void tabQLDiem_Click(object sender, EventArgs e)
        {
            txtTenSV_Diem.Enabled = false;
            btnThem_Diem.Enabled = false;
            btnXoa_Diem.Enabled = false;
            btnSua_Diem.Enabled = false;
            btnLuu_Diem.Enabled = false;
            btnTim_Diem.Enabled = false;
            LoadDataGridViewQLDiem();
        }

        private void ResetValuesQLDiem()
        {
            txtTenSV_Diem.Text = "";
            txtMSSV_Diem.Text = "";
            txtMaHP_Diem.Text = "";
            txtTenHP_Diem.Text = "";
            txtDiem_Diem.Text = "";
            txtKetQua_Diem.Text = "";
        }

        private void btnThem_Diem_Click(object sender, EventArgs e)
        {
            btnThem_Diem.Enabled = false;
            btnXoa_Diem.Enabled = false;
            btnSua_Diem.Enabled = false;
            btnLuu_Diem.Enabled = true;
            btnTim_Diem.Enabled = false;
            ResetValuesQLDiem();
            txtMSSV_Diem.Enabled = true;
            txtMSSV_Diem.Focus();
        }

        private void btnXoa_Diem_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblQLDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMSSV_Diem.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblHocPhan WHERE MSSV=N'" + txtMSSV_Diem.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridViewHP();
                ResetValuesHP();
            }
        }
        private void DTGVDiem_Click(object sender, EventArgs e)
        {
            if (tblQLDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV_Diem.Focus();
                return;
            }
            txtMSSV_Diem.Text = DTGVDiem.CurrentRow.Cells["MSSV"].Value.ToString();
            txtTenSV_Diem.Text = DTGVDiem.CurrentRow.Cells["TenSinhVien"].Value.ToString();
            txtMaHP_Diem.Text = DTGVDiem.CurrentRow.Cells["MaHocPhan"].Value.ToString();
            txtTenHP_Diem.Text = DTGVDiem.CurrentRow.Cells["TenHocPhan"].Value.ToString();
            txtDiem_Diem.Text = DTGVDiem.CurrentRow.Cells["DiemThi"].Value.ToString();
            txtKetQua_Diem.Text = DTGVDiem.CurrentRow.Cells["KetQua"].Value.ToString();
        }

        private void btnLuu_Diem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtDiem_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem_Diem.Focus();
                return;
            }
            if (txtKetQua_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKetQua_Diem.Focus();
                return;
            }
            if (txtTenSV_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSV_Diem.Focus();
                return;
            }
            if (txtMSSV_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã số sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV_Diem.Focus();
                return;
            }
            if (txtMaHP_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHP_Diem.Focus();
                return;
            }
            if (txtTenHP_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHP_Diem.Focus();
                return;
            }
            sql = "SELECT MaHocPhan, MSSV FROM tblHocPhan WHERE MaHocPhan=N'" + txtMaHP_Diem.Text + "' and MSSV = '" + txtMSSV_Diem.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Thong tin này đã có, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMSSV_Diem.Focus();
                txtMSSV_Diem.Text = "";
                txtMaHP_Diem.Focus();
                txtMaHP_Diem.Text = "";
                return;
            }
            sql = "INSERT INTO tblDiemThi(MSSV, TenSinhVien, MaHocPhan, TenHocPhan,  DiemThi, KetQua) VALUES ('" +
                txtMSSV_Diem.Text + "',N'" + txtTenSV_Diem.Text + "','" + txtMaHP_Diem.Text + "', N'" + txtTenHP_Diem.Text + "','" + 
                txtDiem_Diem.Text + "','" + txtKetQua_Diem + "')";
            Functions.RunSQL(sql);
            LoadDataGridViewQLDiem();
            ResetValuesQLDiem();
            btnXoa_Diem.Enabled = true;
            btnThem_Diem.Enabled = true;
            btnSua_Diem.Enabled = true;
            btnTim_Diem.Enabled = true;
            btnLuu_Diem.Enabled = false;
            txtMSSV_Diem.Enabled = false;
        }

        private void btnSua_Diem_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblQLDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiem_Diem.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem_Diem.Focus();
                return;
            }
            if (txtKetQua_Diem.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKetQua_Diem.Focus();
                return;
            }
            if (txtTenSV_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã số sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV_Diem.Focus();
                return;
            }
            if (txtMSSV_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV_Diem.Focus();
                return;
            }
            if (txtMaHP_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHP_Diem.Focus();
                return;
            }
            if (txtTenHP_Diem.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHP_Diem.Focus();
                return;
            }
            sql = "UPDATE tblDiemThi set MSSV = '" + txtMSSV_Diem.Text + "', TenSinhVien = N'" +      
                txtTenSV_Diem.Text + "', MaHocPhan =" + txtMaHP_Diem.Text + ", TenHocPhan = N'" + txtTenHP_Diem.Text + 
                "', DiemThi = N'" + txtDiem_Diem.Text + "', KetQua = N'" + txtKetQua_Diem.Text + "' WHERE MSSV = '" + txtMSSV_Diem.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridViewQLDiem();
            ResetValuesQLDiem();
        }

        private void btnTim_Diem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHP_Diem.Text == "") && (txtKetQua_Diem.Text == "") && (txtTenSV_Diem.Text == "") &&
               (txtMSSV_Diem.Text == "") && (txtTenHP_Diem.Text == "") && (txtDiem_Diem.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Yêu cầu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT MSSV, TenSinhVien, MaHocPhan, TenHocPhan, DiemThi, KetQua  FROM tblDiemThi WHERE 1=1";
            if (txtDiem_Diem.Text != "")
                sql = sql + " and DiemThi Like N'%" + txtDiem_Diem.Text + "%'";
            if (txtKetQua_Diem.Text != "")
                sql = sql + " and KetQua Like N'%" + txtKetQua_Diem.Text + "%'";
            if (txtTenSV_Diem.Text != "")
                sql = sql + " and TenSinhVien Like N'%" + txtTenSV_Diem.Text + "%'";
            if (txtMSSV_Diem.Text != "")
                sql = sql + " and MSSV Like N'%" + txtMSSV_Diem.Text + "%'";
            if (txtMaHP_Diem.Text != "")
                sql = sql + " and MaHocPhan Like N'%" + txtMaHP_Diem.Text + "%'";
            if (txtTenHP_Diem.Text != "")
                sql = sql + " and TenHocPhan Like N'%" + txtTenHP_Diem.Text + "%'";
            tblQLDiem = Functions.GetDataToTable(sql);
            if (tblQLDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblQLDiem.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTGVDiem.DataSource = tblQLDiem;
            ResetValuesQLDiem();
        }

       


        //////// FUNCTIONS TAB HỌC PHẦN
        private void LoadDataGridViewHP()
        {
            string sql;
            sql = "SELECT MaHocPhan, TenHocPhan, SoTinChi, SoTiet, HocPhi FROM tblHocPhan";
            tblHP = Functions.GetDataToTable(sql);
            DTGVSubject.DataSource = tblHP;
            DTGVSubject.Columns[0].HeaderText = "Mã học phần";
            DTGVSubject.Columns[1].HeaderText = "Tên học phần";
            DTGVSubject.Columns[2].HeaderText = "Số tín chỉ";
            DTGVSubject.Columns[3].HeaderText = "Số tiết ";
            DTGVSubject.Columns[4].HeaderText = "Học phí";
            DTGVSubject.Columns[0].Width = 100;
            DTGVSubject.Columns[1].Width = 150;
            DTGVSubject.Columns[2].Width = 100;
            DTGVSubject.Columns[3].Width = 150;
            DTGVSubject.Columns[4].Width = 100;
            DTGVSubject.AllowUserToAddRows = false;
            DTGVSubject.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void tabHocPhan_Click(object sender, EventArgs e)
        {
            txtMaHP_Sub.Enabled = false;
            btnLuu_Sub.Enabled = false;
            btnSua_Sub.Enabled = false;
            btnTim_Sub.Enabled = false;
            btnXoa_Sub.Enabled = false;
            LoadDataGridViewHP();
        }

        private void ResetValuesHP()
        {
            txtMaHP_Sub.Text = "";
            txtTenHP_Sub.Text = "";
            txtSoTiet_Sub.Text = "";
            txtSoTinChi_Sub.Text = "";
            mskHocPhi_Sub.Text = "";
        }

        private void btnTim_Sub_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHP_Sub.Text == "") && (txtTenHP_Sub.Text == "") && (txtSoTiet_Sub.Text == "") &&
               (txtSoTinChi_Sub.Text == "") && (mskHocPhi_Sub.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Yêu cầu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT MaHocPhan, TenHocPhan, SoTinChi, SoTiet, HocPhi  FROM tblHocPhan WHERE 1=1";
            if (txtMaHP_Sub.Text != "")
                sql = sql + " and MaHocPhan Like '%" + txtMaHP_Sub.Text + "%'";
            if (txtTenHP_Sub.Text != "")
                sql = sql + " and TenHocPhan Like N'%" + txtTenHP_Sub.Text + "%'";
            if (txtSoTinChi_Sub.Text != "")
                sql = sql + " and SoTinChi Like N'%" + txtSoTinChi_Sub.Text + "%'";
            if (txtSoTiet_Sub.Text != "")
                sql = sql + " and SoTiet Like '%" + txtSoTiet_Sub.Text + "%'";
            if (mskHocPhi_Sub.Text != "")
                sql = sql + " and HocPhi Like N'%" + mskHocPhi_Sub.Text + "%'";
            tblHP = Functions.GetDataToTable(sql);
            if (tblHP.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHP.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTGVSubject.DataSource = tblHP;
            ResetValuesHP();
        }

        private void btnThem_Sub_Click(object sender, EventArgs e)
        {
            btnSua_Sub.Enabled = false;
            btnXoa_Sub.Enabled = false;
            btnLuu_Sub.Enabled = true;
            btnThem_Sub.Enabled = false;
            ResetValuesHP();
            txtMaHP_Sub.Enabled = true;
            txtMaHP_Sub.Focus();
        }

        private void btnXoa_Sub_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHP_Sub.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblHocPhan WHERE MaHocPhan=N'" + txtMaHP_Sub.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridViewHP();
                ResetValuesHP();
            }
        }
        private void DTGVSubject_Click(object sender, EventArgs e)
        {
            if (tblHP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHP_Sub.Focus();
                return;
            }
            txtMaHP_Sub.Text = DTGVSubject.CurrentRow.Cells["MaHocPhan"].Value.ToString();
            txtTenHP_Sub.Text = DTGVSubject.CurrentRow.Cells["TenHocPhan"].Value.ToString();
            txtSoTiet_Sub.Text = DTGVSubject.CurrentRow.Cells["SoTiet"].Value.ToString();
            txtSoTinChi_Sub.Text = DTGVSubject.CurrentRow.Cells["SoTinChi"].Value.ToString();
            mskHocPhi_Sub.Text = DTGVSubject.CurrentRow.Cells["HocPhi"].Value.ToString();
        }


        private void btnLuu_Sub_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHP_Sub.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHP_Sub.Focus();
                return;
            }
            if (txtTenHP_Sub.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHP_Sub.Focus();
                return;
            }
            if (txtSoTinChi_Sub.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số tín chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTinChi_Sub.Focus();
                return;
            }
            if (txtSoTiet_Sub.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTiet_Sub.Focus();
                return;
            }
            if (mskHocPhi_Sub.Text == "")
            {
                MessageBox.Show("Bạn phải nhập học phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskHocPhi_Sub.Focus();
                return;
            }
            sql = "SELECT MaHocPhan FROM tblHocPhan WHERE MaHocPhan=N'" + txtMaHP_Sub.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã học phần này đã có, bạn phải nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHP_Sub.Focus();
                txtMaHP_Sub.Text = "";
                return;
            }
            
            sql = "INSERT INTO tblHocPhan(MaHocPhan,TenHocPhan,SoTinChi,SoTiet,HocPhi) VALUES ('" + txtMaHP_Sub.Text.Trim() + "',N'" + txtTenHP_Sub.Text.Trim() + "', '" + txtSoTinChi_Sub.Text.Trim() + "','" + txtSoTiet_Sub.Text + "','" + mskHocPhi_Sub.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridViewHP();
            ResetValuesHP();
            btnXoa_Sub.Enabled = true;
            btnThem_Sub.Enabled = true;
            btnSua_Sub.Enabled = true;
            btnLuu_Sub.Enabled = false;
            txtMaHP_Sub.Enabled = false;
        }

        private void btnSua_Sub_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHP_Sub.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHP_Sub.Focus();
                return;
            }
            if (txtTenHP_Sub.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHP_Sub.Focus();
                return;
            }
            if (txtSoTiet_Sub.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTiet_Sub.Focus();
                return;
            }
            if (txtSoTinChi_Sub.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số tín chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTinChi_Sub.Focus();
                return;
            }
            if (mskHocPhi_Sub.Text == "   .   .   ")
            {
                MessageBox.Show("Bạn phải nhập hoc phí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHP_Diem.Focus();
                return;
            }
            sql = "UPDATE tblHocPhan set MaHocPhan = '" + txtMaHP_Sub.Text.Trim().ToString() + "', TenHocPhan = N'" +      
                txtTenHP_Sub.Text + "', SoTinChi =" + txtSoTinChi_Sub.Text.Trim().ToString() + ", SoTiet = '" + txtSoTiet_Sub.Text +
                "', HocPhi = '" + mskHocPhi_Sub.Text + "' WHERE MaHocPhan = '" + txtMaHP_Sub.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridViewHP();
            ResetValuesHP();
        }


        //////// FUNCTIONS TAB KHEN THƯỞNG
        private void LoadDataGridViewKT()
        {
            string sql;
            sql = "SELECT MSSV, TenSinhVien, Lop, Khoa FROM tblSinhVien"; 
            tblKT = Functions.GetDataToTable(sql);
            DTGVKhenThuong.DataSource = tblKT;
            DTGVKhenThuong.Columns[0].HeaderText = "MSSV";
            DTGVKhenThuong.Columns[1].HeaderText = "Tên sinh viên";
            DTGVKhenThuong.Columns[2].HeaderText = "Lớp";
            DTGVKhenThuong.Columns[3].HeaderText = "Khoa";
            DTGVKhenThuong.Columns[4].HeaderText = "Điểm Trung Bình";
            DTGVKhenThuong.Columns[5].HeaderText = "Điểm Rèn Luyện";
            DTGVKhenThuong.Columns[6].HeaderText = "Học Lực";
            DTGVKhenThuong.Columns[7].HeaderText = "Khen Thưởng";
            DTGVKhenThuong.Columns[0].Width = 100;
            DTGVKhenThuong.Columns[1].Width = 150;
            DTGVKhenThuong.Columns[2].Width = 100;
            DTGVKhenThuong.Columns[3].Width = 150;
            DTGVKhenThuong.Columns[4].Width = 100;
            DTGVKhenThuong.Columns[5].Width = 100;
            DTGVKhenThuong.Columns[6].Width = 100;
            DTGVKhenThuong.Columns[7].Width = 100;
            DTGVKhenThuong.AllowUserToAddRows = false;
            DTGVKhenThuong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValuesKT()
        {
            txtMaSV_KT.Text = "";
            txtHoTen_KT.Text = "";
            txtLop_KT.Text = "";
            txtKhoa_KT.Text = "";
        }

        private void btnHuy_KT_Click(object sender, EventArgs e)
        {
            ResetValuesKT();
            DTGVKhenThuong.DataSource = null;
            DTGVKhenThuong.Refresh();
        }
        private void DTGVKhenThuong_Click(object sender, EventArgs e)
        {
            if (tblKT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV_KT.Focus();
                return;
            }
            txtMaSV_KT.Text = DTGVKhenThuong.CurrentRow.Cells["MSSV"].Value.ToString();
            txtHoTen_KT.Text = DTGVKhenThuong.CurrentRow.Cells["TenSinhVien"].Value.ToString();
            txtLop_KT.Text = DTGVKhenThuong.CurrentRow.Cells["Lop"].Value.ToString();
            txtKhoa_KT.Text = DTGVKhenThuong.CurrentRow.Cells["Khoa"].Value.ToString();
        }

        private void btnTim_KT_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaSV_KT.Text == "") && (txtHoTen_KT.Text == "") &&
               (txtLop_KT.Text == "") && (txtKhoa_KT.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Yêu cầu ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT MSSV, TenSinhVien, Lop, Khoa, DiemTB, DiemRL, HocLuc, KhenThuong FROM tblDanhGia WHERE 1=1";         
                sql = sql + " and MSSV Like '%" + txtMaSV_KT.Text + "%'";
            if (txtHoTen_KT.Text != "")
                sql = sql + " and TenSinhVien Like N'%" + txtHoTen_KT.Text + "%'";
            if (txtLop_KT.Text != "")
                sql = sql + " and Lop Like N'%" + txtLop_KT.Text + "%'";
            if (txtKhoa_KT.Text != "")
                sql = sql + " and Khoa Like N'%" + txtKhoa_KT.Text + "%'";                      
            tblKT = Functions.GetDataToTable(sql);
            if (tblKT.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblKT.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTGVKhenThuong.DataSource = tblKT;
            ResetValuesKT();
        }




        private void txtTenSV_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void chkDoanVien_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void chkGioiTinh_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtCMND_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtNgaySinh_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtNoiSinh_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDanToc_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiaChi_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtLop_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtKhoa_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtNienKhoa_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskSDT_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtEmail_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenMe_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskSDTMe_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtNgheMe_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiaChiMe_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtSearchMSSV_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenCha_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskSDTCha_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtNgheCha_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiaChiCha_HS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenSV_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtGioiTinh_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskSDT_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMSSV_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtLop_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtKhoa_Search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenSV_Diem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiem4_Diem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMaHP_Diem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMSSV_Diem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiem10_Diem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenHP_Diem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMaHP_Sub_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtSoTinChi_Sub_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtKhoa_Sub_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenHP_Sub_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        private void txtSoTiet_Sub_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mskHocPhi_Sub_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        

        private void txtHoTen_KT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtLop_KT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMaSV_KT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtKhoa_KT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
