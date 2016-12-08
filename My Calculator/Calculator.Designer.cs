namespace CSharpTutorial1
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.SixthButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.FiftButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DisplayTextBox.Location = new System.Drawing.Point(39, 8);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(330, 35);
            this.DisplayTextBox.TabIndex = 0;
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SevenButton.Location = new System.Drawing.Point(39, 80);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(52, 46);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(97, 80);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(52, 46);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(155, 80);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(52, 46);
            this.NineButton.TabIndex = 1;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Location = new System.Drawing.Point(251, 80);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(52, 46);
            this.SquareRootButton.TabIndex = 1;
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // CButton
            // 
            this.CButton.Location = new System.Drawing.Point(317, 80);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(52, 46);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.Location = new System.Drawing.Point(251, 132);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(52, 46);
            this.PlusMinus.TabIndex = 1;
            this.PlusMinus.Text = "+/-";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // ModButton
            // 
            this.ModButton.Location = new System.Drawing.Point(317, 132);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(52, 46);
            this.ModButton.TabIndex = 1;
            this.ModButton.Text = "%";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.MinusButton);
            this.panel1.Controls.Add(this.MultiplicationButton);
            this.panel1.Controls.Add(this.ModButton);
            this.panel1.Controls.Add(this.PlusButton);
            this.panel1.Controls.Add(this.DivideButton);
            this.panel1.Controls.Add(this.PlusMinus);
            this.panel1.Controls.Add(this.CButton);
            this.panel1.Controls.Add(this.SquareRootButton);
            this.panel1.Controls.Add(this.NineButton);
            this.panel1.Controls.Add(this.EightButton);
            this.panel1.Controls.Add(this.EqualButton);
            this.panel1.Controls.Add(this.ThreeButton);
            this.panel1.Controls.Add(this.SixthButton);
            this.panel1.Controls.Add(this.ZeroButton);
            this.panel1.Controls.Add(this.OneButton);
            this.panel1.Controls.Add(this.PointButton);
            this.panel1.Controls.Add(this.TwoButton);
            this.panel1.Controls.Add(this.FiftButton);
            this.panel1.Controls.Add(this.FourButton);
            this.panel1.Controls.Add(this.SevenButton);
            this.panel1.Controls.Add(this.DisplayTextBox);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 327);
            this.panel1.TabIndex = 0;
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(317, 237);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(52, 46);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Location = new System.Drawing.Point(317, 184);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(52, 47);
            this.MultiplicationButton.TabIndex = 1;
            this.MultiplicationButton.Text = "*";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(251, 237);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(52, 46);
            this.PlusButton.TabIndex = 1;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(251, 184);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(52, 47);
            this.DivideButton.TabIndex = 1;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(155, 237);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(52, 46);
            this.EqualButton.TabIndex = 1;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(155, 184);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(52, 47);
            this.ThreeButton.TabIndex = 1;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // SixthButton
            // 
            this.SixthButton.Location = new System.Drawing.Point(155, 132);
            this.SixthButton.Name = "SixthButton";
            this.SixthButton.Size = new System.Drawing.Size(52, 46);
            this.SixthButton.TabIndex = 1;
            this.SixthButton.Text = "6";
            this.SixthButton.UseVisualStyleBackColor = true;
            this.SixthButton.Click += new System.EventHandler(this.SixthButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(39, 237);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(52, 46);
            this.ZeroButton.TabIndex = 1;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(39, 184);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(52, 47);
            this.OneButton.TabIndex = 1;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Location = new System.Drawing.Point(97, 237);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(52, 46);
            this.PointButton.TabIndex = 1;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(97, 184);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(52, 47);
            this.TwoButton.TabIndex = 1;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // FiftButton
            // 
            this.FiftButton.Location = new System.Drawing.Point(97, 132);
            this.FiftButton.Name = "FiftButton";
            this.FiftButton.Size = new System.Drawing.Size(52, 46);
            this.FiftButton.TabIndex = 1;
            this.FiftButton.Text = "5";
            this.FiftButton.UseVisualStyleBackColor = true;
            this.FiftButton.Click += new System.EventHandler(this.FiftButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(39, 132);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(52, 46);
            this.FourButton.TabIndex = 1;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 334);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                           Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.calculator_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button SixthButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button FiftButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button DivideButton;
    }
}

