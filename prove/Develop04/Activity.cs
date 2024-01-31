
// Activity class 
class Activity
{
    // Protected string _name
    protected string _name;

    // Protected string _description
    protected string _description;

    // Protected int _duration
    protected int _duration;

    // Displays the staring message method.
    public void DisplayStartingMessage() {

        // Clears the console
        Console.Clear();

        // Displays the welcome message with passed in _name string 
        // set in the calling class
        Console.WriteLine($"Welcome to the {_name} Activity.");

        // Blank line
        Console.WriteLine();
        // Calls in the _description variable set in the calling class
        Console.WriteLine($"{_description}");

        // Blank line
        Console.WriteLine();

        // Display message for user to answer
        Console.Write("How long, in seconds, would you like your session? ");

        // Reads in user input
        string input = Console.ReadLine();

        // Converts user input to in an stores in _duration variable
        _duration = int.Parse(input);

        // Blank line
        Console.WriteLine();

        // Get ready display message
        Console.WriteLine("Get ready...");

        // Calls the ShowSpinner method with passed in seconds
        ShowSpinner(2);
    }

    // Displays the ending message method.
    public void DisplayEndingMessage() {

        // Display message
        Console.WriteLine("Well done!!");

        // Calls the ShowSpinner method with passed in seconds
        ShowSpinner(2);

        // Blank line
        Console.WriteLine();

        // Displays the completed message with passed in _duration int and _name string
        // set in the calling class
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");

        // Calls the ShowSpinner method with passed in seconds
        ShowSpinner(8);

        // Clears the console
        Console.Clear();
    }

    // ShowSpinner method that shows the spinner for amoount of
    // seconds passed in.
    public void ShowSpinner(int seconds) {

        // Declare a variable to store the start time
        var startTime = DateTime.Now;

        // Create an array of string characters to use as a spinner animation
        var spinner = new string[] {"-", "\\", "|", "/"};

        // Index variable to keep track of the spinner
        var index = 0;

        // Calculates the current seconds from startTime and continue to process
        // until the specified number of seconds
        while ((DateTime.Now - startTime).TotalSeconds < seconds) {
                // Print next spinner character
                Console.Write("\b" + spinner[index++ % spinner.Length]);

                // Sleep for 300 milliseconds
                Thread.Sleep(300);
        }
    }

    // ShowCountDown method that shows the countdown for amount of
    // seconds passed in and the message.
    public void ShowCountDown(string message, int seconds) { 
             
        // Store the current position of the cursor
        int cursorLeft = Console.CursorLeft;

        // loop thru the seconds
        for (int i = seconds; i > 0; i--) {
            // Restore original cursor position
            Console.SetCursorPosition(cursorLeft, Console.CursorTop);

            // Display the passed in message and countdown value
            Console.Write(message + i);

            // Sleep for 1000 milliseconds (1 second)
            Thread.Sleep(1000);
        }

        // Blank out the last number onthe display
        Console.Write("\b ");
    }
}