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
    public partial class frmHocPhi : Form
    {
        DataTable tblHP;
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql = "select MaHocPhan, TenHocPhan, SoTinChi, SoTiet, HocPhi from tblHocPhan";
            tblHP = Class.Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblHP;
            dataGridView.Columns[0].HeaderText = "Mã Học Phần";
            dataGridView.Columns[1].HeaderText = "Tên Học Phần";
            dataGridView.Columns[2].HeaderText = "Số Tín Chỉ";
            dataGridView.Columns[3].HeaderText = "Số Tiết";
            dataGridView.Columns[4].HeaderText = "Học Phí";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 250;
            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[3].Width = 80;
            dataGridView.Columns[4].Width = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
