namespace CMPE2800_Lab02.Dialogs
{
    partial class GameMenu
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.InstructionsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(271, 198);

            this.PlayButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.Location = new System.Drawing.Point(270, 81);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(147, 47);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(271, 245);

            this.HistoryButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.HistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.Location = new System.Drawing.Point(270, 148);
            this.HistoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(147, 47);
            this.HistoryButton.TabIndex = 0;
            this.HistoryButton.Text = "Game History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // InstructionsButton
            // 
            this.InstructionsButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.InstructionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsButton.ForeColor = System.Drawing.Color.White;
            this.InstructionsButton.Location = new System.Drawing.Point(270, 220);
            this.InstructionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InstructionsButton.Name = "InstructionsButton";
            this.InstructionsButton.Size = new System.Drawing.Size(147, 47);
            this.InstructionsButton.TabIndex = 0;
            this.InstructionsButton.Text = "Instructions";
            this.InstructionsButton.UseVisualStyleBackColor = false;
            this.InstructionsButton.Click += new System.EventHandler(this.InstructionsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMPE2800_Lab02.Properties.Resources.ammoDrop;
            this.pictureBox1.Image = global::CMPE2800_Lab02.Properties.Resources.menuImage;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.InstructionsButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameMenu";
            this.Text = "TANK GAME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button InstructionsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}