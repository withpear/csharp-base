using System;

namespace DotNetAPIExample.AttributeTest
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple =true, Inherited = true)]
    public class InheritedAttribute : Attribute
    {
        public InheritedAttribute()
        {

        }
        public InheritedAttribute(string message)
        {

        }
    }

    [AttributeUsage(AttributeTargets.All, Inherited =false)]
    public class NoInheritedAttribute : Attribute
    {

    }


    [Inherited]
    public class BaseA
    {
        [Inherited("b")]
        [Inherited("a")]
        public virtual void MethodA() { }
    }
    public class DerivedA : BaseA
    {
        public override void MethodA()
        {
        }
    }
    [NoInherited]
    public class BaseB
    {
        [NoInherited]
        public virtual void MethodB() { }
    }
    public class DerivedB : BaseB
    {
        public override void MethodB()
        {
        }
    }
}
