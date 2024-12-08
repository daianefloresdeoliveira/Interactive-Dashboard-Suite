using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//Name: Flores de Oliveira, Daiane
//Date: 17/07/2023
//Description: Section 2 - Final Project - Simple Calculator

namespace FinalProject
{
    internal class Calc
    {
        private decimal result;  //A decimal that stores the result currently displayed by the calculator
        private decimal operand1; //A decimal that stores the value of the first operand
        private decimal operand2; //A decimal that stores the value of the second operand
        private string op; //A string type that stores the value of the operator
        public decimal Result   // Gets the value of the currentValue field
        {
            set { result = value; }
            get { return result; }
        }
        public decimal Operand1
        {
            set { operand1 = value; }  // minuscula
            get { return operand1; }
        }
        public decimal Operand2
        {
            set { operand2 = value; }  // minuscula
            get { return operand2; }
        }
        public string Op
        {
            set { op = value; }   // minuscula
            get { return op; }
        }
        public Calc() { }  // default constructor

        public Calc(decimal   operand1, decimal operand2, string op)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.op = op;
        }
        public void Add()
        {
           result = operand1 + operand2;         
        }
        public void Subtract() 
        { 
            result = operand1 - operand2;
        }
        public void Multiply() 
        {
            result = operand1 * operand2;            
        }
        public void Divide() 
        {            
            if(operand2 == 0)
            {
                result = 99999999999;
            }

            else 
            {
                result = operand1 / operand2;
            }         
        }
        public void Equals() 
        {
            
            if (Op == "+")
            {
                //result = operand1 + operand2;
                //operation = Operand1 + "+" + Operand2;
                Add();
                //return result;                
            }

            if (Op == "-")
            {
                //result = operand1 - operand2;
                //operation = Operand1 + "-" + Operand2;
                Subtract();
                //return result;
                //return result;
            }

            if (Op == "*")
            {
                //result = operand1 * operand2;
                //operation = Operand1 + "*" + Operand2;
                Multiply();
                //return result;
                //return result;
            }

            if (Op == "/")
            {
                Divide();
            }            
        }
        public void Clear() 
        { 
            Operand1 = 0; 
            Operand2 = 0;
            Op = null;
        }

    }// end class
}// end namespace
