using Kpo4310_nvm.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm
{
    public class FootballPlayerFactoryTest : IFootballPlayerFactory
    {

        IFootballPlayerLoader IFootballPlayerFactory.CreateFootballPlayersListLoader()
        {
            return new MockFootballPlayersListCommand();
        }
        IFootballPlayerSaver IFootballPlayerFactory.CreateFootballPlayersListSaver()
        {
            return new SaveFootballPlayerTest();
        }
    }
}
