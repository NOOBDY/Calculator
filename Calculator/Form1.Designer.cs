
using System;
using System.Windows.Forms;

namespace Calculator
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
            this._additionButton = new System.Windows.Forms.Button();
            this._subtractionButton = new System.Windows.Forms.Button();
            this._multiplicationButton = new System.Windows.Forms.Button();
            this._divisionButton = new System.Windows.Forms.Button();
            this._equalsButton = new System.Windows.Forms.Button();
            this._dotButton = new System.Windows.Forms.Button();
            this._number7Button = new System.Windows.Forms.Button();
            this._number8Button = new System.Windows.Forms.Button();
            this._number9Button = new System.Windows.Forms.Button();
            this._number4Button = new System.Windows.Forms.Button();
            this._number5Button = new System.Windows.Forms.Button();
            this._number1Button = new System.Windows.Forms.Button();
            this._number6Button = new System.Windows.Forms.Button();
            this._number3Button = new System.Windows.Forms.Button();
            this._number2Button = new System.Windows.Forms.Button();
            this._number0Button = new System.Windows.Forms.Button();
            this._clearAllButton = new System.Windows.Forms.Button();
            this._clearButton = new System.Windows.Forms.Button();
            this._textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _additionButton
            // 
            this._additionButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._additionButton.Location = new System.Drawing.Point(160, 98);
            this._additionButton.Name = "_additionButton";
            this._additionButton.Size = new System.Drawing.Size(50, 50);
            this._additionButton.TabIndex = 0;
            this._additionButton.Text = "+";
            this._additionButton.UseVisualStyleBackColor = true;
            // 
            // _subtractionButton
            // 
            this._subtractionButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._subtractionButton.Location = new System.Drawing.Point(160, 148);
            this._subtractionButton.Name = "_subtractionButton";
            this._subtractionButton.Size = new System.Drawing.Size(50, 50);
            this._subtractionButton.TabIndex = 1;
            this._subtractionButton.Text = "-";
            this._subtractionButton.UseVisualStyleBackColor = true;
            // 
            // _multiplicationButton
            // 
            this._multiplicationButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._multiplicationButton.Location = new System.Drawing.Point(160, 198);
            this._multiplicationButton.Name = "_multiplicationButton";
            this._multiplicationButton.Size = new System.Drawing.Size(50, 50);
            this._multiplicationButton.TabIndex = 2;
            this._multiplicationButton.Text = "*";
            this._multiplicationButton.UseVisualStyleBackColor = true;
            // 
            // _divisionButton
            // 
            this._divisionButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._divisionButton.Location = new System.Drawing.Point(160, 248);
            this._divisionButton.Name = "_divisionButton";
            this._divisionButton.Size = new System.Drawing.Size(50, 50);
            this._divisionButton.TabIndex = 3;
            this._divisionButton.Text = "/";
            this._divisionButton.UseVisualStyleBackColor = true;
            // 
            // _equalsButton
            // 
            this._equalsButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._equalsButton.Location = new System.Drawing.Point(110, 248);
            this._equalsButton.Name = "_equalsButton";
            this._equalsButton.Size = new System.Drawing.Size(50, 50);
            this._equalsButton.TabIndex = 4;
            this._equalsButton.Text = "=";
            this._equalsButton.UseVisualStyleBackColor = true;
            this._equalsButton.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // _dotButton
            // 
            this._dotButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dotButton.Location = new System.Drawing.Point(60, 248);
            this._dotButton.Name = "_dotButton";
            this._dotButton.Size = new System.Drawing.Size(50, 50);
            this._dotButton.TabIndex = 5;
            this._dotButton.Text = ".";
            this._dotButton.UseVisualStyleBackColor = true;
            this._dotButton.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // _number7Button
            // 
            this._number7Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number7Button.Location = new System.Drawing.Point(10, 98);
            this._number7Button.Name = "_number7Button";
            this._number7Button.Size = new System.Drawing.Size(50, 50);
            this._number7Button.TabIndex = 6;
            this._number7Button.Text = "7";
            this._number7Button.UseVisualStyleBackColor = true;
            // 
            // _number8Button
            // 
            this._number8Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number8Button.Location = new System.Drawing.Point(60, 98);
            this._number8Button.Name = "_number8Button";
            this._number8Button.Size = new System.Drawing.Size(50, 50);
            this._number8Button.TabIndex = 7;
            this._number8Button.Text = "8";
            this._number8Button.UseVisualStyleBackColor = true;
            // 
            // _number9Button
            // 
            this._number9Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number9Button.Location = new System.Drawing.Point(110, 98);
            this._number9Button.Name = "_number9Button";
            this._number9Button.Size = new System.Drawing.Size(50, 50);
            this._number9Button.TabIndex = 8;
            this._number9Button.Text = "9";
            this._number9Button.UseVisualStyleBackColor = true;
            // 
            // _number4Button
            // 
            this._number4Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number4Button.Location = new System.Drawing.Point(10, 148);
            this._number4Button.Name = "_number4Button";
            this._number4Button.Size = new System.Drawing.Size(50, 50);
            this._number4Button.TabIndex = 4;
            this._number4Button.Text = "4";
            this._number4Button.UseVisualStyleBackColor = true;
            // 
            // _number5Button
            // 
            this._number5Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number5Button.Location = new System.Drawing.Point(60, 148);
            this._number5Button.Name = "_number5Button";
            this._number5Button.Size = new System.Drawing.Size(50, 50);
            this._number5Button.TabIndex = 10;
            this._number5Button.Text = "5";
            this._number5Button.UseVisualStyleBackColor = true;
            // 
            // _number1Button
            // 
            this._number1Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number1Button.Location = new System.Drawing.Point(10, 198);
            this._number1Button.Name = "_number1Button";
            this._number1Button.Size = new System.Drawing.Size(50, 50);
            this._number1Button.TabIndex = 11;
            this._number1Button.Text = "1";
            this._number1Button.UseVisualStyleBackColor = true;
            // 
            // _number6Button
            // 
            this._number6Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number6Button.Location = new System.Drawing.Point(110, 148);
            this._number6Button.Name = "_number6Button";
            this._number6Button.Size = new System.Drawing.Size(50, 50);
            this._number6Button.TabIndex = 12;
            this._number6Button.Text = "6";
            this._number6Button.UseVisualStyleBackColor = true;
            // 
            // _number3Button
            // 
            this._number3Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number3Button.Location = new System.Drawing.Point(110, 198);
            this._number3Button.Name = "_number3Button";
            this._number3Button.Size = new System.Drawing.Size(50, 50);
            this._number3Button.TabIndex = 13;
            this._number3Button.Text = "3";
            this._number3Button.UseVisualStyleBackColor = true;
            // 
            // _number2Button
            // 
            this._number2Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number2Button.Location = new System.Drawing.Point(60, 198);
            this._number2Button.Name = "_number2Button";
            this._number2Button.Size = new System.Drawing.Size(50, 50);
            this._number2Button.TabIndex = 14;
            this._number2Button.Text = "2";
            this._number2Button.UseVisualStyleBackColor = true;
            // 
            // _number0Button
            // 
            this._number0Button.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._number0Button.Location = new System.Drawing.Point(10, 248);
            this._number0Button.Name = "_number0Button";
            this._number0Button.Size = new System.Drawing.Size(50, 50);
            this._number0Button.TabIndex = 15;
            this._number0Button.Text = "0";
            this._number0Button.UseVisualStyleBackColor = true;
            // 
            // _clearAllButton
            // 
            this._clearAllButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clearAllButton.Location = new System.Drawing.Point(160, 48);
            this._clearAllButton.Name = "_clearAllButton";
            this._clearAllButton.Size = new System.Drawing.Size(50, 50);
            this._clearAllButton.TabIndex = 16;
            this._clearAllButton.Text = "C";
            this._clearAllButton.UseVisualStyleBackColor = true;
            this._clearAllButton.Click += new System.EventHandler(this.ClearAllButtonClick);
            // 
            // _clearButton
            // 
            this._clearButton.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clearButton.Location = new System.Drawing.Point(110, 48);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(50, 50);
            this._clearButton.TabIndex = 17;
            this._clearButton.Text = "CE";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // _textBox
            // 
            this._textBox.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBox.Location = new System.Drawing.Point(10, 12);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(200, 32);
            this._textBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 322);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._clearButton);
            this.Controls.Add(this._clearAllButton);
            this.Controls.Add(this._number0Button);
            this.Controls.Add(this._number2Button);
            this.Controls.Add(this._number3Button);
            this.Controls.Add(this._number6Button);
            this.Controls.Add(this._number1Button);
            this.Controls.Add(this._number5Button);
            this.Controls.Add(this._number4Button);
            this.Controls.Add(this._number9Button);
            this.Controls.Add(this._number8Button);
            this.Controls.Add(this._number7Button);
            this.Controls.Add(this._dotButton);
            this.Controls.Add(this._equalsButton);
            this.Controls.Add(this._divisionButton);
            this.Controls.Add(this._multiplicationButton);
            this.Controls.Add(this._subtractionButton);
            this.Controls.Add(this._additionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _additionButton;
        private Button _subtractionButton;
        private Button _multiplicationButton;
        private Button _divisionButton;
        private Button _equalsButton;
        private Button _dotButton;
        private Button _number7Button;
        private Button _number8Button;
        private Button _number9Button;
        private Button _number4Button;
        private Button _number5Button;
        private Button _number1Button;
        private Button _number6Button;
        private Button _number3Button;
        private Button _number2Button;
        private Button _number0Button;
        private Button _clearAllButton;
        private Button _clearButton;
        private TextBox _textBox;
    }
}

