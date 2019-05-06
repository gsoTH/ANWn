using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StackTraceTest
{
    class Program
    {
        static void TraceTest()
        {
            StackTrace st = new StackTrace();
            string callerMethodName = st.GetFrame(1).GetMethod().Name;

            Console.WriteLine("Aufrufende Methode: " + callerMethodName);
        }

        static void Main(string[] args)
        {
            TraceTest();

            Console.ReadKey();
        }
    }
}
