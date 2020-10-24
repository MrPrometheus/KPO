using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4310_nvm.Lib;
using System.Windows.Forms;

namespace Kpo4310_nvm.Main
{
    public partial class FrmFootbalPlayer : Form
    {
        private FootballPlayer _player = null;

        public FootballPlayer FootballPlayer
        {
            get { return _player; }
        }
        public FrmFootbalPlayer()
        {
            InitializeComponent();
        }

        public void SetFootballPlayer(FootballPlayer player)
        {
            this._player = player;
            LblFootbolsData.Text = "Данные игрока: " + player.Surname;
            LblComandName.Text = player.CommandCode + " - " + player.Description;
            LblPosition.Text = "Место: " + player.RankingPlace;
            LblReiting.Text = "Количество баллов: " + player.NumberOfPoints;
        }
    }
}
