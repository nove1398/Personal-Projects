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
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelSizerBottom = new System.Windows.Forms.Panel();
            this.panelSizerRight = new System.Windows.Forms.Panel();
            this.panelSizerLeft = new System.Windows.Forms.Panel();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.DarkRed;
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
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(135, 21);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Pregnancy Corner";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.panelSizerBottom.BackColor = System.Drawing.Color.Lime;
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
            this.panelSizerRight.BackColor = System.Drawing.Color.Lime;
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
            this.panelSizerLeft.BackColor = System.Drawing.Color.Lime;
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
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelSizerLeft);
            this.Controls.Add(this.panelSizerRight);
            this.Controls.Add(this.panelSizerBottom);
            this.Controls.Add(this.panelTopMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "MainMenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
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
    }
}