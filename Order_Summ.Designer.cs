namespace WindowsFormsApp3
{
    partial class Order_Summ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Summ));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(506, 26);
            this.label4.MinimumSize = new System.Drawing.Size(430, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 80);
            this.label4.TabIndex = 13;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, -14);
            this.label2.MaximumSize = new System.Drawing.Size(300, 500);
            this.label2.MinimumSize = new System.Drawing.Size(190, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 200);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.Location = new System.Drawing.Point(1290, 9);
            this.label25.MinimumSize = new System.Drawing.Size(100, 100);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 100);
            this.label25.TabIndex = 59;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(1204, 6);
            this.label24.MinimumSize = new System.Drawing.Size(70, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 100);
            this.label24.TabIndex = 58;
            this.label24.Text = "label24";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Image = ((System.Drawing.Image)(resources.GetObject("label23.Image")));
            this.label23.Location = new System.Drawing.Point(1100, 9);
            this.label23.MinimumSize = new System.Drawing.Size(70, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 100);
            this.label23.TabIndex = 57;
            this.label23.Text = "label23";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(208, 127);
            this.label1.MinimumSize = new System.Drawing.Size(980, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(980, 400);
            this.label1.TabIndex = 60;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(489, 661);
            this.label3.MinimumSize = new System.Drawing.Size(510, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 80);
            this.label3.TabIndex = 61;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Order_Summ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1402, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Order_Summ";
            this.Text = "Order_Summ";
            this.Load += new System.EventHandler(this.Order_Summ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}