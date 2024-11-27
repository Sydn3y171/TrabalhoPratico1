namespace GestaoObras
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            Clearbutton = new Button();
            Loginbutton = new Button();
            Registerbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label1.Location = new Point(176, 65);
            label1.Name = "label1";
            label1.Size = new Size(281, 27);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Constructly";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Century Gothic", 10.8F);
            UsernameLabel.Location = new Point(97, 159);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(108, 21);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username :";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Century Gothic", 10.8F);
            PasswordLabel.Location = new Point(97, 225);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(100, 21);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password :";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Century Gothic", 10.8F);
            UsernameTextBox.Location = new Point(231, 153);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(226, 30);
            UsernameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Century Gothic", 10.8F);
            PasswordTextBox.Location = new Point(231, 220);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(226, 30);
            PasswordTextBox.TabIndex = 4;
            // 
            // Clearbutton
            // 
            Clearbutton.Font = new Font("Century Gothic", 9F);
            Clearbutton.Location = new Point(231, 280);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(94, 29);
            Clearbutton.TabIndex = 5;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = true;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.Font = new Font("Century Gothic", 9F);
            Loginbutton.Location = new Point(363, 280);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(94, 29);
            Loginbutton.TabIndex = 6;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // Registerbutton
            // 
            Registerbutton.Font = new Font("Century Gothic", 9F);
            Registerbutton.Location = new Point(231, 324);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(226, 29);
            Registerbutton.TabIndex = 7;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = true;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 421);
            Controls.Add(Registerbutton);
            Controls.Add(Loginbutton);
            Controls.Add(Clearbutton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login Constructly";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button Clearbutton;
        private Button Loginbutton;
        private Button Registerbutton;
    }
}