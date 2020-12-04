using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public class FootballPlayerFactory : IFootballPlayerFactory
    {
        IFootballPlayerLoader IFootballPlayerFactory.CreateFootballPlayersListLoader()
        {
            return new LoadFootballPlayerListCommand(AppGlobalSettings.DataFileName);
        }
        IFootballPlayerSaver IFootballPlayerFactory.CreateFootballPlayersListSaver()
        {
            return new SaveFootballPlayer(AppGlobalSettings.DataFileNameSave);
        }
    }
}
