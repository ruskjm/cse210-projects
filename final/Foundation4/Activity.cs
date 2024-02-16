// Base activity class
public abstract class Activity {

    // Activity date protected string
    protected string _activityDate;

    // Activity length protected string
    protected int _activityLength;

    // Activity list protected List
    protected List<Activity> _activityList;

    // Activity Constructor
    public Activity(string date, int duration) {

        // Set the values
        _activityDate = date;
        _activityLength = duration;
    }

    // Abstract method
    public abstract double GetDistance();

    // Abstract method
    public abstract double GetSpeed();

    // Abstract method
    public abstract double GetPace();

    // Display method
    public void GetSummary() {
        // Blank Line
        Console.WriteLine();

        // Display dashes for readability
        Console.WriteLine("-----------------------------------------");

        // Display output on separate line
        Console.WriteLine($"Date: {_activityDate}\n" + 
        $"Activity: {GetType().Name}\n" +
        $"Duration: {_activityLength} minutes\n" + 
        $"Distance: {GetDistance()} miles\n" +
        $"Speed: {GetSpeed()} mph\n" +
        $"Pace: {GetPace()} min per mile");

        // Display dashes for readability
        Console.WriteLine("-----------------------------------------");
        
        // Blank Line
        Console.WriteLine();
    }

}