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

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                //MockFootballPlayersListCommand loader = new MockFootballPlayersListCommand();
                IFootballPlayerLoader loader = new LoadFootballPlayerListCommand(AppGlobalSettings.DataFileName);
                loader.Execute();
               
                if (loader.Status == LoadStatus.Success)
                {
                    bsPlayers.DataSource = loader.FootballPlayers;
                    dgvFootballPlayers.DataSource = bsPlayers;
                }
            }
            //обработка исключения "Метод не реализован"
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
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
    }
}
