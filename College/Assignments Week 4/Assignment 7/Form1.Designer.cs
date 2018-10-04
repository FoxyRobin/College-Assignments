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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSquare = new System.Windows.Forms.Label();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCreate.Location = new System.Drawing.Point(38, 107);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(296, 37);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create square";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Side";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSquare
            // 
            this.lblSquare.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold);
            this.lblSquare.Location = new System.Drawing.Point(33, 147);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(301, 310);
            this.lblSquare.TabIndex = 2;
            this.lblSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSquare.Click += new System.EventHandler(this.lblSquare_Click);
            // 
            // txtNr
            // 
            this.txtNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNr.Location = new System.Drawing.Point(189, 42);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(145, 36);
            this.txtNr.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 466);
            this.Controls.Add(this.txtNr);
            this.Controls.Add(this.lblSquare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Iteration assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSquare;
        private System.Windows.Forms.TextBox txtNr;
    }
}

