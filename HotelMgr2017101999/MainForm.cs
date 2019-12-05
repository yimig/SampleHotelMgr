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

namespace HotelMgr2017101999
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm form=new AddUserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm form=new AboutForm();
            form.MdiParent = this;
            form.Show();
        }

        private void miCheckIn_Click(object sender, EventArgs e)
        {
            RegisterRoomForm form=new RegisterRoomForm();
            form.MdiParent = this;
            form.Show();
        }

        private void miCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutRoomForm form=new CheckOutRoomForm();
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm1999_Load(object sender, EventArgs e)
        {
            if (RoleManager.curUser.Role == 0)
            {
                miUserManage.Visible = false;
                toolStripButton5.Visible = false;
                toolStripButton6.Visible = false;
            }
        }

        private void MainForm1999_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void miEditUser_Click(object sender, EventArgs e)
        {
            UserManagerForm form=new UserManagerForm();
            form.MdiParent = this;
            form.Show();
        }

        private void miCustomerQuery_Click(object sender, EventArgs e)
        {
            ClientForm form=new ClientForm();
            form.MdiParent = this;
            form.Show();
        }

        private void miRoomQuery_Click(object sender, EventArgs e)
        {
            RoomForm form=new RoomForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
