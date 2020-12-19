using Kpo4310_nvm.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4310_nvm.Main
{
    public partial class FrmMain : Form
    {

        private List<FootballPlayer> players = null;
        private int count = 0;
        private BindingSource bsPlayers = new BindingSource();
        public FrmMain()
        {
            InitializeComponent();
            SStatus.Items[0].Text = AppGlobalSettings.LogPath + " | " + AppGlobalSettings.DataFileName;
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnAfterRowConvert(FootballPlayer currentRow)
        {
            tsLblStatus.Text = $"Текущий: {currentRow.Surname} | Всего обработано {++count}";
        }

        private async void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //throw new IncorrectFileInput("Файл пуст");
                //MockFootballPlayersListCommand loader = new MockFootballPlayersListCommand();
                //IFootballPlayerLoader loader = AppGlobalSettings.DetailsFactory.CreateFootballPlayersListLoader();
                IFootballPlayerLoader loader = IoC.container.Resolve<IFootballPlayerLoader>();
                loader.SetAfterRowConvert(this.OnAfterRowConvert);
                await Task.Run(() => loader.Execute(AppGlobalSettings.DataFileName));
                players = loader.FootballPlayers;
                if (loader.Status == LoadStatus.Success)
                {
                    bsPlayers.DataSource = loader.FootballPlayers;
                    dgvFootballPlayers.DataSource = bsPlayers;
                }
            }
            //обработка исключения "Метод не реализован"
            catch (IncorrectFileInput ex)
            {
                LogCustomExeption.ErrorLog(ex);
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                LogCustomExeption.ErrorLog(ex);
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }

        }

        private void mnOpenFootbalPlayer_Click(object sender, EventArgs e)
        {
            FrmFootbalPlayer frmFp = new FrmFootbalPlayer();
            FootballPlayer player = bsPlayers.Current as FootballPlayer;
            frmFp.SetFootballPlayer(player);
            frmFp.ShowDialog();
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            var t = new[] { -2, 1, -5, 5 };
            SortedAlg.CircleSort(t);
            Console.WriteLine(t);
            try
            {
                if(players == null || players.Count == 0)
                {
                    throw new Exception("Нет данных для сохранения");
                }
                IFootballPlayerSaver saver = IoC.container.Resolve<IFootballPlayerSaver>();
                saver.FootballPlayers = players;
                saver.Execute(AppGlobalSettings.DataFileNameSave);
            }
            catch (IncorrectFileInput ex)
            {
                LogCustomExeption.ErrorLog(ex);
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                LogCustomExeption.ErrorLog(ex);
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }
        }
    }
}
