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
            this.TextHistory.Location = new System.Drawing.Point(0, 0);
            this.TextHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextHistory.Multiline = true;
            this.TextHistory.Name = "TextHistory";
            this.TextHistory.ReadOnly = true;
            this.TextHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextHistory.Size = new System.Drawing.Size(711, 360);
            this.TextHistory.TabIndex = 0;
            // 
            // GameHistoryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.TextHistory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameHistoryTab";
            this.Text = "GameHistoryTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextHistory;
    }
}