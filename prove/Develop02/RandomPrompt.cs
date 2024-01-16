using System;

//RandomPrompt class can generate random prompts
public class RandomPrompt {
    //Declare array to store a list of possible prompt phrases
   public List<string> prompts;

    public RandomPrompt() {
        //Prompts that can be returned
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
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