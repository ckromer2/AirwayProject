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
            SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ImageAlign = ContentAlignment.TopCenter;
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(807, 89);
            Title.TabIndex = 0;
            Title.Text = "AIR 3550";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += label1_Click;
            // 
            // CreditCardTextBox
            // 
            CreditCardTextBox.Location = new Point(631, 299);
            CreditCardTextBox.Name = "CreditCardTextBox";
            CreditCardTextBox.Size = new Size(100, 23);
            CreditCardTextBox.TabIndex = 2;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(487, 299);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(100, 23);
            AddressTextBox.TabIndex = 3;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(631, 253);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(100, 23);
            AgeTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(487, 253);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(100, 23);
            LastNameTextBox.TabIndex = 5;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(631, 206);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(100, 23);
            PhoneNumberTextBox.TabIndex = 6;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(487, 206);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(100, 23);
            FirstNameTextBox.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(82, 289);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 8;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(82, 242);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 9;
            // 
            // PasswordSignUpTextBox
            // 
            PasswordSignUpTextBox.Location = new Point(487, 341);
            PasswordSignUpTextBox.Name = "PasswordSignUpTextBox";
            PasswordSignUpTextBox.Size = new Size(100, 23);
            PasswordSignUpTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 268);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(631, 325);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 12;
            label2.Text = "Credit Card";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(631, 279);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 13;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 229);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 14;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 367);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 325);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 16;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 279);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 17;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 229);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 18;
            label8.Text = "First Name";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 315);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 19;
            label9.Text = "Password";
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(584, 403);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(75, 23);
            SignUpButton.TabIndex = 21;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(93, 403);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 22;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(LoginButton);
            Controls.Add(SignUpButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordSignUpTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(AgeTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CreditCardTextBox);
            Controls.Add(Title);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
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
    }
}