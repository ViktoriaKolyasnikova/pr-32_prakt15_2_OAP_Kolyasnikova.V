using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace pr_32_prakt15_2_OAP_Kolyasnikova.V
{
    class Program
    {
        //A
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("t.txt");
            string st = f.ReadToEnd();
            f.Close();
            Stack s = new Stack();
            bool b = true;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == '(') s.Push(i);
                else if (st[i] == ')')
                {
                    if (s.Count == 0)
                    { 
                        b = false; Console.WriteLine("Возможно лишняя ) скобка в позиции "+i); 
                    }
                    else s.Pop(); 
                }
            }
            if (s.Count == 0)
            {
                if (b)
                {
                    Console.WriteLine("Cкобки сбалансированы");
                }
            }
            else 
            {
                Console.Write("Возможно лишняя ( скобка в позиции:");
                while (s.Count != 0)
                {
                    Console.Write(" "+ (int)s.Pop());
                }
            }
                Console.ReadKey();
        }
    }
}