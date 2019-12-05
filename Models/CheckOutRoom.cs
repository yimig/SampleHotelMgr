using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CheckOutRoom
    {
        private string roomID, clientName, oper, note, outId;
        private int inId;
        private double price, foregift, total, account;
        private DateTime inTime, outTime;

        public int InId
        {
            get => inId;
            set => inId = value;
        }

        public string OutId
        {
            get => outId;
            set => outId = value;
        }

        public string RoomId
        {
            get => roomID;
            set => roomID = value;
        }

        public string ClientName
        {
            get => clientName;
            set => clientName = value;
        }

        public DateTime InTime
        {
            get => inTime;
            set => inTime = value;
        }

        public DateTime OutTime
        {
            get => outTime;
            set => outTime = value;
        }

        public string Oper
        {
            get => oper;
            set => oper = value;
        }

        public string Note
        {
            get => note;
            set => note = value;
        }

        public double Account
        {
            get => account;
            set => account = value;
        }

        public double Total
        {
            get => total;
            set => total = value;
        }

        public double Foregift
        {
            get => foregift;
            set => foregift = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}
