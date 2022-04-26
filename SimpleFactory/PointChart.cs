using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactorySample
{
    class PointChart : Chart
    {
        public PointChart()
        {
            Console.WriteLine("创建点状图！");
        }
        public void Display()
        {
            Console.WriteLine("显示点状图！");
        }
    }
}
