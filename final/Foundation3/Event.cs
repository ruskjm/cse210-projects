// Event class
public class Event {

    // Event title string
    private string _eventTitle;

    // Event description string
    private string _eventDescription;

    // Event date string
    private string _eventDate;

    // Event time string
    private string _eventTime;

    // The address from class instance 
    private Address _eventAddress;

    // Event constructor
    public Event(string title, string description, string date, 
        string time, string street, string city, string state, string zip) {

            // Set values
            _eventTitle = title;
            _eventDescription = description;
            _eventDate = date;
            _eventTime = time;

            // Sets address from address class
            _eventAddress = new Address(street, city, state, zip);
    }

    // Method to display event details
    public void DisplayStandardDetails() {
        Console.WriteLine($"The event title is {_eventTitle}");
        Console.WriteLine($"The event description is {_eventDescription}");
        Console.WriteLine($"The event date is {_eventDate}");
        Console.WriteLine($"The event time is {_eventTime}");
        Console.WriteLine($"The event will be at:");

        // Calls DisplayAddress method from Address class
        _eventAddress.DisplayAddress();
    }

    // Method to display event description
    public void DisplayShortDescription() {
        Console.WriteLine($"A {GetType()} Event");
        Console.WriteLine($"The event title is {_eventTitle}");
        Console.WriteLine($"The event date is {_eventDate}");
    }
}