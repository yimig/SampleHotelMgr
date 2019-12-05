using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RegisterRoom
    {
        private string roomId, clientName, phone, certType, certId, address, oper;
        private int inId, personNum, delMark;
        private double price, foregift;
        private DateTime inTime, outTime;
        private bool sex;

        public string RoomId
        {
            get => roomId;
            set => roomId = value;
        }

        public string ClientName
        {
            get => clientName;
            set => clientName = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string CertType
        {
            get => certType;
            set => certType = value;
        }

        public string CertId
        {
            get => certId;
            set => certId = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Oper
        {
            get => oper;
            set => oper = value;
        }

        public int InId
        {
            get => inId;
            set => inId = value;
        }

        public int PersonNum
        {
            get => personNum;
            set => personNum = value;
        }

        public int DelMark
        {
            get => delMark;
            set => delMark = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public double Foregift
        {
            get => foregift;
            set => foregift = value;
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

        public bool Sex
        {
            get => sex;
            set => sex = value;
        }
    }
}
