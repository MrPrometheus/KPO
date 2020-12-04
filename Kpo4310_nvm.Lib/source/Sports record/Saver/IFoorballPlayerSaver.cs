using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public enum SaveStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100,
        NoData = -200,
    }
    public interface IFootballPlayerSaver
    {
        List<FootballPlayer> FootballPlayers { get; set; }
        SaveStatus Status { get; }
        void Execute();
    }
}
