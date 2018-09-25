namespace erc20_with_bulk_transfer_tester
{
    partial class Form1
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
            this.WrapperContract = new System.Windows.Forms.Button();
            this.NativeBulk = new System.Windows.Forms.Button();
            this.StatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WrapperContract
            // 
            this.WrapperContract.Location = new System.Drawing.Point(127, 199);
            this.WrapperContract.Name = "WrapperContract";
            this.WrapperContract.Size = new System.Drawing.Size(136, 23);
            this.WrapperContract.TabIndex = 0;
            this.WrapperContract.Text = "With wrapper contract";
            this.WrapperContract.UseVisualStyleBackColor = true;
            this.WrapperContract.Click += new System.EventHandler(this.WithWrapperContract_Click);
            // 
            // NativeBulk
            // 
            this.NativeBulk.Location = new System.Drawing.Point(477, 199);
            this.NativeBulk.Name = "NativeBulk";
            this.NativeBulk.Size = new System.Drawing.Size(148, 23);
            this.NativeBulk.TabIndex = 1;
            this.NativeBulk.Text = "Native bulk";
            this.NativeBulk.UseVisualStyleBackColor = true;
            this.NativeBulk.Click += new System.EventHandler(this.NativeBulk_Click);
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Location = new System.Drawing.Point(127, 278);
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(498, 23);
            this.StatusProgressBar.TabIndex = 2;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Location = new System.Drawing.Point(287, 320);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(171, 20);
            this.StatusTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.StatusProgressBar);
            this.Controls.Add(this.NativeBulk);
            this.Controls.Add(this.WrapperContract);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WrapperContract;
        private System.Windows.Forms.Button NativeBulk;
        private System.Windows.Forms.ProgressBar StatusProgressBar;
        private System.Windows.Forms.TextBox StatusTextBox;
    }
}

