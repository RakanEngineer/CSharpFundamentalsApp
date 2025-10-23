namespace C__FundamentalsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */


            //Console.WriteLine("What is your name?");
            //Console.Write("Type your first name: ");
            //string myFirstName;
            //myFirstName = Console.ReadLine();

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            //Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            //Console.ReadLine();

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Sorry, we didn't understand!");
            }
            Console.ReadLine(); 
        }
    }
}
