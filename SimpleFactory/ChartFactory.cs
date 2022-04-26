using System;
using System.Configuration;
using System.Reflection;

namespace SimpleFactorySample
{
    class ChartFactory
    {
        //静态工厂方法
        public static Chart GetChart(string type) 
        {
		    Chart chart = null;
		    if (type.Equals("histogram")) 
            {
			    chart = new HistogramChart();
			    Console.WriteLine("初始化设置柱状图！");
		    }
		    else if (type.Equals("pie")) 
            {
			    chart = new PieChart();
			    Console.WriteLine("初始化设置饼状图！");
		    }
		    else if (type.Equals("line")) 
            {
			    chart = new LineChart();
			    Console.WriteLine("初始化设置折线图！");			
		    }
			else if (type.Equals("point"))
            {
				chart = new PointChart();
				Console.WriteLine("初始化设置点状图！");
            }
		    return chart;
	    }
		public static Chart GetChart()
        {
			string a = ConfigurationManager.AppSettings["chart"];
			Chart chart = (Chart)Assembly.Load("SimpleFactory").CreateInstance(a);
			return chart;
        }
    }
}
