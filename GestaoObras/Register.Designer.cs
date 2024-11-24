namespace GestaoObras
{
    partial class Register
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
            ReguserLabel = new Label();
            RegpassLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            Regclearbutton = new Button();
            RegcreatButton = new Button();
            SuspendLayout();
            // 
            // ReguserLabel
            // 
            ReguserLabel.AutoSize = true;
            ReguserLabel.Font = new Font("Century Gothic", 10.8F);
            ReguserLabel.Location = new Point(81, 154);
            ReguserLabel.Name = "ReguserLabel";
            ReguserLabel.Size = new Size(108, 21);
            ReguserLabel.TabIndex = 0;
            ReguserLabel.Text = "Username :";
            // 
            // RegpassLabel
            // 
            RegpassLabel.AutoSize = true;
            RegpassLabel.Font = new Font("Century Gothic", 10.8F);
            RegpassLabel.Location = new Point(81, 236);
            RegpassLabel.Name = "RegpassLabel";
            RegpassLabel.Size = new Size(100, 21);
            RegpassLabel.TabIndex = 1;
            RegpassLabel.Text = "Password :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 10.8F);
            textBox1.Location = new Point(195, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 30);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 10.8F);
            textBox2.Location = new Point(195, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 30);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label1.Location = new Point(172, 70);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 4;
            label1.Text = "Creat Account";
            // 
            // Regclearbutton
            // 
            Regclearbutton.Font = new Font("Century Gothic", 9F);
            Regclearbutton.Location = new Point(138, 314);
            Regclearbutton.Name = "Regclearbutton";
            Regclearbutton.Size = new Size(94, 29);
            Regclearbutton.TabIndex = 5;
            Regclearbutton.Text = "Clear";
            Regclearbutton.UseVisualStyleBackColor = true;
            // 
            // RegcreatButton
            // 
            RegcreatButton.Font = new Font("Century Gothic", 9F);
            RegcreatButton.Location = new Point(303, 314);
            RegcreatButton.Name = "RegcreatButton";
            RegcreatButton.Size = new Size(94, 29);
            RegcreatButton.TabIndex = 6;
            RegcreatButton.Text = "Create";
            RegcreatButton.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 427);
            Controls.Add(RegcreatButton);
            Controls.Add(Regclearbutton);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(RegpassLabel);
            Controls.Add(ReguserLabel);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReguserLabel;
        private Label RegpassLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button Regclearbutton;
        private Button RegcreatButton;
    }
}