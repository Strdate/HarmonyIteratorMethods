using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarmonyTest
{
    [HarmonyPatch(typeof(TestClass))]
    [HarmonyPatch("DetouredMethod_1")]
    class Patches
    {
        static void Prefix()
        {
            Console.WriteLine("Inside DetouredMethod_1 prefix");
        }

        static void Postfix()
        {
            Console.WriteLine("Inside DetouredMethod_1 postfix");
        }

        static void Finalizer()
        {
            Console.WriteLine("Inside DetouredMethod_1 finalizer");
        }
    }
}
