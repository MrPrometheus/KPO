using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public enum LoadStatus
    {
        None = 0,
        Success = 1,
        FileNameIsEmpty = -1,
        FileNotExists = -2,
        GeneralError = -100
    }
    public interface IFootballPlayerLoader
    {
        List<FootballPlayer> FootballPlayers { get; }
        LoadStatus Status { get; }
        void Execute();
    }
}
