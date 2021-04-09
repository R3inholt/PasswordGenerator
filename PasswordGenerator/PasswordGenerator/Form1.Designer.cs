namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.lowercaseCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ambiguousCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lengthComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select desired options to create new password.";
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Location = new System.Drawing.Point(206, 55);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(91, 17);
            this.symbolsCheckBox.TabIndex = 1;
            this.symbolsCheckBox.Text = "( e.g. @#$% )";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Location = new System.Drawing.Point(206, 78);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(95, 17);
            this.numbersCheckBox.TabIndex = 2;
            this.numbersCheckBox.Text = "( e.g. 123456 )";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowercaseCharsCheckBox
            // 
            this.lowercaseCharsCheckBox.AutoSize = true;
            this.lowercaseCharsCheckBox.Location = new System.Drawing.Point(206, 101);
            this.lowercaseCharsCheckBox.Name = "lowercaseCharsCheckBox";
            this.lowercaseCharsCheckBox.Size = new System.Drawing.Size(104, 17);
            this.lowercaseCharsCheckBox.TabIndex = 3;
            this.lowercaseCharsCheckBox.Text = "( e.g. abcdefgh )";
            this.lowercaseCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // uppercaseCharsCheckBox
            // 
            this.uppercaseCharsCheckBox.AutoSize = true;
            this.uppercaseCharsCheckBox.Location = new System.Drawing.Point(206, 124);
            this.uppercaseCharsCheckBox.Name = "uppercaseCharsCheckBox";
            this.uppercaseCharsCheckBox.Size = new System.Drawing.Size(117, 17);
            this.uppercaseCharsCheckBox.TabIndex = 4;
            this.uppercaseCharsCheckBox.Text = "( e.g. ABCDEFGH )";
            this.uppercaseCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Include Symbols:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Include Numbers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Include Lowercase Characters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Include Uppercase Characters:";
            // 
            // ambiguousCharsCheckBox
            // 
            this.ambiguousCharsCheckBox.AutoSize = true;
            this.ambiguousCharsCheckBox.Location = new System.Drawing.Point(206, 147);
            this.ambiguousCharsCheckBox.Name = "ambiguousCharsCheckBox";
            this.ambiguousCharsCheckBox.Size = new System.Drawing.Size(166, 17);
            this.ambiguousCharsCheckBox.TabIndex = 5;
            this.ambiguousCharsCheckBox.Text = "( e.g. {} [] () /\\ \' \" ` ~ , ; : . <> )";
            this.ambiguousCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Exclude Ambiguous Characters:";
            // 
            // lengthComboBox
            // 
            this.lengthComboBox.FormattingEnabled = true;
            this.lengthComboBox.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.lengthComboBox.Location = new System.Drawing.Point(206, 28);
            this.lengthComboBox.Name = "lengthComboBox";
            this.lengthComboBox.Size = new System.Drawing.Size(163, 21);
            this.lengthComboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password Length:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 172);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 36);
            this.generateButton.TabIndex = 14;
            this.generateButton.Text = "Generate Password";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(12, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(357, 20);
            this.passwordTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Your Password";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(12, 56);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(112, 36);
            this.copyButton.TabIndex = 17;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.copyButton);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(31, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 110);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uppercaseCharsCheckBox);
            this.groupBox2.Controls.Add(this.symbolsCheckBox);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numbersCheckBox);
            this.groupBox2.Controls.Add(this.lengthComboBox);
            this.groupBox2.Controls.Add(this.lowercaseCharsCheckBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ambiguousCharsCheckBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(31, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 225);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox symbolsCheckBox;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.CheckBox lowercaseCharsCheckBox;
        private System.Windows.Forms.CheckBox uppercaseCharsCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ambiguousCharsCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox lengthComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

