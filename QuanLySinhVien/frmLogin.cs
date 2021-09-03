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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtDNGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDNGV_Click(object sender, EventArgs e)
        {
            if (txtDNGV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNGV.Focus();
                return;
            }

            if (txtMKGV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKGV.Focus();
                return;
            }
            if (txtMKGV.Text != "HungVuong" || txtDNGV.Text != "qlsv")
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNGV.Focus();
                txtMKGV.Focus();
                return;
            }
            else
            {
                frmGiangVien frm = new frmGiangVien();
                frm.ShowDialog();
            }
        }

        private void txtDNGV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMKGV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void chkHienPassGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienPassGV.Checked)
                txtMKGV.UseSystemPasswordChar = false;
            else
                txtMKGV.UseSystemPasswordChar = true;
        }

        private void btnHuyGV_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }
        
            


        public void btnDNSV_Click(object sender, EventArgs e)
        {
        if (txtDNSV.Text == "")
        {
            MessageBox.Show("Bạn chưa nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDNSV.Focus();
            return;
        }

        if (txtMKSV.Text == "")
        {
            MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMKSV.Focus();
            return;
        }
        if (txtDNSV.Text != "CT01" && txtDNSV.Text != "DL01" && txtDNSV.Text != "NN01" && txtDNSV.Text != "TC01" && txtDNSV.Text != "LP01" &&
            txtDNSV.Text != "CT02" && txtDNSV.Text != "DL02" && txtDNSV.Text != "NN02" && txtDNSV.Text != "TC02" && txtDNSV.Text != "LP02" &&
            txtDNSV.Text != "CT03" && txtDNSV.Text != "DL03" && txtDNSV.Text != "NN03" && txtDNSV.Text != "TC03" && txtDNSV.Text != "LP03" &&
            txtDNSV.Text != "CT04" && txtDNSV.Text != "DL04" && txtDNSV.Text != "NN04" && txtDNSV.Text != "TC04" && txtDNSV.Text != "LP04" &&
            txtDNSV.Text != "CT05" && txtDNSV.Text != "DL05" && txtDNSV.Text != "NN05" && txtDNSV.Text != "TC05" && txtDNSV.Text != "LP05" &&
            txtDNSV.Text != "CT06" && txtDNSV.Text != "DL06" && txtDNSV.Text != "NN06" && txtDNSV.Text != "TC06" && txtDNSV.Text != "LP06" &&
            txtDNSV.Text != "CT07" && txtDNSV.Text != "DL07" && txtDNSV.Text != "NN07" && txtDNSV.Text != "TC07" && txtDNSV.Text != "LP07" &&
            txtDNSV.Text != "CT08" && txtDNSV.Text != "DL08" && txtDNSV.Text != "NN08" && txtDNSV.Text != "TC08" && txtDNSV.Text != "LP08" &&
            txtDNSV.Text != "CT09" && txtDNSV.Text != "DL09" && txtDNSV.Text != "NN09" && txtDNSV.Text != "TC09" && txtDNSV.Text != "LP09" &&
            txtDNSV.Text != "CT10" && txtDNSV.Text != "DL10" && txtDNSV.Text != "NN10" && txtDNSV.Text != "TC10" && txtDNSV.Text != "LP10" || txtMKSV.Text != "HungVuong")
        {
            MessageBox.Show("Sai thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDNSV.Focus();
            txtMKSV.Focus();
            return;
        }
        else
        {
             
            frmHomeSinhVien frm = new frmHomeSinhVien(txtDNSV.Text);
            frm.Show();
        }
    }

        private void chkHienPassSV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienPassSV.Checked)
                txtMKSV.UseSystemPasswordChar = false;
            else
                txtMKSV.UseSystemPasswordChar = true;
        }
    }
}
