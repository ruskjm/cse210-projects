// Lecture class that inherits from Event class
public class Lecture: Event {

    // Speaker name string
    private string _speakerName;

    // Capacity string
    private string _capacity;

    // Lecture constructor
    // Inherits title, description, date, time, street, city, state, zip
    // from base class
    public Lecture(string title, string description, string date, 
        string time, string street, string city, string state, string zip, 
        string name, string capacity) :
        base(title, description, date, time, street, city, state, zip) {

        // Sets the values
        _speakerName = name;
        _capacity = capacity;
    }

    // Method to display event details
    public void DisplayFullDetails() {
        Console.WriteLine($"A {GetType()} Event");
        // Calls DisplayStandardDetails from base class
        DisplayStandardDetails();
        Console.WriteLine($"The speaker is {_speakerName}");
        Console.WriteLine($"The event capacity is {_capacity}");
    }
}