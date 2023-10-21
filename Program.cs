using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemoRevision5th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first way
            int[] marks = { 10, 20, 30, 40 };
            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine(marks[k]);
            }
            Console.WriteLine("----------------------------");
            int[] marks3;//just declarartion
            //second way
            int[] marks1 = new int[4] { 10, 10, 20, 21 };
            for(int j=0; j<4; j++)
            {
                Console.WriteLine(marks1[j]);
            }
            int[] marks2 = new int[4];//just declaration
            marks2[0] = 30;
            //Third way

            Array a=Array.CreateInstance(typeof(int) ,4);
            a.SetValue(10, 0);
            //Object o=a.GetValue(0);
            int v=(int)a.GetValue(0);
            Console.WriteLine($"te value of v={v}");
            Console.WriteLine("-------------------------------");
            int[] oneD = { 12, 34, 56 };
            PrintFristValue(oneD);
            int[,] twoD = { { 12, 34 }, { 23, 45 } };
            PrintFristValue(twoD);
            int[,,] threeD = { {
                    { 12, 12, 12
                    },
                    { 11, 11, 11
                    },
                    { 12, 12, 12
                    }
                }
            };
            PrintFristValue(threeD);
            int[,,] td2 = new int[1, 2, 3] {
                {
                    { 1, 2, 3 }, { 4, 5, 6 } } };
            PrintFristValue(td2);
            Console.WriteLine("---------------------------");
            int[] arr=new int[4]
            { 10,20,34,23};
            foreach(int i1 in arr)
            {
                Console.WriteLine(i1);
            }
            Console.WriteLine("----------------------------");
            string[] names = new string[] { "Amit", "Sumit", "Suma", "Roma", "Komal" };
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
            object[] obj = new object[] { 1, "Suma", 45.44f, 3433.34d };
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
            //Implicitly typed local variable-2.0framework
            //cannnnot be reinstantiated by giving different types and also cannot be used ass parameter type
            Console.WriteLine("-----------------------------------------------------------------------");
            var p = "Hello";
            Console.WriteLine(p);
            var i = 67.8755d;
            Console.WriteLine(i);
            var d1 = new DateTime(2023, 04, 10);
            //framework--3.5 and above
            //can be reinstantiated by giving diff types and also be used as parameter type
            //as parameter
            dynamic myd = "Hello";
            Console.WriteLine(myd);//hello
            myd = 4566;
            Console.WriteLine(myd);//4566

            Console.ReadLine();


        }
        


        static void PrintFristValue(Array a)
        {
            Console.WriteLine(a.Rank);
            int[] indexers = new int[a.Rank];
            Console.WriteLine($"First Value={a.GetValue(indexers)}");
        }
    }
}
