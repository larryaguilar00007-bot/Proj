
namespace HW4
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobileDisplay = new System.Windows.Forms.TextBox();
            this.txtLastnameDisplay = new System.Windows.Forms.TextBox();
            this.txtFirstnameDisplay = new System.Windows.Forms.TextBox();
            this.pictureBox1Display = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbnMaleDisplay = new System.Windows.Forms.RadioButton();
            this.rbnFemaleDisplay = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxStatusDisplay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtrBirthdayDisplay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLocationDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Display)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIM CARD Registration Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lastname";
            // 
            // txtMobileDisplay
            // 
            this.txtMobileDisplay.Location = new System.Drawing.Point(154, 123);
            this.txtMobileDisplay.Name = "txtMobileDisplay";
            this.txtMobileDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtMobileDisplay.TabIndex = 4;
            // 
            // txtLastnameDisplay
            // 
            this.txtLastnameDisplay.Location = new System.Drawing.Point(319, 158);
            this.txtLastnameDisplay.Name = "txtLastnameDisplay";
            this.txtLastnameDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtLastnameDisplay.TabIndex = 5;
            // 
            // txtFirstnameDisplay
            // 
            this.txtFirstnameDisplay.Location = new System.Drawing.Point(154, 158);
            this.txtFirstnameDisplay.Name = "txtFirstnameDisplay";
            this.txtFirstnameDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtFirstnameDisplay.TabIndex = 6;
            // 
            // pictureBox1Display
            // 
            this.pictureBox1Display.Location = new System.Drawing.Point(344, 39);
            this.pictureBox1Display.Name = "pictureBox1Display";
            this.pictureBox1Display.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1Display.TabIndex = 10;
            this.pictureBox1Display.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sex";
            // 
            // rbnMaleDisplay
            // 
            this.rbnMaleDisplay.AutoSize = true;
            this.rbnMaleDisplay.Location = new System.Drawing.Point(122, 204);
            this.rbnMaleDisplay.Name = "rbnMaleDisplay";
            this.rbnMaleDisplay.Size = new System.Drawing.Size(48, 17);
            this.rbnMaleDisplay.TabIndex = 12;
            this.rbnMaleDisplay.TabStop = true;
            this.rbnMaleDisplay.Text = "Male";
            this.rbnMaleDisplay.UseVisualStyleBackColor = true;
            // 
            // rbnFemaleDisplay
            // 
            this.rbnFemaleDisplay.AutoSize = true;
            this.rbnFemaleDisplay.Location = new System.Drawing.Point(176, 204);
            this.rbnFemaleDisplay.Name = "rbnFemaleDisplay";
            this.rbnFemaleDisplay.Size = new System.Drawing.Size(59, 17);
            this.rbnFemaleDisplay.TabIndex = 13;
            this.rbnFemaleDisplay.TabStop = true;
            this.rbnFemaleDisplay.Text = "Female";
            this.rbnFemaleDisplay.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxStatusDisplay
            // 
            this.cbxStatusDisplay.FormattingEnabled = true;
            this.cbxStatusDisplay.Items.AddRange(new object[] {
            "its Complicated",
            "Singel"});
            this.cbxStatusDisplay.Location = new System.Drawing.Point(319, 201);
            this.cbxStatusDisplay.Name = "cbxStatusDisplay";
            this.cbxStatusDisplay.Size = new System.Drawing.Size(121, 21);
            this.cbxStatusDisplay.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Birtday";
            // 
            // dtrBirthdayDisplay
            // 
            this.dtrBirthdayDisplay.Location = new System.Drawing.Point(139, 239);
            this.dtrBirthdayDisplay.Name = "dtrBirthdayDisplay";
            this.dtrBirthdayDisplay.Size = new System.Drawing.Size(146, 20);
            this.dtrBirthdayDisplay.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Location";
            // 
            // txtLocationDisplay
            // 
            this.txtLocationDisplay.Location = new System.Drawing.Point(145, 274);
            this.txtLocationDisplay.Name = "txtLocationDisplay";
            this.txtLocationDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtLocationDisplay.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLocationDisplay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtrBirthdayDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxStatusDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbnFemaleDisplay);
            this.Controls.Add(this.rbnMaleDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1Display);
            this.Controls.Add(this.txtFirstnameDisplay);
            this.Controls.Add(this.txtLastnameDisplay);
            this.Controls.Add(this.txtMobileDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMobileDisplay;
        private System.Windows.Forms.TextBox txtLastnameDisplay;
        private System.Windows.Forms.TextBox txtFirstnameDisplay;
        private System.Windows.Forms.PictureBox pictureBox1Display;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbnMaleDisplay;
        private System.Windows.Forms.RadioButton rbnFemaleDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxStatusDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtrBirthdayDisplay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLocationDisplay;
    }
}