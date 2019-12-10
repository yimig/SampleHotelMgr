using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgr2017101999
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelDataSet.RegisterRoom”中。您可以根据需要移动或删除它。
            this.registerRoomTableAdapter.Fill(this.hotelDataSet.RegisterRoom);

        }

        private void Query()
        {
            var clients = (from item in hotelDataSet.RegisterRoom
                where item.clientName.Contains(txtQueryName.Text)
                select item).ToList();
            clientGridView.DataSource = clients;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var row = hotelDataSet.RegisterRoom.Rows[clientGridView.SelectedRows[0].Index];
            UpdateData(row);
        }

        private bool CheckGender()
        {
            return rbMale.Checked;
        }

        private void UpdateData(DataRow row)
        {
            row["clientName"] = txtClientName.Text;
            row["sex"] = CheckGender();
            row["phone"] = txtPhone.Text;
            row["certType"] = cmbCertType.SelectedItem.ToString();
            row["certId"] = txtCertId.Text;
            row["address"] = txtAddress.Text;
            row["personNum"] = txtPersonNum.Text;
            registerRoomTableAdapter.Update(hotelDataSet.RegisterRoom);
            hotelDataSet.RegisterRoom.AcceptChanges();
        }

        private void clientGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rows = clientGridView.SelectedRows;
            if (rows.Count == 0)
            {
                EnableBreakMode();
            }
            else
            {
                LoadInputs(rows[0]);
            }
        }

        private void EnableBreakMode()
        {
            txtClientName.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtPhone.Text = "";
            cmbCertType.SelectedItem = "";
            txtCertId.Text = "";
            txtAddress.Text = "";
            txtPersonNum.Text = "";
            btnSave.Enabled = false;
        }

        private void LoadInputs(DataGridViewRow row)
        {
            btnSave.Enabled = true;
            txtClientName.Text = row.Cells[6].Value.ToString();
            LoadGender(Convert.ToBoolean(row.Cells[7].Value.ToString()));
            txtPhone.Text = row.Cells[8].Value.ToString();
            cmbCertType.SelectedItem = row.Cells[9].Value;
            txtCertId.Text = row.Cells[10].Value.ToString();
            txtAddress.Text = row.Cells[11].Value.ToString();
            txtPersonNum.Text = row.Cells[12].Value.ToString();
        }

        private void LoadGender(bool isMale)
        {
            if (isMale) rbMale.Checked = true;
            else
            {
                rbFemale.Checked = true;
            }
        }

        private void clientGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                e.Value = e.Value.ToString() == "True" ? "男" : "女";
            }
        }
    }
}
