using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHDN
{
    public partial class frmDangNhap : Form
    {
        private frmQLNHDN fQLNHDN;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_DN_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap_DN.Text == "" && txtMatKhau_DN.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTenDangNhap_DN.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMatKhau_DN.Text == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BUS.Login bus = new BUS.Login();
                Tuple<DataTable,int> tp = bus.checkLogin(txtTenDangNhap_DN.Text, txtMatKhau_DN.Text);
                if (tp.Item2 == 0)
                {
                    MessageBox.Show("Sai mật khẩu! Vui lòng nhập lại!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    fQLNHDN = new frmQLNHDN(this, tp.Item1);
                    fQLNHDN.Show();

                    this.Hide();
                }
            }
        }

        private void btnThoat_DN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_DN_Leave(object sender, EventArgs e)
        {
            BUS.Login bus = new BUS.Login();
            if (bus.checkUsername(txtTenDangNhap_DN.Text) == 0)
            {
                lbBaoLoi_DN.Text = "* Tên đăng nhập không tồn tại!";
            }
            else lbBaoLoi_DN.Text = "";
        }

        private void txtMatKhau_DN_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDangNhap_DN.PerformClick();
            }
        }
    }
}
