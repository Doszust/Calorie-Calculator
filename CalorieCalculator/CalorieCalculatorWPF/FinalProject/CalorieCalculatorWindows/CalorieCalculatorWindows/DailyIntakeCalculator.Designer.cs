namespace CalorieCalculatorWindows
{
    partial class DailyIntakeCalculator
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
            this.lblAddCaloriesEaten = new System.Windows.Forms.Label();
            this.lblAddCaloriesLost = new System.Windows.Forms.Label();
            this.btnAddCalories = new System.Windows.Forms.Button();
            this.btnSubtractCalories = new System.Windows.Forms.Button();
            this.lblCaloriesEaten = new System.Windows.Forms.Label();
            this.lblCaloriesLeft = new System.Windows.Forms.Label();
            this.lblCaloriesEatenResult = new System.Windows.Forms.Label();
            this.lblCaloriesLeftResult = new System.Windows.Forms.Label();
            this.lblSuccessfulDays = new System.Windows.Forms.Label();
            this.lblSuccessfulDaysResult = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtAddCalories = new System.Windows.Forms.MaskedTextBox();
            this.txtSubtractCalories = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblAddCaloriesEaten
            // 
            this.lblAddCaloriesEaten.AutoSize = true;
            this.lblAddCaloriesEaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCaloriesEaten.Location = new System.Drawing.Point(67, 9);
            this.lblAddCaloriesEaten.Name = "lblAddCaloriesEaten";
            this.lblAddCaloriesEaten.Size = new System.Drawing.Size(146, 20);
            this.lblAddCaloriesEaten.TabIndex = 0;
            this.lblAddCaloriesEaten.Text = "Add Calories Eaten";
            // 
            // lblAddCaloriesLost
            // 
            this.lblAddCaloriesLost.AutoSize = true;
            this.lblAddCaloriesLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCaloriesLost.Location = new System.Drawing.Point(72, 58);
            this.lblAddCaloriesLost.Name = "lblAddCaloriesLost";
            this.lblAddCaloriesLost.Size = new System.Drawing.Size(134, 20);
            this.lblAddCaloriesLost.TabIndex = 1;
            this.lblAddCaloriesLost.Text = "Add Calories Lost";
            // 
            // btnAddCalories
            // 
            this.btnAddCalories.Location = new System.Drawing.Point(155, 32);
            this.btnAddCalories.Name = "btnAddCalories";
            this.btnAddCalories.Size = new System.Drawing.Size(75, 23);
            this.btnAddCalories.TabIndex = 4;
            this.btnAddCalories.Text = "Enter";
            this.btnAddCalories.UseVisualStyleBackColor = true;
            this.btnAddCalories.Click += new System.EventHandler(this.btnAddCalories_Click);
            // 
            // btnSubtractCalories
            // 
            this.btnSubtractCalories.Location = new System.Drawing.Point(155, 81);
            this.btnSubtractCalories.Name = "btnSubtractCalories";
            this.btnSubtractCalories.Size = new System.Drawing.Size(75, 23);
            this.btnSubtractCalories.TabIndex = 5;
            this.btnSubtractCalories.Text = "Enter";
            this.btnSubtractCalories.UseVisualStyleBackColor = true;
            this.btnSubtractCalories.Click += new System.EventHandler(this.btnSubtractCalories_Click);
            // 
            // lblCaloriesEaten
            // 
            this.lblCaloriesEaten.AutoSize = true;
            this.lblCaloriesEaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesEaten.Location = new System.Drawing.Point(10, 120);
            this.lblCaloriesEaten.Name = "lblCaloriesEaten";
            this.lblCaloriesEaten.Size = new System.Drawing.Size(130, 20);
            this.lblCaloriesEaten.TabIndex = 6;
            this.lblCaloriesEaten.Text = "You Have Eaten:";
            // 
            // lblCaloriesLeft
            // 
            this.lblCaloriesLeft.AutoSize = true;
            this.lblCaloriesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesLeft.Location = new System.Drawing.Point(10, 147);
            this.lblCaloriesLeft.Name = "lblCaloriesLeft";
            this.lblCaloriesLeft.Size = new System.Drawing.Size(133, 20);
            this.lblCaloriesLeft.TabIndex = 7;
            this.lblCaloriesLeft.Text = "You May Still Eat:";
            // 
            // lblCaloriesEatenResult
            // 
            this.lblCaloriesEatenResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaloriesEatenResult.AutoSize = true;
            this.lblCaloriesEatenResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesEatenResult.Location = new System.Drawing.Point(191, 120);
            this.lblCaloriesEatenResult.Name = "lblCaloriesEatenResult";
            this.lblCaloriesEatenResult.Size = new System.Drawing.Size(49, 20);
            this.lblCaloriesEatenResult.TabIndex = 8;
            this.lblCaloriesEatenResult.Text = "0 Cal.";
            this.lblCaloriesEatenResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCaloriesLeftResult
            // 
            this.lblCaloriesLeftResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaloriesLeftResult.AutoSize = true;
            this.lblCaloriesLeftResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesLeftResult.Location = new System.Drawing.Point(191, 147);
            this.lblCaloriesLeftResult.Name = "lblCaloriesLeftResult";
            this.lblCaloriesLeftResult.Size = new System.Drawing.Size(49, 20);
            this.lblCaloriesLeftResult.TabIndex = 9;
            this.lblCaloriesLeftResult.Text = "0 Cal.";
            this.lblCaloriesLeftResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuccessfulDays
            // 
            this.lblSuccessfulDays.AutoSize = true;
            this.lblSuccessfulDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessfulDays.Location = new System.Drawing.Point(10, 174);
            this.lblSuccessfulDays.Name = "lblSuccessfulDays";
            this.lblSuccessfulDays.Size = new System.Drawing.Size(200, 20);
            this.lblSuccessfulDays.TabIndex = 10;
            this.lblSuccessfulDays.Text = "Successful Days In A Row:";
            // 
            // lblSuccessfulDaysResult
            // 
            this.lblSuccessfulDaysResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuccessfulDaysResult.AutoSize = true;
            this.lblSuccessfulDaysResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessfulDaysResult.Location = new System.Drawing.Point(219, 174);
            this.lblSuccessfulDaysResult.Name = "lblSuccessfulDaysResult";
            this.lblSuccessfulDaysResult.Size = new System.Drawing.Size(18, 20);
            this.lblSuccessfulDaysResult.TabIndex = 11;
            this.lblSuccessfulDaysResult.Text = "0";
            this.lblSuccessfulDaysResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(102, 197);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 29);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtAddCalories
            // 
            this.txtAddCalories.Location = new System.Drawing.Point(48, 33);
            this.txtAddCalories.Mask = "9999";
            this.txtAddCalories.Name = "txtAddCalories";
            this.txtAddCalories.Size = new System.Drawing.Size(100, 20);
            this.txtAddCalories.TabIndex = 13;
            // 
            // txtSubtractCalories
            // 
            this.txtSubtractCalories.Location = new System.Drawing.Point(48, 82);
            this.txtSubtractCalories.Mask = "9999";
            this.txtSubtractCalories.Name = "txtSubtractCalories";
            this.txtSubtractCalories.Size = new System.Drawing.Size(100, 20);
            this.txtSubtractCalories.TabIndex = 14;
            // 
            // DailyIntakeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 238);
            this.Controls.Add(this.txtSubtractCalories);
            this.Controls.Add(this.txtAddCalories);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSuccessfulDaysResult);
            this.Controls.Add(this.lblSuccessfulDays);
            this.Controls.Add(this.lblCaloriesLeftResult);
            this.Controls.Add(this.lblCaloriesEatenResult);
            this.Controls.Add(this.lblCaloriesLeft);
            this.Controls.Add(this.lblCaloriesEaten);
            this.Controls.Add(this.btnSubtractCalories);
            this.Controls.Add(this.btnAddCalories);
            this.Controls.Add(this.lblAddCaloriesLost);
            this.Controls.Add(this.lblAddCaloriesEaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DailyIntakeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Intake Calculator";
            this.Load += new System.EventHandler(this.DailyIntakeCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCaloriesEaten;
        private System.Windows.Forms.Label lblAddCaloriesLost;
        private System.Windows.Forms.Button btnAddCalories;
        private System.Windows.Forms.Button btnSubtractCalories;
        private System.Windows.Forms.Label lblCaloriesEaten;
        private System.Windows.Forms.Label lblCaloriesLeft;
        private System.Windows.Forms.Label lblCaloriesEatenResult;
        private System.Windows.Forms.Label lblCaloriesLeftResult;
        private System.Windows.Forms.Label lblSuccessfulDays;
        private System.Windows.Forms.Label lblSuccessfulDaysResult;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MaskedTextBox txtAddCalories;
        private System.Windows.Forms.MaskedTextBox txtSubtractCalories;
    }
}