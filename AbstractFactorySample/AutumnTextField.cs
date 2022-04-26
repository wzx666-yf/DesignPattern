using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactorySample
{
    class AutumnTextField : TextField
    {
        public void Display()
        {
            Console.WriteLine("显示金黄色边框文本框。");
        }
    }
}
