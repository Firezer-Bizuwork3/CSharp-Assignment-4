﻿namespace assignment_4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.text_number = new System.Windows.Forms.TextBox();
            this.text_IN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_objectname = new System.Windows.Forms.TextBox();
            this.text_count = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.butn_add = new System.Windows.Forms.Button();
            this.butn_canel = new System.Windows.Forms.Button();
            this.butn_reset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chk_options = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory Number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 10, 0, 0, 0, 0);
            // 
            // text_number
            // 
            this.text_number.Location = new System.Drawing.Point(95, 94);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(137, 22);
            this.text_number.TabIndex = 4;
            this.text_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_IN
            // 
            this.text_IN.Location = new System.Drawing.Point(590, 94);
            this.text_IN.Name = "text_IN";
            this.text_IN.Size = new System.Drawing.Size(150, 22);
            this.text_IN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Object Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // text_objectname
            // 
            this.text_objectname.Location = new System.Drawing.Point(95, 200);
            this.text_objectname.Name = "text_objectname";
            this.text_objectname.Size = new System.Drawing.Size(312, 22);
            this.text_objectname.TabIndex = 9;
            this.text_objectname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // text_count
            // 
            this.text_count.Location = new System.Drawing.Point(95, 292);
            this.text_count.Name = "text_count";
            this.text_count.Size = new System.Drawing.Size(137, 22);
            this.text_count.TabIndex = 10;
            // 
            // text_price
            // 
            this.text_price.BackColor = System.Drawing.Color.White;
            this.text_price.Location = new System.Drawing.Point(327, 292);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(161, 22);
            this.text_price.TabIndex = 11;
            // 
            // butn_add
            // 
            this.butn_add.BackColor = System.Drawing.Color.White;
            this.butn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_add.Location = new System.Drawing.Point(104, 376);
            this.butn_add.Name = "butn_add";
            this.butn_add.Size = new System.Drawing.Size(91, 37);
            this.butn_add.TabIndex = 12;
            this.butn_add.Text = "Add";
            this.butn_add.UseVisualStyleBackColor = false;
            this.butn_add.Click += new System.EventHandler(this.butn_add_Click);
            // 
            // butn_canel
            // 
            this.butn_canel.BackColor = System.Drawing.Color.White;
            this.butn_canel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_canel.Location = new System.Drawing.Point(251, 376);
            this.butn_canel.Name = "butn_canel";
            this.butn_canel.Size = new System.Drawing.Size(78, 37);
            this.butn_canel.TabIndex = 13;
            this.butn_canel.Text = "Cancel";
            this.butn_canel.UseVisualStyleBackColor = false;
            this.butn_canel.Click += new System.EventHandler(this.butn_canel_Click);
            // 
            // butn_reset
            // 
            this.butn_reset.BackColor = System.Drawing.Color.White;
            this.butn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_reset.Location = new System.Drawing.Point(393, 376);
            this.butn_reset.Name = "butn_reset";
            this.butn_reset.Size = new System.Drawing.Size(95, 37);
            this.butn_reset.TabIndex = 14;
            this.butn_reset.Text = "Reset";
            this.butn_reset.UseVisualStyleBackColor = false;
            this.butn_reset.Click += new System.EventHandler(this.butn_reset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(609, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 20);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "product_Availability";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chk_options
            // 
            this.chk_options.FormattingEnabled = true;
            this.chk_options.Items.AddRange(new object[] {
            "Product_availability",
            "a",
            "b"});
            this.chk_options.Location = new System.Drawing.Point(594, 200);
            this.chk_options.Name = "chk_options";
            this.chk_options.Size = new System.Drawing.Size(146, 38);
            this.chk_options.TabIndex = 16;
            this.chk_options.SelectedIndexChanged += new System.EventHandler(this.chk_options_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(579, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 97);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(31, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(579, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 113);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment_Method";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(32, 65);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(897, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_options);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butn_reset);
            this.Controls.Add(this.butn_canel);
            this.Controls.Add(this.butn_add);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_count);
            this.Controls.Add(this.text_objectname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_IN);
            this.Controls.Add(this.text_number);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Snow;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox text_number;
        private System.Windows.Forms.TextBox text_IN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_objectname;
        private System.Windows.Forms.TextBox text_count;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.Button butn_add;
        private System.Windows.Forms.Button butn_canel;
        private System.Windows.Forms.Button butn_reset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox chk_options;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

