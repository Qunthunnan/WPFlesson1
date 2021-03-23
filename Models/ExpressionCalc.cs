using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WPFLessonCalc.Models
{
    class ExpressionCalc
    {
        public enum eOperation { Plus, Minus, Multiply, Divide };
        private int count;
        Operation head; 
        public Operation this[int i]
        {
            get
            {
                Operation curent = head;
                for (int j = 0; j <= i; j++)
                {
                    curent = curent.nextOperation;
                }
                return curent;
            }
        }

        public ExpressionCalc()
        {
            count = 0;
            head = null;
        }

        public void addOperation(double num1, double num2, eOperation operation)
        {
            if (head == null)
            {
                head = new Operation(num1, num2, operation);
            }
            else
            {
                Operation curent = head;
                while (curent.nextOperation != null)
                {
                    curent = curent.nextOperation;
                }
                curent.nextOperation = new Operation(num1, num2, operation, null, curent);
            }
            count++;
        }

        public double calculateExpression() 
        {
            Operation curent = head;
            while (curent != null)
            {
                if (curent.operation == eOperation.Multiply || curent.operation == eOperation.Divide && curent.resultStatus != true)
                {
                    curent.calculateOperation();
                }

                if (curent.nextOperation != null)
                {
                    curent = curent.nextOperation;
                }
                else
                {
                    break;
                }
            }

            curent = head;

            while (curent != null) 
            {
                if (curent.resultStatus != true)
                {
                    curent.calculateOperation();
                }

                if (curent.nextOperation != null)
                {
                    curent = curent.nextOperation;
                }
                else
                {
                    break;
                }
            } 

            return curent.result;
        }

        //public override string ToString()
        //{
        //    string expression = "";
        //    string operation = "";
            

        //    if (count >= 1)
        //    {
        //        Operation curent = head;
        //        switch (curent.operation)
        //        {
        //            case eOperation.Plus:
        //                operation = "+";
        //                break;
        //            case eOperation.Minus:
        //                operation = "-";
        //                break;
        //            case eOperation.Multiply:
        //                operation = "*";
        //                break;
        //            case eOperation.Divide:
        //                operation = "/";
        //                break;
        //            default:
        //                break;
        //        }

        //        expression = head.num1.ToString() + operation + head.num2.ToString();

        //        if (count > 1)
        //        {
        //            for (int i = 1; i <= count; i++)
        //            {
        //                curent = curent.nextOperation;
        //                switch (curent.operation)
        //                {
        //                    case eOperation.Plus:
        //                        operation = "+";
        //                        break;
        //                    case eOperation.Minus:
        //                        operation = "-";
        //                        break;
        //                    case eOperation.Multiply:
        //                        operation = "*";
        //                        break;
        //                    case eOperation.Divide:
        //                        operation = "/";
        //                        break;
        //                    default:
        //                        break;
        //                }
        //                expression += operation + curent.num2.ToString();
        //            }
        //        } 
        //    }

        //    return expression;
        //}

        public class Operation
        {
            public double num1;
            public double num2;
            public double result;
            public bool resultStatus = false;
            public eOperation operation;

            public Operation nextOperation;
            public Operation prevOperation;

            public Operation(double num1, double num2, eOperation operation, Operation next = null, Operation prev = null)
            {
                this.num1 = num1;
                this.num2 = num2;
                this.operation = operation;
                this.nextOperation = next;
                this.prevOperation = prev;
            }

            public void calculateOperation()
            {
                if (prevOperation != null && prevOperation.resultStatus == true)
                {
                    num1 = prevOperation.result;
                }

                if (nextOperation != null && nextOperation.resultStatus == true)
                {
                    num2 = nextOperation.result;
                }

                switch (operation)
                {
                    case eOperation.Plus:
                        result = num1 + num2;
                        resultStatus = true;
                        break;
                    case eOperation.Minus:
                        result = num1 - num2;
                        resultStatus = true;
                        break;
                    case eOperation.Multiply:
                        result = num1 * num2;
                        resultStatus = true;
                        break;
                    case eOperation.Divide:
                        result = num1 / num2;
                        resultStatus = true;
                        break;
                    default:
                        break;
                }

                if (prevOperation != null && prevOperation.resultStatus == true)
                {
                    prevOperation.result = result;
                }

                if (nextOperation != null && nextOperation.resultStatus == true)
                {
                    nextOperation.result = result;
                }

            }

        }

    }
}
