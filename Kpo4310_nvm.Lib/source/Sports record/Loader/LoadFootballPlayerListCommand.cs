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
        private OnLoadFileDelegate onAfterRowConvert = null;

        private List<FootballPlayer> _players = null;
        private string _path;
        private LoadStatus _status = LoadStatus.None;
        public List<FootballPlayer> FootballPlayers { get { return _players; } }
        public LoadStatus Status { get { return _status; } }

        public void SetAfterRowConvert(OnLoadFileDelegate onAfterRowConvert)
        {
            this.onAfterRowConvert = onAfterRowConvert;
        }
        public OnLoadFileDelegate AfterRowConvert
        {
            get => onAfterRowConvert;
        }

        /*
         Метод должен загрузить данные, хранящиеся в файле, в программу в определенном формате
         */
        public void Execute(string path)
        {
            _path = path;
            try
            {
                //Сделать проверку на пустоту пути, если нет, выдать ошибку
                if (String.IsNullOrEmpty(_path))
                {
                    _status = LoadStatus.FileNameIsEmpty;
                    throw new Exception("Имя файла не указано");
                }
                //Сделать проверку на существование файла по указанному пути, если нет, выдать ошибку
                if (!File.Exists(_path))
                {
                    _status = LoadStatus.FileNotExists;
                    throw new Exception("Файла не существует");
                }

                _players = new List<FootballPlayer>();

                //Если путь корректен, то считать из него построчно информацию
                using (var sr = new StreamReader(_path))
                {
                    string line;
                //Каждая интерация - новая строка, которая должна соответсвовать шаблону
                    while ((line = sr.ReadLine()) != null)
                    {
                //В каждой строке символ '|' - является разделителем между информационными полями
                        string[] arr = line.Split('|');
                        double num;
                        int num1;
                //Все поля должны соответсвовать модели Игрока футбльной команды
                        FootballPlayer p = new FootballPlayer()
                        {
                            Surname = arr[0],
                            CommandCode = arr[1],
                            Description = arr[2],
                            NumberOfPoints = Double.Parse(arr[3]),
                            RankingPlace = Int32.Parse(arr[4])
                        };
                        _players.Add(p);
                        onAfterRowConvert?.Invoke(p);
                    }
                }
            }
                //Если все поля верны и можно сформировать модель, то установить статус загрузки в успешно, иначе в ошибку и вызвать исключение
            catch(Exception ex)
            {
                LogUtility.ErrorLog(ex);
                _status = LoadStatus.GeneralError;
            }
            _status = LoadStatus.Success;
        }
    }
}
