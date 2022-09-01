namespace assignment_4
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_black = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productCard2 = new assignment_4.ProductCard();
            this.productCard1 = new assignment_4.ProductCard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_black);
            this.panel1.Controls.Add(this.lbl_green);
            this.panel1.Controls.Add(this.lbl_blue);
            this.panel1.Controls.Add(this.lbl_red);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 559);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(12, 241);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(48, 48);
            this.panel6.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(12, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(48, 44);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(12, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 44);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 46);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_black
            // 
            this.lbl_black.AutoSize = true;
            this.lbl_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_black.Location = new System.Drawing.Point(80, 264);
            this.lbl_black.Name = "lbl_black";
            this.lbl_black.Size = new System.Drawing.Size(60, 25);
            this.lbl_black.TabIndex = 3;
            this.lbl_black.Text = "Black";
            this.lbl_black.Click += new System.EventHandler(this.lbl_black_Click);
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.Location = new System.Drawing.Point(80, 199);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(66, 25);
            this.lbl_green.TabIndex = 2;
            this.lbl_green.Text = "Green";
            this.lbl_green.Click += new System.EventHandler(this.lbl_green_Click);
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.Location = new System.Drawing.Point(80, 141);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(51, 25);
            this.lbl_blue.TabIndex = 1;
            this.lbl_blue.Text = "Blue";
            this.lbl_blue.Click += new System.EventHandler(this.lbl_blue_Click);
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.Location = new System.Drawing.Point(84, 79);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(47, 25);
            this.lbl_red.TabIndex = 0;
            this.lbl_red.Text = "Red";
            this.lbl_red.Click += new System.EventHandler(this.lbl_red_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.productCard2);
            this.panel2.Controls.Add(this.productCard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 559);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // productCard2
            // 
            this.productCard2.Description = null;
            this.productCard2.Location = new System.Drawing.Point(68, 302);
            this.productCard2.Name = "productCard2";
            this.productCard2.Price = null;
            this.productCard2.Size = new System.Drawing.Size(392, 202);
            this.productCard2.TabIndex = 1;
            this.productCard2.Title = null;
            // 
            // productCard1
            // 
            this.productCard1.Description = null;
            this.productCard1.Location = new System.Drawing.Point(59, 12);
            this.productCard1.Name = "productCard1";
            this.productCard1.Price = null;
            this.productCard1.Size = new System.Drawing.Size(392, 181);
            this.productCard1.TabIndex = 0;
            this.productCard1.Title = null;
            this.productCard1.Load += new System.EventHandler(this.productCard1_Load_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_black;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private ProductCard productCard2;
        private ProductCard productCard1;
    }
}