﻿namespace GROUP9Project.UI
{
    partial class MarketingManagerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeTab = new System.Windows.Forms.Label();
            this.HistoryTab = new System.Windows.Forms.Label();
            this.FlightsTab = new System.Windows.Forms.Label();
            this.RewardsTab = new System.Windows.Forms.Label();
            this.FlightListBox = new System.Windows.Forms.ListBox();
            this.PlaneBox = new System.Windows.Forms.ComboBox();
            this.ChangePlaneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogedInLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeeTab);
            this.panel1.Controls.Add(this.HistoryTab);
            this.panel1.Controls.Add(this.FlightsTab);
            this.panel1.Controls.Add(this.RewardsTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 19;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.AutoSize = true;
            this.EmployeeTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeTab.Location = new System.Drawing.Point(314, 9);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Size = new System.Drawing.Size(109, 30);
            this.EmployeeTab.TabIndex = 6;
            this.EmployeeTab.Text = "Employee";
            // 
            // HistoryTab
            // 
            this.HistoryTab.AutoSize = true;
            this.HistoryTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistoryTab.Location = new System.Drawing.Point(226, 9);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Size = new System.Drawing.Size(82, 30);
            this.HistoryTab.TabIndex = 7;
            this.HistoryTab.Text = "History";
            this.HistoryTab.Click += new System.EventHandler(this.HistoryTab_Click);
            // 
            // FlightsTab
            // 
            this.FlightsTab.AutoSize = true;
            this.FlightsTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightsTab.Location = new System.Drawing.Point(45, 9);
            this.FlightsTab.Name = "FlightsTab";
            this.FlightsTab.Size = new System.Drawing.Size(75, 30);
            this.FlightsTab.TabIndex = 5;
            this.FlightsTab.Text = "Flights";
            this.FlightsTab.Click += new System.EventHandler(this.FlightsTab_Click);
            // 
            // RewardsTab
            // 
            this.RewardsTab.AutoSize = true;
            this.RewardsTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardsTab.Location = new System.Drawing.Point(126, 9);
            this.RewardsTab.Name = "RewardsTab";
            this.RewardsTab.Size = new System.Drawing.Size(94, 30);
            this.RewardsTab.TabIndex = 8;
            this.RewardsTab.Text = "Rewards";
            this.RewardsTab.Click += new System.EventHandler(this.RewardsTab_Click);
            // 
            // FlightListBox
            // 
            this.FlightListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlightListBox.FormattingEnabled = true;
            this.FlightListBox.ItemHeight = 15;
            this.FlightListBox.Location = new System.Drawing.Point(115, 110);
            this.FlightListBox.Name = "FlightListBox";
            this.FlightListBox.Size = new System.Drawing.Size(334, 259);
            this.FlightListBox.TabIndex = 20;
            // 
            // PlaneBox
            // 
            this.PlaneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlaneBox.FormattingEnabled = true;
            this.PlaneBox.Location = new System.Drawing.Point(488, 134);
            this.PlaneBox.Name = "PlaneBox";
            this.PlaneBox.Size = new System.Drawing.Size(121, 23);
            this.PlaneBox.TabIndex = 21;
            // 
            // ChangePlaneButton
            // 
            this.ChangePlaneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangePlaneButton.Location = new System.Drawing.Point(488, 194);
            this.ChangePlaneButton.Name = "ChangePlaneButton";
            this.ChangePlaneButton.Size = new System.Drawing.Size(109, 23);
            this.ChangePlaneButton.TabIndex = 22;
            this.ChangePlaneButton.Text = "Confirm Action";
            this.ChangePlaneButton.UseVisualStyleBackColor = true;
            this.ChangePlaneButton.Click += new System.EventHandler(this.ChangePlaneButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Flights Without Planes Assigned";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select Plane";
            // 
            // LogedInLable
            // 
            this.LogedInLable.AutoSize = true;
            this.LogedInLable.Location = new System.Drawing.Point(633, 9);
            this.LogedInLable.Name = "LogedInLable";
            this.LogedInLable.Size = new System.Drawing.Size(0, 15);
            this.LogedInLable.TabIndex = 25;
            // 
            // MarketingManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogedInLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangePlaneButton);
            this.Controls.Add(this.PlaneBox);
            this.Controls.Add(this.FlightListBox);
            this.Controls.Add(this.panel1);
            this.Name = "MarketingManagerForm";
            this.Text = "MarketingMangerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label EmployeeTab;
        private Label HistoryTab;
        private Label FlightsTab;
        private Label RewardsTab;
        private ListBox FlightListBox;
        private ComboBox PlaneBox;
        private Button ChangePlaneButton;
        private Label label1;
        private Label label2;
        private Label LogedInLable;
        private List<DataBase.Flight> FlightList;
    }
}