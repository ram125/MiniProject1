namespace MiniProject1
{
    partial class Form4
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordAgainTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(353, 267);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 171);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 1;
            label1.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 120);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(352, 119);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(150, 31);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(353, 171);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(150, 31);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordAgainTextBox
            // 
            passwordAgainTextBox.Location = new Point(353, 220);
            passwordAgainTextBox.Name = "passwordAgainTextBox";
            passwordAgainTextBox.Size = new Size(150, 31);
            passwordAgainTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 226);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 6;
            label3.Text = "password again";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(passwordAgainTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox passwordAgainTextBox;
        private Label label3;
    }
}