using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Forms_Test.Model
{
    class BudgetItem
    {
        [Key]
        public int BudgetItemId { get; set; }

        public DateTime AddedOn { get; set; }

        public string ItemName { get; set; }

        public double ItemCost { get; set; }

        public string ItemDescription { get; set; }

        public static List<BudgetItem> SampleItems = new List<BudgetItem>()
        {
            new BudgetItem{ BudgetItemId = 1, ItemName = "Gas", ItemCost = 3000.00,  AddedOn = DateTime.Now, ItemDescription = "for car gas transportation"},
            new BudgetItem{ BudgetItemId = 2, ItemName = "Gas", ItemCost = 3000.00,   AddedOn = DateTime.Now, ItemDescription = "for car gas transportation"},
            new BudgetItem{ BudgetItemId = 3, ItemName = "Gas", ItemCost = 3000.00,   AddedOn = DateTime.Now, ItemDescription = "for car gas transportation"},
            new BudgetItem{ BudgetItemId = 4, ItemName = "Gas", ItemCost = 3000.00,   AddedOn = DateTime.Now, ItemDescription = "for car gas transportation"},
            new BudgetItem{ BudgetItemId = 5, ItemName = "Gas", ItemCost = 3000.00,   AddedOn = DateTime.Now, ItemDescription = "for car gas transportation"},
            new BudgetItem{ BudgetItemId = 6, ItemName = "Gas", ItemCost = 3000.00,   AddedOn = DateTime.Now, ItemDescription = "for car gas transportation"},
            new BudgetItem{ BudgetItemId = 7, ItemName = "Gas", ItemCost = 3000.00,   AddedOn = DateTime.Now, ItemDescription = "for car gas transportation"},
        };
    }
}
