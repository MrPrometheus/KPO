using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public class FootballPlayer
    {
        public FootballPlayer()
        {
            Surname = "";
            CommandCode = "";
            Description = "";
            NumberOfPoints = 0.0;
            RankingPlace = 0;
        }
        public string Surname { get; set; }
        public string CommandCode { get; set; }
        public string Description { get; set; }
        public double NumberOfPoints { get; set; }
        public int RankingPlace { get; set; }
    }
}
