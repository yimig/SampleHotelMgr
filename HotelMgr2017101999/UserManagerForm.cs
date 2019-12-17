using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace HotelMgr2017101999
{
    public partial class UserManagerForm : Form
    {
        public UserManagerForm()
        {
            InitializeComponent();
        }

        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelDataSet.UserDetails”中。您可以根据需要移动或删除它。
            this.userDetailsTableAdapter.Fill(this.hotelDataSet.UserDetails);

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var row = hotelDataSet.UserDetails.Rows[dgvUsers.SelectedRows[0].Index];
            row["userName"] = txtUserName.Text;
            row["userPwd"] = Encryption.SHA1(txtPwd.Text);
            row["role"] = txtRole.Text;
            userDetailsTableAdapter.Update(hotelDataSet.UserDetails);
            hotelDataSet.UserDetails.AcceptChanges();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除此行数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) ==
                DialogResult.OK)
            {
                DataRow delRow = hotelDataSet.UserDetails.Select("userName=\'" + txtUserName.Text + "\'")[0];
                delRow.Delete();
                userDetailsTableAdapter.Update(hotelDataSet.UserDetails);
                hotelDataSet.UserDetails.AcceptChanges();
            }
        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            var selRow = dgvUsers.SelectedRows[0];
            txtUserName.Text = selRow.Cells[0].Value.ToString();
            txtPwd.Text = selRow.Cells[1].Value.ToString();
            txtRole.Text = selRow.Cells[2].Value.ToString();
        }

        private void TB_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox) sender;
            tb.SelectAll();
        }
    }
}
