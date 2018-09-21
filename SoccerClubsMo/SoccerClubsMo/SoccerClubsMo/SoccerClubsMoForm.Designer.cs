namespace SoccerClubsMo
{
    partial class frmSoccerClubs
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
            this.mnuClubs = new System.Windows.Forms.MenuStrip();
            this.mniClubs = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTeamName1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTeamName2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.mniTeamName3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTeamName4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClubs.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuClubs
            // 
            this.mnuClubs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniClubs});
            this.mnuClubs.Location = new System.Drawing.Point(0, 0);
            this.mnuClubs.Name = "mnuClubs";
            this.mnuClubs.Size = new System.Drawing.Size(284, 24);
            this.mnuClubs.TabIndex = 1;
            this.mnuClubs.Text = "menuStrip1";
            // 
            // mniClubs
            // 
            this.mniClubs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTeamName1,
            this.mniTeamName2,
            this.mniTeamName3,
            this.mniTeamName4});
            this.mniClubs.Name = "mniClubs";
            this.mniClubs.Size = new System.Drawing.Size(49, 20);
            this.mniClubs.Text = "Clubs";
            // 
            // mniTeamName1
            // 
            this.mniTeamName1.Name = "mniTeamName1";
            this.mniTeamName1.Size = new System.Drawing.Size(177, 22);
            this.mniTeamName1.Text = "Manchester City";
            // 
            // mniTeamName2
            // 
            this.mniTeamName2.Name = "mniTeamName2";
            this.mniTeamName2.Size = new System.Drawing.Size(177, 22);
            this.mniTeamName2.Text = "Manchester United ";
            this.mniTeamName2.Click += new System.EventHandler(this.mniTeamName2_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(33, 107);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(211, 31);
            this.lblTeamName.TabIndex = 2;
            this.lblTeamName.Text = "Manchester City";
            this.lblTeamName.Click += new System.EventHandler(this.lblTeamName_Click);
            // 
            // mniTeamName3
            // 
            this.mniTeamName3.Name = "mniTeamName3";
            this.mniTeamName3.Size = new System.Drawing.Size(177, 22);
            this.mniTeamName3.Text = "Real Madrid";
            this.mniTeamName3.Click += new System.EventHandler(this.mniTeamName3_Click);
            // 
            // mniTeamName4
            // 
            this.mniTeamName4.Name = "mniTeamName4";
            this.mniTeamName4.Size = new System.Drawing.Size(177, 22);
            this.mniTeamName4.Text = "Barcelona";
            this.mniTeamName4.Click += new System.EventHandler(this.mniTeamName4_Click);
            // 
            // frmSoccerClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.mnuClubs);
            this.MainMenuStrip = this.mnuClubs;
            this.Name = "frmSoccerClubs";
            this.Text = "Soccer Clubs Mo";
            this.mnuClubs.ResumeLayout(false);
            this.mnuClubs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuClubs;
        private System.Windows.Forms.ToolStripMenuItem mniClubs;
        private System.Windows.Forms.ToolStripMenuItem mniTeamName1;
        private System.Windows.Forms.ToolStripMenuItem mniTeamName2;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.ToolStripMenuItem mniTeamName3;
        private System.Windows.Forms.ToolStripMenuItem mniTeamName4;
    }
}

