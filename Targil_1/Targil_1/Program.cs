﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_1
{
    class Program
    {

        /*
        ברגע שיש התייחסות לשדה סטטי כלומר בפעם הראשונה שיש התייחסות לשדה סטטי
        מתרחש אתחול לכל השדות הסטטיים.

         * */


        static void Main(string[] args)
        {
            //Console.WriteLine(MyClass.StaticField);
            //MyClass.Foo();
            Console.WriteLine("First...");

            for (int i = 0; i < 11; i++)
            {
                new MyClass(i);
                
            }
            MyStaticClass.Foo();
            Console.ReadLine();

        }
        class MyClass
        {
            static int Counter = InitialValue();
            public static int StaticField = 1;

            static MyClass()
            {
                Console.WriteLine("Iam static constructor");
            }
            public MyClass(int x)
            {
                //if (counter >= 10)
                //{
                //    Console.WriteLine("Too Many objects");
                //}
                Console.WriteLine(x);
            }
            public static int InitialValue() {
                Console.WriteLine($"initial Value {Counter} and staticField { StaticField } ");
                return 0;
            }
            public static void Foo() {
               Console.WriteLine("Foo");
            }
        }

        static class MyStaticClass
        {
            internal static void Foo()
            {
                Console.WriteLine($"initial Value Foo and staticMyClass");
            }
        }


    }
}
