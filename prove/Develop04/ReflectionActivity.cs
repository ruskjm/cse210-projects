// ReflectionActivity class that inherits from the Activity class
class ReflectionActivity: Activity
{
    // Private list of strings _prompts
     private List<string> _prompts;

    // Private list of strings _questions
     private List<string> _questions;  

    // Random number generator
     private Random random = new Random();   

    // ReflectionActivity constructor that sets the _name and _description protected
    // variables from the Activity class
    public ReflectionActivity() {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shows " +
        "strength and resilience. This will help you recognize the power you have and how you can use it in " +
        "other aspects of your life.";
    }

    // RunBreathingActivity method that calls the other classes
    // Called by Program class (main)
    public void RunReflectionActivity() {
        
        // Call the DisplayStartingMessage method from the Activity class
        DisplayStartingMessage();

        // Blank line
        Console.WriteLine();

        // Call the DisplayPrompt method
        DisplayPrompt();

        // Declare a variable to store the start time
        var startTime = DateTime.Now;

        // Call the LoadQuestions method to load all the questions
        LoadQuestions();

        // Calculates the current seconds from startTime and continue to process
        // until the specified number of seconds from the protected _duration
        // from Activity class
        while ((DateTime.Now - startTime).TotalSeconds < _duration) {

            // Call the DisplayQuestion method
            DisplayQuestion();
        }

        // Blank line
        Console.WriteLine();

        // Call the DisplayEndingMessage from the Activity class
        DisplayEndingMessage();        
    }

    // Private method to gets a random prompt
    private string GetRandomPrompt() {

        // List of random prompts
        _prompts = new List<string>() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you showed great resilience in the face of adversity.",
            "Think of an experience where you overcame fear and stepped outside your comfort zone.",
            "Think of a time when you creatively solved a problem.",
            "Think of an experience where you failed at first but demonstrated grit and perseverance."
        };
 
        // Get random index
        var index = random.Next(_prompts.Count);

        // Returns random prompt
        return _prompts[index];       
    }

    // Private method that loads the random questions
    private void LoadQuestions() {
        // List of random questions
        _questions = new List<string>() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "Did you achieve what you had hoped from this experience?",
            "What was the most difficult part of this experience for you and how did you overcome it?",
            "Did this experience help you gain any new skills?",
            "Did you ever feel like giving up?",
            "What motivated you to persist through to the end?",
            "If you had unlimited resources, how might you have approached this experience differently?",
            "Knowing what you know now, what advice would you give someone who was about to start a similar experience"
        };
    }

    // Private method to gets a random question
    private string GetRandomQuestion() {
        
        // Get random index
        var index = random.Next(_questions.Count);

        // Saves off returned question to a sttring
        string question = _questions[index];

        // Remove selected question from list   
        _questions.RemoveAt(index);

        // If all questions have been used reload them
        if(_questions.Count == 0) {
           LoadQuestions();
        } 
  
        // Returns random question
        return question;
    }

    // Priavte method to display prompt
    private void DisplayPrompt() {

        // Get a random prompt by calling GetRandomPrompt method
        string prompt = GetRandomPrompt();

        // Blank line
        Console.WriteLine();

        // Display message
        Console.WriteLine("Consider the following prompt:");

        // Blank line
        Console.WriteLine();

        // Display message with random prompt
        Console.WriteLine("--- " + prompt + " ---");

        // Blank line
        Console.WriteLine();

        // Display message
        Console.WriteLine("When you have something in mind, press enter to continue.");

        // Read in user input (waiting for user to hit enter)
        Console.ReadLine();

        // Display message
        Console.WriteLine("Now ponder on each of the following questions as they related " +
        "to this experience.");

        // Call the ShowCountDown method from the Activity class
        // and pass in message and seconds
        ShowCountDown("You may begin in: ", 5);

        // Clear console
        Console.Clear();

        // Display message with random prompt again so the user can refer back to it
        Console.WriteLine("--- " + prompt + " ---");

        // Blank line
        Console.WriteLine();
    }

    // Priavte method to display question
    private void DisplayQuestion() {

        // Get a question prompt by calling GetRandomQuestion method
        string question = GetRandomQuestion();

        //Display questions
        Console.Write("> " + question  + "  ");

        // Calls the ShowSpinner method from the Activity class with passed in seconds
        ShowSpinner(10);

        // Blank line
        Console.WriteLine();
    }

}