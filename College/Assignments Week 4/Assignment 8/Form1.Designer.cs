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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSum1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSum2 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.btnComp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number (n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(38, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "sum = 1 + 2 + ... + n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSum1
            // 
            this.lblSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSum1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSum1.Location = new System.Drawing.Point(311, 180);
            this.lblSum1.Name = "lblSum1";
            this.lblSum1.Size = new System.Drawing.Size(100, 23);
            this.lblSum1.TabIndex = 2;
            this.lblSum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(38, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "sum = n * (n + 1) / 2";
            // 
            // lblSum2
            // 
            this.lblSum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSum2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSum2.Location = new System.Drawing.Point(311, 225);
            this.lblSum2.Name = "lblSum2";
            this.lblSum2.Size = new System.Drawing.Size(100, 23);
            this.lblSum2.TabIndex = 4;
            this.lblSum2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinal
            // 
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFinal.Location = new System.Drawing.Point(38, 283);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(373, 36);
            this.lblFinal.TabIndex = 5;
            // 
            // txtNr
            // 
            this.txtNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNr.Location = new System.Drawing.Point(311, 47);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(100, 26);
            this.txtNr.TabIndex = 6;
            // 
            // btnComp
            // 
            this.btnComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnComp.Location = new System.Drawing.Point(42, 105);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(369, 33);
            this.btnComp.TabIndex = 7;
            this.btnComp.Text = "&Compare";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 353);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.txtNr);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblSum2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Iteration assignment 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSum2;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.Button btnComp;
    }
}

