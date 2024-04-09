namespace MiniProject1
{
    partial class Form2
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
            comboBoxCountries = new ComboBox();
            comboBoxTowns = new ComboBox();
            adminButton = new Button();
            SuspendLayout();
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(208, 116);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(182, 33);
            comboBoxCountries.TabIndex = 0;
            // 
            // comboBoxTowns
            // 
            comboBoxTowns.FormattingEnabled = true;
            comboBoxTowns.Location = new Point(468, 116);
            comboBoxTowns.Name = "comboBoxTowns";
            comboBoxTowns.Size = new Size(182, 33);
            comboBoxTowns.TabIndex = 1;
            // 
            // adminButton
            // 
            adminButton.Location = new Point(369, 253);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(142, 34);
            adminButton.TabIndex = 3;
            adminButton.Text = "make changes";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(adminButton);
            Controls.Add(comboBoxTowns);
            Controls.Add(comboBoxCountries);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxCountries;
        private ComboBox comboBoxTowns;
        private Button adminButton;
    }
}