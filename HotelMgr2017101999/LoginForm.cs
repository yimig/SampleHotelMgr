using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BLL;
using Models;

namespace HotelMgr2017101999
{
    public partial class LoginForm : Form
    {
        #region 控件响应方法

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckUserName(txtName.Text)&&CheckPwd(txtPwd.Text))StartLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') txtPwd.Focus();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='\r')StartLogin();
        }

        #endregion

        #region 自定义调用方法

        /// <summary>
        /// 弹出一个提示框，给相应的TextBox焦点
        /// </summary>
        /// <param name="info">提示内容</param>
        /// <param name="focusTextBox">需要给焦点的TextBox</param>
        void AlertMessageBox(string info, TextBox focusTextBox)
        {
            MessageBox.Show(info, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            focusTextBox.Focus();
        }

        /// <summary>
        /// 检查输入用户名是否为空
        /// </summary>
        /// <param name="userName">输入用户名</param>
        /// <returns></returns>
        bool CheckUserName(string userName)
        {
            bool result=true;
            if (string.IsNullOrEmpty(userName))
            {
                AlertMessageBox("用户名不能为空",txtName);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// 检查输入密码是否为空
        /// </summary>
        /// <param name="pwd">输入密码</param>
        /// <returns></returns>
        bool CheckPwd(string pwd)
        {
            bool result = true;
            if (string.IsNullOrEmpty(pwd))
            {
                AlertMessageBox("密码不能为空",txtPwd);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// 接入登录程序
        /// </summary>
        /// <param name="info">用户信息</param>
        void StartLogin()
        {
            List<User> users=UserManager.GetUsers(txtName.Text, Encryption.SHA1(txtPwd.Text));
            if (users.Count!=0)
            {
                RoleManager.curUser = users[0];
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("错误的用户名或密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
            }
        }

        #endregion

    }
}
