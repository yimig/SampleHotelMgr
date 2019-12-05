using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace HotelMgr2017101999
{
    public partial class RegisterRoomForm : Form
    {
        public RegisterRoomForm()
        {
            InitializeComponent();
            cmbCertType.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CleanInput();
        }

        private void RegisterRoomForm_Load(object sender, EventArgs e)
        {
            txtOper.Text = RoleManager.curUser.UserName;
            DataTable dt = RoomManager.GetRoomInfo();
            if (dt.Rows.Count != 0) dgvRoomList.DataSource = dt;
            else
            {
                MessageBox.Show("已经没有空房间了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                RegisterRoom info = GetRegRoomInfo();
                if (RoomManager.InsertRoomInfo(info))
                    MessageBox.Show("插入数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("插入数据失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CleanInput()
        {
            txtRoomId.Text = "";
            txtPrice.Text = "";
            txtForegift.Text = "";
            dtpInTime.Text = "";
            dtpOutTime.Text = "";
            txtClientName.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            cmbCertType.SelectedIndex = 0;
            txtCertId.Text = "";
            txtAddress.Text = "";
            txtPersonNum.Text = "";
        }

        private RegisterRoom GetRegRoomInfo()
        {
            RegisterRoom info=new RegisterRoom();
            info.RoomId = txtRoomId.Text;
            info.Price = Convert.ToDouble(txtPrice.Text);
            info.Foregift = Convert.ToDouble(txtForegift.Text);
            info.InTime = dtpInTime.Value;
            info.OutTime = dtpInTime.Value;
            info.ClientName = txtClientName.Text;
            info.Sex = CheckGender();
            info.Phone = txtPhone.Text;
            info.CertType = cmbCertType.SelectedItem.ToString();
            info.CertId = txtCertId.Text;
            info.PersonNum = Convert.ToInt32(txtPersonNum.Text);
            info.Oper = txtOper.Text;
            info.Address = txtAddress.Text;
            info.DelMark = 0;
            return info;
        }

        private bool CheckGender()
        {
            return rbMale.Checked;
        }

        private bool CheckInput()
        {
            if (CheckTextBox(txtRoomId, "房间号")) return false;
            if (CheckTextBox(txtPrice, "价格")) return false;
            if (CheckTextBox(txtForegift, "押金")) return false;
            if (CheckTextBox(txtClientName, "客户姓名")) return false;
            if (CheckTextBox(txtPhone, "电话号码")) return false;
            if (CheckTextBox(txtCertId, "证件号码")) return false;
            if (CheckTextBox(txtAddress, "地址")) return false;
            if (CheckTextBox(txtPersonNum, "住宿人数")) return false;
            if (CheckInPerson()) return false;
            if (CheckDate(dtpInTime, "入住时间")) return false;
            if (CheckDate(dtpOutTime, "离开时间")) return false;
            if (CheckLeaveDate()) return false;
            return true;
        }

        private bool CheckTextBox(TextBox tb,string name)
        {
            bool isBlank=false;
            if (tb.Text == "")
            {
                isBlank = true;
                MessageBox.Show(name + "不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb.Focus();
            }
            return isBlank;
        }

        private bool CheckInPerson()
        {
            bool isError=false;
            if (Convert.ToInt32(txtPersonNum.Text) >
                Convert.ToInt32(dgvRoomList.SelectedRows[0].Cells["可入住人数"].Value.ToString()))
            {
                isError = true;
                MessageBox.Show("入住人数不能大于标准人数，请换房间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanInput();
                txtRoomId.Focus();
            }

            return isError;
        }

        private bool CheckDate(DateTimePicker dtp,string name)
        {
            bool isError=false;
            if (DateTime.Today > dtp.Value)
            {
                isError = true;
                MessageBox.Show(name + "不能小于当前时间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp.Focus();
            }

            return isError;
        }

        private bool CheckLeaveDate()
        {
            bool isError=false;
            if (dtpInTime.Value > dtpOutTime.Value)
            {
                isError = true;
                MessageBox.Show( "离开时间不能小于入住时间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpOutTime.Focus();
            }

            return isError;
        }

        private void dgvRoomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CleanInput();
            if (dgvRoomList.SelectedRows.Count == 1)
            {
                txtRoomId.Text = dgvRoomList.SelectedRows[0].Cells["房间号"].Value.ToString();
                txtPrice.Text = dgvRoomList.SelectedRows[0].Cells["价格"].Value.ToString();
            }
        }
    }
}
