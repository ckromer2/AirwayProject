namespace GROUP9Project.UI
{
    partial class FlightsForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SearchButton = new Button();
            PurchaseButton = new Button();
            PointsCheckBox = new CheckBox();
            ArriveComboBox = new ComboBox();
            DepartComboBox = new ComboBox();
            FirstFlightListBox = new ListBox();
            SecondFlightListBox = new ListBox();
            DepartTextBox = new MaskedTextBox();
            ReturnTextBox = new MaskedTextBox();
            RoundTripCheckBox = new CheckBox();
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
            panel1.TabIndex = 17;
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
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 65);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 18;
            label1.Text = "First Flight";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(469, 65);
            label2.Name = "label2";
            label2.Size = new Size(178, 37);
            label2.TabIndex = 19;
            label2.Text = "Second Flight";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(33, 131);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 27;
            label3.Text = "Depart";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(33, 177);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 28;
            label4.Text = "Arrive";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(33, 225);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 29;
            label5.Text = "Depart Date";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(33, 273);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 30;
            label6.Text = "Return Date";
            label6.Click += label6_Click;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.None;
            SearchButton.Location = new Point(38, 337);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 31;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // PurchaseButton
            // 
            PurchaseButton.Anchor = AnchorStyles.None;
            PurchaseButton.Location = new Point(370, 336);
            PurchaseButton.Name = "PurchaseButton";
            PurchaseButton.Size = new Size(174, 23);
            PurchaseButton.TabIndex = 32;
            PurchaseButton.Text = "Purchase Selected Flights";
            PurchaseButton.UseVisualStyleBackColor = true;
            // 
            // PointsCheckBox
            // 
            PointsCheckBox.Anchor = AnchorStyles.None;
            PointsCheckBox.AutoSize = true;
            PointsCheckBox.Location = new Point(415, 311);
            PointsCheckBox.Name = "PointsCheckBox";
            PointsCheckBox.Size = new Size(81, 19);
            PointsCheckBox.TabIndex = 33;
            PointsCheckBox.Text = "Use Points";
            PointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ArriveComboBox
            // 
            ArriveComboBox.Anchor = AnchorStyles.None;
            ArriveComboBox.FormattingEnabled = true;
            ArriveComboBox.Location = new Point(33, 151);
            ArriveComboBox.Name = "ArriveComboBox";
            ArriveComboBox.Size = new Size(121, 23);
            ArriveComboBox.TabIndex = 34;
            // 
            // DepartComboBox
            // 
            DepartComboBox.Anchor = AnchorStyles.None;
            DepartComboBox.FormattingEnabled = true;
            DepartComboBox.Location = new Point(33, 105);
            DepartComboBox.Name = "DepartComboBox";
            DepartComboBox.Size = new Size(121, 23);
            DepartComboBox.TabIndex = 35;
            // 
            // FirstFlightListBox
            // 
            FirstFlightListBox.Anchor = AnchorStyles.None;
            FirstFlightListBox.FormattingEnabled = true;
            FirstFlightListBox.ItemHeight = 15;
            FirstFlightListBox.Location = new Point(233, 117);
            FirstFlightListBox.Name = "FirstFlightListBox";
            FirstFlightListBox.Size = new Size(234, 184);
            FirstFlightListBox.TabIndex = 36;
            // 
            // SecondFlightListBox
            // 
            SecondFlightListBox.Anchor = AnchorStyles.None;
            SecondFlightListBox.FormattingEnabled = true;
            SecondFlightListBox.ItemHeight = 15;
            SecondFlightListBox.Location = new Point(473, 117);
            SecondFlightListBox.Name = "SecondFlightListBox";
            SecondFlightListBox.Size = new Size(234, 184);
            SecondFlightListBox.TabIndex = 37;
            // 
            // DepartTextBox
            // 
            DepartTextBox.Anchor = AnchorStyles.None;
            DepartTextBox.Location = new Point(33, 195);
            DepartTextBox.Name = "DepartTextBox";
            DepartTextBox.Size = new Size(100, 23);
            DepartTextBox.TabIndex = 38;
            // 
            // ReturnTextBox
            // 
            ReturnTextBox.Anchor = AnchorStyles.None;
            ReturnTextBox.Location = new Point(33, 243);
            ReturnTextBox.Name = "ReturnTextBox";
            ReturnTextBox.Size = new Size(100, 23);
            ReturnTextBox.TabIndex = 39;
            // 
            // RoundTripCheckBox
            // 
            RoundTripCheckBox.Anchor = AnchorStyles.None;
            RoundTripCheckBox.AutoSize = true;
            RoundTripCheckBox.Location = new Point(33, 301);
            RoundTripCheckBox.Name = "RoundTripCheckBox";
            RoundTripCheckBox.Size = new Size(83, 19);
            RoundTripCheckBox.TabIndex = 40;
            RoundTripCheckBox.Text = "Round Trip";
            RoundTripCheckBox.UseVisualStyleBackColor = true;
            // 
            // FlightsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RoundTripCheckBox);
            Controls.Add(ReturnTextBox);
            Controls.Add(DepartTextBox);
            Controls.Add(SecondFlightListBox);
            Controls.Add(FirstFlightListBox);
            Controls.Add(DepartComboBox);
            Controls.Add(ArriveComboBox);
            Controls.Add(PointsCheckBox);
            Controls.Add(PurchaseButton);
            Controls.Add(SearchButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FlightsForm";
            Text = "FlightsForm";
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Button SearchButton;
        private Button PurchaseButton;
        private CheckBox PointsCheckBox;
        private ComboBox ArriveComboBox;
        private ComboBox DepartComboBox;
        private ListBox FirstFlightListBox;
        private ListBox SecondFlightListBox;
        private MaskedTextBox DepartTextBox;
        private MaskedTextBox ReturnTextBox;
        private CheckBox RoundTripCheckBox;
    }
}