namespace CMPE2800_Lab02
{
    partial class GameOver
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
            this._labWinner = new System.Windows.Forms.Label();
            this._btnNewGame = new System.Windows.Forms.Button();
            this._btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labWinner
            // 
            this._labWinner.AutoSize = true;
            this._labWinner.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labWinner.Location = new System.Drawing.Point(119, 52);
            this._labWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labWinner.Name = "_labWinner";
            this._labWinner.Size = new System.Drawing.Size(188, 32);
            this._labWinner.TabIndex = 0;
            this._labWinner.Text = "Player 0 Wins";
            // 
            // _btnNewGame
            // 
            this._btnNewGame.Location = new System.Drawing.Point(68, 135);
            this._btnNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnNewGame.Name = "_btnNewGame";
            this._btnNewGame.Size = new System.Drawing.Size(100, 28);
            this._btnNewGame.TabIndex = 1;
            this._btnNewGame.Text = "New Game";
            this._btnNewGame.UseVisualStyleBackColor = true;
            this._btnNewGame.Click += new System.EventHandler(this._btnNewGame_Click);
            // 
            // _btnQuit
            // 
            this._btnQuit.Location = new System.Drawing.Point(273, 135);
            this._btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnQuit.Name = "_btnQuit";
            this._btnQuit.Size = new System.Drawing.Size(100, 28);
            this._btnQuit.TabIndex = 2;
            this._btnQuit.Text = "Quit";
            this._btnQuit.UseVisualStyleBackColor = true;
            this._btnQuit.Click += new System.EventHandler(this._btnQuit_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 192);
            this.ControlBox = false;
            this.Controls.Add(this._btnQuit);
            this.Controls.Add(this._btnNewGame);
            this.Controls.Add(this._labWinner);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameOver";
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labWinner;
        private System.Windows.Forms.Button _btnNewGame;
        private System.Windows.Forms.Button _btnQuit;
    }
}