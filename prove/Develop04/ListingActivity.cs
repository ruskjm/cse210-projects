class ListingActivity : Activity
{
    // Private int for list count
    private int _count;

    // Private list of string  _questions
    private List<string> _questions;

    // ListingActivity constructor that sets the _name and _description protected
    // variables from the Activity class
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your " +
        "life by having you list as many things as you can in a certain area.";
    }

    public void RunListingActivity()
    {

        // Call the DisplayStartingMessage method from the Activity class
        DisplayStartingMessage();

        // Blank line
        Console.WriteLine();

        // Call the GetRandomQuestion method
        GetRandomQuestion();

        // Blank line
        Console.WriteLine();

        // Call the ShowCountDown method from the Activity class
        // and pass in message and seconds
        ShowCountDown("You may begin in: ", 5);

        // Blank line
        Console.WriteLine();

        // Declare a variable to store the start time
        var startTime = DateTime.Now;

        // New string list
        List<string> list = new List<string>();

        // Calculates the current seconds from startTime and continue to process
        // until the specified number of seconds from the protected _duration
        // from Activity class
        while ((DateTime.Now - startTime).TotalSeconds < _duration) {
            // Call GetListFromUser method with passed in list
            GetListFromUser(list);
        }

        // Display how many items entered
        Console.WriteLine($"You have listed {_count} items!");

        // Blank line
        Console.WriteLine();

        // Call the DisplayEndingMessage from the Activity class
        DisplayEndingMessage();
    }

    // Private method to gets a random question
    private void GetRandomQuestion() {

        // List of random questions
        _questions = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

        // Random number generator
        var random = new Random();

        // Get random index
        var index = random.Next(_questions.Count);

        // Get random question and set string
        string question = _questions[index];

        // Blank line
        Console.WriteLine();

        // Display message
        Console.WriteLine("List as many responses you can to the following prompt:");

        // Blank line
        Console.WriteLine();

        // Display random question
        Console.WriteLine(question);
    }


    // Private method to for the user to enter a list
    private void GetListFromUser(List<string> list)
    {

        // Display message
        Console.Write(">");

        // Read in user input
        string input = Console.ReadLine();

        // Add input to the list
        list.Add(input);

        // Set the count of the list 
        _count = list.Count();

    }



}