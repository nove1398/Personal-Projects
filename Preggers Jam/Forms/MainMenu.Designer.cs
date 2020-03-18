namespace Preggers_Jam.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelSizerBottom = new System.Windows.Forms.Panel();
            this.panelSizerRight = new System.Windows.Forms.Panel();
            this.panelSizerLeft = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonComments = new System.Windows.Forms.Button();
            this.buttonBlogs = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTopMenu.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.panelTopMenu.Controls.Add(this.labelTitle);
            this.panelTopMenu.Controls.Add(this.buttonMinimize);
            this.panelTopMenu.Controls.Add(this.buttonExit);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1200, 32);
            this.panelTopMenu.TabIndex = 4;
            this.panelTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMenuDown);
            this.panelTopMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMenuMove);
            this.panelTopMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelTopMenuUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 21);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Pregnancy Corner";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(1136, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(32, 32);
            this.buttonMinimize.TabIndex = 5;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1168, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 32);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelSizerBottom
            // 
            this.panelSizerBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelSizerBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panelSizerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSizerBottom.Location = new System.Drawing.Point(0, 649);
            this.panelSizerBottom.Name = "panelSizerBottom";
            this.panelSizerBottom.Size = new System.Drawing.Size(1200, 1);
            this.panelSizerBottom.TabIndex = 5;
            this.panelSizerBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelBottomDown);
            this.panelSizerBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelBottomMove);
            this.panelSizerBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelBottomUp);
            // 
            // panelSizerRight
            // 
            this.panelSizerRight.BackColor = System.Drawing.Color.Transparent;
            this.panelSizerRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelSizerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSizerRight.Location = new System.Drawing.Point(1198, 32);
            this.panelSizerRight.Name = "panelSizerRight";
            this.panelSizerRight.Size = new System.Drawing.Size(2, 617);
            this.panelSizerRight.TabIndex = 6;
            this.panelSizerRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelSizerRightDown);
            this.panelSizerRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelSizerRightMove);
            this.panelSizerRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelSizerRightUp);
            // 
            // panelSizerLeft
            // 
            this.panelSizerLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.panelSizerLeft.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panelSizerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSizerLeft.Location = new System.Drawing.Point(0, 32);
            this.panelSizerLeft.Name = "panelSizerLeft";
            this.panelSizerLeft.Size = new System.Drawing.Size(2, 617);
            this.panelSizerLeft.TabIndex = 7;
            this.panelSizerLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPanelSizerLeftDown);
            this.panelSizerLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPanelSizerLeftMove);
            this.panelSizerLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPanelSIzerLeftUp);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.SeaGreen;
            this.panelNavigation.Controls.Add(this.buttonStatistics);
            this.panelNavigation.Controls.Add(this.button1);
            this.panelNavigation.Controls.Add(this.buttonComments);
            this.panelNavigation.Controls.Add(this.buttonBlogs);
            this.panelNavigation.Controls.Add(this.buttonDashboard);
            this.panelNavigation.Controls.Add(this.pictureBoxLogo);
            this.panelNavigation.Controls.Add(this.buttonLogOut);
            this.panelNavigation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.ForeColor = System.Drawing.Color.White;
            this.panelNavigation.Location = new System.Drawing.Point(2, 32);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(174, 617);
            this.panelNavigation.TabIndex = 8;
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Image = ((System.Drawing.Image)(resources.GetObject("buttonStatistics.Image")));
            this.buttonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.Location = new System.Drawing.Point(-2, 266);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(176, 40);
            this.buttonStatistics.TabIndex = 6;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStatistics.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Messages";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonComments
            // 
            this.buttonComments.FlatAppearance.BorderSize = 0;
            this.buttonComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComments.Image = ((System.Drawing.Image)(resources.GetObject("buttonComments.Image")));
            this.buttonComments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComments.Location = new System.Drawing.Point(0, 174);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(171, 40);
            this.buttonComments.TabIndex = 0;
            this.buttonComments.Text = "Comments";
            this.buttonComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonComments.UseVisualStyleBackColor = true;
            // 
            // buttonBlogs
            // 
            this.buttonBlogs.FlatAppearance.BorderSize = 0;
            this.buttonBlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlogs.Image = ((System.Drawing.Image)(resources.GetObject("buttonBlogs.Image")));
            this.buttonBlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlogs.Location = new System.Drawing.Point(-2, 128);
            this.buttonBlogs.Name = "buttonBlogs";
            this.buttonBlogs.Size = new System.Drawing.Size(173, 40);
            this.buttonBlogs.TabIndex = 1;
            this.buttonBlogs.Text = "Blogs";
            this.buttonBlogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBlogs.UseVisualStyleBackColor = true;
            this.buttonBlogs.Click += new System.EventHandler(this.buttonBlogs_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 82);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(174, 40);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(174, 82);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 576);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(174, 41);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(176, 32);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1022, 617);
            this.panelContainer.TabIndex = 9;
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelSizerLeft);
            this.Controls.Add(this.panelSizerRight);
            this.Controls.Add(this.panelSizerBottom);
            this.Controls.Add(this.panelTopMenu);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "MainMenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelSizerBottom;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSizerRight;
        private System.Windows.Forms.Panel panelSizerLeft;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonBlogs;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonComments;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Panel panelContainer;
    }
}