class ReflectionActivity: Activity
{
     private List<string> _prompts;
     private List<string> _questions;

    public ReflectionActivity() {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shows " +
        "strength and resilience. This will help you recognize the power you have and how you can use it in " +
        "other aspects of your life.";
    }

    public void Run() {
        
    }

    private string GetRandomPrompt() {
        var prompts = new List<string>() {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    
        var random = new Random();
        var index = random.Next(prompts.Count);

        return prompts[index];
        
    }

    private string GetRandomQuestion() {
        var prompts = new List<string>() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
    };
    
        var random = new Random();
        var index = random.Next(prompts.Count);

        return prompts[index]; 
        
    }

    public void DisplayPrompt() {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine("--- " + prompt + " ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        }

    public void DisplayQuestion() {
        Console.WriteLine("Now ponder on each of the following questions as they related " +
        "to this experience.");
        ShowCountDown("You may begin in: ", 5);
        Console.Clear();

        string question = GetRandomQuestion();
        Console.Write("> " + question  + "  ");
        ShowSpinner(5);
    }


}