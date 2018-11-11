namespace CalorieCalculatorWindows
{
    partial class GoalEntry
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
            this.lblEnterGoal = new System.Windows.Forms.Label();
            this.lblSelectMode = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pnlMode = new System.Windows.Forms.Panel();
            this.radLose = new System.Windows.Forms.RadioButton();
            this.radGain = new System.Windows.Forms.RadioButton();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtGoal = new System.Windows.Forms.MaskedTextBox();
            this.pnlMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnterGoal
            // 
            this.lblEnterGoal.AutoSize = true;
            this.lblEnterGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterGoal.Location = new System.Drawing.Point(11, 13);
            this.lblEnterGoal.Name = "lblEnterGoal";
            this.lblEnterGoal.Size = new System.Drawing.Size(90, 20);
            this.lblEnterGoal.TabIndex = 0;
            this.lblEnterGoal.Text = "Enter Goal:";
            // 
            // lblSelectMode
            // 
            this.lblSelectMode.AutoSize = true;
            this.lblSelectMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMode.Location = new System.Drawing.Point(10, 39);
            this.lblSelectMode.Name = "lblSelectMode";
            this.lblSelectMode.Size = new System.Drawing.Size(102, 20);
            this.lblSelectMode.TabIndex = 2;
            this.lblSelectMode.Text = "Select Mode:";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(15, 67);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(107, 50);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // pnlMode
            // 
            this.pnlMode.Controls.Add(this.radLose);
            this.pnlMode.Controls.Add(this.radGain);
            this.pnlMode.Location = new System.Drawing.Point(118, 39);
            this.pnlMode.Name = "pnlMode";
            this.pnlMode.Size = new System.Drawing.Size(122, 22);
            this.pnlMode.TabIndex = 5;
            // 
            // radLose
            // 
            this.radLose.AutoSize = true;
            this.radLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLose.Location = new System.Drawing.Point(61, 1);
            this.radLose.Name = "radLose";
            this.radLose.Size = new System.Drawing.Size(56, 20);
            this.radLose.TabIndex = 1;
            this.radLose.TabStop = true;
            this.radLose.Text = "Lose";
            this.radLose.UseVisualStyleBackColor = true;
            // 
            // radGain
            // 
            this.radGain.AutoSize = true;
            this.radGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGain.Location = new System.Drawing.Point(3, 1);
            this.radGain.Name = "radGain";
            this.radGain.Size = new System.Drawing.Size(54, 20);
            this.radGain.TabIndex = 0;
            this.radGain.TabStop = true;
            this.radGain.Text = "Gain";
            this.radGain.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(133, 67);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 50);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(118, 13);
            this.txtGoal.Mask = "0009";
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(122, 20);
            this.txtGoal.TabIndex = 7;
            this.txtGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 129);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pnlMode);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblSelectMode);
            this.Controls.Add(this.lblEnterGoal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GoalEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goal Entry";
            this.Load += new System.EventHandler(this.GoalEntry_Load);
            this.pnlMode.ResumeLayout(false);
            this.pnlMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterGoal;
        private System.Windows.Forms.Label lblSelectMode;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Panel pnlMode;
        private System.Windows.Forms.RadioButton radLose;
        private System.Windows.Forms.RadioButton radGain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MaskedTextBox txtGoal;
    }
}