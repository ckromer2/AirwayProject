namespace GROUP9Project.UI
{
    partial class RewardsForm
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
            label1 = new Label();
            usedPointsLabel = new Label();
            label3 = new Label();
            curPointsLabel = new Label();
            panel1 = new Panel();
            EmployeeTab = new Label();
            FlightsTab = new Label();
            HistoryTab = new Label();
            RewardsTab = new Label();
            LogedInLable = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(245, 155);
            label1.Name = "label1";
            label1.Size = new Size(296, 54);
            label1.TabIndex = 5;
            label1.Text = "Current Points: ";
            // 
            // usedPointsLabel
            // 
            usedPointsLabel.Anchor = AnchorStyles.None;
            usedPointsLabel.AutoSize = true;
            usedPointsLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            usedPointsLabel.Location = new Point(496, 223);
            usedPointsLabel.Name = "usedPointsLabel";
            usedPointsLabel.Size = new Size(45, 54);
            usedPointsLabel.TabIndex = 6;
            usedPointsLabel.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(245, 223);
            label3.Name = "label3";
            label3.Size = new Size(251, 54);
            label3.TabIndex = 7;
            label3.Text = "Points Used: ";
            // 
            // curPointsLabel
            // 
            curPointsLabel.Anchor = AnchorStyles.None;
            curPointsLabel.AutoSize = true;
            curPointsLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            curPointsLabel.Location = new Point(536, 155);
            curPointsLabel.Name = "curPointsLabel";
            curPointsLabel.Size = new Size(45, 54);
            curPointsLabel.TabIndex = 8;
            curPointsLabel.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(EmployeeTab);
            panel1.Controls.Add(FlightsTab);
            panel1.Controls.Add(HistoryTab);
            panel1.Controls.Add(RewardsTab);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 16;
            // 
            // EmployeeTab
            // 
            EmployeeTab.AutoSize = true;
            EmployeeTab.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeTab.Location = new Point(314, 9);
            EmployeeTab.Name = "EmployeeTab";
            EmployeeTab.Size = new Size(109, 30);
            EmployeeTab.TabIndex = 6;
            EmployeeTab.Text = "Employee";
            EmployeeTab.Click += EmployeeTab_Click;
            // 
            // FlightsTab
            // 
            FlightsTab.AutoSize = true;
            FlightsTab.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FlightsTab.Location = new Point(45, 9);
            FlightsTab.Name = "FlightsTab";
            FlightsTab.Size = new Size(75, 30);
            FlightsTab.TabIndex = 5;
            FlightsTab.Text = "Flights";
            FlightsTab.Click += FlightsTab_Click;
            // 
            // HistoryTab
            // 
            HistoryTab.AutoSize = true;
            HistoryTab.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            HistoryTab.Location = new Point(226, 9);
            HistoryTab.Name = "HistoryTab";
            HistoryTab.Size = new Size(82, 30);
            HistoryTab.TabIndex = 7;
            HistoryTab.Text = "History";
            HistoryTab.Click += HistoryTab_Click_1;
            // 
            // RewardsTab
            // 
            RewardsTab.AutoSize = true;
            RewardsTab.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            RewardsTab.Location = new Point(126, 9);
            RewardsTab.Name = "RewardsTab";
            RewardsTab.Size = new Size(94, 30);
            RewardsTab.TabIndex = 8;
            RewardsTab.Text = "Rewards";
            RewardsTab.Click += RewardsTab_Click;
            // 
            // LogedInLable
            // 
            LogedInLable.AutoSize = true;
            LogedInLable.Location = new Point(633, 9);
            LogedInLable.Name = "LogedInLable";
            LogedInLable.Size = new Size(0, 15);
            LogedInLable.TabIndex = 17;
            // 
            // RewardsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogedInLable);
            Controls.Add(panel1);
            Controls.Add(curPointsLabel);
            Controls.Add(label3);
            Controls.Add(usedPointsLabel);
            Controls.Add(label1);
            Name = "RewardsForm";
            Text = "RewardsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label usedPointsLabel;
        private Label label3;
        private Label curPointsLabel;
        private Panel panel1;
        private Label FlightsTab;
        private Label RewardsTab;
        private Label LogedInLable;
        private Label EmployeeTab;
        private Label HistoryTab;
    }
}