namespace Electricity_Bill_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input 
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your User ID : ");
            string userId =Console.ReadLine();
            Console.WriteLine($"{name} please enter the amount of units consumed :  ");
            double units = double.Parse(Console.ReadLine());
            double rate1 = 1.20;
            double rate2 = 1.50;
            double rate3 = 1.80;
            double rate4 = 2.00;
            double sum = 0;
            double surcharge = 0;


            // doing work
            if (units <= 199)
            {
                sum = units * rate1;
                Console.WriteLine($"The total for {units} @ $1.20 = {sum} ");
            }
            else if (units >= 200 && units <= 399)
            {
                sum = units * rate2;
                Console.WriteLine($"The total for {units} @ $1.50 = {sum} ");
            }
            else if (units >= 400 && units <= 599)
            {
                sum = units *rate3;
                Console.WriteLine($"The total for {units} @ $1.80 = {sum} ");
            }
            else if (units >= 600)
            {
                sum = units * rate4;
                Console.WriteLine($"The total for {units} @ $2.00 = {sum} ");
            }


            double total = sum;


            if (sum > 400)
            {
                surcharge = sum * 0.15;
                total = sum + surcharge;

            }

            // output
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Name: {name}\n\nUserID: {userId}" +
                $"\n\nUnits: {units}\n\nTotal before Surcharge: ${sum}" +
                $"\n\n(if over $400 surcharge of 15% added)" +
                $"\n\nSurcharge amount: ${surcharge}\n\n" +
                $"Total after surcharge: ${total}");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            

            
        }
    }
}
