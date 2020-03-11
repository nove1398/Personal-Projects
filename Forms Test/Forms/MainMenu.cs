using Forms_Test.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms_Test
{
    public partial class MainMenuContainer : Form
    {
        private Point LastPoint;
        private Form CurrentForm;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        public MainMenuContainer()
        {
            InitializeComponent();
            SwitchPanel(new HomeForm());
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void OnMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void OnDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonTitleMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonBudget_Click(object sender, EventArgs e)
        {
            SwitchPanel(new BudgetForm());
            MoveIndicator(sender);
        }

        //Change panel forms
        private void SwitchPanel(Form subForm)
        {
            foreach (var item in panelDynamicContent.Controls)
            {
                panelDynamicContent.Controls.Remove((Form)item);
            }
            subForm.TopLevel = false;
            subForm.TopMost = true;
            subForm.Parent = panelDynamicContent;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            subForm.Show();
            CurrentForm = subForm;
            
        }

        //Move the panel indicator
        private void MoveIndicator(object sender)
        {
            Button btn = ((Button)sender);
            panelMenuIndicator.Top = btn.Location.Y;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            SwitchPanel(new HomeForm());
            MoveIndicator(sender);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            SwitchPanel(new HomeForm());
            MoveIndicator(sender);
        }
    }
}
