/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Week 04 Develop: Mindfulness Program
Inheritance

Functional requirements
Your program must do the following:
1. Have a menu system to allow the user to choose an activity.
2. Each activity should start with a common starting message that provides the name of 
   the activity, a description, and asks for and sets the duration of the activity in seconds. 
   Then, it should tell the user to prepare to begin and pause for several seconds.
3. Each activity should end with a common ending message that tells the user they have done 
   a good job, and pause and then tell them the activity they have completed and the length 
   of time and pauses for several seconds before finishing.
4. Whenever the application pauses it should show some kind of animation to the user, 
   such as a spinner, a countdown timer, or periods being displayed to the screen.
5. The interface for the program should remain generally true to the one shown in the video 
   demo.
6. Provide activities for reflection, breathing, and enumeration, as described below:

Classes:
Activity: Base class that has _name, _description, _duration protected variables.
          DisplayStartingMessage, DisplayEndingMessage, ShowSpinner, ShowCountDown methods
          used by derived classes.
Menu: Displays the menu and reads in the user menu choice.
ListingActivity: Inherits from the Activity class and calls the methods from the base class.
                 Has the ListingActivity constructor, RunListingActivity, GetRandomQuestion, 
                 GetListFromUser methods.
BreathingActivity: Inherits from the Activity class and calls the methods from the base class.
                   Has the BreathingActivity constructor and RunBreathingActivity method.
ReflectionActivity: Inherits from the Activity class and calls the methods from the base class.
                    Has the ReflectionActivity constructor and RunReflectionActivity, GetRandomPrompt
                    LoadQuestions, GetRandomQuestion, DisplayPrompt and DisplayQuestion methods.         

Stretch comments:
I did the below beyond the core requirements:
1. Created amenu class that loads the menu and reads in the user input.
2. In the ReflectionActivity class modified the code so the same question is not repeated
   from the GetRandomQuestion method.
3. Added for prompts and questions in the ReflectionActivity and ListingActivity classes.
*/

// Main application class
class Program
{
    // Entry point for application
    static void Main(string[] args)
    {
        // Variable used to store user input for menu selection
        String input = "";

        // Create new Menu object
        Menu menu = new Menu();

        // Create new BreathingActivity object
        BreathingActivity breathingActivity = new BreathingActivity();

        // Create new ReflectionActivity object
        ReflectionActivity reflectionActivity = new ReflectionActivity();

        // Create new ListingActivity object
        ListingActivity listingActivity = new ListingActivity();

        // While loop that will continue until user enters 4
        while(input != "4") {

            // Call the ShowMenu in the Menu class to display the menu
            menu.ShowMenu();

            //Call the GetMenuSelection in the Menu class to read in the user input
            input = menu.GetMenuSelection();

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
                // Blank Line
                Console.WriteLine();

                // Message to display
                Console.WriteLine("Thank you for using the Mindfulness Program");
            }

            // Message to display if valid option not entered
            else {
                Console.WriteLine("Not a valid entry, try again!");
            }
        }

    }
}