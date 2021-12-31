using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarmonyTest
{
    class TestClass
    {
        internal IEnumerator<int> DetouredMethod_1()
        {
            Console.WriteLine("Inside DetouredMethod_1 1");
            yield return 0;
            Console.WriteLine("Inside DetouredMethod_1 2");
            yield break;
        }
    }
}
