namespace Assignment_7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.erasebtn = new System.Windows.Forms.Button();
            this.calcbtn = new System.Windows.Forms.Button();
            this.startkmtxt = new System.Windows.Forms.TextBox();
            this.endkmtxt = new System.Windows.Forms.TextBox();
            this.pricekmtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceexlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VATlbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.priceinlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(40, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 10);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "End km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price / km";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // erasebtn
            // 
            this.erasebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.erasebtn.Location = new System.Drawing.Point(339, 50);
            this.erasebtn.Name = "erasebtn";
            this.erasebtn.Size = new System.Drawing.Size(97, 32);
            this.erasebtn.TabIndex = 4;
            this.erasebtn.Text = "&Erase";
            this.erasebtn.UseVisualStyleBackColor = true;
            this.erasebtn.Click += new System.EventHandler(this.erasebtn_Click);
            // 
            // calcbtn
            // 
            this.calcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.calcbtn.Location = new System.Drawing.Point(339, 131);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(97, 32);
            this.calcbtn.TabIndex = 5;
            this.calcbtn.Text = "&Calculate";
            this.calcbtn.UseVisualStyleBackColor = true;
            this.calcbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // startkmtxt
            // 
            this.startkmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.startkmtxt.Location = new System.Drawing.Point(184, 54);
            this.startkmtxt.Name = "startkmtxt";
            this.startkmtxt.Size = new System.Drawing.Size(100, 25);
            this.startkmtxt.TabIndex = 6;
            // 
            // endkmtxt
            // 
            this.endkmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.endkmtxt.Location = new System.Drawing.Point(184, 95);
            this.endkmtxt.Name = "endkmtxt";
            this.endkmtxt.Size = new System.Drawing.Size(100, 25);
            this.endkmtxt.TabIndex = 7;
            // 
            // pricekmtxt
            // 
            this.pricekmtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.pricekmtxt.Location = new System.Drawing.Point(184, 133);
            this.pricekmtxt.Name = "pricekmtxt";
            this.pricekmtxt.Size = new System.Drawing.Size(100, 25);
            this.pricekmtxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(46, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price excl VAT";
            // 
            // priceexlbl
            // 
            this.priceexlbl.AutoSize = true;
            this.priceexlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.priceexlbl.Location = new System.Drawing.Point(46, 249);
            this.priceexlbl.Name = "priceexlbl";
            this.priceexlbl.Size = new System.Drawing.Size(0, 20);
            this.priceexlbl.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.Location = new System.Drawing.Point(203, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "VAT";
            // 
            // VATlbl
            // 
            this.VATlbl.AutoSize = true;
            this.VATlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.VATlbl.Location = new System.Drawing.Point(203, 249);
            this.VATlbl.Name = "VATlbl";
            this.VATlbl.Size = new System.Drawing.Size(0, 20);
            this.VATlbl.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label8.Location = new System.Drawing.Point(330, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Price incl VAT";
            // 
            // priceinlbl
            // 
            this.priceinlbl.AutoSize = true;
            this.priceinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.priceinlbl.Location = new System.Drawing.Point(330, 249);
            this.priceinlbl.Name = "priceinlbl";
            this.priceinlbl.Size = new System.Drawing.Size(0, 20);
            this.priceinlbl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 286);
            this.Controls.Add(this.priceinlbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VATlbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceexlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricekmtxt);
            this.Controls.Add(this.endkmtxt);
            this.Controls.Add(this.startkmtxt);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.erasebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sequence - Assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button erasebtn;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.TextBox startkmtxt;
        private System.Windows.Forms.TextBox endkmtxt;
        private System.Windows.Forms.TextBox pricekmtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label priceexlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label VATlbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label priceinlbl;
    }
}

