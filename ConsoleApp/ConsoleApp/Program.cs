using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int r = Console.Read();
            //Console.WriteLine(r);
            //Console.Read();
            int code = (int)'A';//字符转ASCII
            Console.WriteLine("A->{0}", code);
            char ch = (char)65;//ASCII转字符
            Console.WriteLine("65->{0}", ch);

            char character = '玉';
            int code10 = (int)character;
            Console.WriteLine(code10);
            string code16 = Convert.ToString(code10,16);
            Console.WriteLine("{0}的Unicode编码为：{1}",character,code16);

            //Console.WriteLine("1.2\t1.89\t3.14\n2.75\t3.89\t239\t0.76\t6342\t3.92\a");

            //Console.WriteLine("\\n \\t \\a\a");
            //Console.WriteLine("\\' \"\a");
            Console.WriteLine("  *  ");
            Console.WriteLine(" * * ");
            Console.WriteLine("*   *");
            Console.WriteLine(" * *");
            Console.WriteLine("  *  ");

            Console.WriteLine(Math.PI);
            //double x,y;
            //Console.Write("输入华氏温度：");
            //x=int.Parse( Console.ReadLine());
            //y = (x - 32) * 5 / 9;
            //Console.WriteLine(y);

            //int day = 12;
            //int today;
            //int tomorrow;
            ////today = day++;
            //today = 0;
            //tomorrow = ++day;
            //Console.WriteLine("day = {0},today = {1},tomorrow = {2}",day,today,tomorrow);

            //int i = 3;
            //Console.WriteLine(i--);
            //Console.WriteLine(i);
            //Console.WriteLine(--i);

            //string text = "Welocome to ";
            //text += "Beijing!";
            //Console.WriteLine(text);

            //int a = 10;
            //int b;
            //b = ++a;
            //b = a++;
            //Console.WriteLine(b);
            int x, y;
            x=int.Parse(Console.ReadLine());
            y=x*(2+x)+5*x* x-4;
            Console.WriteLine(y);


        }
    }
}
