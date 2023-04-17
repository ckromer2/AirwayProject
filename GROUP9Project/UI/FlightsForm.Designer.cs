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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeeTab = new System.Windows.Forms.Label();
            this.HistoryTab = new System.Windows.Forms.Label();
            this.FlightsTab = new System.Windows.Forms.Label();
            this.RewardsTab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReturnDateLable = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.PointsCheckBox = new System.Windows.Forms.CheckBox();
            this.ArriveComboBox = new System.Windows.Forms.ComboBox();
            this.DepartComboBox = new System.Windows.Forms.ComboBox();
            this.FirstFlightListBox = new System.Windows.Forms.ListBox();
            this.SecondFlightListBox = new System.Windows.Forms.ListBox();
            this.RoundTripCheckBox = new System.Windows.Forms.CheckBox();
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.TabIndex = 17;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.AutoSize = true;
            this.EmployeeTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeTab.Location = new System.Drawing.Point(553, 9);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Size = new System.Drawing.Size(109, 30);
            this.EmployeeTab.TabIndex = 6;
            this.EmployeeTab.Text = "Employee";
            // 
            // HistoryTab
            // 
            this.HistoryTab.AutoSize = true;
            this.HistoryTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistoryTab.Location = new System.Drawing.Point(385, 9);
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
            // 
            // RewardsTab
            // 
            this.RewardsTab.AutoSize = true;
            this.RewardsTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardsTab.Location = new System.Drawing.Point(213, 9);
            this.RewardsTab.Name = "RewardsTab";
            this.RewardsTab.Size = new System.Drawing.Size(94, 30);
            this.RewardsTab.TabIndex = 8;
            this.RewardsTab.Text = "Rewards";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Flight";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(531, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Second Flight";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Depart";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Arrive";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Depart Date";
            // 
            // ReturnDateLable
            // 
            this.ReturnDateLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnDateLable.AutoSize = true;
            this.ReturnDateLable.Location = new System.Drawing.Point(33, 246);
            this.ReturnDateLable.Name = "ReturnDateLable";
            this.ReturnDateLable.Size = new System.Drawing.Size(69, 15);
            this.ReturnDateLable.TabIndex = 30;
            this.ReturnDateLable.Text = "Return Date";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.Location = new System.Drawing.Point(33, 307);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurchaseButton.Location = new System.Drawing.Point(428, 332);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(174, 23);
            this.PurchaseButton.TabIndex = 32;
            this.PurchaseButton.Text = "Purchase Selected Flights";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            // 
            // PointsCheckBox
            // 
            this.PointsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PointsCheckBox.AutoSize = true;
            this.PointsCheckBox.Location = new System.Drawing.Point(476, 307);
            this.PointsCheckBox.Name = "PointsCheckBox";
            this.PointsCheckBox.Size = new System.Drawing.Size(81, 19);
            this.PointsCheckBox.TabIndex = 33;
            this.PointsCheckBox.Text = "Use Points";
            this.PointsCheckBox.UseVisualStyleBackColor = true;
            this.PointsCheckBox.CheckedChanged += new System.EventHandler(this.PointsCheckBox_CheckedChanged);
            // 
            // ArriveComboBox
            // 
            this.ArriveComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArriveComboBox.FormattingEnabled = true;
            this.ArriveComboBox.Location = new System.Drawing.Point(33, 151);
            this.ArriveComboBox.Name = "ArriveComboBox";
            this.ArriveComboBox.Size = new System.Drawing.Size(121, 23);
            this.ArriveComboBox.TabIndex = 34;
            // 
            // DepartComboBox
            // 
            this.DepartComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartComboBox.FormattingEnabled = true;
            this.DepartComboBox.Location = new System.Drawing.Point(33, 105);
            this.DepartComboBox.Name = "DepartComboBox";
            this.DepartComboBox.Size = new System.Drawing.Size(121, 23);
            this.DepartComboBox.TabIndex = 35;
            this.DepartComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartComboBox_SelectedIndexChanged);
            // 
            // FirstFlightListBox
            // 
            this.FirstFlightListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstFlightListBox.FormattingEnabled = true;
            this.FirstFlightListBox.ItemHeight = 15;
            this.FirstFlightListBox.Location = new System.Drawing.Point(262, 117);
            this.FirstFlightListBox.Name = "FirstFlightListBox";
            this.FirstFlightListBox.Size = new System.Drawing.Size(234, 184);
            this.FirstFlightListBox.TabIndex = 36;
            // 
            // SecondFlightListBox
            // 
            this.SecondFlightListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondFlightListBox.FormattingEnabled = true;
            this.SecondFlightListBox.ItemHeight = 15;
            this.SecondFlightListBox.Location = new System.Drawing.Point(531, 117);
            this.SecondFlightListBox.Name = "SecondFlightListBox";
            this.SecondFlightListBox.Size = new System.Drawing.Size(234, 184);
            this.SecondFlightListBox.TabIndex = 37;
            // 
            // RoundTripCheckBox
            // 
            this.RoundTripCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoundTripCheckBox.AutoSize = true;
            this.RoundTripCheckBox.Location = new System.Drawing.Point(33, 224);
            this.RoundTripCheckBox.Name = "RoundTripCheckBox";
            this.RoundTripCheckBox.Size = new System.Drawing.Size(83, 19);
            this.RoundTripCheckBox.TabIndex = 40;
            this.RoundTripCheckBox.Text = "Round Trip";
            this.RoundTripCheckBox.UseVisualStyleBackColor = true;
            this.RoundTripCheckBox.CheckedChanged += new System.EventHandler(this.RoundTripCheckBox_CheckedChanged);
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.Location = new System.Drawing.Point(33, 195);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.Size = new System.Drawing.Size(200, 23);
            this.DepartureDatePicker.TabIndex = 41;
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Location = new System.Drawing.Point(33, 264);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(200, 23);
            this.ReturnDatePicker.TabIndex = 42;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.RoundTripCheckBox);
            this.Controls.Add(this.SecondFlightListBox);
            this.Controls.Add(this.FirstFlightListBox);
            this.Controls.Add(this.DepartComboBox);
            this.Controls.Add(this.ArriveComboBox);
            this.Controls.Add(this.PointsCheckBox);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ReturnDateLable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
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
        private Label label4;
        private Label label5;
        private Label ReturnDateLable;
        private Button SearchButton;
        private Button PurchaseButton;
        private CheckBox PointsCheckBox;
        private ComboBox ArriveComboBox;
        private ComboBox DepartComboBox;
        private ListBox FirstFlightListBox;
        private ListBox SecondFlightListBox;
        private CheckBox RoundTripCheckBox;
        private DateTimePicker DepartureDatePicker;
        private DateTimePicker ReturnDatePicker;
        private List<DataBase.Route> PossibleRoutes1;
        private List<int> ListBoxToRoute1;
        private List<DataBase.Route> PossibleRoutes2;
        private List<int> ListBoxToRoute2;
    }
}