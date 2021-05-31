using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    interface A
    {
        void Hello();
    }
    interface B
    {
        void Hello();
    }
    class HI : A, B
    {
        void A.Hello()
        {
            Console.WriteLine("Hello to all");
        }
        void B.Hello()
        {
            Console.WriteLine("Hello to all");
        }
    }
   
}
   