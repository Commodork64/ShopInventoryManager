namespace ShopInventoryManager
{
    partial class Form2
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
            this.txt_HelpBox = new System.Windows.Forms.TextBox();
            this.btn_Dismiss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_HelpBox
            // 
            this.txt_HelpBox.BackColor = System.Drawing.SystemColors.Info;
            this.txt_HelpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_HelpBox.Location = new System.Drawing.Point(12, 12);
            this.txt_HelpBox.Multiline = true;
            this.txt_HelpBox.Name = "txt_HelpBox";
            this.txt_HelpBox.ReadOnly = true;
            this.txt_HelpBox.Size = new System.Drawing.Size(703, 428);
            this.txt_HelpBox.TabIndex = 0;
            // 
            // btn_Dismiss
            // 
            this.btn_Dismiss.Location = new System.Drawing.Point(315, 446);
            this.btn_Dismiss.Name = "btn_Dismiss";
            this.btn_Dismiss.Size = new System.Drawing.Size(127, 50);
            this.btn_Dismiss.TabIndex = 1;
            this.btn_Dismiss.Text = "OK";
            this.btn_Dismiss.UseVisualStyleBackColor = true;
            this.btn_Dismiss.Click += new System.EventHandler(this.btn_Dismiss_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 531);
            this.Controls.Add(this.btn_Dismiss);
            this.Controls.Add(this.txt_HelpBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HelpBox;
        private System.Windows.Forms.Button btn_Dismiss;
    }
}