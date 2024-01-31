// BreathingActivity class that inherits from the Activity class
class BreathingActivity: Activity
{

    // BreathingActivity constructor that sets the _name and _description protected
    // variables from the Activity class
    public BreathingActivity() {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through " +
        "breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    // RunBreathingActivity method that calls the other classes
    // Called by Program class (main)
    public void RunBreathingActivity() {
        
        // Call the DisplayStartingMessage method from the Activity class
        DisplayStartingMessage();

        // Blank line
        Console.WriteLine();

        // Declare a variable to store the start time
        var startTime = DateTime.Now;

        // Calculates the current seconds from startTime and continue to process
        // until the specified number of seconds from the protected _duration
        // from Activity class
        while ((DateTime.Now - startTime).TotalSeconds < _duration) {

            // Call the ShowCountDown method from the Activity class
            // and pass in message and seconds
            ShowCountDown("Breath in...", 4);

            // Blank line
            Console.WriteLine();

            // Call the ShowCountDown method from the Activity class
            // and pass in message and seconds
            ShowCountDown("Now breath out...", 6);

            // Blank line
            Console.WriteLine();

            // Blank line
            Console.WriteLine(); 
        }  

        // Call the DisplayEndingMessage from the Activity class
        DisplayEndingMessage();    
    }

}