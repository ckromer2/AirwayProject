using System.Runtime.CompilerServices;

namespace GROUP9Project.UI
{
    partial class HistoryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BookedFlightsListBox = new System.Windows.Forms.ListBox();
            this.TakenFlightsListBox = new System.Windows.Forms.ListBox();
            this.CancelledFlightsListBox = new System.Windows.Forms.ListBox();
            this.PrintPassButton = new System.Windows.Forms.Button();
            this.CancelFlightButton = new System.Windows.Forms.Button();
            this.LogedInLable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogedInLable);
            this.panel1.Controls.Add(this.EmployeeTab);
            this.panel1.Controls.Add(this.HistoryTab);
            this.panel1.Controls.Add(this.FlightsTab);
            this.panel1.Controls.Add(this.RewardsTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 16;
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
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Booked Flights";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(543, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cancelled Flights";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(311, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Taken Flights";
            // 
            // BookedFlightsListBox
            // 
            this.BookedFlightsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BookedFlightsListBox.FormattingEnabled = true;
            this.BookedFlightsListBox.ItemHeight = 15;
            this.BookedFlightsListBox.Location = new System.Drawing.Point(69, 111);
            this.BookedFlightsListBox.Name = "BookedFlightsListBox";
            this.BookedFlightsListBox.Size = new System.Drawing.Size(186, 244);
            this.BookedFlightsListBox.TabIndex = 20;
            // 
            // TakenFlightsListBox
            // 
            this.TakenFlightsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TakenFlightsListBox.FormattingEnabled = true;
            this.TakenFlightsListBox.ItemHeight = 15;
            this.TakenFlightsListBox.Location = new System.Drawing.Point(311, 111);
            this.TakenFlightsListBox.Name = "TakenFlightsListBox";
            this.TakenFlightsListBox.Size = new System.Drawing.Size(186, 244);
            this.TakenFlightsListBox.TabIndex = 21;
            // 
            // CancelledFlightsListBox
            // 
            this.CancelledFlightsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelledFlightsListBox.FormattingEnabled = true;
            this.CancelledFlightsListBox.ItemHeight = 15;
            this.CancelledFlightsListBox.Location = new System.Drawing.Point(543, 111);
            this.CancelledFlightsListBox.Name = "CancelledFlightsListBox";
            this.CancelledFlightsListBox.Size = new System.Drawing.Size(186, 244);
            this.CancelledFlightsListBox.TabIndex = 22;
            // 
            // PrintPassButton
            // 
            this.PrintPassButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintPassButton.Location = new System.Drawing.Point(69, 371);
            this.PrintPassButton.Name = "PrintPassButton";
            this.PrintPassButton.Size = new System.Drawing.Size(90, 42);
            this.PrintPassButton.TabIndex = 23;
            this.PrintPassButton.Text = "Print Boarding Pass";
            this.PrintPassButton.UseVisualStyleBackColor = true;
            this.PrintPassButton.Click += new System.EventHandler(this.PrintPassButton_Click);
            // 
            // CancelFlightButton
            // 
            this.CancelFlightButton.AccessibleName = "";
            this.CancelFlightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelFlightButton.Location = new System.Drawing.Point(165, 371);
            this.CancelFlightButton.Name = "CancelFlightButton";
            this.CancelFlightButton.Size = new System.Drawing.Size(90, 42);
            this.CancelFlightButton.TabIndex = 24;
            this.CancelFlightButton.Text = "Cancel Flight";
            this.CancelFlightButton.UseVisualStyleBackColor = true;
            this.CancelFlightButton.Click += new System.EventHandler(this.CancelFlightButtonClick);
            // 
            // LogedInLable
            // 
            this.LogedInLable.AutoSize = true;
            this.LogedInLable.Location = new System.Drawing.Point(633, 9);
            this.LogedInLable.Name = "LogedInLable";
            this.LogedInLable.Size = new System.Drawing.Size(0, 15);
            this.LogedInLable.TabIndex = 25;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelFlightButton);
            this.Controls.Add(this.PrintPassButton);
            this.Controls.Add(this.CancelledFlightsListBox);
            this.Controls.Add(this.TakenFlightsListBox);
            this.Controls.Add(this.BookedFlightsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
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
        private Label label2;
        private Label label3;
        private ListBox BookedFlightsListBox;
        private ListBox TakenFlightsListBox;
        private ListBox CancelledFlightsListBox;
        private Button PrintPassButton;
        private Button CancelFlightButton;
        private List<DataBase.BookingRecord> BookedFlights;
        private List<DataBase.BookingRecord> TakenFlights;
        private List<DataBase.BookingRecord> CancelledFlights;
        private Label LogedInLable;
    }
}