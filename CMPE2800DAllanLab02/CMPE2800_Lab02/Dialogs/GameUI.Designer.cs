namespace CMPE2800_Lab02
{
    partial class GameUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
            this._labHP1 = new System.Windows.Forms.Label();
            this._labHP2 = new System.Windows.Forms.Label();
            this._labScoreDisplay = new System.Windows.Forms.Label();
            this._labScore = new System.Windows.Forms.Label();
            this._pbxSuper1 = new System.Windows.Forms.PictureBox();
            this._pbxSuper2 = new System.Windows.Forms.PictureBox();
            this._pbxShield1 = new System.Windows.Forms.PictureBox();
            this._pbxShield2 = new System.Windows.Forms.PictureBox();
            this._pbxRocket2 = new System.Windows.Forms.PictureBox();
            this._pbxMG2 = new System.Windows.Forms.PictureBox();
            this._pbxMG1 = new System.Windows.Forms.PictureBox();
            this._pbxRocket1 = new System.Windows.Forms.PictureBox();
            this._labLives1 = new System.Windows.Forms.Label();
            this._labLives2 = new System.Windows.Forms.Label();
            this._labHAmmo1 = new System.Windows.Forms.Label();
            this._labHAmmo2 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._pbxSuper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxSuper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxShield1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxShield2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxRocket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxRocket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _labHP1
            // 
            this._labHP1.AutoSize = true;
            this._labHP1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labHP1.Location = new System.Drawing.Point(369, 29);
            this._labHP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labHP1.Name = "_labHP1";
            this._labHP1.Size = new System.Drawing.Size(71, 17);
            this._labHP1.TabIndex = 2;
            this._labHP1.Text = "100/100";
            // 
            // _labHP2
            // 
            this._labHP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._labHP2.AutoSize = true;
            this._labHP2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labHP2.Location = new System.Drawing.Point(609, 27);
            this._labHP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labHP2.Name = "_labHP2";
            this._labHP2.Size = new System.Drawing.Size(71, 17);
            this._labHP2.TabIndex = 3;
            this._labHP2.Text = "100/100";
            // 
            // _labScoreDisplay
            // 
            this._labScoreDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._labScoreDisplay.AutoSize = true;
            this._labScoreDisplay.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labScoreDisplay.Location = new System.Drawing.Point(464, 36);
            this._labScoreDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labScoreDisplay.Name = "_labScoreDisplay";
            this._labScoreDisplay.Size = new System.Drawing.Size(80, 38);
            this._labScoreDisplay.TabIndex = 4;
            this._labScoreDisplay.Text = "0 | 0";
            // 
            // _labScore
            // 
            this._labScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._labScore.AutoSize = true;
            this._labScore.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labScore.Location = new System.Drawing.Point(465, -1);
            this._labScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labScore.Name = "_labScore";
            this._labScore.Size = new System.Drawing.Size(83, 36);
            this._labScore.TabIndex = 5;
            this._labScore.Text = "Score";
            // 
            // _pbxShield1
            // 
            this._pbxShield1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pbxShield1.Image = global::CMPE2800_Lab02.Properties.Resources.shield;
            this._pbxShield1.Location = new System.Drawing.Point(220, 98);
            this._pbxShield1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pbxShield1.Name = "_pbxShield1";
            this._pbxShield1.Size = new System.Drawing.Size(40, 37);
            this._pbxShield1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxShield1.TabIndex = 15;
            this._pbxShield1.TabStop = false;
            // 
            // _pbxShield2
            // 
            this._pbxShield2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pbxShield2.Image = global::CMPE2800_Lab02.Properties.Resources.shield;
            this._pbxShield2.Location = new System.Drawing.Point(760, 98);
            this._pbxShield2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pbxShield2.Name = "_pbxShield2";
            this._pbxShield2.Size = new System.Drawing.Size(40, 37);
            this._pbxShield2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxShield2.TabIndex = 15;
            this._pbxShield2.TabStop = false;
            // 
            // _pbxSuper1
            // 
            this._pbxSuper1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pbxSuper1.Image = global::CMPE2800_Lab02.Properties.Resources.super;
            this._pbxSuper1.Location = new System.Drawing.Point(175, 98);
            this._pbxSuper1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pbxSuper1.Name = "_pbxSuper1";
            this._pbxSuper1.Size = new System.Drawing.Size(40, 37);
            this._pbxSuper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxSuper1.TabIndex = 15;
            this._pbxSuper1.TabStop = false;
            // 
            // _pbxSuper2
            // 
            this._pbxSuper2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pbxSuper2.Image = global::CMPE2800_Lab02.Properties.Resources.super;
            this._pbxSuper2.Location = new System.Drawing.Point(810, 98);
            this._pbxSuper2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._pbxSuper2.Name = "_pbxSuper2";
            this._pbxSuper2.Size = new System.Drawing.Size(40, 37);
            this._pbxSuper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxSuper2.TabIndex = 15;
            this._pbxSuper2.TabStop = false;
            // 
            // _pbxRocket2
            // 
            this._pbxRocket2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pbxRocket2.Image = ((System.Drawing.Image)(resources.GetObject("_pbxRocket2.Image")));
            this._pbxRocket2.Location = new System.Drawing.Point(693, 98);
            this._pbxRocket2.Margin = new System.Windows.Forms.Padding(4);
            this._pbxRocket2.Name = "_pbxRocket2";
            this._pbxRocket2.Size = new System.Drawing.Size(58, 37);
            this._pbxRocket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxRocket2.TabIndex = 9;
            this._pbxRocket2.TabStop = false;
            // 
            // _pbxMG2
            // 
            this._pbxMG2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._pbxMG2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._pbxMG2.Image = global::CMPE2800_Lab02.Properties.Resources.shell;
            this._pbxMG2.Location = new System.Drawing.Point(622, 98);
            this._pbxMG2.Margin = new System.Windows.Forms.Padding(4);
            this._pbxMG2.Name = "_pbxMG2";
            this._pbxMG2.Size = new System.Drawing.Size(58, 37);
            this._pbxMG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxMG2.TabIndex = 8;
            this._pbxMG2.TabStop = false;
            // 
            // _pbxMG1
            // 
            this._pbxMG1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._pbxMG1.Image = global::CMPE2800_Lab02.Properties.Resources.shell;
            this._pbxMG1.Location = new System.Drawing.Point(363, 98);
            this._pbxMG1.Margin = new System.Windows.Forms.Padding(4);
            this._pbxMG1.Name = "_pbxMG1";
            this._pbxMG1.Size = new System.Drawing.Size(58, 37);
            this._pbxMG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxMG1.TabIndex = 7;
            this._pbxMG1.TabStop = false;
            // 
            // _pbxRocket1
            // 
            this._pbxRocket1.Image = global::CMPE2800_Lab02.Properties.Resources.ammoDrop;
            this._pbxRocket1.Location = new System.Drawing.Point(297, 98);
            this._pbxRocket1.Margin = new System.Windows.Forms.Padding(4);
            this._pbxRocket1.Name = "_pbxRocket1";
            this._pbxRocket1.Size = new System.Drawing.Size(58, 37);
            this._pbxRocket1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pbxRocket1.TabIndex = 6;
            this._pbxRocket1.TabStop = false;
            // 
            // _labLives1
            // 
            this._labLives1.AutoSize = true;
            this._labLives1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this._labLives1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labLives1.ForeColor = System.Drawing.Color.White;
            this._labLives1.Location = new System.Drawing.Point(27, 84);
            this._labLives1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labLives1.Name = "_labLives1";
            this._labLives1.Size = new System.Drawing.Size(21, 24);
            this._labLives1.TabIndex = 10;
            this._labLives1.Text = "3";
            // 
            // _labLives2
            // 
            this._labLives2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._labLives2.AutoSize = true;
            this._labLives2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(90)))), ((int)(((byte)(74)))));
            this._labLives2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labLives2.ForeColor = System.Drawing.Color.White;
            this._labLives2.Location = new System.Drawing.Point(972, 84);
            this._labLives2.Margin = new System.Windows.Forms.Padding(0);
            this._labLives2.Name = "_labLives2";
            this._labLives2.Size = new System.Drawing.Size(21, 24);
            this._labLives2.TabIndex = 11;
            this._labLives2.Text = "3";
            // 
            // _labHAmmo1
            // 
            this._labHAmmo1.AutoSize = true;
            this._labHAmmo1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labHAmmo1.Location = new System.Drawing.Point(318, 78);
            this._labHAmmo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labHAmmo1.Name = "_labHAmmo1";
            this._labHAmmo1.Size = new System.Drawing.Size(22, 22);
            this._labHAmmo1.TabIndex = 12;
            this._labHAmmo1.Text = "5";
            // 
            // _labHAmmo2
            // 
            this._labHAmmo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._labHAmmo2.AutoSize = true;
            this._labHAmmo2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labHAmmo2.Location = new System.Drawing.Point(708, 80);
            this._labHAmmo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labHAmmo2.Name = "_labHAmmo2";
            this._labHAmmo2.Size = new System.Drawing.Size(22, 22);
            this._labHAmmo2.TabIndex = 13;
            this._labHAmmo2.Text = "5";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 44);
            this.label2.TabIndex = 15;
            this.label2.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar1.Location = new System.Drawing.Point(15, 47);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 27);
            this.progressBar1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "HP";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(622, 47);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(423, 27);
            this.progressBar2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Player 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(802, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Player 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMPE2800_Lab02.Properties.Resources.heart;
            this.pictureBox1.Location = new System.Drawing.Point(15, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CMPE2800_Lab02.Properties.Resources.heart;
            this.pictureBox2.Location = new System.Drawing.Point(994, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 142);
            this.ControlBox = false;
            this.Controls.Add(this._labLives2);
            this.Controls.Add(this._labLives1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
			this.Controls.Add(this._pbxSuper1);
            this.Controls.Add(this._pbxSuper2);
            this.Controls.Add(this._pbxShield1);
            this.Controls.Add(this._pbxShield2);
            this.Controls.Add(this._pbxRocket2);
            this.Controls.Add(this._pbxMG2);
            this.Controls.Add(this._pbxMG1);
            this.Controls.Add(this._pbxRocket1);
            this.Controls.Add(this._labScore);
            this.Controls.Add(this._labScoreDisplay);
            this.Controls.Add(this._labHP2);
            this.Controls.Add(this._labHP1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this._labHAmmo1);
            this.Controls.Add(this._labHAmmo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameUI";
            this.Text = "First to 3 points wins!";
            ((System.ComponentModel.ISupportInitialize)(this._pbxSuper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxSuper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxShield1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxShield2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxRocket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pbxRocket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _labHP1;
        private System.Windows.Forms.Label _labHP2;
        private System.Windows.Forms.Label _labScoreDisplay;
        private System.Windows.Forms.Label _labScore;
        private System.Windows.Forms.PictureBox _pbxSuper1;
        private System.Windows.Forms.PictureBox _pbxSuper2;
        private System.Windows.Forms.PictureBox _pbxShield1;
        private System.Windows.Forms.PictureBox _pbxShield2;
        private System.Windows.Forms.PictureBox _pbxRocket1;
        private System.Windows.Forms.PictureBox _pbxMG1;
        private System.Windows.Forms.PictureBox _pbxMG2;
        private System.Windows.Forms.PictureBox _pbxRocket2;
        private System.Windows.Forms.Label _labLives1;
        private System.Windows.Forms.Label _labLives2;
        private System.Windows.Forms.Label _labHAmmo1;
        private System.Windows.Forms.Label _labHAmmo2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}