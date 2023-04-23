namespace GROUP9Project.UI
{
    partial class AccountantForm
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
            EmployeeTab = new Label();
            RewardsTab = new Label();
            FlightsTab = new Label();
            HistoryTab = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FlightsListBox = new ListBox();
            PercentFullListBox = new ListBox();
            IncomeListBox = new ListBox();
            panel1 = new Panel();
            LogedInLable = new Label();
            label4 = new Label();
            TotalFlights = new TextBox();
            TotalIncome = new TextBox();
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
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
            HistoryTab.Click += HistoryTab_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(219, 65);
            label1.Name = "label1";
            label1.Size = new Size(95, 37);
            label1.TabIndex = 9;
            label1.Text = "Flights";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(461, 65);
            label2.Name = "label2";
            label2.Size = new Size(153, 37);
            label2.TabIndex = 10;
            label2.Text = "Percent Full";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(658, 65);
            label3.Name = "label3";
            label3.Size = new Size(104, 37);
            label3.TabIndex = 11;
            label3.Text = "Income";
            // 
            // FlightsListBox
            // 
            FlightsListBox.Anchor = AnchorStyles.None;
            FlightsListBox.FormattingEnabled = true;
            FlightsListBox.ItemHeight = 15;
            FlightsListBox.Location = new Point(219, 116);
            FlightsListBox.Name = "FlightsListBox";
            FlightsListBox.Size = new Size(189, 229);
            FlightsListBox.TabIndex = 12;
            // 
            // PercentFullListBox
            // 
            PercentFullListBox.Anchor = AnchorStyles.None;
            PercentFullListBox.FormattingEnabled = true;
            PercentFullListBox.ItemHeight = 15;
            PercentFullListBox.Location = new Point(461, 116);
            PercentFullListBox.Name = "PercentFullListBox";
            PercentFullListBox.Size = new Size(104, 229);
            PercentFullListBox.TabIndex = 13;
            // 
            // IncomeListBox
            // 
            IncomeListBox.Anchor = AnchorStyles.None;
            IncomeListBox.FormattingEnabled = true;
            IncomeListBox.ItemHeight = 15;
            IncomeListBox.Location = new Point(658, 116);
            IncomeListBox.Name = "IncomeListBox";
            IncomeListBox.Size = new Size(131, 229);
            IncomeListBox.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(LogedInLable);
            panel1.Controls.Add(EmployeeTab);
            panel1.Controls.Add(HistoryTab);
            panel1.Controls.Add(FlightsTab);
            panel1.Controls.Add(RewardsTab);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 15;
            // 
            // LogedInLable
            // 
            LogedInLable.AutoSize = true;
            LogedInLable.Location = new Point(633, 9);
            LogedInLable.Name = "LogedInLable";
            LogedInLable.Size = new Size(0, 15);
            LogedInLable.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 362);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 16;
            label4.Text = "Total";
            // 
            // TotalFlights
            // 
            TotalFlights.BackColor = SystemColors.Window;
            TotalFlights.Location = new Point(219, 354);
            TotalFlights.Name = "TotalFlights";
            TotalFlights.ReadOnly = true;
            TotalFlights.Size = new Size(100, 23);
            TotalFlights.TabIndex = 17;
            // 
            // TotalIncome
            // 
            TotalIncome.BackColor = SystemColors.Window;
            TotalIncome.Location = new Point(658, 354);
            TotalIncome.Name = "TotalIncome";
            TotalIncome.ReadOnly = true;
            TotalIncome.Size = new Size(100, 23);
            TotalIncome.TabIndex = 18;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(4, 125);
            StartDatePicker.MaxDate = new DateTime(2023, 4, 22, 0, 0, 0, 0);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(200, 23);
            StartDatePicker.TabIndex = 42;
            StartDatePicker.Value = new DateTime(2023, 4, 22, 0, 0, 0, 0);
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(4, 165);
            EndDatePicker.MaxDate = new DateTime(2023, 4, 22, 0, 0, 0, 0);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(200, 23);
            EndDatePicker.TabIndex = 43;
            EndDatePicker.Value = new DateTime(2023, 4, 22, 0, 0, 0, 0);
            EndDatePicker.ValueChanged += EndDatePicker_ValueChanged;
            // 
            // AccountantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EndDatePicker);
            Controls.Add(StartDatePicker);
            Controls.Add(TotalIncome);
            Controls.Add(TotalFlights);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(IncomeListBox);
            Controls.Add(PercentFullListBox);
            Controls.Add(FlightsListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountantForm";
            Text = "AccountantForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EmployeeTab;
        private Label RewardsTab;
        private Label FlightsTab;
        private Label HistoryTab;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox FlightsListBox;
        private ListBox PercentFullListBox;
        private ListBox IncomeListBox;
        private Panel panel1;
        private Label label4;
        private TextBox TotalFlights;
        private TextBox TotalIncome;
        private Label LogedInLable;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
    }
}