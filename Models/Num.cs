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

        public void addNum(int num)
        {
            this.num = Convert.ToDouble(this.num.ToString() + num.ToString());
        }

        public void addDotNum(int num) 
        {
            this.num = this.num = Convert.ToDouble(this.num.ToString() + "." + num.ToString());
            doted = true;
        }

        public double getNum()
        {
            return num;
        }

        List<int> list = new List<int>();

        public bool isDotet() 
        {
            return doted;
        }
    }
}
