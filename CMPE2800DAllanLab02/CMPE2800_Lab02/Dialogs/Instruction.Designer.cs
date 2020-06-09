namespace CMPE2800_Lab02
{
    partial class Instruction
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
            this._btnContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labWinner
            // 
            this._labWinner.AutoSize = true;
            this._labWinner.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labWinner.Location = new System.Drawing.Point(16, 14);
            this._labWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labWinner.Name = "_labWinner";
            this._labWinner.Size = new System.Drawing.Size(355, 32);
            this._labWinner.TabIndex = 0;
            this._labWinner.Text = "Player 1 Instruction";
            // 
            // _btnContinue
            // 
            this._btnContinue.Location = new System.Drawing.Point(436, 294);
            this._btnContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._btnContinue.Name = "_btnContinue";
            this._btnContinue.Size = new System.Drawing.Size(112, 35);
            this._btnContinue.TabIndex = 1;
            this._btnContinue.Text = "Continue";
            this._btnContinue.UseVisualStyleBackColor = true;
            this._btnContinue.Click += new System.EventHandler(this._btnContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 2 Instruction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 189);
            this.label2.TabIndex = 3;
            this.label2.Text = "Move Up : Arrow Up \nMove Down: Arrow Down \nMove Left: Arrow Left \nMove Right: Arr" +
    "ow Right \nFire: Enter \nSwitch Ammo: /\nRotate tank: Ctrl + Arrow Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 189);
            this.label3.TabIndex = 4;
            this.label3.Text = "Move Up : W \nMove Down: S \nMove Left: A \nMove Right: D \nFire: Space \nSwitch Ammo:" +
    " Q\nRotate tank: Shift + WASD Key";
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 348);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnContinue);
            this.Controls.Add(this._labWinner);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Instruction";
            this.Text = "Game Control Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labWinner;
        private System.Windows.Forms.Button _btnContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}