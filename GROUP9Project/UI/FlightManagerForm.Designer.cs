namespace GROUP9Project.UI
{
    partial class FlightManagerForm
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
            FlightsListBox = new ListBox();
            PrintManifestButton = new Button();
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
            panel1.TabIndex = 19;
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
            label1.Location = new Point(233, 80);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 25;
            label1.Text = "Upcoming Flights";
            // 
            // FlightsListBox
            // 
            FlightsListBox.Anchor = AnchorStyles.None;
            FlightsListBox.FormattingEnabled = true;
            FlightsListBox.ItemHeight = 15;
            FlightsListBox.Location = new Point(233, 111);
            FlightsListBox.Name = "FlightsListBox";
            FlightsListBox.Size = new Size(334, 259);
            FlightsListBox.TabIndex = 24;
            // 
            // PrintManifestButton
            // 
            PrintManifestButton.Anchor = AnchorStyles.None;
            PrintManifestButton.Location = new Point(610, 111);
            PrintManifestButton.Name = "PrintManifestButton";
            PrintManifestButton.Size = new Size(130, 34);
            PrintManifestButton.TabIndex = 26;
            PrintManifestButton.Text = "Print Flight Manifest";
            PrintManifestButton.UseVisualStyleBackColor = true;
            // 
            // FlightManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PrintManifestButton);
            Controls.Add(label1);
            Controls.Add(FlightsListBox);
            Controls.Add(panel1);
            Name = "FlightManagerForm";
            Text = "FlightManagerForm";
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
        private ListBox FlightsListBox;
        private Button PrintManifestButton;
    }
}