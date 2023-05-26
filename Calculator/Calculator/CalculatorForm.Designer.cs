namespace Calculator
{
    partial class CalculatorForm
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
            OneButton = new Button();
            button2 = new Button();
            threeButton = new Button();
            fourButton = new Button();
            fiveButton = new Button();
            sixButton = new Button();
            sevenButton = new Button();
            eightButton = new Button();
            nineButton = new Button();
            zeroButton = new Button();
            equalsButton = new Button();
            plusButton = new Button();
            substractionButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            inOutLabel = new Label();
            SuspendLayout();
            // 
            // OneButton
            // 
            OneButton.Location = new Point(102, 211);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(60, 60);
            OneButton.TabIndex = 0;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.MouseClick += OneButtonMouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(168, 211);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.MouseClick += TwoButtonMouseClick;
            // 
            // threeButton
            // 
            threeButton.Location = new Point(234, 211);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(60, 60);
            threeButton.TabIndex = 2;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.MouseClick += ThreeButtonMouseClick;
            // 
            // fourButton
            // 
            fourButton.Location = new Point(102, 277);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(60, 60);
            fourButton.TabIndex = 3;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.MouseClick += FourButtonMouseClick;
            // 
            // fiveButton
            // 
            fiveButton.Location = new Point(168, 277);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(60, 60);
            fiveButton.TabIndex = 4;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.MouseClick += FiveButtonMouseClick;
            // 
            // sixButton
            // 
            sixButton.Location = new Point(234, 277);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(60, 60);
            sixButton.TabIndex = 5;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.MouseClick += SixButtonMouseClick;
            // 
            // sevenButton
            // 
            sevenButton.Location = new Point(102, 343);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(60, 60);
            sevenButton.TabIndex = 6;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.MouseClick += SevenButtonMouseClick;
            // 
            // eightButton
            // 
            eightButton.Location = new Point(168, 343);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(60, 60);
            eightButton.TabIndex = 7;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.MouseClick += EightButtonMouseClick;
            // 
            // nineButton
            // 
            nineButton.Location = new Point(234, 343);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(60, 60);
            nineButton.TabIndex = 8;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.MouseClick += NineButtonMouseClick;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(102, 409);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(60, 60);
            zeroButton.TabIndex = 9;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.MouseClick += ZeroButtonMouseClick;
            // 
            // equalsButton
            // 
            equalsButton.Location = new Point(168, 409);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(126, 60);
            equalsButton.TabIndex = 11;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.MouseClick += equalsButton_MouseClick;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(300, 211);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(60, 60);
            plusButton.TabIndex = 12;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.MouseClick += AdditionButtonMouseClick;
            // 
            // substractionButton
            // 
            substractionButton.Location = new Point(300, 277);
            substractionButton.Name = "substractionButton";
            substractionButton.Size = new Size(60, 60);
            substractionButton.TabIndex = 13;
            substractionButton.Text = "-";
            substractionButton.UseVisualStyleBackColor = true;
            substractionButton.MouseClick += SubtractionButtonMouseClick;
            // 
            // multiplicationButton
            // 
            multiplicationButton.Location = new Point(300, 343);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(60, 60);
            multiplicationButton.TabIndex = 14;
            multiplicationButton.Text = "*";
            multiplicationButton.UseVisualStyleBackColor = true;
            multiplicationButton.MouseClick += MultiplicationButtonMouseClick;
            // 
            // divisionButton
            // 
            divisionButton.Location = new Point(300, 409);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(60, 60);
            divisionButton.TabIndex = 15;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = true;
            divisionButton.MouseClick += DivisionButtonMouseClick;
            // 
            // inOutLabel
            // 
            inOutLabel.AutoSize = true;
            inOutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inOutLabel.Location = new Point(102, 126);
            inOutLabel.Name = "inOutLabel";
            inOutLabel.Size = new Size(0, 28);
            inOutLabel.TabIndex = 16;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 503);
            Controls.Add(inOutLabel);
            Controls.Add(divisionButton);
            Controls.Add(multiplicationButton);
            Controls.Add(substractionButton);
            Controls.Add(plusButton);
            Controls.Add(equalsButton);
            Controls.Add(zeroButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(threeButton);
            Controls.Add(button2);
            Controls.Add(OneButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OneButton;
        private Button button2;
        private Button threeButton;
        private Button fourButton;
        private Button fiveButton;
        private Button sixButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button zeroButton;
        private Button equalsButton;
        private Button plusButton;
        private Button substractionButton;
        private Button multiplicationButton;
        private Button divisionButton;
        private Label inOutLabel;
    }
}