using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public interface IFootballPlayerFactory
    {
        IFootballPlayerLoader CreateFootballPlayersListLoader();
        IFootballPlayerSaver CreateFootballPlayersListSaver();
    }
}
