namespace GROUP9Project.UI
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
            panel1 = new Panel();
            EmployeeTab = new Label();
            HistoryTab = new Label();
            FlightsTab = new Label();
            RewardsTab = new Label();
            label1 = new Label();
            RoutesListBox = new ListBox();
            AddRouteButton = new Button();
            RemoveRouteButton = new Button();
            ModifyRouteButton = new Button();
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
            panel1.TabIndex = 18;
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
            label1.Location = new Point(54, 65);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 19;
            label1.Text = "Offered Routes";
            // 
            // RoutesListBox
            // 
            RoutesListBox.Anchor = AnchorStyles.None;
            RoutesListBox.FormattingEnabled = true;
            RoutesListBox.ItemHeight = 15;
            RoutesListBox.Location = new Point(54, 116);
            RoutesListBox.Name = "RoutesListBox";
            RoutesListBox.Size = new Size(386, 304);
            RoutesListBox.TabIndex = 20;
            // 
            // AddRouteButton
            // 
            AddRouteButton.Anchor = AnchorStyles.None;
            AddRouteButton.Location = new Point(517, 115);
            AddRouteButton.Name = "AddRouteButton";
            AddRouteButton.Size = new Size(145, 37);
            AddRouteButton.TabIndex = 21;
            AddRouteButton.Text = "Add Route";
            AddRouteButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRouteButton
            // 
            RemoveRouteButton.Anchor = AnchorStyles.None;
            RemoveRouteButton.Location = new Point(517, 176);
            RemoveRouteButton.Name = "RemoveRouteButton";
            RemoveRouteButton.Size = new Size(145, 37);
            RemoveRouteButton.TabIndex = 22;
            RemoveRouteButton.Text = "Remove Route";
            RemoveRouteButton.UseVisualStyleBackColor = true;
            // 
            // ModifyRouteButton
            // 
            ModifyRouteButton.Anchor = AnchorStyles.None;
            ModifyRouteButton.Location = new Point(517, 235);
            ModifyRouteButton.Name = "ModifyRouteButton";
            ModifyRouteButton.Size = new Size(145, 37);
            ModifyRouteButton.TabIndex = 23;
            ModifyRouteButton.Text = "Modify Route";
            ModifyRouteButton.UseVisualStyleBackColor = true;
            // 
            // LoadManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModifyRouteButton);
            Controls.Add(RemoveRouteButton);
            Controls.Add(AddRouteButton);
            Controls.Add(RoutesListBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "LoadManagerForm";
            Text = "LoadManagerForm";
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
        private ListBox RoutesListBox;
        private Button AddRouteButton;
        private Button RemoveRouteButton;
        private Button ModifyRouteButton;
    }
}