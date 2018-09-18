namespace Assignment_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nr1txt = new System.Windows.Forms.TextBox();
            this.nr2txt = new System.Windows.Forms.TextBox();
            this.nr3txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.averagelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.button1.Location = new System.Drawing.Point(37, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Calculate average";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number 3:";
            // 
            // nr1txt
            // 
            this.nr1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.nr1txt.Location = new System.Drawing.Point(229, 42);
            this.nr1txt.Name = "nr1txt";
            this.nr1txt.Size = new System.Drawing.Size(100, 25);
            this.nr1txt.TabIndex = 4;
            // 
            // nr2txt
            // 
            this.nr2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.nr2txt.Location = new System.Drawing.Point(229, 76);
            this.nr2txt.Name = "nr2txt";
            this.nr2txt.Size = new System.Drawing.Size(100, 25);
            this.nr2txt.TabIndex = 5;
            // 
            // nr3txt
            // 
            this.nr3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.nr3txt.Location = new System.Drawing.Point(229, 112);
            this.nr3txt.Name = "nr3txt";
            this.nr3txt.Size = new System.Drawing.Size(100, 25);
            this.nr3txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(33, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average:";
            // 
            // averagelbl
            // 
            this.averagelbl.AutoSize = true;
            this.averagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.averagelbl.Location = new System.Drawing.Point(278, 209);
            this.averagelbl.Name = "averagelbl";
            this.averagelbl.Size = new System.Drawing.Size(0, 20);
            this.averagelbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 254);
            this.Controls.Add(this.averagelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nr3txt);
            this.Controls.Add(this.nr2txt);
            this.Controls.Add(this.nr1txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Sequence - Assignment 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nr1txt;
        private System.Windows.Forms.TextBox nr2txt;
        private System.Windows.Forms.TextBox nr3txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label averagelbl;
    }
}

