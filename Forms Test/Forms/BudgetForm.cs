using Forms_Test.Data;
using Forms_Test.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms_Test.Forms
{
    public partial class BudgetForm : Form
    {

        private BindingList<BudgetItem> BudgetItems;
        private double TotalAllocated = 0.0;


        public BudgetForm()
        {
            InitializeComponent();
            BudgetItems = new BindingList<BudgetItem>();
            listBoxBudgetItems.DataSource = BudgetItems;
            listBoxBudgetItems.DisplayMember = "ItemName";
            listBoxBudgetItems.ValueMember = "BudgetItemId";
            foreach(var item in BudgetItem.SampleItems)
            {
                BudgetItems.Add(item);
                TotalAllocated += item.ItemCost;
            }
            labelTotalAmount.Text = string.Format("Total allocated Budget: {0:C}", TotalAllocated);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BudgetItems.Add(new BudgetItem() { AddedOn = DateTime.Now, 
                ItemCost = Convert.ToDouble(textBoxCost.Text), 
                ItemDescription = textBoxItemDescription.Text, 
                ItemName = textBoxItemName.Text });
            TotalAllocated += Convert.ToDouble(textBoxCost.Text);
            labelTotalAmount.Text = string.Format("Total allocated Budget: {0:C}",TotalAllocated);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
        }
    }
}
