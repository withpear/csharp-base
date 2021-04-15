using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAPIExample.AttributeTest
{
    public static class Example
    {
        public static void InheritedTest()
        {
            Type typeA = typeof(DerivedA);
            var len1 = typeA.GetCustomAttributes(typeof(InheritedAttribute), true).Length;
            Console.WriteLine($"DerivedA has Inherited attribute: {len1 > 0}"); //True

            MethodInfo memberA = typeA.GetMethod(nameof(DerivedA.MethodA));
            var len2 = memberA.GetCustomAttributes(typeof(InheritedAttribute), true).Length;
            Console.WriteLine($"DerivedA.MemberA has Inherited attribute: {len2 > 0}\n"); //True

            Type typeB = typeof(DerivedB);
            var len3 = typeB.GetCustomAttributes(typeof(NoInheritedAttribute), true).Length;
            Console.WriteLine($"DerivedA has Inherited attribute: {len3 > 0}"); //False

            MethodInfo memberB = typeB.GetMethod(nameof(DerivedB.MethodB));
            var len4 = memberB.GetCustomAttributes(typeof(NoInheritedAttribute), true).Length;
            Console.WriteLine($"DerivedA.MemberA has Inherited attribute: {len4 > 0}\n"); //False
        }
    }
}
