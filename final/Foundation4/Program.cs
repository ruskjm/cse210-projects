/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Final Project
Program 4: Polymorphism with Exercise Tracking
*/

// Main application class
class Program {
    // Entry point for application
    static void Main(string[] args) {

        // Clear the console
        Console.Clear();

        // Display
        Console.WriteLine("Jason Exercise Log");

        // New Activity List
        List<Activity> activityList = new List<Activity>();

        // New Cycling object and pass in values to constructor
        Cycling cycling = new Cycling("10 Feb 2024", 127, 14.25);

        // Add activities to list
        activityList.Add(cycling);

        // New Swimming object and pass in values to constructor
        Swimming swimming = new Swimming("12 Feb 2024", 59, 65);

        // Add activities to list
        activityList.Add(swimming);

        // New Running object and pass in values to constructor
        Running running = new Running("15 Feb 2024", 61, 7.08);

        // Add activities to list
        activityList.Add(running);

        // Loop thru activity list
        foreach(Activity activity in activityList) {

            // Call method to display results
            activity.GetSummary();
        }
    }
}