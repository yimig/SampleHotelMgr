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
using Models;
using BLL;

namespace HotelMgr2017101999
{
    public partial class AddUserForm : Form
    {

        #region 控件响应方法

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') txtPwd.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckUserName() && CheckPwd()) StartRegister(txtName.Text, txtPwd.Text, CheckUserType());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 自定义调用方法

        /// <summary>
        /// 弹出一个提示框，给相应的TextBox焦点
        /// </summary>
        /// <param name="info">提示内容</param>
        /// <param name="focusTextBox">需要给焦点的TextBox</param>
        private void AlertMessageBox(string info, TextBox focusTextBox)
        {
            MessageBox.Show(info, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            focusTextBox.Focus();
        }

        /// <summary>
        /// 检查输入用户名是否为空
        /// </summary>
        /// <param name="userName">输入用户名</param>
        /// <returns></returns>
        private bool CheckUserName()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                AlertMessageBox("用户名不能为空", txtName);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// 检查输入密码是否为空
        /// </summary>
        /// <param name="pwd">输入密码</param>
        /// <returns></returns>
        private bool CheckPwd()
        {

            bool result = true;
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                AlertMessageBox("密码不能为空", txtPwd);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// 返回选中的用户类型
        /// </summary>
        /// <returns></returns>
        private UserType CheckUserType()
        {
            return rbEmp.Checked ? UserType.User : UserType.Admin;
        }


        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPsw">用户密码</param>
        /// <param name="userType">用户类型</param>
        /// <returns></returns>
        private void StartRegister(string userName, string userPsw, UserType userType)
        {
            if (!UpdateUserInfo(new User(userName, userPsw, (int) userType))) MessageBox.Show("注册失败！");
            else MessageBox.Show("注册成功！");
        }

        /// <summary>
        /// 上传用户信息
        /// </summary>
        /// <param name="userInfo">获得的用户信息</param>
        private bool UpdateUserInfo(User userInfo)
        {
            return UserManager.AddUser(userInfo);
        }

        #endregion

        #region 枚举
        /// <summary>
        /// 用户类型
        /// </summary>
        private enum UserType { User,Admin}


        #endregion

    }
}
