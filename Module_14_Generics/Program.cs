using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_14_Generics // Шаблоны
{
    class Program
    {
        public class Info<T>
        {
            T[] userlist;
            int i;
            public Info()
            {
                userlist = new T[3];
                i = 0;
            }
            public void Add(T obj)
            {
                if (i == 3) return;
                userlist[i] = obj;
                i++;                
            }
            public void PrintInfo()
            {
                foreach (T item in userlist)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }
        static void Main(string[] args)
        {
            Info<string> str = new Info<string>();
            for (int i = 0; i < 3; i++)
            {
            str.Add(Console.ReadLine());
            }
            str.PrintInfo();

            Info<int> Myint = new Info<int>();
            for (int j = 0; j < 3; j++)
            {
                Myint.Add(j);
            }
            Myint.PrintInfo();
        }
    }
}
