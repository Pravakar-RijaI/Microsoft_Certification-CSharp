using System;

namespace CSharpFoundational
{
    internal class GMT
    {
        public static void Main()
        {
            int[] times = {800, 1200, 1600, 2000};
            Console.WriteLine("Enter Current GMT: ");
            int currentGmt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current Medicine Schedule: ");
            DisplayTime(times);
            Console.WriteLine("\nEnter New GMT: ");
            int newGmt = Convert.ToInt32(Console.ReadLine());
            times = EvaluateTime(times,currentGmt,newGmt);
            Console.WriteLine("New Medicine Schedule: ");
            DisplayTime(times);
        }
        
        public static void DisplayTime(int[] times)
        {
            foreach(int time in times)
            {
                string gmtTime = time.ToString();
                
                if(gmtTime.Length >= 3)
                {
                    Console.Write(gmtTime.Insert(gmtTime.Length - 2,":") + "\t");
                }
                else if(gmtTime.Length == 2)
                {
                    Console.Write(gmtTime.Insert(0,"0") + "\t");
                }
                else
                {
                    Console.Write(gmtTime.Insert(0,"0:0") + "\t");
                }
            }
        }
        
        public static int[] EvaluateTime(int[] times, int currentGmt, int newGmt)
        {
            int diff = 0;
            
            if((currentGmt > 0 && newGmt > 0) || (currentGmt < 0 && newGmt < 0))
            {
                diff = 100 * (Math.Abs(newGmt) - Math.Abs(currentGmt));
                for(int i = 0; i < times.Length; i++)
                {
                    times[i] = (times[i] + diff) % 2400;
                }
            }
            else
            {
                diff = 100 * (Math.Abs(newGmt) + Math.Abs(currentGmt));
                for(int i = 0; i < times.Length; i++)
                {
                    times[i] = (times[i] + diff) % 2400;
                }
            }
            return times;
        }
    }
}