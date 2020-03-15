using Preggers_Jam.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Preggers_Jam.Forms
{
    public partial class MainMenuForm : Form
    {

        private bool isBottomPanelDragged = false;
        private bool isRightPanelDragged = false;
        private bool isLeftPanelDragged = false;
        private bool IsFormBeingDragged = false;
        private Point offset;

        public MainMenuForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }



        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnPanelBottomDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void OnPanelBottomMove(object sender, MouseEventArgs e)
        {
            
                if (Height <= 650 && isBottomPanelDragged)
                {
                    Height = 650;
                    isBottomPanelDragged = false;
                }
                else
                {
                    Height = Height + e.Y;
                    isBottomPanelDragged = true;
                }
            
        }

        private void OnPanelBottomUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }

        private void OnPanelSizerRightDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void OnPanelSizerRightMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
            }
        }

        private void OnPanelSizerRightUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }

        private void OnPanelSizerLeftDown(object sender, MouseEventArgs e)
        {

                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                    Point pointStartPosition = panelTopMenu.PointToScreen(new Point(e.X, Location.Y));
                    offset = new Point();
                    offset.X = Location.X - pointStartPosition.X;
                }
                else
                {
                    isLeftPanelDragged = false;
                }

        }

        private void OnPanelSizerLeftMove(object sender, MouseEventArgs e)
        {
                if (isLeftPanelDragged)
                {
                    if (Width < 100)
                    {
                        Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        Point newPoint = panelTopMenu.PointToScreen(new Point(e.X, e.Y));
                        //newPoint.Offset(offset);

                        Location = newPoint;
                        Width = Width - e.X;
                    }
                }
        }

        private void OnPanelSIzerLeftUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }

        private void OnPanelTopMenuDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsFormBeingDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                IsFormBeingDragged = false;
            }
            if (e.Clicks == 2)
            {
                IsFormBeingDragged = false;
            }
        }

        private void OnPanelTopMenuMove(object sender, MouseEventArgs e)
        {
            if (IsFormBeingDragged)
            {
                Point newPoint = panelTopMenu.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                Location = newPoint;             
            }
        }

        private void OnPanelTopMenuUp(object sender, MouseEventArgs e)
        {
            IsFormBeingDragged = false;

        }
    }
}
