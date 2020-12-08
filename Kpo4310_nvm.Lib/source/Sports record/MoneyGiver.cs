using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nvm.Lib
{
    public static class MoneyGiver
    {
        public static void SetMoney(FootballPlayer player)
        {
            var koef = 1.0;
            int[] money = {10_000, 1000, 100};
            switch(player.CommandCode)
            {
                case "С":
                    koef = 1.5;
                    break;
                case "Д":
                    koef = 1.2;
                    break;
                case "Ш":
                    break;
                default:
                    break;
            }
            player.Money = koef * money[player.RankingPlace - 1] * 150;
        }

        public static void SorterArray(IList<int> mas)
        {
            int temp;
            for (int i = 0; i < mas.Count - 1; i++)
            {
                for (int j = i + 1; j < mas.Count; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
        }
    }
}
