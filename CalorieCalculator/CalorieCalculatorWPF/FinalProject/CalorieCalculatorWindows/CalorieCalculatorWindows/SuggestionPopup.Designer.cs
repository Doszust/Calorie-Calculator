namespace CalorieCalculatorWindows
{
    partial class SuggestionPopup
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblGain = new System.Windows.Forms.Label();
            this.lblGainResults = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblLoseResults = new System.Windows.Forms.Label();
            this.lblMaintain = new System.Windows.Forms.Label();
            this.lblMaintainResults = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(11, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(299, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Based On Your Inputs, You Should Eat...";
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGain.Location = new System.Drawing.Point(11, 41);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(123, 20);
            this.lblGain.TabIndex = 1;
            this.lblGain.Text = "To Gain Weight:";
            // 
            // lblGainResults
            // 
            this.lblGainResults.AutoSize = true;
            this.lblGainResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGainResults.Location = new System.Drawing.Point(265, 41);
            this.lblGainResults.Name = "lblGainResults";
            this.lblGainResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGainResults.Size = new System.Drawing.Size(45, 20);
            this.lblGainResults.TabIndex = 2;
            this.lblGainResults.Text = "0000";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(11, 73);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(124, 20);
            this.lblLose.TabIndex = 3;
            this.lblLose.Text = "To Lose Weight:";
            // 
            // lblLoseResults
            // 
            this.lblLoseResults.AutoSize = true;
            this.lblLoseResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoseResults.Location = new System.Drawing.Point(265, 73);
            this.lblLoseResults.Name = "lblLoseResults";
            this.lblLoseResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoseResults.Size = new System.Drawing.Size(45, 20);
            this.lblLoseResults.TabIndex = 4;
            this.lblLoseResults.Text = "0000";
            // 
            // lblMaintain
            // 
            this.lblMaintain.AutoSize = true;
            this.lblMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintain.Location = new System.Drawing.Point(11, 105);
            this.lblMaintain.Name = "lblMaintain";
            this.lblMaintain.Size = new System.Drawing.Size(149, 20);
            this.lblMaintain.TabIndex = 5;
            this.lblMaintain.Text = "To Maintain Weight:";
            // 
            // lblMaintainResults
            // 
            this.lblMaintainResults.AutoSize = true;
            this.lblMaintainResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainResults.Location = new System.Drawing.Point(265, 105);
            this.lblMaintainResults.Name = "lblMaintainResults";
            this.lblMaintainResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMaintainResults.Size = new System.Drawing.Size(45, 20);
            this.lblMaintainResults.TabIndex = 6;
            this.lblMaintainResults.Text = "0000";
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOk.Location = new System.Drawing.Point(123, 141);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 27);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SuggestionPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMaintainResults);
            this.Controls.Add(this.lblMaintain);
            this.Controls.Add(this.lblLoseResults);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblGainResults);
            this.Controls.Add(this.lblGain);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SuggestionPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suggested Calorie Intake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.Label lblGainResults;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblLoseResults;
        private System.Windows.Forms.Label lblMaintain;
        private System.Windows.Forms.Label lblMaintainResults;
        private System.Windows.Forms.Button btnOk;
    }
}