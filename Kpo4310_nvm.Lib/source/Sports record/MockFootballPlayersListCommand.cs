using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public class MockFootballPlayersListCommand
    {
        private readonly string _dataFileName = "";
        private List<FootballPlayer> _players = null;
        public List<FootballPlayer> FootballPlayersList
        { 
            get { return _players; } 
        }
        public MockFootballPlayersListCommand()
        {

        }

        public void Execute()
        {
            throw new Exception("Не смог добавить");
            {
                FootballPlayer fp = new FootballPlayer()
                {
                    Surname = "Баландин",
                    CommandCode = "С",
                    Description = "Спартак",
                    NumberOfPoints = 123.7,
                    RankingPlace = 2
                };
                FootballPlayersList.Add(fp);
            }
            {
                FootballPlayer fp = new FootballPlayer()
                {
                    Surname = "Шишков",
                    CommandCode = "Ш",
                    Description = "Шахтер",
                    NumberOfPoints = 79.98,
                    RankingPlace = 3
                };
                FootballPlayersList.Add(fp);
            }
            {
                FootballPlayer fp = new FootballPlayer()
                {
                    Surname = "Кравченко",
                    CommandCode = "Д",
                    Description = "Динамо",
                    NumberOfPoints = 134.8,
                    RankingPlace = 1
                };
                FootballPlayersList.Add(fp);
            }
        }
    }
}
