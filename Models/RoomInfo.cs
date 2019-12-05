using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RoomInfo
    {
        private string roomId, roomType, roomFloor, note;
        private double roomPrice;
        private int personNum, inPerson;

        public string RoomId
        {
            get => roomId;
            set => roomId = value;
        }

        public string RoomType
        {
            get => roomType;
            set => roomType = value;
        }

        public string RoomFloor
        {
            get => roomFloor;
            set => roomFloor = value;
        }

        public string Note
        {
            get => note;
            set => note = value;
        }

        public double RoomPrice
        {
            get => roomPrice;
            set => roomPrice = value;
        }

        public int PersonNum
        {
            get => personNum;
            set => personNum = value;
        }

        public int InPerson
        {
            get => inPerson;
            set => inPerson = value;
        }
    }
}
