namespace WindowsFormsApp3
{
    partial class Order_Complete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Complete));
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(235, 35);
            this.label1.MinimumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 500);
            this.label1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(63, 556);
            this.label17.MinimumSize = new System.Drawing.Size(430, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(430, 60);
            this.label17.TabIndex = 89;
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(457, 556);
            this.label2.MinimumSize = new System.Drawing.Size(430, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 60);
            this.label2.TabIndex = 90;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Order_Complete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(967, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Order_Complete";
            this.Text = "Order_Complete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
    }
}