﻿namespace GROUP9Project.UI
{
    partial class ManifestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PassengerListBox = new System.Windows.Forms.ListBox();
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
            this.EmployeeTab.Click += new System.EventHandler(this.EmployeeTab_Click);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "People On Board";
            // 
            // PassengerListBox
            // 
            this.PassengerListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassengerListBox.FormattingEnabled = true;
            this.PassengerListBox.ItemHeight = 15;
            this.PassengerListBox.Location = new System.Drawing.Point(233, 111);
            this.PassengerListBox.Name = "PassengerListBox";
            this.PassengerListBox.Size = new System.Drawing.Size(334, 259);
            this.PassengerListBox.TabIndex = 24;
            // 
            // LogedInLable
            // 
            this.LogedInLable.AutoSize = true;
            this.LogedInLable.Location = new System.Drawing.Point(633, 9);
            this.LogedInLable.Name = "LogedInLable";
            this.LogedInLable.Size = new System.Drawing.Size(0, 15);
            this.LogedInLable.TabIndex = 26;
            // 
            // ManifestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogedInLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassengerListBox);
            this.Controls.Add(this.panel1);
            this.Name = "ManifestForm";
            this.Text = "ManifestForm";
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
        private Label label1;
        private ListBox PassengerListBox;
        private Label LogedInLable;
    }
}