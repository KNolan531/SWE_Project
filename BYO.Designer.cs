namespace WindowsFormsApp3
{
    partial class BYO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BYO));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sauce = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.crust = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.CheckBox();
            this.t3 = new System.Windows.Forms.CheckBox();
            this.t4 = new System.Windows.Forms.CheckBox();
            this.t5 = new System.Windows.Forms.CheckBox();
            this.t6 = new System.Windows.Forms.CheckBox();
            this.t7 = new System.Windows.Forms.CheckBox();
            this.t8 = new System.Windows.Forms.CheckBox();
            this.t9 = new System.Windows.Forms.CheckBox();
            this.t10 = new System.Windows.Forms.CheckBox();
            this.t11 = new System.Windows.Forms.CheckBox();
            this.t12 = new System.Windows.Forms.CheckBox();
            this.t13 = new System.Windows.Forms.CheckBox();
            this.t14 = new System.Windows.Forms.CheckBox();
            this.t15 = new System.Windows.Forms.CheckBox();
            this.t16 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(433, 18);
            this.label3.MinimumSize = new System.Drawing.Size(430, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 80);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.MaximumSize = new System.Drawing.Size(300, 500);
            this.label2.MinimumSize = new System.Drawing.Size(190, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 200);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(412, 647);
            this.label1.MinimumSize = new System.Drawing.Size(430, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 60);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(534, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose your Size!";
            // 
            // size
            // 
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "Small($8.99)",
            "Medium($11.99)",
            "Large($14.99)",
            "Xtra-Large($17.99) "});
            this.size.Location = new System.Drawing.Point(544, 125);
            this.size.Name = "size";
            this.size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.size.Size = new System.Drawing.Size(168, 28);
            this.size.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(534, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choose your Sauce!";
            // 
            // sauce
            // 
            this.sauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sauce.FormattingEnabled = true;
            this.sauce.Items.AddRange(new object[] {
            "Red Sauce",
            "Alfredo",
            "Barbecue"});
            this.sauce.Location = new System.Drawing.Point(561, 206);
            this.sauce.Name = "sauce";
            this.sauce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sauce.Size = new System.Drawing.Size(140, 32);
            this.sauce.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(199, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "MEATS ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(199, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "VEGGIES/OTHER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(534, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Special Notes";
            // 
            // notes
            // 
            this.notes.AccessibleName = "";
            this.notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.notes.Location = new System.Drawing.Point(513, 565);
            this.notes.MaximumSize = new System.Drawing.Size(250, 100);
            this.notes.MinimumSize = new System.Drawing.Size(150, 70);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(226, 70);
            this.notes.TabIndex = 17;
            this.notes.TextChanged += new System.EventHandler(this.notes_TextChanged);
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t1.FlatAppearance.BorderSize = 0;
            this.t1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.ForeColor = System.Drawing.SystemColors.Window;
            this.t1.Location = new System.Drawing.Point(245, 362);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(126, 28);
            this.t1.TabIndex = 24;
            this.t1.Text = "Pepperoni";
            this.t1.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Image = ((System.Drawing.Image)(resources.GetObject("label23.Image")));
            this.label23.Location = new System.Drawing.Point(25, 589);
            this.label23.MinimumSize = new System.Drawing.Size(70, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 100);
            this.label23.TabIndex = 46;
            this.label23.Text = "label23";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(129, 585);
            this.label24.MinimumSize = new System.Drawing.Size(70, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 100);
            this.label24.TabIndex = 47;
            this.label24.Text = "label24";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.Location = new System.Drawing.Point(223, 589);
            this.label25.MinimumSize = new System.Drawing.Size(100, 100);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 100);
            this.label25.TabIndex = 48;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            this.label26.Location = new System.Drawing.Point(534, 249);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(215, 25);
            this.label26.TabIndex = 49;
            this.label26.Text = "Choose your Crust!";
            // 
            // crust
            // 
            this.crust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crust.FormattingEnabled = true;
            this.crust.Items.AddRange(new object[] {
            "Hand-Tossed",
            "Pan ",
            "Thin "});
            this.crust.Location = new System.Drawing.Point(562, 277);
            this.crust.Name = "crust";
            this.crust.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.crust.Size = new System.Drawing.Size(140, 32);
            this.crust.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Window;
            this.label28.Location = new System.Drawing.Point(282, 328);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(121, 20);
            this.label28.TabIndex = 53;
            this.label28.Text = "($1 per topping)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.Window;
            this.label29.Location = new System.Drawing.Point(388, 400);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(121, 20);
            this.label29.TabIndex = 54;
            this.label29.Text = "($1 per topping)";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t2.FlatAppearance.BorderSize = 0;
            this.t2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.ForeColor = System.Drawing.SystemColors.Window;
            this.t2.Location = new System.Drawing.Point(396, 363);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(71, 28);
            this.t2.TabIndex = 55;
            this.t2.Text = "Beef";
            this.t2.UseVisualStyleBackColor = true;
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t3.FlatAppearance.BorderSize = 0;
            this.t3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.ForeColor = System.Drawing.SystemColors.Window;
            this.t3.Location = new System.Drawing.Point(495, 364);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(110, 28);
            this.t3.TabIndex = 56;
            this.t3.Text = "Sausage";
            this.t3.UseVisualStyleBackColor = true;
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t4.FlatAppearance.BorderSize = 0;
            this.t4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.ForeColor = System.Drawing.SystemColors.Window;
            this.t4.Location = new System.Drawing.Point(626, 366);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(72, 28);
            this.t4.TabIndex = 57;
            this.t4.Text = "Ham";
            this.t4.UseVisualStyleBackColor = true;
            // 
            // t5
            // 
            this.t5.AutoSize = true;
            this.t5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t5.FlatAppearance.BorderSize = 0;
            this.t5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5.ForeColor = System.Drawing.SystemColors.Window;
            this.t5.Location = new System.Drawing.Point(721, 367);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(88, 28);
            this.t5.TabIndex = 58;
            this.t5.Text = "Bacon";
            this.t5.UseVisualStyleBackColor = true;
            // 
            // t6
            // 
            this.t6.AutoSize = true;
            this.t6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t6.FlatAppearance.BorderSize = 0;
            this.t6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6.ForeColor = System.Drawing.SystemColors.Window;
            this.t6.Location = new System.Drawing.Point(825, 368);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(105, 28);
            this.t6.TabIndex = 59;
            this.t6.Text = "Chicken";
            this.t6.UseVisualStyleBackColor = true;
            // 
            // t7
            // 
            this.t7.AutoSize = true;
            this.t7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t7.FlatAppearance.BorderSize = 0;
            this.t7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t7.ForeColor = System.Drawing.SystemColors.Window;
            this.t7.Location = new System.Drawing.Point(234, 435);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(138, 28);
            this.t7.TabIndex = 60;
            this.t7.Text = "Mushrooms";
            this.t7.UseVisualStyleBackColor = true;
            // 
            // t8
            // 
            this.t8.AutoSize = true;
            this.t8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t8.FlatAppearance.BorderSize = 0;
            this.t8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t8.ForeColor = System.Drawing.SystemColors.Window;
            this.t8.Location = new System.Drawing.Point(384, 434);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(96, 28);
            this.t8.TabIndex = 61;
            this.t8.Text = "Onions";
            this.t8.UseVisualStyleBackColor = true;
            // 
            // t9
            // 
            this.t9.AutoSize = true;
            this.t9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t9.FlatAppearance.BorderSize = 0;
            this.t9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t9.ForeColor = System.Drawing.SystemColors.Window;
            this.t9.Location = new System.Drawing.Point(495, 435);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(171, 28);
            this.t9.TabIndex = 62;
            this.t9.Text = "Green Peppers";
            this.t9.UseVisualStyleBackColor = true;
            // 
            // t10
            // 
            this.t10.AutoSize = true;
            this.t10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t10.FlatAppearance.BorderSize = 0;
            this.t10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t10.ForeColor = System.Drawing.SystemColors.Window;
            this.t10.Location = new System.Drawing.Point(681, 434);
            this.t10.Name = "t10";
            this.t10.Size = new System.Drawing.Size(99, 28);
            this.t10.TabIndex = 63;
            this.t10.Text = "Tomato";
            this.t10.UseVisualStyleBackColor = true;
            // 
            // t11
            // 
            this.t11.AutoSize = true;
            this.t11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t11.FlatAppearance.BorderSize = 0;
            this.t11.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t11.ForeColor = System.Drawing.SystemColors.Window;
            this.t11.Location = new System.Drawing.Point(786, 434);
            this.t11.Name = "t11";
            this.t11.Size = new System.Drawing.Size(123, 28);
            this.t11.TabIndex = 64;
            this.t11.Text = "Pineapple";
            this.t11.UseVisualStyleBackColor = true;
            // 
            // t12
            // 
            this.t12.AutoSize = true;
            this.t12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t12.FlatAppearance.BorderSize = 0;
            this.t12.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t12.ForeColor = System.Drawing.SystemColors.Window;
            this.t12.Location = new System.Drawing.Point(234, 485);
            this.t12.Name = "t12";
            this.t12.Size = new System.Drawing.Size(143, 28);
            this.t12.TabIndex = 65;
            this.t12.Text = "Black Olives";
            this.t12.UseVisualStyleBackColor = true;
            // 
            // t13
            // 
            this.t13.AutoSize = true;
            this.t13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t13.FlatAppearance.BorderSize = 0;
            this.t13.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t13.ForeColor = System.Drawing.SystemColors.Window;
            this.t13.Location = new System.Drawing.Point(384, 488);
            this.t13.Name = "t13";
            this.t13.Size = new System.Drawing.Size(114, 28);
            this.t13.TabIndex = 66;
            this.t13.Text = "Jalapeno";
            this.t13.UseVisualStyleBackColor = true;
            // 
            // t14
            // 
            this.t14.AutoSize = true;
            this.t14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t14.FlatAppearance.BorderSize = 0;
            this.t14.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t14.ForeColor = System.Drawing.SystemColors.Window;
            this.t14.Location = new System.Drawing.Point(504, 486);
            this.t14.Name = "t14";
            this.t14.Size = new System.Drawing.Size(105, 28);
            this.t14.TabIndex = 67;
            this.t14.Text = "Spinach";
            this.t14.UseVisualStyleBackColor = true;
            // 
            // t15
            // 
            this.t15.AutoSize = true;
            this.t15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t15.FlatAppearance.BorderSize = 0;
            this.t15.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t15.ForeColor = System.Drawing.SystemColors.Window;
            this.t15.Location = new System.Drawing.Point(633, 485);
            this.t15.Name = "t15";
            this.t15.Size = new System.Drawing.Size(155, 28);
            this.t15.TabIndex = 68;
            this.t15.Text = "Extra Cheese";
            this.t15.UseVisualStyleBackColor = true;
            // 
            // t16
            // 
            this.t16.AutoSize = true;
            this.t16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.t16.FlatAppearance.BorderSize = 0;
            this.t16.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.t16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t16.ForeColor = System.Drawing.SystemColors.Window;
            this.t16.Location = new System.Drawing.Point(804, 485);
            this.t16.Name = "t16";
            this.t16.Size = new System.Drawing.Size(148, 28);
            this.t16.TabIndex = 69;
            this.t16.Text = "Feta Cheese";
            this.t16.UseVisualStyleBackColor = true;
            // 
            // BYO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1133, 710);
            this.Controls.Add(this.t16);
            this.Controls.Add(this.t15);
            this.Controls.Add(this.t14);
            this.Controls.Add(this.t13);
            this.Controls.Add(this.t12);
            this.Controls.Add(this.t11);
            this.Controls.Add(this.t10);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.crust);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sauce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BYO";
            this.Text = "BYO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sauce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.CheckBox t1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox crust;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox t2;
        private System.Windows.Forms.CheckBox t3;
        private System.Windows.Forms.CheckBox t4;
        private System.Windows.Forms.CheckBox t5;
        private System.Windows.Forms.CheckBox t6;
        private System.Windows.Forms.CheckBox t7;
        private System.Windows.Forms.CheckBox t8;
        private System.Windows.Forms.CheckBox t9;
        private System.Windows.Forms.CheckBox t10;
        private System.Windows.Forms.CheckBox t11;
        private System.Windows.Forms.CheckBox t12;
        private System.Windows.Forms.CheckBox t13;
        private System.Windows.Forms.CheckBox t14;
        private System.Windows.Forms.CheckBox t15;
        private System.Windows.Forms.CheckBox t16;
    }
}