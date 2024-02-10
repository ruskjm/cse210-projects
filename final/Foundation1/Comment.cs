// Public class for comment
public class Comment {

// Name of person making comment
public string _name;

// The comment from the video
public string _comment;

    // Display method for each comment
    public void DisplayComments() {

        // Display name of person making comment
        Console.WriteLine($"Name of commenter is: {_name}");

        // Display comment
        Console.WriteLine($"The comment is {_comment}");

        // Blank line
        Console.WriteLine();
    }
}