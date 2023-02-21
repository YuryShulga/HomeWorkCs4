using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCs4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(1,99);
            Money m2 = new Money(1,199);
            Console.WriteLine($"m1 - {m1}");
            Console.WriteLine($"m2 - {m2}");
            Console.WriteLine($"m1+m2 = { m1 + m2}");
            Console.WriteLine($"m1-m2 = {m1 - m2}");
            int num = 3;
            Console.WriteLine($"num = {num}");
            Console.WriteLine($"m1/num = {m1 / num}");
            Console.WriteLine($"m1*num = {m1 * num}");
            Console.WriteLine($"m1++ = {m1++}");
            Console.WriteLine($"m1 = {m1}");
            Console.WriteLine($"m1-- = {m1--}");
            Console.WriteLine($"m1 = {m1}");            
            Money m3=new Money(m1);
            Console.WriteLine($"----------");
            Console.WriteLine($"m1 - {m1}");
            Console.WriteLine($"m2 - {m2}");
            Console.WriteLine($"m3 - {m3}");
            Console.WriteLine($"m1>m2 - {m1 > m2}");
            Console.WriteLine($"m1<m2 - {m1 < m2}");
            Console.WriteLine($"m1==m2 - {m1==m2}");
            Console.WriteLine($"m1==m3 - {m1==m3}");
            Console.WriteLine($"m1!=m2 - {m1 != m2}");
            Console.WriteLine($"m1!=m3 - {m1 != m3}");
        }
    }
   
}
