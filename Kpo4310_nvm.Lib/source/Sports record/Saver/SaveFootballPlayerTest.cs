using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4310_nvm.Lib
{
    class SaveFootballPlayerTest : IFootballPlayerSaver
    {
        private readonly string _dataFileName = "";
        private SaveStatus _status = SaveStatus.None;
        private List<FootballPlayer> _players = null;
        public List<FootballPlayer> FootballPlayers
        {
            get => _players;
            set => _players = value;
        }
        public SaveStatus Status { get { return _status; } }

        public void Execute()
        {
            try
            {
                if (FootballPlayers == null) throw new Exception("Нет данных для сохранения");
                _status = SaveStatus.Success;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogUtility.ErrorLog(ex);
                _status = SaveStatus.NoData;
            }
        }
    }
}
