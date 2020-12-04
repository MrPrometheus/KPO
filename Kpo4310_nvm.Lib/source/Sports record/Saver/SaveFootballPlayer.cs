using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public class SaveFootballPlayer : IFootballPlayerSaver
    {
        private readonly string _path;
        private List<FootballPlayer> _footballPlayers;
        public SaveFootballPlayer(string dataFileName)
        {
            _path = dataFileName;
            _footballPlayers = null;
        }

        public List<FootballPlayer> FootballPlayers
        {
            set => _footballPlayers = value;
            get => _footballPlayers;
        }

        private SaveStatus _status = SaveStatus.None;
        public SaveStatus Status
        {
            get => _status;
        }

        public void Execute()
        {
            if(String.IsNullOrEmpty(_path))
            {
                _status = SaveStatus.FileNameIsEmpty;
                throw new Exception("Название файла пустное");
            }
            if(_footballPlayers == null)
            {
                _status = SaveStatus.NoData;
                throw new Exception("Нет данных");
            }

            using(StreamWriter sw = new StreamWriter(_path, false))
            {
                if(_footballPlayers.Count != 0)
                {
                    for(int i = 0; i < _footballPlayers.Count; i++)
                    {
                        try
                        {
                            FootballPlayer player = _footballPlayers[i];
                            sw.WriteLine(player.Surname + '|' + player.CommandCode + '|' + player.Description + '|' + player.NumberOfPoints + '|' + player.RankingPlace);
                        }
                        catch(Exception ex)
                        {
                            LogUtility.ErrorLog(ex);
                            _status = SaveStatus.GeneralError;
                        }
                    }
                }
            }
            _status = SaveStatus.Success;
        }
    }
}
