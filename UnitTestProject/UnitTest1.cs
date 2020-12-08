using Kpo4310_nvm.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingLoaderTest()
        {
            var loader = new MockFootballPlayersListCommand();
            loader.Execute("");
            var count = loader.FootballPlayers.Count;
            Assert.AreEqual(count, 3);
        }

        [TestMethod]
        public void TestingLoaderStatus()
        {
            var loader = new MockFootballPlayersListCommand();
            loader.Execute("");
            Assert.AreEqual(loader.Status, LoadStatus.Success);
        }

        [TestMethod]
        public void LoadFootballPlayerListCommandStatus()
        {
            var loader = new LoadFootballPlayerListCommand();
            loader.Execute(AppGlobalSettings.DataFileName);
            Assert.AreEqual(loader.Status, LoadStatus.Success);
        }

        [TestMethod]
        public void TestingMoney1()
        {
            var loader = new LoadFootballPlayerListCommand();
            loader.Execute("G:\\KPO\\Kpo4310_nmv.Main\\bin\\Debug\\FootballPlayer.txt");

            MoneyGiver.SetMoney(loader.FootballPlayers[0]);

            Assert.AreEqual(225_000, loader.FootballPlayers[0].Money);
        }

        [TestMethod]
        public void TestingMoney2()
        {
            var loader = new LoadFootballPlayerListCommand();
            loader.Execute("G:\\KPO\\Kpo4310_nmv.Main\\bin\\Debug\\FootballPlayer.txt");

            MoneyGiver.SetMoney(loader.FootballPlayers[1]);

            Assert.AreEqual(15_000, loader.FootballPlayers[1].Money);
        }

        [TestMethod]
        public void TestingMoney3()
        {
            var loader = new LoadFootballPlayerListCommand();
            loader.Execute("G:\\KPO\\Kpo4310_nmv.Main\\bin\\Debug\\FootballPlayer.txt");

            MoneyGiver.SetMoney(loader.FootballPlayers[2]);

            Assert.AreEqual(1_800_000, loader.FootballPlayers[2].Money);
        }

        [TestMethod]
        public void SortedTest1()
        {
            var arr = new[] { 124, 412, 12, 52, -12 };
            MoneyGiver.SorterArray(arr);
            Assert.IsTrue(arr.SequenceEqual(new[] { -12, 12, 52, 124, 412 }));
        }

        [TestMethod]
        public void SortedTest2()
        {
            var loader = new LoadFootballPlayerListCommand();
            loader.Execute("G:\\KPO\\Kpo4310_nmv.Main\\bin\\Debug\\FootballPlayer.txt");

            var arr = new[] {loader.FootballPlayers[0].RankingPlace,
                             loader.FootballPlayers[1].RankingPlace,
                             loader.FootballPlayers[2].RankingPlace};
            MoneyGiver.SorterArray(arr);
            Assert.IsTrue(arr.SequenceEqual(new[] { 1, 2, 3 }));
        }
    }
}
