
using System.Threading.Tasks.Dataflow;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() {}

    public void DisplayStartingMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long in seconds, would you like your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(2);
    }

    public void DisplayEndingMessage() {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
        Console.Clear();
    }

    public void ShowSpinner(int seconds) {
        var startTime = DateTime.Now;
        var spinner = new string[] {"-", "\\", "|", "/"};
        var index = 0;

        while ((DateTime.Now - startTime).TotalSeconds < seconds) {
                Console.Write("\b" + spinner[index++ % spinner.Length]); 
                Thread.Sleep(300);
        }
         

    }

    public void ShowCountDown(string message, int seconds) 
    {
        Console.Write(message);
        
        int cursorLeft = Console.CursorLeft;

        for (int i = seconds; i >= 0; i--)
        {
            Console.SetCursorPosition(cursorLeft, Console.CursorTop);
            Console.Write(i);
            
            Thread.Sleep(1000);

            Console.SetCursorPosition(cursorLeft, Console.CursorTop);
            Console.Write(new string('\b', i.ToString().Length)); 
            //Console.Write(new string(' ', i.ToString().Length));
            //Console.Write("\b\b"); // backspace space backspace
        }
    }

// public void ShowCountDown(string message, int seconds)  
// {
//     Console.Write(message);
    
//     for (int i = seconds; i > 0; i--) 
//     {
//         Console.Write(" " + i);
//         Thread.Sleep(1000);
//         Console.SetCursorPosition(0, Console.CursorTop); 
//     }
// }

// public void ShowCountDown(string message, int seconds)
// {
//     //Console.Write(message);

//     for (int i = seconds; i > 0; i--)
//     {
//         Console.Write(message);
//         Console.Write(i);  
//         Thread.Sleep(1000);
        
//         int msgLength = message.Length + i.ToString().Length + 1;
//         Console.SetCursorPosition(0, Console.CursorTop);
        
//          for (int j = 0; j < msgLength; j++)
//          {
//              Console.Write("\b"); 
//          }
//     }
    
// }



}