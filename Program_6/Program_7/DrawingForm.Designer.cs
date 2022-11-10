namespace Program_7
{
    partial class DrawingForm
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
            this.colorpengroupBox = new System.Windows.Forms.GroupBox();
            this.whitepenradioButton = new System.Windows.Forms.RadioButton();
            this.greenpenradioButton = new System.Windows.Forms.RadioButton();
            this.bluepenradioButton = new System.Windows.Forms.RadioButton();
            this.redpenradioButton = new System.Windows.Forms.RadioButton();
            this.blackpenradioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingpanel = new System.Windows.Forms.Panel();
            this.sizegroupBox = new System.Windows.Forms.GroupBox();
            this.sizeeightradioButton = new System.Windows.Forms.RadioButton();
            this.sizesixradioButton = new System.Windows.Forms.RadioButton();
            this.sizefourradioButton = new System.Windows.Forms.RadioButton();
            this.sizetworadioButton = new System.Windows.Forms.RadioButton();
            this.colorpanelgroupBox = new System.Windows.Forms.GroupBox();
            this.blackpanelradioButton = new System.Windows.Forms.RadioButton();
            this.whitepanelradioButton = new System.Windows.Forms.RadioButton();
            this.darkgraypanelradioButton = new System.Windows.Forms.RadioButton();
            this.fuchsiapanelradioButton = new System.Windows.Forms.RadioButton();
            this.colorpengroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.sizegroupBox.SuspendLayout();
            this.colorpanelgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorpengroupBox
            // 
            this.colorpengroupBox.Controls.Add(this.whitepenradioButton);
            this.colorpengroupBox.Controls.Add(this.greenpenradioButton);
            this.colorpengroupBox.Controls.Add(this.bluepenradioButton);
            this.colorpengroupBox.Controls.Add(this.redpenradioButton);
            this.colorpengroupBox.Controls.Add(this.blackpenradioButton);
            this.colorpengroupBox.Location = new System.Drawing.Point(12, 27);
            this.colorpengroupBox.Name = "colorpengroupBox";
            this.colorpengroupBox.Size = new System.Drawing.Size(139, 198);
            this.colorpengroupBox.TabIndex = 0;
            this.colorpengroupBox.TabStop = false;
            this.colorpengroupBox.Text = "Color Pen";
            // 
            // whitepenradioButton
            // 
            this.whitepenradioButton.AutoSize = true;
            this.whitepenradioButton.Location = new System.Drawing.Point(19, 140);
            this.whitepenradioButton.Name = "whitepenradioButton";
            this.whitepenradioButton.Size = new System.Drawing.Size(62, 20);
            this.whitepenradioButton.TabIndex = 4;
            this.whitepenradioButton.Text = "White";
            this.whitepenradioButton.UseVisualStyleBackColor = true;
            // 
            // greenpenradioButton
            // 
            this.greenpenradioButton.AutoSize = true;
            this.greenpenradioButton.Location = new System.Drawing.Point(19, 113);
            this.greenpenradioButton.Name = "greenpenradioButton";
            this.greenpenradioButton.Size = new System.Drawing.Size(65, 20);
            this.greenpenradioButton.TabIndex = 3;
            this.greenpenradioButton.Text = "Green";
            this.greenpenradioButton.UseVisualStyleBackColor = true;
            // 
            // bluepenradioButton
            // 
            this.bluepenradioButton.AutoSize = true;
            this.bluepenradioButton.Location = new System.Drawing.Point(19, 86);
            this.bluepenradioButton.Name = "bluepenradioButton";
            this.bluepenradioButton.Size = new System.Drawing.Size(55, 20);
            this.bluepenradioButton.TabIndex = 2;
            this.bluepenradioButton.Text = "Blue";
            this.bluepenradioButton.UseVisualStyleBackColor = true;
            // 
            // redpenradioButton
            // 
            this.redpenradioButton.AutoSize = true;
            this.redpenradioButton.Location = new System.Drawing.Point(19, 60);
            this.redpenradioButton.Name = "redpenradioButton";
            this.redpenradioButton.Size = new System.Drawing.Size(54, 20);
            this.redpenradioButton.TabIndex = 1;
            this.redpenradioButton.Text = "Red";
            this.redpenradioButton.UseVisualStyleBackColor = true;
            // 
            // blackpenradioButton
            // 
            this.blackpenradioButton.AutoSize = true;
            this.blackpenradioButton.Checked = true;
            this.blackpenradioButton.Location = new System.Drawing.Point(19, 34);
            this.blackpenradioButton.Name = "blackpenradioButton";
            this.blackpenradioButton.Size = new System.Drawing.Size(62, 20);
            this.blackpenradioButton.TabIndex = 0;
            this.blackpenradioButton.TabStop = true;
            this.blackpenradioButton.Text = "Black";
            this.blackpenradioButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizerToolStripMenuItem,
            this.clearPanelToolStripMenuItem,
            this.exitWindowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customizerToolStripMenuItem
            // 
            this.customizerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeColorToolStripMenuItem});
            this.customizerToolStripMenuItem.Name = "customizerToolStripMenuItem";
            this.customizerToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.customizerToolStripMenuItem.Text = "customizer";
            // 
            // customizeColorToolStripMenuItem
            // 
            this.customizeColorToolStripMenuItem.Name = "customizeColorToolStripMenuItem";
            this.customizeColorToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.customizeColorToolStripMenuItem.Text = "customize color";
            // 
            // clearPanelToolStripMenuItem
            // 
            this.clearPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.clearPanelToolStripMenuItem.Name = "clearPanelToolStripMenuItem";
            this.clearPanelToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.clearPanelToolStripMenuItem.Text = "clear panel";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.clearToolStripMenuItem.Text = "clear";
            // 
            // exitWindowToolStripMenuItem
            // 
            this.exitWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.exitWindowToolStripMenuItem.Name = "exitWindowToolStripMenuItem";
            this.exitWindowToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.exitWindowToolStripMenuItem.Text = "exit window";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // drawingpanel
            // 
            this.drawingpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingpanel.Location = new System.Drawing.Point(326, 27);
            this.drawingpanel.Name = "drawingpanel";
            this.drawingpanel.Size = new System.Drawing.Size(462, 411);
            this.drawingpanel.TabIndex = 2;
            // 
            // sizegroupBox
            // 
            this.sizegroupBox.Controls.Add(this.sizeeightradioButton);
            this.sizegroupBox.Controls.Add(this.sizesixradioButton);
            this.sizegroupBox.Controls.Add(this.sizefourradioButton);
            this.sizegroupBox.Controls.Add(this.sizetworadioButton);
            this.sizegroupBox.Location = new System.Drawing.Point(12, 231);
            this.sizegroupBox.Name = "sizegroupBox";
            this.sizegroupBox.Size = new System.Drawing.Size(308, 207);
            this.sizegroupBox.TabIndex = 3;
            this.sizegroupBox.TabStop = false;
            this.sizegroupBox.Text = "Size";
            // 
            // sizeeightradioButton
            // 
            this.sizeeightradioButton.AutoSize = true;
            this.sizeeightradioButton.Location = new System.Drawing.Point(19, 103);
            this.sizeeightradioButton.Name = "sizeeightradioButton";
            this.sizeeightradioButton.Size = new System.Drawing.Size(43, 20);
            this.sizeeightradioButton.TabIndex = 3;
            this.sizeeightradioButton.Text = "XL";
            this.sizeeightradioButton.UseVisualStyleBackColor = true;
            // 
            // sizesixradioButton
            // 
            this.sizesixradioButton.AutoSize = true;
            this.sizesixradioButton.Location = new System.Drawing.Point(19, 76);
            this.sizesixradioButton.Name = "sizesixradioButton";
            this.sizesixradioButton.Size = new System.Drawing.Size(63, 20);
            this.sizesixradioButton.TabIndex = 2;
            this.sizesixradioButton.Text = "Large";
            this.sizesixradioButton.UseVisualStyleBackColor = true;
            // 
            // sizefourradioButton
            // 
            this.sizefourradioButton.AutoSize = true;
            this.sizefourradioButton.Checked = true;
            this.sizefourradioButton.Location = new System.Drawing.Point(19, 49);
            this.sizefourradioButton.Name = "sizefourradioButton";
            this.sizefourradioButton.Size = new System.Drawing.Size(76, 20);
            this.sizefourradioButton.TabIndex = 1;
            this.sizefourradioButton.TabStop = true;
            this.sizefourradioButton.Text = "Medium";
            this.sizefourradioButton.UseVisualStyleBackColor = true;
            // 
            // sizetworadioButton
            // 
            this.sizetworadioButton.AutoSize = true;
            this.sizetworadioButton.Location = new System.Drawing.Point(19, 22);
            this.sizetworadioButton.Name = "sizetworadioButton";
            this.sizetworadioButton.Size = new System.Drawing.Size(62, 20);
            this.sizetworadioButton.TabIndex = 0;
            this.sizetworadioButton.Text = "Small";
            this.sizetworadioButton.UseVisualStyleBackColor = true;
            // 
            // colorpanelgroupBox
            // 
            this.colorpanelgroupBox.Controls.Add(this.fuchsiapanelradioButton);
            this.colorpanelgroupBox.Controls.Add(this.darkgraypanelradioButton);
            this.colorpanelgroupBox.Controls.Add(this.blackpanelradioButton);
            this.colorpanelgroupBox.Controls.Add(this.whitepanelradioButton);
            this.colorpanelgroupBox.Location = new System.Drawing.Point(168, 30);
            this.colorpanelgroupBox.Name = "colorpanelgroupBox";
            this.colorpanelgroupBox.Size = new System.Drawing.Size(152, 195);
            this.colorpanelgroupBox.TabIndex = 4;
            this.colorpanelgroupBox.TabStop = false;
            this.colorpanelgroupBox.Text = "Color Panel";
            // 
            // blackpanelradioButton
            // 
            this.blackpanelradioButton.AutoSize = true;
            this.blackpanelradioButton.Location = new System.Drawing.Point(16, 58);
            this.blackpanelradioButton.Name = "blackpanelradioButton";
            this.blackpanelradioButton.Size = new System.Drawing.Size(62, 20);
            this.blackpanelradioButton.TabIndex = 1;
            this.blackpanelradioButton.TabStop = true;
            this.blackpanelradioButton.Text = "Black";
            this.blackpanelradioButton.UseVisualStyleBackColor = true;
            // 
            // whitepanelradioButton
            // 
            this.whitepanelradioButton.AutoSize = true;
            this.whitepanelradioButton.Checked = true;
            this.whitepanelradioButton.Location = new System.Drawing.Point(16, 31);
            this.whitepanelradioButton.Name = "whitepanelradioButton";
            this.whitepanelradioButton.Size = new System.Drawing.Size(62, 20);
            this.whitepanelradioButton.TabIndex = 0;
            this.whitepanelradioButton.TabStop = true;
            this.whitepanelradioButton.Text = "White";
            this.whitepanelradioButton.UseVisualStyleBackColor = true;
            // 
            // darkgraypanelradioButton
            // 
            this.darkgraypanelradioButton.AutoSize = true;
            this.darkgraypanelradioButton.Location = new System.Drawing.Point(16, 85);
            this.darkgraypanelradioButton.Name = "darkgraypanelradioButton";
            this.darkgraypanelradioButton.Size = new System.Drawing.Size(89, 20);
            this.darkgraypanelradioButton.TabIndex = 2;
            this.darkgraypanelradioButton.TabStop = true;
            this.darkgraypanelradioButton.Text = "Dark Gray";
            this.darkgraypanelradioButton.UseVisualStyleBackColor = true;
            // 
            // fuchsiapanelradioButton
            // 
            this.fuchsiapanelradioButton.AutoSize = true;
            this.fuchsiapanelradioButton.Location = new System.Drawing.Point(16, 112);
            this.fuchsiapanelradioButton.Name = "fuchsiapanelradioButton";
            this.fuchsiapanelradioButton.Size = new System.Drawing.Size(75, 20);
            this.fuchsiapanelradioButton.TabIndex = 3;
            this.fuchsiapanelradioButton.TabStop = true;
            this.fuchsiapanelradioButton.Text = "Fuchsia";
            this.fuchsiapanelradioButton.UseVisualStyleBackColor = true;
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorpanelgroupBox);
            this.Controls.Add(this.sizegroupBox);
            this.Controls.Add(this.drawingpanel);
            this.Controls.Add(this.colorpengroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawingForm";
            this.Text = "Drawing Window";
            this.colorpengroupBox.ResumeLayout(false);
            this.colorpengroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sizegroupBox.ResumeLayout(false);
            this.sizegroupBox.PerformLayout();
            this.colorpanelgroupBox.ResumeLayout(false);
            this.colorpanelgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox colorpengroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Panel drawingpanel;
        private System.Windows.Forms.GroupBox sizegroupBox;
        private System.Windows.Forms.RadioButton whitepenradioButton;
        private System.Windows.Forms.RadioButton greenpenradioButton;
        private System.Windows.Forms.RadioButton bluepenradioButton;
        private System.Windows.Forms.RadioButton redpenradioButton;
        private System.Windows.Forms.RadioButton blackpenradioButton;
        private System.Windows.Forms.GroupBox colorpanelgroupBox;
        private System.Windows.Forms.RadioButton whitepanelradioButton;
        private System.Windows.Forms.RadioButton blackpanelradioButton;
        private System.Windows.Forms.ToolStripMenuItem exitWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton sizeeightradioButton;
        private System.Windows.Forms.RadioButton sizesixradioButton;
        private System.Windows.Forms.RadioButton sizefourradioButton;
        private System.Windows.Forms.RadioButton sizetworadioButton;
        private System.Windows.Forms.RadioButton fuchsiapanelradioButton;
        private System.Windows.Forms.RadioButton darkgraypanelradioButton;
    }
}

