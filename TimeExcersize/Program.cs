using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeExcersize
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
            int amountOfMinutes = 43800;
            string prefix = "";

            void FindMonth(long minutes)
            {
                long month = (minutes % 43800) + 1;
                Console.WriteLine(month);
                Console.ReadKey();

            }
            FindMonth(amountOfMinutes);       
            
            void TimeOfDay(long minutes)
            {
                int startOfDay = 0;
                                                
                long minutesRemaining = (minutes % 60);
                double hours = Math.Floor((double)minutes / 60);
                
                Console.WriteLine($"Minutes remaining {minutesRemaining}, hours {hours}");                               

                string timeOfDay = $"{(startOfDay + hours) % 12}:{Convert.ToString(minutesRemaining).PadLeft(2, '0')}";                
                
                Console.WriteLine($"Time of day is {timeOfDay}{prefix}");
                Console.ReadKey();

                //DETERMINE HOW TO DECIDE IF IT IS AM OR PM/                                                             
            }

           


            TimeOfDay(360 * 5);


        }
    }
}
