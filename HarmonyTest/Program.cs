using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarmonyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var harmony = new Harmony("abcdef_22.lp");
            harmony.PatchAll(typeof(Program).Assembly);
            var testClass = new TestClass();
            var enumerator = testClass.DetouredMethod_1();
            enumerator.MoveNext();
            enumerator.MoveNext();

            Console.ReadLine();
        }
    }
}
