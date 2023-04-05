namespace GROUP9Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            CreditCardTextBox = new TextBox();
            AddressTextBox = new TextBox();
            AgeTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            IDTextBox = new TextBox();
            PasswordSignUpTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SignUpButton = new Button();
            LoginButton = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ImageAlign = ContentAlignment.TopCenter;
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(800, 89);
            Title.TabIndex = 0;
            Title.Text = "AIR 3550";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += label1_Click;
            // 
            // CreditCardTextBox
            // 
            CreditCardTextBox.Location = new Point(245, 186);
            CreditCardTextBox.Name = "CreditCardTextBox";
            CreditCardTextBox.Size = new Size(100, 23);
            CreditCardTextBox.TabIndex = 2;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(101, 186);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(100, 23);
            AddressTextBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(245, 140);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(100, 23);
            AgeTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(101, 140);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(100, 23);
            LastNameTextBox.TabIndex = 5;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(245, 96);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(100, 23);
            PhoneNumberTextBox.TabIndex = 6;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(101, 96);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(100, 23);
            FirstNameTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(138, 187);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 8;
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.None;
            IDTextBox.Location = new Point(138, 140);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 9;
            // 
            // PasswordSignUpTextBox
            // 
            PasswordSignUpTextBox.Location = new Point(101, 228);
            PasswordSignUpTextBox.Name = "PasswordSignUpTextBox";
            PasswordSignUpTextBox.Size = new Size(100, 23);
            PasswordSignUpTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 166);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 212);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 12;
            label2.Text = "Credit Card";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 166);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 13;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 122);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 14;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 254);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 212);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 16;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 166);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 17;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 122);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 18;
            label8.Text = "First Name";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(138, 213);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 19;
            label9.Text = "Password";
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(198, 301);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(75, 23);
            SignUpButton.TabIndex = 21;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(150, 301);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 22;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Bottom;
            splitContainer1.Location = new Point(0, 107);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(LoginButton);
            splitContainer1.Panel1.Controls.Add(IDTextBox);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(PasswordTextBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SignUpButton);
            splitContainer1.Panel2.Controls.Add(PhoneNumberTextBox);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(FirstNameTextBox);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(AgeTextBox);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(CreditCardTextBox);
            splitContainer1.Panel2.Controls.Add(PasswordSignUpTextBox);
            splitContainer1.Panel2.Controls.Add(AddressTextBox);
            splitContainer1.Panel2.Controls.Add(LastNameTextBox);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(800, 343);
            splitContainer1.SplitterDistance = 394;
            splitContainer1.TabIndex = 23;
            // 
            // LoginForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Controls.Add(splitContainer1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox LoginIDBox;
        private Label Air3550;
        private Label LoginIDLabel;
        private TextBox LoginPasswordBox;
        private Label LoginPasswordLabel;
        private Label Title;
        private TextBox CreditCardTextBox;
        private TextBox AddressTextBox;
        private TextBox AgeTextBox;
        private TextBox LastNameTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox FirstNameTextBox;
        private TextBox PasswordTextBox;
        private TextBox IDTextBox;
        private TextBox PasswordSignUpTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button SignUpButton;
        private Button LoginButton;
        private SplitContainer splitContainer1;
    }
}