using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z_v1();
            Print_a_2_z_v2();
            Console.WriteLine();
            Print_a_2_z_v3();
            Console.WriteLine();

               //while(true){
                   // char c = Console.ReadKey().KeyChar;
                   // Console.WriteLine(" " +Char2Code(c));
               // }
                while (true)
                {
                    char c = Console.ReadKey().KeyChar;
                    Console.WriteLine(" " +IsUpper (c));
                }
        }
        public static void Print_a_2_z_v1()
        {
            
            Console.WriteLine('a');
            Console.WriteLine('b');
            Console.WriteLine('c');
            Console.WriteLine('d');
            Console.WriteLine('e');
            Console.WriteLine('f');
            Console.WriteLine('g');
            Console.WriteLine('h');
            Console.WriteLine('i');
            Console.WriteLine('j');
            Console.WriteLine('k');
            Console.WriteLine('l');
            Console.WriteLine('m');
            Console.WriteLine('n');
            Console.WriteLine('o');
            Console.WriteLine('p');
            Console.WriteLine('q');
            Console.WriteLine('r');
            Console.WriteLine('s');
            Console.WriteLine('t');
            Console.WriteLine('u');
            Console.WriteLine('v');
            Console.WriteLine('w');
            Console.WriteLine('x');
            Console.WriteLine('y');
            Console.WriteLine('z');
        }
        public static void Print_a_2_z_v2()
        {
            for (int i = 97; i < 122; i++)
            {
                Console.Write((char)i);
            }
        }
        public static void Print_a_2_z_v3()
        {
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.Write(c);
                c++;
            }
        }
        public static int Char2Code(char c)
        {
    
            return (int)c;
        }
        public static bool IsUpper(char c)
        {
          for (int i = 65 ;i<=90;i++) {
              if((int)c==i)
              return true;
          }



            return false;
        }
        public static char ToUpper(char c)
        {

            return c;
        }

    }
}
