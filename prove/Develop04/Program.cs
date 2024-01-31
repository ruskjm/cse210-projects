
// Main application class
class Program
{
    // Entry point for application
    static void Main(string[] args)
    {
        // Variable used to store user input for menu selection
        String input = "";

        // Create new BreathingActivity object
        BreathingActivity breathingActivity = new BreathingActivity();

        // Create new ReflectionActivity object
        ReflectionActivity reflectionActivity = new ReflectionActivity();

        // Create new ListingActivity object
        ListingActivity listingActivity = new ListingActivity();

        // While loop that will continue until user enters 4
        while(input != "4") {
            // Menu to display
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflection activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Read user input
            input = Console.ReadLine();

            // Breathing activity option
            if (input == "1") {

                // Calls the RunBreathingActivity method in the BreathingActivity class
                breathingActivity.RunBreathingActivity();
            }

            // Reflection activity option
            else if (input == "2") {
                // Calls the RunReflectionActivity method in the ReflectionActivity class
                reflectionActivity.RunReflectionActivity();
            }

            // Reflection listing option
            else if (input == "3") {
                // Calls the RunListingActivity method in the ListingActivity class
                listingActivity.RunListingActivity();
            }

            // Message to display if user enters to quit
            else if (input == "4") {
                Console.WriteLine("Thank you for using the Mindfulness Program");
            }

            // Message to display if valid option not entered
            else {
                Console.WriteLine("Not a valid entry, try again!");
            }
        }

    }
}