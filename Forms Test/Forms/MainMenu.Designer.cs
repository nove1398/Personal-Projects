namespace Forms_Test
{
    partial class MainMenuContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuContainer));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuContainer = new System.Windows.Forms.Panel();
            this.panelMenuIndicator = new System.Windows.Forms.Panel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonBudget = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonTitleMinimize = new System.Windows.Forms.Button();
            this.buttonTitleExit = new System.Windows.Forms.Button();
            this.panelDynamicContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMenuContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMenu.Controls.Add(this.panelMenuContainer);
            this.panelMenu.Location = new System.Drawing.Point(0, 49);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(172, 701);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMove);
            // 
            // panelMenuContainer
            // 
            this.panelMenuContainer.Controls.Add(this.panelMenuIndicator);
            this.panelMenuContainer.Controls.Add(this.labelCopyright);
            this.panelMenuContainer.Controls.Add(this.buttonStatistics);
            this.panelMenuContainer.Controls.Add(this.buttonBudget);
            this.panelMenuContainer.Controls.Add(this.buttonHome);
            this.panelMenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenuContainer.Name = "panelMenuContainer";
            this.panelMenuContainer.Size = new System.Drawing.Size(170, 701);
            this.panelMenuContainer.TabIndex = 3;
            this.panelMenuContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDown);
            this.panelMenuContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMove);
            // 
            // panelMenuIndicator
            // 
            this.panelMenuIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuIndicator.BackColor = System.Drawing.Color.GhostWhite;
            this.panelMenuIndicator.Location = new System.Drawing.Point(1, 18);
            this.panelMenuIndicator.Name = "panelMenuIndicator";
            this.panelMenuIndicator.Size = new System.Drawing.Size(5, 34);
            this.panelMenuIndicator.TabIndex = 2;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(36, 680);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Padding = new System.Windows.Forms.Padding(3);
            this.labelCopyright.Size = new System.Drawing.Size(95, 21);
            this.labelCopyright.TabIndex = 0;
            this.labelCopyright.Text = "copyright 2020";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStatistics.FlatAppearance.BorderSize = 0;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonStatistics.Location = new System.Drawing.Point(9, 86);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(163, 34);
            this.buttonStatistics.TabIndex = 0;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonBudget
            // 
            this.buttonBudget.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBudget.FlatAppearance.BorderSize = 0;
            this.buttonBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBudget.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBudget.ForeColor = System.Drawing.Color.White;
            this.buttonBudget.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonBudget.Location = new System.Drawing.Point(9, 52);
            this.buttonBudget.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBudget.Name = "buttonBudget";
            this.buttonBudget.Size = new System.Drawing.Size(163, 34);
            this.buttonBudget.TabIndex = 0;
            this.buttonBudget.Text = "Budget";
            this.buttonBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBudget.UseVisualStyleBackColor = false;
            this.buttonBudget.Click += new System.EventHandler(this.buttonBudget_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(12, 18);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(160, 34);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Gray;
            this.panelTitleBar.Controls.Add(this.pictureBoxLogo);
            this.panelTitleBar.Controls.Add(this.buttonTitleMinimize);
            this.panelTitleBar.Controls.Add(this.buttonTitleExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1187, 51);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMove);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 51);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonTitleMinimize
            // 
            this.buttonTitleMinimize.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTitleMinimize.FlatAppearance.BorderSize = 0;
            this.buttonTitleMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTitleMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTitleMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonTitleMinimize.Location = new System.Drawing.Point(1134, 1);
            this.buttonTitleMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTitleMinimize.Name = "buttonTitleMinimize";
            this.buttonTitleMinimize.Size = new System.Drawing.Size(26, 23);
            this.buttonTitleMinimize.TabIndex = 4;
            this.buttonTitleMinimize.Text = "-";
            this.buttonTitleMinimize.UseVisualStyleBackColor = false;
            this.buttonTitleMinimize.Click += new System.EventHandler(this.buttonTitleMinimize_Click);
            // 
            // buttonTitleExit
            // 
            this.buttonTitleExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTitleExit.FlatAppearance.BorderSize = 0;
            this.buttonTitleExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTitleExit.ForeColor = System.Drawing.Color.White;
            this.buttonTitleExit.Location = new System.Drawing.Point(1162, 1);
            this.buttonTitleExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTitleExit.Name = "buttonTitleExit";
            this.buttonTitleExit.Size = new System.Drawing.Size(26, 23);
            this.buttonTitleExit.TabIndex = 4;
            this.buttonTitleExit.Text = "X";
            this.buttonTitleExit.UseVisualStyleBackColor = false;
            this.buttonTitleExit.Click += new System.EventHandler(this.button6_Click);
            // 
            // panelDynamicContent
            // 
            this.panelDynamicContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDynamicContent.Location = new System.Drawing.Point(173, 49);
            this.panelDynamicContent.Name = "panelDynamicContent";
            this.panelDynamicContent.Size = new System.Drawing.Size(1014, 701);
            this.panelDynamicContent.TabIndex = 3;
            // 
            // MainMenuContainer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 750);
            this.Controls.Add(this.panelDynamicContent);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1187, 588);
            this.Name = "MainMenuContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMove);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuContainer.ResumeLayout(false);
            this.panelMenuContainer.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelMenuIndicator;
        private System.Windows.Forms.Panel panelMenuContainer;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonBudget;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button buttonTitleMinimize;
        private System.Windows.Forms.Button buttonTitleExit;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDynamicContent;
    }
}