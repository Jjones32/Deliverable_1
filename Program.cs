using System;

namespace DELIVERABLE1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yes = true;
            bool y = true;

            Console.WriteLine("Hello, how many people are we making PB&J sandwiches for?");
            var answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number of people again for confirmation.");

            
            
                answer += 1;
                SandwichMath();
                Console.WriteLine("please enter number of people again for confirmation.");

                if (answer < 1)
                {
                    Console.WriteLine("Goodbye");

                }

                Console.WriteLine(" ");

                Console.WriteLine("Would you like to restart?");
                Console.WriteLine("Please type yes or y");
                Console.ReadLine();

                if (yes)
                {
                    Console.WriteLine("Hello, how many people are we making PB&J sandwiches for?");
                    SandwichMath();
                }
                if (y)
                {
                    Console.WriteLine("Hello, how many people are we making PB&J sandwiches for?");
                    SandwichMath();
                }
                else 
                {
                    
                }
                                   
        }
        
        public static void SandwichMath()
        {
            double sammys = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Number of ingrediants needed:");
            Console.WriteLine(" ");
            double totalSlicesOfBread = sammys * 2;
            double totalTblSpoonPb = sammys * 2;
            double totalTspJelly = sammys * 4;
            Console.WriteLine("It takes  " + totalSlicesOfBread + " slicesto make all these sandwiches.");
            Console.WriteLine("It takes " + totalTblSpoonPb + " tablespoons of peanut butter to make this many sandwiches");
            Console.WriteLine("It takes " + totalTspJelly + " teaspoons of jelly to make this many sandwiches");
            Console.WriteLine(" ");
            Console.WriteLine("It takes " + Math.Round(totalSlicesOfBread / 28) + " loaves of bread to make this many snadwiches");
            Console.WriteLine("It takes " + Math.Round(totalTblSpoonPb / 32) + " jars of peanut butter to make this many sandwiches");
            Console.WriteLine("It takes " + Math.Round(totalTspJelly / 48) + " jars of jelly are needed to make this many sandwiches");
        }
        
  
    }
}
