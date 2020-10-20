namespace Kpo4310_nvm.Main
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFootbalPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenFootbalPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvFootballPlayers = new System.Windows.Forms.DataGridView();
            this.tsLableConfig = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MMenu.SuspendLayout();
            this.SStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFootballPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmFootbalPlayer});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(800, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(48, 20);
            this.mmFile.Text = "Файл";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(121, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(121, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mmFootbalPlayer
            // 
            this.mmFootbalPlayer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenFootbalPlayer});
            this.mmFootbalPlayer.Name = "mmFootbalPlayer";
            this.mmFootbalPlayer.Size = new System.Drawing.Size(87, 20);
            this.mmFootbalPlayer.Text = "Футболисты";
            // 
            // mnOpenFootbalPlayer
            // 
            this.mnOpenFootbalPlayer.Name = "mnOpenFootbalPlayer";
            this.mnOpenFootbalPlayer.Size = new System.Drawing.Size(233, 22);
            this.mnOpenFootbalPlayer.Text = "Открыть данные футболиста";
            this.mnOpenFootbalPlayer.Click += new System.EventHandler(this.mnOpenFootbalPlayer_Click);
            // 
            // SStatus
            // 
            this.SStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLableConfig,
            this.tsLabel});
            this.SStatus.Location = new System.Drawing.Point(0, 428);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(800, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvFootballPlayers
            // 
            this.dgvFootballPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFootballPlayers.Location = new System.Drawing.Point(0, 27);
            this.dgvFootballPlayers.Name = "dgvFootballPlayers";
            this.dgvFootballPlayers.Size = new System.Drawing.Size(800, 398);
            this.dgvFootballPlayers.TabIndex = 2;
            // 
            // tsLableConfig
            // 
            this.tsLableConfig.Name = "tsLableConfig";
            this.tsLableConfig.Size = new System.Drawing.Size(0, 17);
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFootballPlayers);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "FrmMain";
            this.Text = "КПО:4310:Султанов";
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            this.SStatus.ResumeLayout(false);
            this.SStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFootballPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvFootballPlayers;
        private System.Windows.Forms.ToolStripMenuItem mmFootbalPlayer;
        private System.Windows.Forms.ToolStripMenuItem mnOpenFootbalPlayer;
        private System.Windows.Forms.ToolStripStatusLabel tsLableConfig;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
    }
}

