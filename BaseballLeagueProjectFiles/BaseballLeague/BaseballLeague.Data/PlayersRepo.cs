﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseballLeague.Models;
using System.Data.SqlClient;
using BaseballLeague.Data.Config;
using System.Data;
using Dapper;

namespace BaseballLeague.Data
{
    public class PlayersRepo : IPlayerRepo
    {
        public Player AddPlayer(Player player)
        {
            int playerId;

            using (var connection = new SqlConnection(Settings.ConnectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "SP_AddPlayer";
                command.CommandType = CommandType.StoredProcedure;

                var outputParam = new SqlParameter("@PlayerID", SqlDbType.Int) { Direction = ParameterDirection.Output };

                command.Connection = connection;
                command.Parameters.AddWithValue("@PlayerName", player.PlayerName);
                command.Parameters.AddWithValue("@JerseyNumber", player.JerseyNumber);
                command.Parameters.AddWithValue("@PositionID", player.PositionID);
                command.Parameters.AddWithValue("@PreviousYrsBattingAvg", player.PreviousYrsBattingAvg);
                command.Parameters.AddWithValue("@NumYrsPlayed", player.NumYrsPlayed);
                command.Parameters.AddWithValue("@TeamID", player.TeamID);
                command.Parameters.Add(outputParam);
                connection.Open();

                command.ExecuteNonQuery();

                playerId = (int)outputParam.Value;

                player.PlayerID = playerId;

                return player;
            }
        }

        public void DeletePlayerFromTeam(int playerId)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayers(int teamId)
        {
            throw new NotImplementedException();
        }

        public Player TradePlayer(int playerId, int teamId)
        {
            throw new NotImplementedException();
        }

        public List<Position> GetPositions()
        {
            var results = new List<Position>();
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                results = cn.Query<Position>("SELECT * FROM Positions").ToList();
            }
            return results;
        } 
    }
}