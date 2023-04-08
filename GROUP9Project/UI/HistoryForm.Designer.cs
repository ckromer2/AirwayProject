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
            panel1 = new Panel();
            EmployeeTab = new Label();
            HistoryTab = new Label();
            FlightsTab = new Label();
            RewardsTab = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BookedFlightsListBox = new ListBox();
            TakenFlightsListBox = new ListBox();
            CancelledFlightsListBox = new ListBox();
            PrintPassButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(EmployeeTab);
            panel1.Controls.Add(HistoryTab);
            panel1.Controls.Add(FlightsTab);
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
            EmployeeTab.Location = new Point(553, 9);
            EmployeeTab.Name = "EmployeeTab";
            EmployeeTab.Size = new Size(109, 30);
            EmployeeTab.TabIndex = 6;
            EmployeeTab.Text = "Employee";
            // 
            // HistoryTab
            // 
            HistoryTab.AutoSize = true;
            HistoryTab.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            HistoryTab.Location = new Point(385, 9);
            HistoryTab.Name = "HistoryTab";
            HistoryTab.Size = new Size(82, 30);
            HistoryTab.TabIndex = 7;
            HistoryTab.Text = "History";
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
            // 
            // RewardsTab
            // 
            RewardsTab.AutoSize = true;
            RewardsTab.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            RewardsTab.Location = new Point(213, 9);
            RewardsTab.Name = "RewardsTab";
            RewardsTab.Size = new Size(94, 30);
            RewardsTab.TabIndex = 8;
            RewardsTab.Text = "Rewards";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 65);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 17;
            label1.Text = "Booked Flights";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(543, 65);
            label2.Name = "label2";
            label2.Size = new Size(175, 30);
            label2.TabIndex = 18;
            label2.Text = "Cancelled Flights";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(311, 65);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 19;
            label3.Text = "Taken Flights";
            // 
            // BookedFlightsListBox
            // 
            BookedFlightsListBox.Anchor = AnchorStyles.None;
            BookedFlightsListBox.FormattingEnabled = true;
            BookedFlightsListBox.ItemHeight = 15;
            BookedFlightsListBox.Location = new Point(69, 111);
            BookedFlightsListBox.Name = "BookedFlightsListBox";
            BookedFlightsListBox.Size = new Size(186, 244);
            BookedFlightsListBox.TabIndex = 20;
            // 
            // TakenFlightsListBox
            // 
            TakenFlightsListBox.Anchor = AnchorStyles.None;
            TakenFlightsListBox.FormattingEnabled = true;
            TakenFlightsListBox.ItemHeight = 15;
            TakenFlightsListBox.Location = new Point(311, 111);
            TakenFlightsListBox.Name = "TakenFlightsListBox";
            TakenFlightsListBox.Size = new Size(186, 244);
            TakenFlightsListBox.TabIndex = 21;
            // 
            // CancelledFlightsListBox
            // 
            CancelledFlightsListBox.Anchor = AnchorStyles.None;
            CancelledFlightsListBox.FormattingEnabled = true;
            CancelledFlightsListBox.ItemHeight = 15;
            CancelledFlightsListBox.Location = new Point(543, 111);
            CancelledFlightsListBox.Name = "CancelledFlightsListBox";
            CancelledFlightsListBox.Size = new Size(186, 244);
            CancelledFlightsListBox.TabIndex = 22;
            // 
            // PrintPassButton
            // 
            PrintPassButton.Anchor = AnchorStyles.None;
            PrintPassButton.Location = new Point(103, 371);
            PrintPassButton.Name = "PrintPassButton";
            PrintPassButton.Size = new Size(122, 42);
            PrintPassButton.TabIndex = 23;
            PrintPassButton.Text = "Print Selected Boarding Pass";
            PrintPassButton.UseVisualStyleBackColor = true;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PrintPassButton);
            Controls.Add(CancelledFlightsListBox);
            Controls.Add(TakenFlightsListBox);
            Controls.Add(BookedFlightsListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "HistoryForm";
            Text = "HistoryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}