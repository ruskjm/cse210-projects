/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Week 05 Develop: Eternal Quest Program
Polymorphism

Functional requirements
Your program must do the following:
1. Provide for simple goals that can be marked complete and the user gains some value.
        For example, if you run a marathon you get 1000 points.
2. Provide for eternal goals that are never complete, but each time the user records them, they 
   gain some value.
        For example, every time you read your scriptures you get 100 points.
3. Provide for a checklist goal that must be accomplished a certain number of times to be complete. 
   Each time the user records this goal they gain some value, but when they achieve the desired amount, 
   they get an extra bonus.
        For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, 
        and then a bonus of 500 points on the 10th time.
4. Display the user's score.
5.  Allow the user to create new goals of any type.
6.  Allow the user to record an event (meaning they have accomplished a goal and should receive points).
7.  Show a list of the goals. This list should show indicate whether the goal has been completed or not 
        (for example [ ] compared to [X]), and for checklist goals it should show how many times the goal 
        has been completed (for example Completed 2/5 times).
8.  Allow the user's goals and their current score to be saved and loaded.

In addition your program must:
1.  Use inheritance by having a separate class for each kind of activity with a base class to contain 
    any shared attributes or behaviors.
2.  Use polymorphism by having derived classes override base class methods where appropriate.
3.  Follow the principles of encapsulation and abstraction by having private member variables and 
    putting related items in the same class.

Classes:
Program

GoalsManager

Base Class
    Goals

Subclasses
    EternalGoals

    SimpleGoals

    ChecklistGoals


Stretch comments:


*/


// Main application class
class Program
{
    // Entry point for application
    static void Main(string[] args)
    {

        // Variable used to store user input for menu selection
        string input = "";

        // Variable used to store user input for goal option
        string goalType;

        // Create new GoalsManager object
        GoalsManager goalsManager = new GoalsManager();

        // While loop that will continue until user enters 4
        while (input != "6")
        {

            // Call the DisplayTotalPoints method in the GoalsManager class
            // to display the current total points earned
            goalsManager.DisplayTotalPoints();

            // Call the ShowMenu method in the GoalsManager class
            goalsManager.ShowMenu();

            // Call the GetSelection in the GoalsManager class to read in the user input
            input = goalsManager.GetSelection();

            // Option to add a new goal
            if (input == "1") {

                // Call the ShowMenu method in the GoalsManager class
                goalsManager.DisplayGoalsOptions();

                // Call the GetSelection in the GoalsManager class to read in the user input
                goalType = goalsManager.GetSelection();

                // Create a string array of valid choices the user can enter
                string[] validChoices = { "1", "2", "3" };

                // Validate the user enters a valid choice or prompts for another entry
                while (!validChoices.Contains(goalType))
                {

                    // Display valid choices
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");

                    // Prompts to select again
                    Console.Write("Select a choice from the menu: ");

                    //Call the GetSelection in the GoalsManager class to read in the user input
                    goalType = goalsManager.GetSelection();
                }

                // Call the CreateGoal method in the GoalsManager class
                goalsManager.CreateGoal(goalType);
            }

            // Option to load goals
            else if (input == "2") {
                // Call the ListGoals method in the GoalsManager class
                goalsManager.ListGoals();
            }

            // Option to save the goals to a file
            else if (input == "3") {
                // Call the SaveGoals method in the GoalsManager class
                goalsManager.SaveGoals();
            }

            // Option to load the goals to a file
            else if (input == "4") {
                // Call the LoadGoals method in the GoalsManager class
                goalsManager.LoadGoals();
            }

            // Option to complete a goal
            else if (input == "5") {
                // Call the RecordEvent method in the GoalsManager class
                goalsManager.RecordGoal();
            }

            // Message to display if user enters to quit
            else if (input == "6") {
                // Blank Line
                Console.WriteLine();

                // Message to display
                Console.WriteLine("Thank you using Goal Setting Program");
            }

            // Message to display if valid option not entered
            else {
                Console.WriteLine("Not a valid entry, try again!");
            }
        }
    }
}