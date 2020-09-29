namespace BMICalculator
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblLengte = new System.Windows.Forms.TextBox();
            this.lblGewicht = new System.Windows.Forms.TextBox();
            this.lblLeeftijd = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblAdvies = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBereken.Location = new System.Drawing.Point(277, 313);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(217, 94);
            this.btnBereken.TabIndex = 0;
            this.btnBereken.Text = "BMI Berekenen";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLengte
            // 
            this.lblLengte.Location = new System.Drawing.Point(333, 137);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(100, 22);
            this.lblLengte.TabIndex = 1;
            // 
            // lblGewicht
            // 
            this.lblGewicht.Location = new System.Drawing.Point(333, 186);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(100, 22);
            this.lblGewicht.TabIndex = 2;
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.Location = new System.Drawing.Point(333, 230);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.lblLeeftijd.TabIndex = 3;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(330, 458);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(46, 17);
            this.lblBMI.TabIndex = 4;
            this.lblBMI.Text = "label1";
            // 
            // lblAdvies
            // 
            this.lblAdvies.AutoSize = true;
            this.lblAdvies.Location = new System.Drawing.Point(330, 511);
            this.lblAdvies.Name = "lblAdvies";
            this.lblAdvies.Size = new System.Drawing.Size(46, 17);
            this.lblAdvies.TabIndex = 5;
            this.lblAdvies.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(270, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "BMI Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "lengte in meter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gewicht in kilogram:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Leeftijd:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "BMI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Advies:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(320, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 21);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Man";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(391, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 21);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vrouw";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdvies);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblLeeftijd);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox lblLengte;
        private System.Windows.Forms.TextBox lblGewicht;
        private System.Windows.Forms.TextBox lblLeeftijd;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblAdvies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

