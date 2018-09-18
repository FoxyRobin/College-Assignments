namespace Assignment_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VATlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.priceask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(53, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.pricelbl.Location = new System.Drawing.Point(443, 165);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(0, 20);
            this.pricelbl.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(53, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "VAT:";
            // 
            // VATlbl
            // 
            this.VATlbl.AutoSize = true;
            this.VATlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.VATlbl.Location = new System.Drawing.Point(443, 205);
            this.VATlbl.Name = "VATlbl";
            this.VATlbl.Size = new System.Drawing.Size(0, 20);
            this.VATlbl.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label6.Location = new System.Drawing.Point(53, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.totallbl.Location = new System.Drawing.Point(443, 247);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(0, 20);
            this.totallbl.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.button1.Location = new System.Drawing.Point(57, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Determine VAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceask
            // 
            this.priceask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.priceask.Location = new System.Drawing.Point(388, 45);
            this.priceask.Name = "priceask";
            this.priceask.Size = new System.Drawing.Size(100, 25);
            this.priceask.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 311);
            this.Controls.Add(this.priceask);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VATlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sequence - Assignment 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VATlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox priceask;
    }
}

