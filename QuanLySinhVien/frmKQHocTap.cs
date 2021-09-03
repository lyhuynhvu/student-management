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
    public partial class frmKQHocTap : Form
    {
        DataTable tblKQHT;
        public string idSV;
        public frmKQHocTap(string id)
        {
            idSV = id;
            InitializeComponent();
        }
        private void frmKQHocTap_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql = "select MaHocPhan, TenHocPhan, SoTinChi, DiemThi, KetQua from tblDiemThi where MSSV = '" + idSV + "'";
            tblKQHT = Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblKQHT;
            dataGridView.Columns[0].HeaderText = "Mã Học Phần";
            dataGridView.Columns[1].HeaderText = "Tên Học Phần";
            dataGridView.Columns[2].HeaderText = "Số Tín Chỉ";
            dataGridView.Columns[3].HeaderText = "Điểm Thi";
            dataGridView.Columns[4].HeaderText = "Kết Quả";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 250;
            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void LoadData()
        {
            string sqlGetMssv = "select MSSV from tblDanhGia where  MSSV = '" + idSV + "'";
            lblMaSV.Text = Functions.GetFieldValues(sqlGetMssv);

            string sqlGetName = "select TenSinhVien from tblDanhGia where  MSSV = '" + idSV + "'";
            lblTenSinhVien.Text = Functions.GetFieldValues(sqlGetName);

            string sqlGetGender = "select GioiTinh from tblDanhGia where  MSSV = '" + idSV + "'";
            lblGT.Text = Functions.GetFieldValues(sqlGetGender);

            string sqlGetNoiSinh = "select NoiSinh from tblSinhVien where  MSSV = '" + idSV + "'";
            lblNoiSinh.Text = Functions.GetFieldValues(sqlGetNoiSinh);

            string sqlGetLop = "select Lop from tblDanhGia where  MSSV = '" + idSV + "'";
            lblLop.Text = Functions.GetFieldValues(sqlGetLop);

            string sqlGetFaculty = "select Khoa from tblDanhGia where  MSSV = '" + idSV + "'";
            lblKhoa.Text = Functions.GetFieldValues(sqlGetFaculty);

            string sqlGetKhoa = "select NienKhoa from tblSinhVien where  MSSV = '" + idSV + "'";
            lblNienKhoa.Text = Functions.GetFieldValues(sqlGetKhoa);

        }

    }

    }
