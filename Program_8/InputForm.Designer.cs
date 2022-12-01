namespace Program_8
{
    partial class InputForm
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
            this.okbutton = new System.Windows.Forms.Button();
            this.userControlInput1 = new WindowsFormsControlLibraryProgram_8.UserControlInput();
            this.SuspendLayout();
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(24, 191);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 1;
            this.okbutton.Text = "ok";
            this.okbutton.UseVisualStyleBackColor = true;
            // 
            // userControlInput1
            // 
            this.userControlInput1.Location = new System.Drawing.Point(12, -3);
            this.userControlInput1.Name = "userControlInput1";
            this.userControlInput1.Size = new System.Drawing.Size(590, 207);
            this.userControlInput1.TabIndex = 0;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 226);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.userControlInput1);
            this.Name = "InputForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibraryProgram_8.UserControlInput userControlInput1;
        private System.Windows.Forms.Button okbutton;
    }
}