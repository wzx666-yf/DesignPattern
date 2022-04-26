using System;

namespace PrototypeSample
{
    class Program
    {
        static void Main(string[] args)
        {

            /*ConcretePrototypeA prototypeA, copy;
            prototypeA = new ConcretePrototypeA();
            prototypeA.Attr = "Mark";
            copy = prototypeA.Clone();
            copy.Attr = "Der";
            Console.WriteLine(prototypeA == copy);
            Console.WriteLine(prototypeA.Member == copy.Member);
            Console.WriteLine("{0},{1},{2}",prototypeA.Attr,copy.Attr,prototypeA.Attr == copy.Attr);*/

            /*ConcretePrototypeB prototype, copy;
            prototype = new ConcretePrototypeB();
            prototype.Attr = "Sunny";
            copy = (ConcretePrototypeB)prototype.Clone();
            copy.Attr = "Tom";
            Console.WriteLine(prototype == copy);
            Console.WriteLine(prototype.GetType());
            Console.WriteLine(prototype.GetType() == copy.GetType());
            Console.WriteLine(prototype.Member == copy.Member);
            Console.Read();*/

            WeeklyLog log_previous, log_new;
            log_previous = new WeeklyLog();
            Attachment attachment = new Attachment();
            log_previous.Attachment = attachment;
            log_new = log_previous.Clone();
            Console.WriteLine("周报是否相同？{0}",(log_previous == log_new)?"是":"否");
            Console.WriteLine("附件是否相同？{0}",(log_previous.Attachment == log_new.Attachment)?"是":"否");
            Console.Read();
        }
    }
}
