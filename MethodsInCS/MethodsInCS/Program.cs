using System;

namespace MethodsInCS
{
    //Different ways of writing methods
    public class MethodsEx
    {
        //Parameter less method
        public void Message()
        {
            Console.WriteLine("Hello World!");
        }

        //parameterized method
        public void PrintMessage(string message)
        {
            Console.WriteLine("Hello " + message);
        }

        //Parameter and return method
        public int MethodValue(int value)
        {
            Console.WriteLine("Entered value is:" + value);
            return value;
        }

        // out parameter
        public void OutParameter(out int i)
        {
            i = 30;
            i += i;
        }

        //Abstract method
        public abstract class AbstractMethod
        {
            public abstract void MyAbstractMethod();
        }

        //static method
        public static void PrintValue(int value)
        {
            Console.WriteLine("The Value is: " + value);
        }

    }

        //virtual
        public class VirtualMethod
        {
            public virtual string Message(string msg)
            {
                return "Hello" + msg;
            }
        }

        public class myClass : VirtualMethod
        {
            public override string Message(string msg)
            {
                return base.Message(msg);
            }

        }



    

    class Program
    {
        static void Main(string[] args)
        {
            var p = new MethodsEx();
            p.Message();
            p.PrintMessage("Welcome");
            p.MethodValue(15);
            int i;
            p.OutParameter(out i);
            Console.WriteLine("The addition of the value is: {0}", i);

            var v = new VirtualMethod();
            string name = v.Message("Hie");

            var v1 = new myClass();
            string name1 = v1.Message("Welcome");

            Console.WriteLine(name);
            Console.WriteLine(name1);

            MethodsEx.PrintValue(100);
            Console.ReadLine();

        }
    }
}

