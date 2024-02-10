// Public class for the video
public class Video {

    // Title of the video
    public string _title;

    // Author of the video
    public string _author;

    // Length of video
    public string _length;

    // List of comments
    public List<Comment> _comments = new List<Comment>();

    // Method to get and return total comments from the list
    public int NumberOfComments() {

        // Return count
        return _comments.Count;
    }

    // Method to display video information
    public void DisplayVideoInfo() {

        // Display the video name and author in bold/red
        Console.WriteLine($"\x1B[31;1mName of the video is: {_title} by {_author}\x1B[0m");

        // Display the video length
        Console.WriteLine($"Video length is: {_length} seconds");

        // Display totals on the video
        Console.WriteLine($"The video has {NumberOfComments()} comments");

        // Blank line
        Console.WriteLine();
    }
}