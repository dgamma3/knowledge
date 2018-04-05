using System;

namespace AbstractClass
{
    public class DerivedClass : BaseClass
    {
        public int _z { get; set; }
        public override void AbstractMethod()
        {
          Console.WriteLine("DerivedClass-AbstractMethod");
        }

      
    }
}