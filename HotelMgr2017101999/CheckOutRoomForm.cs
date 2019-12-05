using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace HotelMgr2017101999
{
    public partial class CheckOutRoomForm : Form
    {
        private DataTable dt;

        public CheckOutRoomForm()
        {
            dt = RoomManager.GetUseRoomInfo();
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CleanInput();
        }

        private bool CheckInput()
        {
            bool isSuccess = true;
            if (dtpOutTime.Value < DateTime.Parse(txtInTime.Text))
            {
                MessageBox.Show("离开时间不能小于入住时间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpOutTime.Focus();
                isSuccess = false;
            }

            return isSuccess;
        }

        private CheckOutRoom GetCheckOutRoom()
        {
            CheckOutRoom info = new CheckOutRoom();
            info.OutId = DateTime.Now.ToString("yyyyMMddHHmmss");
            info.InId = Convert.ToInt32(RoomManager.GetInID(cmbRoomId.SelectedItem.ToString()).Rows[0][0].ToString());
            info.RoomId = cmbRoomId.SelectedItem.ToString();
            info.Price = Convert.ToDouble(txtPrice.Text);
            info.Foregift = Convert.ToDouble(txtForegift.Text);
            info.Total = Convert.ToDouble(txtTotal.Text);
            info.Account = Convert.ToDouble(txtAccount.Text);
            info.InTime = DateTime.Parse(txtInTime.Text);
            info.OutTime = dtpOutTime.Value;
            info.ClientName = txtClientName.Text;
            info.Oper = RoleManager.curUser.UserName;
            info.Note = txtNote.Text;
            return info;
        }

        private void CleanInput()
        {
            dtpOutTime.Text = "";
            cmbRoomId.Text = "";
            txtClientName.Text = "";
            txtInTime.Text = "";
            txtPrice.Text = "";
            txtForegift.Text = "";
            txtTotal.Text = "";
            txtAccount.Text = "";
            txtNote.Text = "";
        }

        private void CheckOutRoomForm_Load(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbRoomId.Items.Add(dr["房间号"].ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            CheckOutRoom checkOutRoom = GetCheckOutRoom();
            if (RoomManager.InsertCheckOutRoomInfo(checkOutRoom))
            {
                MessageBox.Show("插入数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("插入数据失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (cmbRoomId.SelectedItem.ToString() == dr["房间号"].ToString())
                {
                    InitItem(dr);
                }
            }
        }

        private void InitItem(DataRow dr)
        {
            txtPrice.Text = dr["价格"].ToString();
            txtForegift.Text = dr["押金"].ToString();
            txtInTime.Text = dr["入住时间"].ToString();
            txtClientName.Text = dr["客户名称"].ToString();
            TimeSpan timeSpan = dtpOutTime.Value - DateTime.Parse(txtInTime.Text);
            double consumTotal = (timeSpan.Days == 0 && timeSpan.Hours < 24 ? 1 : timeSpan.Days) *
                                 Convert.ToDouble(txtPrice.Text);
            txtTotal.Text = consumTotal.ToString();
            txtAccount.Text = (consumTotal - Convert.ToDouble(txtForegift.Text)).ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                SaveResultToFile("D:\\发票单\\" + DateTime.Now.ToString("yyyy-MM-dd")+".txt");
                MessageBox.Show("成功导出到’D:\\发票单‘");
            }
            catch(Exception)
            {
                MessageBox.Show("导出到‘D:\\发票单‘失败，请检查路径是否存在！");
            }
        }

        private void SaveResultToFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter wr = new StreamWriter(stream);
            wr.Write(
                $"-----------蓝天酒店----------\n客户：{txtClientName.Text}\n住宿费：￥{txtTotal.Text}\n开票日期：{DateTime.Now.ToString("yyyy-MM-dd")}\n");
            wr.Close();
            stream.Close();
        }
    }
}
