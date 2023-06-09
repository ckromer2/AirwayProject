﻿namespace GROUP9Project.UI
{
    partial class LoadManagerForm
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
            this.RoutesListBox = new System.Windows.Forms.ListBox();
            this.AddRouteButton = new System.Windows.Forms.Button();
            this.RemoveRouteButton = new System.Windows.Forms.Button();
            this.ModifyRouteButton = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 18;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Offered Routes";
            // 
            // RoutesListBox
            // 
            this.RoutesListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoutesListBox.FormattingEnabled = true;
            this.RoutesListBox.ItemHeight = 15;
            this.RoutesListBox.Location = new System.Drawing.Point(54, 116);
            this.RoutesListBox.Name = "RoutesListBox";
            this.RoutesListBox.Size = new System.Drawing.Size(386, 304);
            this.RoutesListBox.TabIndex = 20;
            // 
            // AddRouteButton
            // 
            this.AddRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddRouteButton.Location = new System.Drawing.Point(517, 115);
            this.AddRouteButton.Name = "AddRouteButton";
            this.AddRouteButton.Size = new System.Drawing.Size(145, 37);
            this.AddRouteButton.TabIndex = 21;
            this.AddRouteButton.Text = "Add Route";
            this.AddRouteButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRouteButton
            // 
            this.RemoveRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveRouteButton.Location = new System.Drawing.Point(517, 176);
            this.RemoveRouteButton.Name = "RemoveRouteButton";
            this.RemoveRouteButton.Size = new System.Drawing.Size(145, 37);
            this.RemoveRouteButton.TabIndex = 22;
            this.RemoveRouteButton.Text = "Remove Route";
            this.RemoveRouteButton.UseVisualStyleBackColor = true;
            // 
            // ModifyRouteButton
            // 
            this.ModifyRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyRouteButton.Location = new System.Drawing.Point(517, 235);
            this.ModifyRouteButton.Name = "ModifyRouteButton";
            this.ModifyRouteButton.Size = new System.Drawing.Size(145, 37);
            this.ModifyRouteButton.TabIndex = 23;
            this.ModifyRouteButton.Text = "Modify Route";
            this.ModifyRouteButton.UseVisualStyleBackColor = true;
            // 
            // LogedInLable
            // 
            this.LogedInLable.AutoSize = true;
            this.LogedInLable.Location = new System.Drawing.Point(633, 9);
            this.LogedInLable.Name = "LogedInLable";
            this.LogedInLable.Size = new System.Drawing.Size(0, 15);
            this.LogedInLable.TabIndex = 24;
            // 
            // LoadManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogedInLable);
            this.Controls.Add(this.ModifyRouteButton);
            this.Controls.Add(this.RemoveRouteButton);
            this.Controls.Add(this.AddRouteButton);
            this.Controls.Add(this.RoutesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LoadManagerForm";
            this.Text = "LoadManagerForm";
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
        private ListBox RoutesListBox;
        private Button AddRouteButton;
        private Button RemoveRouteButton;
        private Button ModifyRouteButton;
        private Label LogedInLable;
    }
}