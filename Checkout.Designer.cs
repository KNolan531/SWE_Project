namespace WindowsFormsApp3
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.creditCard = new System.Windows.Forms.CheckBox();
            this.checkPayment = new System.Windows.Forms.CheckBox();
            this.cashPayment = new System.Windows.Forms.CheckBox();
            this.savedCard = new System.Windows.Forms.CheckBox();
            this.newCard = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.MaximumSize = new System.Drawing.Size(300, 500);
            this.label2.MinimumSize = new System.Drawing.Size(190, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 200);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(459, 88);
            this.label3.MinimumSize = new System.Drawing.Size(430, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 80);
            this.label3.TabIndex = 6;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.Location = new System.Drawing.Point(1223, 27);
            this.label25.MinimumSize = new System.Drawing.Size(100, 100);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 100);
            this.label25.TabIndex = 54;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(1129, 23);
            this.label24.MinimumSize = new System.Drawing.Size(70, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 100);
            this.label24.TabIndex = 53;
            this.label24.Text = "label24";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Image = ((System.Drawing.Image)(resources.GetObject("label23.Image")));
            this.label23.Location = new System.Drawing.Point(1025, 27);
            this.label23.MinimumSize = new System.Drawing.Size(70, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 100);
            this.label23.TabIndex = 52;
            this.label23.Text = "label23";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(424, 195);
            this.label1.MinimumSize = new System.Drawing.Size(500, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 200);
            this.label1.TabIndex = 55;
            // 
            // creditCard
            // 
            this.creditCard.AutoSize = true;
            this.creditCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.creditCard.FlatAppearance.BorderSize = 0;
            this.creditCard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.creditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCard.ForeColor = System.Drawing.SystemColors.Window;
            this.creditCard.Location = new System.Drawing.Point(490, 463);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(134, 28);
            this.creditCard.TabIndex = 66;
            this.creditCard.Text = "Credit Card";
            this.creditCard.UseVisualStyleBackColor = true;
            // 
            // checkPayment
            // 
            this.checkPayment.AutoSize = true;
            this.checkPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkPayment.FlatAppearance.BorderSize = 0;
            this.checkPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.checkPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPayment.ForeColor = System.Drawing.SystemColors.Window;
            this.checkPayment.Location = new System.Drawing.Point(490, 429);
            this.checkPayment.Name = "checkPayment";
            this.checkPayment.Size = new System.Drawing.Size(88, 28);
            this.checkPayment.TabIndex = 65;
            this.checkPayment.Text = "Check";
            this.checkPayment.UseVisualStyleBackColor = true;
            // 
            // cashPayment
            // 
            this.cashPayment.AutoSize = true;
            this.cashPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cashPayment.FlatAppearance.BorderSize = 0;
            this.cashPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cashPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashPayment.ForeColor = System.Drawing.SystemColors.Window;
            this.cashPayment.Location = new System.Drawing.Point(490, 395);
            this.cashPayment.Name = "cashPayment";
            this.cashPayment.Size = new System.Drawing.Size(76, 28);
            this.cashPayment.TabIndex = 64;
            this.cashPayment.Text = "Cash";
            this.cashPayment.UseVisualStyleBackColor = true;
            // 
            // savedCard
            // 
            this.savedCard.AutoSize = true;
            this.savedCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.savedCard.FlatAppearance.BorderSize = 0;
            this.savedCard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.savedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedCard.ForeColor = System.Drawing.SystemColors.Window;
            this.savedCard.Location = new System.Drawing.Point(738, 432);
            this.savedCard.Name = "savedCard";
            this.savedCard.Size = new System.Drawing.Size(137, 28);
            this.savedCard.TabIndex = 68;
            this.savedCard.Text = "Saved Card";
            this.savedCard.UseVisualStyleBackColor = true;
            // 
            // newCard
            // 
            this.newCard.AutoSize = true;
            this.newCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newCard.FlatAppearance.BorderSize = 0;
            this.newCard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.newCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCard.ForeColor = System.Drawing.SystemColors.Window;
            this.newCard.Location = new System.Drawing.Point(738, 398);
            this.newCard.Name = "newCard";
            this.newCard.Size = new System.Drawing.Size(121, 28);
            this.newCard.TabIndex = 67;
            this.newCard.Text = "New Card";
            this.newCard.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.Location = new System.Drawing.Point(445, 557);
            this.label17.MinimumSize = new System.Drawing.Size(430, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(430, 60);
            this.label17.TabIndex = 89;
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1351, 762);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.savedCard);
            this.Controls.Add(this.newCard);
            this.Controls.Add(this.creditCard);
            this.Controls.Add(this.checkPayment);
            this.Controls.Add(this.cashPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox creditCard;
        private System.Windows.Forms.CheckBox checkPayment;
        private System.Windows.Forms.CheckBox cashPayment;
        private System.Windows.Forms.CheckBox savedCard;
        private System.Windows.Forms.CheckBox newCard;
        private System.Windows.Forms.Label label17;
    }
}