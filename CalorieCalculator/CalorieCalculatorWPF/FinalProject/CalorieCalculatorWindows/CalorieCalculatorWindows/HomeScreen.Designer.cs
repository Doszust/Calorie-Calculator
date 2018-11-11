namespace CalorieCalculatorWindows
{
    partial class CalorieCalculatorHomeScreen
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnSetGoals = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(131, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calorie Counter";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(4, 31);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(332, 26);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "If this is your first time, click setup to set up your goals.\r\nYou may use the su" +
    "ggestion option to get a suggested caloric intake.\r\n";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSuggestion);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnSetGoals);
            this.panel1.Controls.Add(this.btnCalculator);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 166);
            this.panel1.TabIndex = 2;
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.Location = new System.Drawing.Point(164, 90);
            this.btnSuggestion.Name = "btnSuggestion";
            this.btnSuggestion.Size = new System.Drawing.Size(149, 72);
            this.btnSuggestion.TabIndex = 3;
            this.btnSuggestion.Text = "Suggestion";
            this.btnSuggestion.UseVisualStyleBackColor = true;
            this.btnSuggestion.Click += new System.EventHandler(this.btnSuggestion_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(164, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(149, 72);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnSetGoals
            // 
            this.btnSetGoals.Location = new System.Drawing.Point(4, 90);
            this.btnSetGoals.Name = "btnSetGoals";
            this.btnSetGoals.Size = new System.Drawing.Size(149, 72);
            this.btnSetGoals.TabIndex = 1;
            this.btnSetGoals.Text = "Set Goals";
            this.btnSetGoals.UseVisualStyleBackColor = true;
            this.btnSetGoals.Click += new System.EventHandler(this.btnSetGoals_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(4, 4);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(149, 72);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // CalorieCalculatorHomeScreen
            // 
            this.ClientSize = new System.Drawing.Size(341, 238);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "CalorieCalculatorHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Calculator";
            this.Load += new System.EventHandler(this.CalorieCalculatorHomeScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSetGoals;
        private System.Windows.Forms.Button btnCalculator;
    }
}

