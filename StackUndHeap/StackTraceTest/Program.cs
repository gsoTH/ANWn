using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StackTraceTest
{
    /// <summary>
    /// Dieses Programm zeigt wie man die Bezeichnung der aufrufenden Methode
    /// via (System.Diagnostics.)Stacktrace abfragen kann.
    /// 
    /// Quelle: Bayer, Das C# 2010 Codebook, S.1095
    /// </summary>
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
