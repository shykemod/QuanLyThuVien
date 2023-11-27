using B_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_PRL
{
    public partial class LoginForm : Form
    {
        public static bool Role = true;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbUserName.Focus(); return;
            }
            if (tbUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbPassword.Focus(); return;
            }
            bool? StateLogin = svc.services.Login(tbUserName.Text, tbPassword.Text);
            if (StateLogin == null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (StateLogin == true)
            {
                Role = true;
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form qltv = new FormQLSach();
                qltv.Show();
                this.Hide();
            }
            else
            {
                Role = false;
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form qltv = new FormQLSach();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
            if (tbPassword.UseSystemPasswordChar)
            {
                btnHide.BackgroundImage = Properties.Resources.hide1;
            }
            else
            {
                btnHide.BackgroundImage = Properties.Resources.view1;
            }
        }
    }
}
