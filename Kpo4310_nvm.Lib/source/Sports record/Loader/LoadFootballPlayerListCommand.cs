using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public class LoadFootballPlayerListCommand : IFootballPlayerLoader
    {
        private List<FootballPlayer> _players = null;
        private string _path;
        private LoadStatus _status = LoadStatus.None;
        public List<FootballPlayer> FootballPlayers { get { return _players; } }
        public LoadStatus Status { get { return _status; } }

        public LoadFootballPlayerListCommand(string path)
        {
            this._path = path;
        }

        public void Execute()
        {
            try
            {
                if (String.IsNullOrEmpty(_path))
                {
                    _status = LoadStatus.FileNameIsEmpty;
                    throw new Exception("Имя файла не указано");
                }
                if (!File.Exists(_path))
                {
                    _status = LoadStatus.FileNotExists;
                    throw new Exception("Файла не существует");
                }

                _players = new List<FootballPlayer>();

                using (var sr = new StreamReader(_path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] arr = line.Split('|');
                        double num;
                        int num1;
                        FootballPlayer p = new FootballPlayer()
                        {
                            Surname = arr[0],
                            CommandCode = arr[1],
                            Description = arr[2],
                            NumberOfPoints = Double.Parse(arr[3]),
                            RankingPlace = Int32.Parse(arr[4])
                        };
                        _players.Add(p);
                    }
                }
            }
            catch(Exception ex)
            {
                LogUtility.ErrorLog(ex);
                _status = LoadStatus.GeneralError;
            }
            _status = LoadStatus.Success;
        }
    }
}
