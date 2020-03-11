namespace Forms_Test.Forms
{
    partial class BudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetForm));
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxBudgetItems = new System.Windows.Forms.ListBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(12, 37);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(307, 23);
            this.textBoxItemName.TabIndex = 0;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItemName.ForeColor = System.Drawing.Color.White;
            this.labelItemName.Location = new System.Drawing.Point(12, 9);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(84, 21);
            this.labelItemName.TabIndex = 1;
            this.labelItemName.Text = "Item Name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxItemDescription);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.labelItemName);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxItemName);
            this.splitContainer1.Panel1.Controls.Add(this.labelCost);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCost);
            this.splitContainer1.Panel1.Controls.Add(this.labelDescription);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxBudgetItems);
            this.splitContainer1.Panel2.Controls.Add(this.labelTotalAmount);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 750);
            this.splitContainer1.SplitterDistance = 395;
            this.splitContainer1.TabIndex = 2;
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.Location = new System.Drawing.Point(12, 190);
            this.textBoxItemDescription.Multiline = true;
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.Size = new System.Drawing.Size(336, 107);
            this.textBoxItemDescription.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(180, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(58, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(56, 319);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(57, 40);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCost.ForeColor = System.Drawing.Color.White;
            this.labelCost.Location = new System.Drawing.Point(12, 91);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(40, 21);
            this.labelCost.TabIndex = 5;
            this.labelCost.Text = "Cost";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(12, 115);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(307, 23);
            this.textBoxCost.TabIndex = 4;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(12, 166);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(119, 21);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Item Description";
            // 
            // listBoxBudgetItems
            // 
            this.listBoxBudgetItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxBudgetItems.FormattingEnabled = true;
            this.listBoxBudgetItems.ItemHeight = 15;
            this.listBoxBudgetItems.Location = new System.Drawing.Point(0, 0);
            this.listBoxBudgetItems.Name = "listBoxBudgetItems";
            this.listBoxBudgetItems.Size = new System.Drawing.Size(788, 379);
            this.listBoxBudgetItems.TabIndex = 1;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalAmount.ForeColor = System.Drawing.Color.White;
            this.labelTotalAmount.Location = new System.Drawing.Point(0, 729);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(40, 21);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "Total";
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 750);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetForm";
            this.Text = "Budget";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxBudgetItems;
    }
}