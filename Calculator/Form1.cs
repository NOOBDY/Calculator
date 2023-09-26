using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ButtonClickFunction = System.Action<object, System.EventArgs>;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _state = new State();
            int counter = 1;
            InitializeComponent();
            this._number1Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number2Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number3Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number4Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number5Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number6Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number7Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number8Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number9Button.Click += new EventHandler(this.ClickNumberButton(counter++));
            this._number0Button.Click += new EventHandler(this.ClickNumberButton(counter++));

            this._additionButton.Click += new EventHandler(this.ClickOperatorButton(Operator.Addition));
            this._subtractionButton.Click += new EventHandler(this.ClickOperatorButton(Operator.Subtraction));
            this._multiplicationButton.Click += new EventHandler(this.ClickOperatorButton(Operator.Multiplication));
            this._divisionButton.Click += new EventHandler(this.ClickOperatorButton(Operator.Division));
        }

        /// <summary>
        /// something
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private ButtonClickFunction ClickNumberButton(int number)
        {
            return (sender, e) =>
            {
                _state.AppendNumber(number.ToString());
                _textBox.Text = _state.GetRightValue();
            };
        }

        /// <summary>
        /// op click
        /// </summary>
        /// <param name="echo"></param>
        /// <returns></returns>
        private ButtonClickFunction ClickOperatorButton(Operator echo)
        {
            return (sender, e) =>
            {
                _state.SetOperator(echo);
                _textBox.Text = _state.GetLeftValue();
            };
        }

        private State _state;

        /// <summary>
        /// dot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButtonClick(object sender, EventArgs e)
        {
            string dot = ".";
            _state.AppendNumber(dot);
        }
        
        /// <summary>
        /// eq
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButtonClick(object sender, EventArgs e)
        {
            _state.Evaluate();
            _textBox.Text = _state.GetLeftValue();
        }

        /// <summary>
        /// ce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllButtonClick(object sender, EventArgs e)
        {
            _state.ClearAll();
            _textBox.Text = "";
        }

        /// <summary>
        /// c
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButtonClick(object sender, EventArgs e)
        {
            _state.Clear();
            _textBox.Text = "";
        }
    }
}
