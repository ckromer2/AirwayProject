using GROUP9Project.DataBase;

namespace GROUP9Project.UI
{
    partial class AddRouteForm
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
            this.departTime = new System.Windows.Forms.DateTimePicker();
            this.departPortLabel = new System.Windows.Forms.Label();
            this.arrivePortLabel = new System.Windows.Forms.Label();
            this.departDateLabel = new System.Windows.Forms.Label();
            this.departTimeLabel = new System.Windows.Forms.Label();
            this.LogedInLable = new System.Windows.Forms.Label();
            this.DepartComboBox = new System.Windows.Forms.ComboBox();
            this.ArriveComboBox = new System.Windows.Forms.ComboBox();
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 83);
            this.panel1.TabIndex = 18;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.AutoSize = true;
            this.EmployeeTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeTab.Location = new System.Drawing.Point(359, 12);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Size = new System.Drawing.Size(134, 37);
            this.EmployeeTab.TabIndex = 6;
            this.EmployeeTab.Text = "Employee";
            // 
            // HistoryTab
            // 
            this.HistoryTab.AutoSize = true;
            this.HistoryTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistoryTab.Location = new System.Drawing.Point(258, 12);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Size = new System.Drawing.Size(101, 37);
            this.HistoryTab.TabIndex = 7;
            this.HistoryTab.Text = "History";
            this.HistoryTab.Click += new System.EventHandler(this.HistoryTab_Click);
            // 
            // FlightsTab
            // 
            this.FlightsTab.AutoSize = true;
            this.FlightsTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightsTab.Location = new System.Drawing.Point(51, 12);
            this.FlightsTab.Name = "FlightsTab";
            this.FlightsTab.Size = new System.Drawing.Size(95, 37);
            this.FlightsTab.TabIndex = 5;
            this.FlightsTab.Text = "Flights";
            this.FlightsTab.Click += new System.EventHandler(this.FlightsTab_Click);
            // 
            // RewardsTab
            // 
            this.RewardsTab.AutoSize = true;
            this.RewardsTab.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardsTab.Location = new System.Drawing.Point(144, 12);
            this.RewardsTab.Name = "RewardsTab";
            this.RewardsTab.Size = new System.Drawing.Size(116, 37);
            this.RewardsTab.TabIndex = 8;
            this.RewardsTab.Text = "Rewards";
            this.RewardsTab.Click += new System.EventHandler(this.RewardsTab_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add/Modify/Remove Routes";
            // 
            // RoutesListBox
            // 
            this.RoutesListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoutesListBox.FormattingEnabled = true;
            this.RoutesListBox.ItemHeight = 20;
            this.RoutesListBox.Location = new System.Drawing.Point(62, 155);
            this.RoutesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoutesListBox.Name = "RoutesListBox";
            this.RoutesListBox.Size = new System.Drawing.Size(501, 124);
            this.RoutesListBox.TabIndex = 20;
            this.RoutesListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.RouteListBoxFormat);
            // 
            // AddRouteButton
            // 
            this.AddRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddRouteButton.Location = new System.Drawing.Point(591, 153);
            this.AddRouteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRouteButton.Name = "AddRouteButton";
            this.AddRouteButton.Size = new System.Drawing.Size(166, 49);
            this.AddRouteButton.TabIndex = 21;
            this.AddRouteButton.Text = "Add Route";
            this.AddRouteButton.UseVisualStyleBackColor = true;
            this.AddRouteButton.Click += new System.EventHandler(this.AddRouteButton_Click);
            // 
            // RemoveRouteButton
            // 
            this.RemoveRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveRouteButton.Location = new System.Drawing.Point(591, 235);
            this.RemoveRouteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveRouteButton.Name = "RemoveRouteButton";
            this.RemoveRouteButton.Size = new System.Drawing.Size(166, 49);
            this.RemoveRouteButton.TabIndex = 22;
            this.RemoveRouteButton.Text = "Remove Route";
            this.RemoveRouteButton.UseVisualStyleBackColor = true;
            this.RemoveRouteButton.Click += new System.EventHandler(this.RemoveRouteButton_Click);
            // 
            // ModifyRouteButton
            // 
            this.ModifyRouteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifyRouteButton.Location = new System.Drawing.Point(591, 315);
            this.ModifyRouteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModifyRouteButton.Name = "ModifyRouteButton";
            this.ModifyRouteButton.Size = new System.Drawing.Size(166, 49);
            this.ModifyRouteButton.TabIndex = 23;
            this.ModifyRouteButton.Text = "Modify Route";
            this.ModifyRouteButton.UseVisualStyleBackColor = true;
            this.ModifyRouteButton.Click += new System.EventHandler(this.ModifyRouteButton_Click);
            // 
            // departTime
            // 
            this.departTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departTime.Location = new System.Drawing.Point(218, 487);
            this.departTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.departTime.Name = "departTime";
            this.departTime.Size = new System.Drawing.Size(165, 27);
            this.departTime.TabIndex = 29;
            // 
            // departPortLabel
            // 
            this.departPortLabel.Location = new System.Drawing.Point(31, 324);
            this.departPortLabel.Name = "departPortLabel";
            this.departPortLabel.Size = new System.Drawing.Size(133, 23);
            this.departPortLabel.TabIndex = 31;
            this.departPortLabel.Text = "Departure Airport";
            // 
            // arrivePortLabel
            // 
            this.arrivePortLabel.Location = new System.Drawing.Point(31, 378);
            this.arrivePortLabel.Name = "arrivePortLabel";
            this.arrivePortLabel.Size = new System.Drawing.Size(115, 23);
            this.arrivePortLabel.TabIndex = 32;
            this.arrivePortLabel.Text = "Arrival Airport";
            // 
            // departDateLabel
            // 
            this.departDateLabel.Location = new System.Drawing.Point(31, 432);
            this.departDateLabel.Name = "departDateLabel";
            this.departDateLabel.Size = new System.Drawing.Size(115, 23);
            this.departDateLabel.TabIndex = 33;
            this.departDateLabel.Text = "Depart Date";
            // 
            // departTimeLabel
            // 
            this.departTimeLabel.Location = new System.Drawing.Point(31, 487);
            this.departTimeLabel.Name = "departTimeLabel";
            this.departTimeLabel.Size = new System.Drawing.Size(115, 23);
            this.departTimeLabel.TabIndex = 34;
            this.departTimeLabel.Text = "Depart Time";
            // 
            // LogedInLable
            // 
            this.LogedInLable.AutoSize = true;
            this.LogedInLable.Location = new System.Drawing.Point(723, 12);
            this.LogedInLable.Name = "LogedInLable";
            this.LogedInLable.Size = new System.Drawing.Size(0, 20);
            this.LogedInLable.TabIndex = 24;
            // 
            // DepartComboBox
            // 
            this.DepartComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartComboBox.FormattingEnabled = true;
            this.DepartComboBox.Location = new System.Drawing.Point(218, 324);
            this.DepartComboBox.Name = "DepartComboBox";
            this.DepartComboBox.Size = new System.Drawing.Size(165, 28);
            this.DepartComboBox.TabIndex = 36;
            this.DepartComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartComboBox_SelectedIndexChanged);
            // 
            // ArriveComboBox
            // 
            this.ArriveComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArriveComboBox.FormattingEnabled = true;
            this.ArriveComboBox.Location = new System.Drawing.Point(218, 378);
            this.ArriveComboBox.Name = "ArriveComboBox";
            this.ArriveComboBox.Size = new System.Drawing.Size(165, 28);
            this.ArriveComboBox.TabIndex = 37;
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.CustomFormat = "MMM, dd yyyy";
            this.DepartureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureDatePicker.Location = new System.Drawing.Point(218, 432);
            this.DepartureDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepartureDatePicker.MaxDate = new System.DateTime(2023, 10, 25, 0, 0, 0, 0);
            this.DepartureDatePicker.MinDate = new System.DateTime(2023, 4, 25, 0, 0, 0, 0);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.Size = new System.Drawing.Size(165, 27);
            this.DepartureDatePicker.TabIndex = 42;
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.ArriveComboBox);
            this.Controls.Add(this.DepartComboBox);
            this.Controls.Add(this.LogedInLable);
            this.Controls.Add(this.ModifyRouteButton);
            this.Controls.Add(this.RemoveRouteButton);
            this.Controls.Add(this.AddRouteButton);
            this.Controls.Add(this.RoutesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.departTime);
            this.Controls.Add(this.departPortLabel);
            this.Controls.Add(this.arrivePortLabel);
            this.Controls.Add(this.departDateLabel);
            this.Controls.Add(this.departTimeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddRouteForm";
            this.Text = "RouteManagerForm";
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
        private Label departPortLabel;
        private Label arrivePortLabel;
        private Label departDateLabel;
        private Label departTimeLabel;
        private DateTimePicker departTime;
        private ListBox RoutesListBox;
        private Button AddRouteButton;
        private Button RemoveRouteButton;
        private Button ModifyRouteButton;
        private Label LogedInLable;
        private ComboBox DepartComboBox;
        private ComboBox ArriveComboBox;
        private DateTimePicker DepartureDatePicker;
    }
}