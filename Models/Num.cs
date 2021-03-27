using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLessonCalc.Models
{
    class Num
    {
        double num = 0;
        bool doted = false;
        bool blockdot = false;

        public void addNum(int num)
        {
            if (this.num.ToString().Length < 15)
            {
                if (doted == true)
                {
                    this.num = Convert.ToDouble(this.num.ToString() + "," + num.ToString());
                    doted = false;
                }
                else
                {
                    this.num = Convert.ToDouble(this.num.ToString() + num.ToString());
                }
            }
            
        }

        public void remooveNum() 
        {
            if (num.ToString().Length > 0)
            {
                num = Convert.ToDouble(num.ToString().Remove(num.ToString().Length - 1));
            }
        }

        public void addDot() 
        {
            doted = true;
            blockdot = true;
        }

        public double getNum()
        {
            return num;
        }

        List<int> list = new List<int>();

        public bool isBlockDot() 
        {
            return blockdot;
        }
    }
}
