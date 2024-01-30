class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your " +
        "life by having you list as many things as you can in a certain area.";
     }

    public void Run() {
        
    }

    public void GetRandomPrompt() {
        var prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

        var random = new Random();
        var index = random.Next(prompts.Count);
  
        string prompt = prompts[index];
        Console.WriteLine();
        Console.WriteLine(prompt);
        
    }

    public List<string> GetListFromUser() {

        List<string> list = new List<string>();

        

        return list;

    }



}