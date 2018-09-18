namespace Assignment_6
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
            this.hourlbl = new System.Windows.Forms.Label();
            this.timetxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.minlbl = new System.Windows.Forms.Label();
            this.seclbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seconds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(48, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "hours : minutes : seconds";
            // 
            // hourlbl
            // 
            this.hourlbl.AutoSize = true;
            this.hourlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.hourlbl.Location = new System.Drawing.Point(47, 200);
            this.hourlbl.Name = "hourlbl";
            this.hourlbl.Size = new System.Drawing.Size(0, 20);
            this.hourlbl.TabIndex = 2;
            // 
            // timetxt
            // 
            this.timetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.timetxt.Location = new System.Drawing.Point(193, 48);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(100, 25);
            this.timetxt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.button1.Location = new System.Drawing.Point(51, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Calculate time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minlbl
            // 
            this.minlbl.AutoSize = true;
            this.minlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.minlbl.Location = new System.Drawing.Point(105, 200);
            this.minlbl.Name = "minlbl";
            this.minlbl.Size = new System.Drawing.Size(0, 20);
            this.minlbl.TabIndex = 5;
            this.minlbl.Click += new System.EventHandler(this.minlbl_Click);
            // 
            // seclbl
            // 
            this.seclbl.AutoSize = true;
            this.seclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.seclbl.Location = new System.Drawing.Point(177, 200);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(0, 20);
            this.seclbl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(93, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label5.Location = new System.Drawing.Point(163, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seclbl);
            this.Controls.Add(this.minlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.hourlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sequence - Assignment 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hourlbl;
        private System.Windows.Forms.TextBox timetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label minlbl;
        private System.Windows.Forms.Label seclbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

