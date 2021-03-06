﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public class MockFootballPlayersListCommand : IFootballPlayerLoader
    {
        private OnLoadFileDelegate onAfterRowConvert = null;

        private string _dataFileName = "";
        private LoadStatus _status = LoadStatus.None;
        private List<FootballPlayer> _players = new List<FootballPlayer>();
        public List<FootballPlayer> FootballPlayers
        { 
            get { return _players; } 
        }

        public void SetAfterRowConvert(OnLoadFileDelegate onAfterRowConvert)
        {
            this.onAfterRowConvert = onAfterRowConvert;
        }
        public OnLoadFileDelegate AfterRowConvert
        {
            get => onAfterRowConvert;
        }

        public LoadStatus Status => _status;

        public void Execute(string path)
        {
            _dataFileName = path;
            {
                FootballPlayer fp = new FootballPlayer()
                {
                    Surname = "Баландин",
                    CommandCode = "С",
                    Description = "Спартак",
                    NumberOfPoints = 123.7,
                    RankingPlace = 2
                };
                _players.Add(fp);
                onAfterRowConvert?.Invoke(fp);
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
                _players.Add(fp);
                onAfterRowConvert?.Invoke(fp);
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
                _players.Add(fp);
                onAfterRowConvert?.Invoke(fp);
            }
            _status = LoadStatus.Success;
        }
    }
}
