using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLeague.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int JerseyNumber { get; set; }
        public int PositionID { get; set; }
        public decimal PreviousYrsBattingAvg { get; set; }
        public int NumYrsPlayed { get; set; }
        public int TeamID { get; set; }
    }
}
