namespace CMPE2800_Lab02.Dialogs
{
    partial class GameHistoryTab
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
            this.TextHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextHistory
            // 
            this.TextHistory.Location = new System.Drawing.Point(24, 43);
            this.TextHistory.Multiline = true;
            this.TextHistory.Name = "TextHistory";
            this.TextHistory.ReadOnly = true;
            this.TextHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextHistory.Size = new System.Drawing.Size(722, 374);
            this.TextHistory.TabIndex = 0;
            // 
            // GameHistoryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextHistory);
            this.Name = "GameHistoryTab";
            this.Text = "GameHistoryTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextHistory;
    }
}