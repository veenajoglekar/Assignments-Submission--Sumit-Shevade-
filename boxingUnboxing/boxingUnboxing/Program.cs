using System;

namespace boxingUnboxing
{
    using System;
    public class BoxingUnboxing
    {
        static void Main()
        {
            // Boxing Example 

            // assigned int value
            // 400 to num 
            int num = 400;

            // boxing
            object obj = num;

            // value of num to be change
            num = 100;

            System.Console.WriteLine
            ("Value type value of num is : {0}", num);
            System.Console.WriteLine
            ("Object type value of obj is : {0}", obj);

            //Unboxing Example

            // assigned int value
            // 23 to num
            int num2 = 23;

            // boxing
            object obj2 = num2;

            // unboxing
            int i = (int)obj2;

            // Display result
            Console.WriteLine("Value of ob object is : " + obj2);
            Console.WriteLine("Value of i is : " + i);
        }
    }

}
