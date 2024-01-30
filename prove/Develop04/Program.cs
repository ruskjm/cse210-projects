
class Program
{
    static void Main(string[] args)
    {
        String input = "";
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        while(input != "4") {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflection activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1") {
                breathingActivity.DisplayStartingMessage();
                Console.WriteLine();
                breathingActivity.ShowCountDown("Breath in...", 3);
                Console.WriteLine();
                breathingActivity.ShowCountDown("Now breath out...", 3);
                Console.WriteLine();
                breathingActivity.DisplayEndingMessage();

            }
            else if (input == "2") {
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.DisplayPrompt();
                reflectionActivity.DisplayQuestion();
                reflectionActivity.DisplayEndingMessage();
            }
            else if (input == "3") {
                listingActivity.DisplayStartingMessage();
                listingActivity.GetRandomPrompt();
                listingActivity.GetListFromUser();
                listingActivity.DisplayEndingMessage();
            }
            else {
                Console.WriteLine("Not a valid entry!");
            }
        }

    }
}