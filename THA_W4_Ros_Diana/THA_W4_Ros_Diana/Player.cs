using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W4_Ros_Diana
{
    internal class Player
    {
        private string playerName;

        private string playerNum;

        private string playerPos;

        public string _playerName
        {
            get {return playerName; }
            set { playerName = value; }
        }

        public string _playerNum
        {
            get {return playerNum; }
            set { playerNum = value; }
        }

        public string _playerPos
        {
            get {return playerPos; }
            set { playerPos = value; }
        }

    }
}
