using System;

namespace AbstractClass
{
    //https://stackoverflow.com/questions/511248/method-return-an-interface
    //https://stackoverflow.com/questions/15392224/interface-as-return-type
    class Program
    {
        static void Main(string[] args)
        {
            var test = Func();
            test.NonOverriden();
            test.AbstractMethod();
            
        }
        
        static BaseClass Func()
        {
            
            
            return new DerivedClass();
            
            //"Returns an interface" really means: "Returns an instance of some class that implements that interface"
        }
    }
}