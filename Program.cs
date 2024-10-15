using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        public static int n, i = -1, op = 0;
        public static int[] a;
        public void insertar(int n) 
        { 
        
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter array elements");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            Console.WriteLine("1 insert");
            Console.WriteLine("2 eraser");
            Console.WriteLine("3 modify");
            Console.WriteLine("4 search");
            Console.WriteLine("5 exit");
            Console.WriteLine("select opcion");
            op = Convert.ToInt32(Console.ReadLine());           
            switch (op) { 
                case 1:
                    Console.WriteLine("insert");
                    break;
                case 2:
                    Console.WriteLine("eraser");
                    break;
                case 3:
                    Console.WriteLine("modify");
                    break;
                case 4:
                    Console.WriteLine("search");
                    break;
                case 5:
                    Console.WriteLine("exit");
                    break;
                    default:
                    Console.WriteLine("error");
                        break;

            } Console.ReadLine();
        }
    }
}
