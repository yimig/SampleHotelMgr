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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelDataSet.RegisterRoom”中。您可以根据需要移动或删除它。
            this.registerRoomTableAdapter.Fill(this.hotelDataSet.RegisterRoom);
            // TODO: 这行代码将数据加载到表“hotelDataSet.Room”中。您可以根据需要移动或删除它。
            this.roomTableAdapter.Fill(this.hotelDataSet.Room);

        }

        private void roomGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rooms = roomGridView.SelectedRows;
            if (rooms.Count > 0)
            {
                var clients = from client in hotelDataSet.RegisterRoom
                    where client.roomId == rooms[0].Cells[0].Value.ToString()
                    where client.delMark == false
                    select client;
                clientGridView.DataSource = clients.AsDataView();
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
