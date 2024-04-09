namespace MiniProject1
{
    partial class Form3
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
            addTown = new Button();
            button2 = new Button();
            UpdateTownButton = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            townTextBox = new TextBox();
            replacedTownTextBox = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // addTown
            // 
            addTown.Location = new Point(224, 224);
            addTown.Name = "addTown";
            addTown.Size = new Size(112, 34);
            addTown.TabIndex = 0;
            addTown.Text = "Add town";
            addTown.UseVisualStyleBackColor = true;
            addTown.Click += AddTownButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(467, 224);
            button2.Name = "button2";
            button2.Size = new Size(133, 34);
            button2.TabIndex = 1;
            button2.Text = "Add country";
            button2.UseVisualStyleBackColor = true;
            // 
            // UpdateTownButton
            // 
            UpdateTownButton.Location = new Point(224, 295);
            UpdateTownButton.Name = "UpdateTownButton";
            UpdateTownButton.Size = new Size(130, 34);
            UpdateTownButton.TabIndex = 2;
            UpdateTownButton.Text = "Update town";
            UpdateTownButton.UseVisualStyleBackColor = true;
            UpdateTownButton.Click += UpdateTownButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(467, 295);
            button4.Name = "button4";
            button4.Size = new Size(163, 34);
            button4.TabIndex = 3;
            button4.Text = "Update country";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(224, 368);
            button5.Name = "button5";
            button5.Size = new Size(140, 34);
            button5.TabIndex = 4;
            button5.Text = "Delete town";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(467, 368);
            button6.Name = "button6";
            button6.Size = new Size(150, 34);
            button6.TabIndex = 5;
            button6.Text = "Delete country";
            button6.UseVisualStyleBackColor = true;
            // 
            // townTextBox
            // 
            townTextBox.Location = new Point(224, 52);
            townTextBox.Name = "townTextBox";
            townTextBox.Size = new Size(150, 31);
            townTextBox.TabIndex = 6;
            // 
            // replacedTownTextBox
            // 
            replacedTownTextBox.Location = new Point(224, 139);
            replacedTownTextBox.Name = "replacedTownTextBox";
            replacedTownTextBox.Size = new Size(150, 31);
            replacedTownTextBox.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(592, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(592, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 58);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 10;
            label1.Text = "Town";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 145);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 11;
            label2.Text = "Replace town with";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 55);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 12;
            label3.Text = "country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 145);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 13;
            label4.Text = "Replace country with";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(replacedTownTextBox);
            Controls.Add(townTextBox);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(UpdateTownButton);
            Controls.Add(button2);
            Controls.Add(addTown);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addTown;
        private Button button2;
        private Button UpdateTownButton;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox townTextBox;
        private TextBox replacedTownTextBox;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}