namespace Assignment_9x
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.radioBtn_fball = new System.Windows.Forms.RadioButton();
            this.radioBtn_hball = new System.Windows.Forms.RadioButton();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_ms_dur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btn_calc.Location = new System.Drawing.Point(37, 226);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(311, 48);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "&Calculate Fee";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioBtn_fball
            // 
            this.radioBtn_fball.AutoSize = true;
            this.radioBtn_fball.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.radioBtn_fball.Location = new System.Drawing.Point(255, 47);
            this.radioBtn_fball.Name = "radioBtn_fball";
            this.radioBtn_fball.Size = new System.Drawing.Size(87, 24);
            this.radioBtn_fball.TabIndex = 1;
            this.radioBtn_fball.TabStop = true;
            this.radioBtn_fball.Text = "Football";
            this.radioBtn_fball.UseVisualStyleBackColor = true;
            // 
            // radioBtn_hball
            // 
            this.radioBtn_hball.AutoSize = true;
            this.radioBtn_hball.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.radioBtn_hball.Location = new System.Drawing.Point(255, 77);
            this.radioBtn_hball.Name = "radioBtn_hball";
            this.radioBtn_hball.Size = new System.Drawing.Size(93, 24);
            this.radioBtn_hball.TabIndex = 2;
            this.radioBtn_hball.TabStop = true;
            this.radioBtn_hball.Text = "Handball";
            this.radioBtn_hball.UseVisualStyleBackColor = true;
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txt_age.Location = new System.Drawing.Point(255, 126);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 25);
            this.txt_age.TabIndex = 3;
            // 
            // txt_ms_dur
            // 
            this.txt_ms_dur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.txt_ms_dur.Location = new System.Drawing.Point(255, 164);
            this.txt_ms_dur.Name = "txt_ms_dur";
            this.txt_ms_dur.Size = new System.Drawing.Size(100, 25);
            this.txt_ms_dur.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(37, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Membership duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.Location = new System.Drawing.Point(33, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fee to be paid";
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoSize = true;
            this.lbl_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lbl_fee.Location = new System.Drawing.Point(251, 298);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(0, 20);
            this.lbl_fee.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 365);
            this.Controls.Add(this.lbl_fee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ms_dur);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.radioBtn_hball);
            this.Controls.Add(this.radioBtn_fball);
            this.Controls.Add(this.btn_calc);
            this.Name = "Form1";
            this.Text = "Selection assignment 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.RadioButton radioBtn_fball;
        private System.Windows.Forms.RadioButton radioBtn_hball;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_ms_dur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_fee;
    }
}

