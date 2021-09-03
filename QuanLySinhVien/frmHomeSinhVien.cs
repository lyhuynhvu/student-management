using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmHomeSinhVien : Form
    {
        public string idSV;
        public frmHomeSinhVien(string id)
        {
            idSV = id;
            InitializeComponent();
        }

        private void btnKQHT_Click(object sender, EventArgs e)
        {
            frmKQHocTap frmKQHT = new frmKQHocTap(idSV);
            frmKQHT.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frmHocPhi frmHP = new frmHocPhi();
            frmHP.ShowDialog();
        }

        private void frmHomeSinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
