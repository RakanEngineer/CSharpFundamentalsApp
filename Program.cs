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

            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = "";
            if (userValue == "1")            
                 message = "You won a new car!";
            
            else if (userValue == "2")            
                 message = "You won a new boat!";
            
            else if (userValue == "3")            
                 message = "You won a new cat!";
            
            else
            {
                Console.WriteLine("Sorry, we didn't understand!");
                message += " You lose";
            }
            Console.WriteLine(message);
            Console.ReadLine(); 
            */

            //Console.WriteLine("Bob's Big Giveaway");
            //Console.Write("Choose a door: 1, 2, or 3: ");
            //string userValue = Console.ReadLine();

            //string message = (userValue =="1") ? "boat" : "strand of lint";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.ReadLine();


            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }
            Console.ReadLine();
            
            int[] numbers = new int[10];
            numbers[0]= 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 4;
            numbers[4] = 16;

            Console.WriteLine(numbers[1]);

            string zig = "You can get what you want out of life";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach (char zigChar in charArray)
                Console.WriteLine(zigChar);
        }
    }
}
