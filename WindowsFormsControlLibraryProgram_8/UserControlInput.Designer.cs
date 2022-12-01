namespace WindowsFormsControlLibraryProgram_8
{
    partial class UserControlInput
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputgroupBox = new System.Windows.Forms.GroupBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemID = new System.Windows.Forms.Label();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.itemnametextBox = new System.Windows.Forms.TextBox();
            this.itemidtextBox = new System.Windows.Forms.TextBox();
            this.inputgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputgroupBox
            // 
            this.inputgroupBox.Controls.Add(this.labelQuantity);
            this.inputgroupBox.Controls.Add(this.labelPrice);
            this.inputgroupBox.Controls.Add(this.labelItemName);
            this.inputgroupBox.Controls.Add(this.labelItemID);
            this.inputgroupBox.Controls.Add(this.quantitytextBox);
            this.inputgroupBox.Controls.Add(this.pricetextBox);
            this.inputgroupBox.Controls.Add(this.itemnametextBox);
            this.inputgroupBox.Controls.Add(this.itemidtextBox);
            this.inputgroupBox.Location = new System.Drawing.Point(13, 15);
            this.inputgroupBox.Name = "inputgroupBox";
            this.inputgroupBox.Size = new System.Drawing.Size(559, 170);
            this.inputgroupBox.TabIndex = 0;
            this.inputgroupBox.TabStop = false;
            this.inputgroupBox.Text = "Input Details";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(38, 125);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(55, 16);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(55, 93);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 16);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(22, 60);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(72, 16);
            this.labelItemName.TabIndex = 5;
            this.labelItemName.Text = "Item Name";
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(45, 28);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(48, 16);
            this.labelItemID.TabIndex = 4;
            this.labelItemID.Text = "Item ID";
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.Location = new System.Drawing.Point(99, 122);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(181, 22);
            this.quantitytextBox.TabIndex = 3;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(99, 90);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(181, 22);
            this.pricetextBox.TabIndex = 2;
            // 
            // itemnametextBox
            // 
            this.itemnametextBox.Location = new System.Drawing.Point(99, 57);
            this.itemnametextBox.Name = "itemnametextBox";
            this.itemnametextBox.Size = new System.Drawing.Size(380, 22);
            this.itemnametextBox.TabIndex = 1;
            // 
            // itemidtextBox
            // 
            this.itemidtextBox.Location = new System.Drawing.Point(99, 25);
            this.itemidtextBox.Name = "itemidtextBox";
            this.itemidtextBox.Size = new System.Drawing.Size(181, 22);
            this.itemidtextBox.TabIndex = 0;
            // 
            // UserControlInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputgroupBox);
            this.Name = "UserControlInput";
            this.Size = new System.Drawing.Size(590, 247);
            this.inputgroupBox.ResumeLayout(false);
            this.inputgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputgroupBox;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemID;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox itemnametextBox;
        private System.Windows.Forms.TextBox itemidtextBox;
    }
}
