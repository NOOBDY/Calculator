using System.Diagnostics;

namespace Calculator
{
    public enum Operator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    public class State
    {
        private string _leftNumber = "";
        private string _rightNumber = "";
        private Operator _currentOperator;

        /// <summary>
        /// something
        /// </summary>
        /// <param name="character"></param>
        public void AppendNumber(string character)
        {
            _rightNumber += character;
            Debug.WriteLine(string.Format("{0} {1}", _leftNumber, _rightNumber));
        }

        /// <summary>
        /// get left
        /// </summary>
        /// <returns></returns>
        public string GetLeftValue()
        {
            return _leftNumber;
        }

        /// <summary>
        /// get right
        /// </summary>
        /// <returns></returns>
        public string GetRightValue()
        {
            return _rightNumber;
        }
        
        /// <summary>
        /// op
        /// </summary>
        /// <param name="echo"></param>
        public void SetOperator(Operator echo)
        {
            _currentOperator = echo;

            if (_leftNumber == "")
            {
                _leftNumber = _rightNumber;
            }
            else
            {
                Evaluate();
            }

            _rightNumber = "";
        }

        /// <summary>
        /// Clear
        /// </summary>
        public void Clear()
        {
            _rightNumber = "";
        }

        /// <summary>
        /// Clear all
        /// </summary>
        public void ClearAll()
        {
            _leftNumber = "";
            _rightNumber = "";
        }

        /// <summary>
        /// eval
        /// </summary>
        public void Evaluate()
        {
            if (_leftNumber == "" || _rightNumber == "")
            {
                return;
            }
            switch (_currentOperator)
            {
                case Operator.Addition:
                    _leftNumber = (float.Parse(_leftNumber) + float.Parse(_rightNumber)).ToString();
                    break;
                case Operator.Subtraction:
                    _leftNumber = (float.Parse(_leftNumber) - float.Parse(_rightNumber)).ToString();
                    break;
                case Operator.Multiplication:
                    _leftNumber = (float.Parse(_leftNumber) * float.Parse(_rightNumber)).ToString();
                    break;
                case Operator.Division:
                    _leftNumber = (float.Parse(_leftNumber) / float.Parse(_rightNumber)).ToString();
                    break;
            }
        }
    }
}