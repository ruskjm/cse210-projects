using System;

//RandomPrompt class can generate random prompts
public class RandomPrompt {
    //Declare array to store a list of possible prompt phrases
   public List<string> prompts;

    public RandomPrompt() {
        //Prompts that can be returned stored in an array of strings
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you learn today from \"Come Follow Me\"?",
            "Did you run into an old friend today?",
            "Are you reading an interesting book, if so tell me about it?",
            "Are you planning or did you recently go on a vacation?",
            "Tell me about a book you are currently reading.",
            "What miracles are you witnessing right now? ",
            "Did you do something today for your physical health?",
            "Did you overcome a challenge or obstacle today?",
            "Have you recently performed an act of service?",
            "Describe two or three things you do to relax.",
            "How do you show yourself kindness and compassion each day?",
            "List 5 things that inspire or motivate you.",
            "What are your favorite hobbies?",
            "What helps you stay focused and motivated when you feel discouraged?"
        };
    }

   public string GetRandomPrompt() {
        //Create Random object 
        var random = new Random();
        //Pick a random index based on number of prompts
        int index = random.Next(prompts.Count);
        //Return prompt text at the selected index
        return prompts[index]; 
   }
}