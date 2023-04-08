namespace GROUP9Project.UI
{
    partial class MarketingMangerForm
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
            RoutesListBox = new ListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
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
            // RoutesListBox
            // 
            RoutesListBox.Anchor = AnchorStyles.None;
            RoutesListBox.FormattingEnabled = true;
            RoutesListBox.ItemHeight = 15;
            RoutesListBox.Location = new Point(115, 110);
            RoutesListBox.Name = "RoutesListBox";
            RoutesListBox.Size = new Size(334, 259);
            RoutesListBox.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(488, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(488, 194);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 22;
            button1.Text = "Confirm Action";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 79);
            label1.Name = "label1";
            label1.Size = new Size(321, 30);
            label1.TabIndex = 23;
            label1.Text = "Routes Without Planes Assigned";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(488, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 24;
            label2.Text = "Select Plane";
            // 
            // MarketingMangerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(RoutesListBox);
            Controls.Add(panel1);
            Name = "MarketingMangerForm";
            Text = "MarketingMangerForm";
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
        private ListBox RoutesListBox;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}