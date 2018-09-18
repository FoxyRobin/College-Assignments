namespace Assignment_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totallbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VATlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shirttxt = new System.Windows.Forms.TextBox();
            this.jeanstxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of T-shirts (x €30,-):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number ofjeans   (x €100,-):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totallbl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.VATlbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pricelbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.groupBox1.Location = new System.Drawing.Point(36, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(284, 137);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(0, 20);
            this.totallbl.TabIndex = 7;
            this.totallbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total price:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VATlbl
            // 
            this.VATlbl.AutoSize = true;
            this.VATlbl.Location = new System.Drawing.Point(293, 94);
            this.VATlbl.Name = "VATlbl";
            this.VATlbl.Size = new System.Drawing.Size(0, 20);
            this.VATlbl.TabIndex = 5;
            this.VATlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "VAT:";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(293, 63);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(0, 20);
            this.pricelbl.TabIndex = 3;
            this.pricelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price:";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.datelbl.Location = new System.Drawing.Point(175, 32);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(169, 20);
            this.datelbl.TabIndex = 1;
            this.datelbl.Text = "                                        ";
            this.datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(36, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shirttxt
            // 
            this.shirttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.shirttxt.Location = new System.Drawing.Point(280, 31);
            this.shirttxt.Name = "shirttxt";
            this.shirttxt.Size = new System.Drawing.Size(100, 25);
            this.shirttxt.TabIndex = 4;
            // 
            // jeanstxt
            // 
            this.jeanstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.jeanstxt.Location = new System.Drawing.Point(280, 74);
            this.jeanstxt.Name = "jeanstxt";
            this.jeanstxt.Size = new System.Drawing.Size(100, 25);
            this.jeanstxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 422);
            this.Controls.Add(this.jeanstxt);
            this.Controls.Add(this.shirttxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sequence - Assignment 8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label VATlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox shirttxt;
        private System.Windows.Forms.TextBox jeanstxt;
    }
}

