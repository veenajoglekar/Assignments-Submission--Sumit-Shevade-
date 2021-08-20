using System;
using System.Collections.Generic;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Travel> travelList = new List<Travel>();
            travelList.Add(new Travel() { StepNum = "1", step = 0 });
            travelList.Add(new Travel() { StepNum = "2", step = 1 });
            travelList.Add(new Travel() { StepNum = "3", step = 2 });
            travelList.Add(new Travel() { StepNum = "4", step = 3 });

           
            foreach (var obj in travelList)
            {
                Console.WriteLine("{0} ) {1}", obj.StepNum, GetStep(obj.step));
            }
            Console.ReadLine();
        }
        //This method is used to return the Steps 
        public static string GetStep(int step)
        {
            switch (step)
            {
                case (int)Steps.SourceDestination:
                    return "Select Source and destination";
                case(int)Steps.Timings:
                    return "Select boarding time";
                case (int)Steps.Payment:
                    return "Complete the payment";
                case (int)Steps.Confirmation:
                    return "Confirm the booking";
                default:
                    return "Invalid step";
            }
        }
    }
  
    public class Travel
    {
        public string StepNum { get; set; }
        public int step { get; set; }
    }

    public enum Steps
    {
        SourceDestination,
        Timings,
        Payment,
        Confirmation
    }
}        

