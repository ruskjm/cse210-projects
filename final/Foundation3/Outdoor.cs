// Outdoor class that inherits from Event class
public class Outdoor: Event {

    // Weather forecast string
    private string _weatherForecast;

    // Outdoor constructor
    // Inherits title, description, date, time, street, city, state, zip
    // from base class
    public Outdoor(string title, string description, string date, 
        string time, string street, string city, string state, string zip, string weather) :
        base(title, description, date, time, street, city, state, zip) {

        // Set the value
        _weatherForecast = weather;
    }

    // Method to display event details
    public void DisplayFullDetails() {
        Console.WriteLine($"A {GetType()} Event");
        // Calls DisplayStandardDetails from base class
        DisplayStandardDetails();
        Console.WriteLine($"The weather forcaste is {_weatherForecast}");
    }
}