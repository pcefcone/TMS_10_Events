using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_10_Events
{
    internal class Operations
    {
        private double variable1 = 0;
        private double variable2 = 0;
        private double res = 0;
        public double result
        {
            get
            {
                return res;
            }

        }
        public event Action<object> Addition;
        public event Action<object> Subtraction;
        public event Action<object> Multiplication;
        public event Action<object> Division;
        public event Action<object> Modulus;
        public event Action<object> Exit;
        public event Action Error;

        public void Calculate()
        {
            variable1 = 0;  
            variable2 = 0;
        }
        public void Calculation(double variable1, string operation, double variable2)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;
            switch (operation)
            {
                case "+":
                    if (Addition != null)
                    {
                        Addition(this);
                    }
                    break;
                case "-":
                    if (Subtraction != null)
                    {
                        Subtraction(this);
                    }
                    break;
                case "*":
                    if (Multiplication != null)
                    {
                        Multiplication(this);
                    }
                    break;
                case "/":
                    if (Division != null && variable2 != 0)
                    {
                        Division(this);
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                case "%":
                    if (Modulus != null && variable2 != 0)
                    {
                        Modulus(this);
                    }
                    else
                    {
                        goto default;
                    }
                    break;
                case "!":
                    if (Exit != null)
                    {
                        Exit(this);
                    }
                    break;
               
                default:
                    Error();
                    break;
            }
        }
        public void Add()
        {
            res = variable1 + variable2;
        }
        public void Sub()
        {
            res = variable1 - variable2;
        }
        public void Mult()
        {
            res = variable1 * variable2;
        }
        public void Div()
        {
            res = variable1 / variable2;
        }
        public void Mod()
        {
            res = variable1 % variable2;
        }

        
        
    }
}
