namespace Birth_Date
{
    partial class Form1
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
            this.DayOfMonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.NameOfMonthLabel = new System.Windows.Forms.Label();
            this.DayOfWeekLabel = new System.Windows.Forms.Label();
            this.DateOutputLabel = new System.Windows.Forms.Label();
            this.DayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.NameOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.DayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShowDateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayOfMonthLabel
            // 
            this.DayOfMonthLabel.AutoSize = true;
            this.DayOfMonthLabel.Location = new System.Drawing.Point(12, 61);
            this.DayOfMonthLabel.Name = "DayOfMonthLabel";
            this.DayOfMonthLabel.Size = new System.Drawing.Size(172, 13);
            this.DayOfMonthLabel.TabIndex = 0;
            this.DayOfMonthLabel.Text = "Enter the numeric day of the month";
            this.DayOfMonthLabel.Click += new System.EventHandler(this.asdf_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(111, 85);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(73, 13);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "Enter the year";
            // 
            // NameOfMonthLabel
            // 
            this.NameOfMonthLabel.AutoSize = true;
            this.NameOfMonthLabel.Location = new System.Drawing.Point(43, 38);
            this.NameOfMonthLabel.Name = "NameOfMonthLabel";
            this.NameOfMonthLabel.Size = new System.Drawing.Size(141, 13);
            this.NameOfMonthLabel.TabIndex = 2;
            this.NameOfMonthLabel.Text = "Enter the name of the month";
            // 
            // DayOfWeekLabel
            // 
            this.DayOfWeekLabel.AutoSize = true;
            this.DayOfWeekLabel.Location = new System.Drawing.Point(55, 16);
            this.DayOfWeekLabel.Name = "DayOfWeekLabel";
            this.DayOfWeekLabel.Size = new System.Drawing.Size(129, 13);
            this.DayOfWeekLabel.TabIndex = 3;
            this.DayOfWeekLabel.Text = "Enter the day of the week";
            // 
            // DateOutputLabel
            // 
            this.DateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateOutputLabel.Location = new System.Drawing.Point(15, 120);
            this.DateOutputLabel.Name = "DateOutputLabel";
            this.DateOutputLabel.Size = new System.Drawing.Size(275, 13);
            this.DateOutputLabel.TabIndex = 4;
            this.DateOutputLabel.Click += new System.EventHandler(this.DateOutputLabel_Click);
            // 
            // DayOfWeekTextBox
            // 
            this.DayOfWeekTextBox.Location = new System.Drawing.Point(190, 12);
            this.DayOfWeekTextBox.Name = "DayOfWeekTextBox";
            this.DayOfWeekTextBox.Size = new System.Drawing.Size(100, 20);
            this.DayOfWeekTextBox.TabIndex = 5;
            this.DayOfWeekTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NameOfMonthTextBox
            // 
            this.NameOfMonthTextBox.Location = new System.Drawing.Point(190, 35);
            this.NameOfMonthTextBox.Name = "NameOfMonthTextBox";
            this.NameOfMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameOfMonthTextBox.TabIndex = 6;
            // 
            // DayOfMonthTextBox
            // 
            this.DayOfMonthTextBox.Location = new System.Drawing.Point(190, 58);
            this.DayOfMonthTextBox.Name = "DayOfMonthTextBox";
            this.DayOfMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.DayOfMonthTextBox.TabIndex = 7;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(190, 82);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearTextBox.TabIndex = 8;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(109, 152);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShowDateButton
            // 
            this.ShowDateButton.Location = new System.Drawing.Point(24, 152);
            this.ShowDateButton.Name = "ShowDateButton";
            this.ShowDateButton.Size = new System.Drawing.Size(75, 23);
            this.ShowDateButton.TabIndex = 9;
            this.ShowDateButton.Text = "Show Date";
            this.ShowDateButton.UseVisualStyleBackColor = true;
            this.ShowDateButton.Click += new System.EventHandler(this.ShowDateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(190, 152);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 187);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowDateButton);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.DayOfMonthTextBox);
            this.Controls.Add(this.NameOfMonthTextBox);
            this.Controls.Add(this.DayOfWeekTextBox);
            this.Controls.Add(this.DateOutputLabel);
            this.Controls.Add(this.DayOfWeekLabel);
            this.Controls.Add(this.NameOfMonthLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.DayOfMonthLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayOfMonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label NameOfMonthLabel;
        private System.Windows.Forms.Label DayOfWeekLabel;
        private System.Windows.Forms.Label DateOutputLabel;
        private System.Windows.Forms.TextBox DayOfWeekTextBox;
        private System.Windows.Forms.TextBox NameOfMonthTextBox;
        private System.Windows.Forms.TextBox DayOfMonthTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ShowDateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

