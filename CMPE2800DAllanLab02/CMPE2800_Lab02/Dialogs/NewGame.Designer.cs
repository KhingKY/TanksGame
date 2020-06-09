namespace CMPE2800_Lab02
{
    partial class NewGame
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
            this._gbxLevels = new System.Windows.Forms.GroupBox();
            this._rbPlains = new System.Windows.Forms.RadioButton();
            this._rbDesert = new System.Windows.Forms.RadioButton();
            this._rbCity = new System.Windows.Forms.RadioButton();
            this._btnLoad = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._gbxLevels.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gbxLevels
            // 
            this._gbxLevels.Controls.Add(this._rbPlains);
            this._gbxLevels.Controls.Add(this._rbDesert);
            this._gbxLevels.Controls.Add(this._rbCity);
<<<<<<< Updated upstream
            this._gbxLevels.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gbxLevels.Location = new System.Drawing.Point(49, 31);
            this._gbxLevels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._gbxLevels.Name = "_gbxLevels";
            this._gbxLevels.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._gbxLevels.Size = new System.Drawing.Size(267, 167);
=======
            this._gbxLevels.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gbxLevels.ForeColor = System.Drawing.Color.White;
            this._gbxLevels.Location = new System.Drawing.Point(4, 3);
            this._gbxLevels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._gbxLevels.Name = "_gbxLevels";
            this._gbxLevels.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._gbxLevels.Size = new System.Drawing.Size(370, 182);
>>>>>>> Stashed changes
            this._gbxLevels.TabIndex = 0;
            this._gbxLevels.TabStop = false;
            this._gbxLevels.Text = "Select a level";
            // 
            // _rbPlains
            // 
            this._rbPlains.AutoSize = true;
            this._rbPlains.Location = new System.Drawing.Point(32, 113);
            this._rbPlains.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._rbPlains.Name = "_rbPlains";
            this._rbPlains.Size = new System.Drawing.Size(117, 31);
            this._rbPlains.TabIndex = 2;
            this._rbPlains.Text = "Plains";
            this._rbPlains.UseVisualStyleBackColor = true;
            // 
            // _rbDesert
            // 
            this._rbDesert.AutoSize = true;
            this._rbDesert.Location = new System.Drawing.Point(32, 73);
            this._rbDesert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._rbDesert.Name = "_rbDesert";
            this._rbDesert.Size = new System.Drawing.Size(117, 31);
            this._rbDesert.TabIndex = 1;
            this._rbDesert.Text = "Desert";
            this._rbDesert.UseVisualStyleBackColor = true;
            // 
            // _rbCity
            // 
            this._rbCity.AutoSize = true;
            this._rbCity.Checked = true;
            this._rbCity.Location = new System.Drawing.Point(32, 33);
            this._rbCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._rbCity.Name = "_rbCity";
            this._rbCity.Size = new System.Drawing.Size(89, 31);
            this._rbCity.TabIndex = 0;
            this._rbCity.TabStop = true;
            this._rbCity.Text = "City";
            this._rbCity.UseVisualStyleBackColor = true;
            // 
            // _btnLoad
            // 
<<<<<<< Updated upstream
            this._btnLoad.Location = new System.Drawing.Point(49, 244);
            this._btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnLoad.Name = "_btnLoad";
            this._btnLoad.Size = new System.Drawing.Size(100, 28);
=======
            this._btnLoad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this._btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLoad.ForeColor = System.Drawing.Color.White;
            this._btnLoad.Location = new System.Drawing.Point(54, 193);
            this._btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnLoad.Name = "_btnLoad";
            this._btnLoad.Size = new System.Drawing.Size(268, 44);
>>>>>>> Stashed changes
            this._btnLoad.TabIndex = 1;
            this._btnLoad.Text = "Load Level";
            this._btnLoad.UseVisualStyleBackColor = false;
            this._btnLoad.Click += new System.EventHandler(this._btnLoad_Click);
            // 
            // _btnCancel
            // 
<<<<<<< Updated upstream
            this._btnCancel.Location = new System.Drawing.Point(229, 244);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(100, 28);
=======
            this._btnCancel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.ForeColor = System.Drawing.Color.White;
            this._btnCancel.Location = new System.Drawing.Point(54, 245);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(268, 40);
>>>>>>> Stashed changes
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = false;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
=======
            this.BackColor = System.Drawing.Color.Olive;
>>>>>>> Stashed changes
            this.ClientSize = new System.Drawing.Size(379, 298);
            this.ControlBox = false;
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnLoad);
            this.Controls.Add(this._gbxLevels);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewGame";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this._gbxLevels.ResumeLayout(false);
            this._gbxLevels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbxLevels;
        private System.Windows.Forms.RadioButton _rbPlains;
        private System.Windows.Forms.RadioButton _rbDesert;
        private System.Windows.Forms.RadioButton _rbCity;
        private System.Windows.Forms.Button _btnLoad;
        private System.Windows.Forms.Button _btnCancel;
    }
}