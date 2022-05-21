
namespace _7.lekcija
{
    public static class Program
    {
        public static void Mains(string[] args)
        {
            int number = 15;

            if (number > 45)
            {
                int number2 = number + 5;
                Console.WriteLine($"Mans skaitlis ir: {number2}");

                if (number2 < 45)
                {
                    int number3 = number2 + 8;
                    Console.WriteLine($"Mans skaitlis ir: {number3}");
                }

                {
                    int number4 = number2 + 9;
                    Console.WriteLine($"Mans skaitlis ir: {number4}");
                }
            }

            Console.WriteLine($"Mans skaitlis ir: {number}");

            string appName = Configuration.AppName;
            Console.WriteLine($"Aplikācijas nosaukums ir {appName}");

            // Piemērs ja nebūtu static
            //Configuration configuration = new Configuration();
            //configuration.Sum();


            Configuration.Sum();

        }
    }
}
   