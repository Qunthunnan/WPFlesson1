using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WPFLessonCalc.Models
{
    class Expression
    {
        public enum eOperation { Plus, Minus, Multiply, Divide };
        private int Count;
        Operation head;

        public Expression()
        {
            Count = 0;
            head = null;
        }

        public void addOperation(double num1, double num2, eOperation operation) 
        {
            if (head == null)
            {
                head = new Operation(num1, num2, operation);
            }
        }

        private class Operation 
        {           
            public double num1;
            public double num2;
            public double result;
            public bool resultStatus = false;
            public eOperation operation;

            public Operation nextOperation;
            public Operation prevOperation;
            
            public Operation(double num1, double num2, eOperation operation, Operation next = null) 
            {
                this.num1 = num1;
                this.num2 = num2;
                this.operation = operation;
                this.nextOperation = next;
            }

            //public void calculateOperation()
            //{
            //    if (prevOperation.resultStatus == true)
            //    {
            //        num1 = prevOperation.result;
            //    }

            //    if (nextOperation.resultStatus == true)
            //    {
            //        num2 = nextOperation.result;
            //    }

            //    switch (operation)
            //    {
            //        case Operations.Plus:
            //            result = num1 + num2;
            //            resultStatus = true;
            //            break;
            //        case Operations.Minus:
            //            result = num1 - num2;
            //            resultStatus = true;
            //            break;
            //        case Operations.Multiply:
            //            result = num1 * num2;
            //            resultStatus = true;
            //            break;
            //        case Operations.Divide:
            //            result = num1 / num2;
            //            resultStatus = true;
            //            break;
            //        default:
            //            break;
            //    }
            //}

        }

    }
}
