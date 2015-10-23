using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseballLeague.Models;

namespace BaseballLeague.Data
{
    public class PlayerMockRepo : IPlayerRepo
    {
        public Player AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayerFromTeam(int playerId)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayers(int teamId)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetPositions()
        {
            throw new NotImplementedException();
        }

        public Player TradePlayer(int playerId, int teamId)
        {
            throw new NotImplementedException();
        }
    }
}
