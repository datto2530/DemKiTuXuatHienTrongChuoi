using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "c","h", "a","o" };
            string inputS = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]==inputS) ;
                {
                    count+=1;
                }
            }
            Console.WriteLine("So ki tu co trong chuoi la " + count);
        }
    }
}