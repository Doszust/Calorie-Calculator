namespace CalorieCalculatorWindows
{
    partial class CalorieIntakeSuggesstion
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
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblActivityLevel = new System.Windows.Forms.Label();
            this.cmbActivityLvl = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.MaskedTextBox();
            this.txtWeight = new System.Windows.Forms.MaskedTextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtHeight = new System.Windows.Forms.MaskedTextBox();
            this.lblYrs = new System.Windows.Forms.Label();
            this.lblLbs = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.pnlSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAge.Location = new System.Drawing.Point(14, 11);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(81, 20);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Enter Age";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(14, 44);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(102, 20);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Enter Weight";
            // 
            // lblActivityLevel
            // 
            this.lblActivityLevel.AutoSize = true;
            this.lblActivityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityLevel.Location = new System.Drawing.Point(14, 143);
            this.lblActivityLevel.Name = "lblActivityLevel";
            this.lblActivityLevel.Size = new System.Drawing.Size(99, 20);
            this.lblActivityLevel.TabIndex = 2;
            this.lblActivityLevel.Text = "Activity Level";
            // 
            // cmbActivityLvl
            // 
            this.cmbActivityLvl.FormattingEnabled = true;
            this.cmbActivityLvl.Items.AddRange(new object[] {
            "Sedentary",
            "Light",
            "Moderate",
            "Vigorous"});
            this.cmbActivityLvl.Location = new System.Drawing.Point(143, 143);
            this.cmbActivityLvl.Name = "cmbActivityLvl";
            this.cmbActivityLvl.Size = new System.Drawing.Size(81, 21);
            this.cmbActivityLvl.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(11, 181);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 48);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(143, 181);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 48);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(143, 10);
            this.txtAge.Mask = "09";
            this.txtAge.Name = "txtAge";
            this.txtAge.PromptChar = '-';
            this.txtAge.Size = new System.Drawing.Size(32, 20);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(143, 43);
            this.txtWeight.Mask = "009";
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PromptChar = '-';
            this.txtWeight.Size = new System.Drawing.Size(32, 20);
            this.txtWeight.TabIndex = 9;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(14, 77);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(99, 20);
            this.lblHeight.TabIndex = 10;
            this.lblHeight.Text = "Enter Height";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(14, 110);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(112, 20);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Select Gender";
            // 
            // pnlSex
            // 
            this.pnlSex.Controls.Add(this.radFemale);
            this.pnlSex.Controls.Add(this.radMale);
            this.pnlSex.Location = new System.Drawing.Point(143, 110);
            this.pnlSex.Name = "pnlSex";
            this.pnlSex.Size = new System.Drawing.Size(81, 19);
            this.pnlSex.TabIndex = 12;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(45, 1);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(31, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "F";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(5, 1);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(34, 17);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "M";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(143, 77);
            this.txtHeight.Mask = "00";
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PromptChar = '-';
            this.txtHeight.Size = new System.Drawing.Size(32, 20);
            this.txtHeight.TabIndex = 13;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblYrs
            // 
            this.lblYrs.AutoSize = true;
            this.lblYrs.Location = new System.Drawing.Point(190, 13);
            this.lblYrs.Name = "lblYrs";
            this.lblYrs.Size = new System.Drawing.Size(34, 13);
            this.lblYrs.TabIndex = 14;
            this.lblYrs.Text = "Years";
            this.lblYrs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLbs
            // 
            this.lblLbs.AutoSize = true;
            this.lblLbs.Location = new System.Drawing.Point(181, 46);
            this.lblLbs.Name = "lblLbs";
            this.lblLbs.Size = new System.Drawing.Size(43, 13);
            this.lblLbs.TabIndex = 15;
            this.lblLbs.Text = "Pounds";
            this.lblLbs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Location = new System.Drawing.Point(185, 80);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(39, 13);
            this.lblInches.TabIndex = 16;
            this.lblInches.Text = "Inches";
            this.lblInches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalorieIntakeSuggesstion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 239);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.lblLbs);
            this.Controls.Add(this.lblYrs);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.pnlSex);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbActivityLvl);
            this.Controls.Add(this.lblActivityLevel);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblAge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalorieIntakeSuggesstion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Intake Suggesstion";
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblActivityLevel;
        private System.Windows.Forms.ComboBox cmbActivityLvl;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MaskedTextBox txtAge;
        private System.Windows.Forms.MaskedTextBox txtWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.MaskedTextBox txtHeight;
        private System.Windows.Forms.Label lblYrs;
        private System.Windows.Forms.Label lblLbs;
        private System.Windows.Forms.Label lblInches;
    }
}