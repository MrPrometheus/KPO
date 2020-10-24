namespace Kpo4310_nvm.Main
{
    partial class FrmFootbalPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblFootbolsData = new System.Windows.Forms.Label();
            this.LblComandName = new System.Windows.Forms.Label();
            this.LblReiting = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFootbolsData
            // 
            this.LblFootbolsData.AutoSize = true;
            this.LblFootbolsData.Location = new System.Drawing.Point(12, 9);
            this.LblFootbolsData.Name = "LblFootbolsData";
            this.LblFootbolsData.Size = new System.Drawing.Size(0, 13);
            this.LblFootbolsData.TabIndex = 0;
            // 
            // LblComandName
            // 
            this.LblComandName.AutoSize = true;
            this.LblComandName.Location = new System.Drawing.Point(13, 26);
            this.LblComandName.Name = "LblComandName";
            this.LblComandName.Size = new System.Drawing.Size(35, 13);
            this.LblComandName.TabIndex = 1;
            this.LblComandName.Text = "label1";
            // 
            // LblReiting
            // 
            this.LblReiting.AutoSize = true;
            this.LblReiting.Location = new System.Drawing.Point(13, 51);
            this.LblReiting.Name = "LblReiting";
            this.LblReiting.Size = new System.Drawing.Size(35, 13);
            this.LblReiting.TabIndex = 2;
            this.LblReiting.Text = "label2";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(13, 75);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(35, 13);
            this.LblPosition.TabIndex = 3;
            this.LblPosition.Text = "label3";
            // 
            // FrmFootbalPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.LblReiting);
            this.Controls.Add(this.LblComandName);
            this.Controls.Add(this.LblFootbolsData);
            this.Name = "FrmFootbalPlayer";
            this.Text = "Футболист";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFootbolsData;
        private System.Windows.Forms.Label LblComandName;
        private System.Windows.Forms.Label LblReiting;
        private System.Windows.Forms.Label LblPosition;
    }
}