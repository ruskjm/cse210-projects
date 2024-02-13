public class Event {

    private string _eventTitle;

    private string _eventDescription;

    private string _eventDate;

    private string _eventTime;

    private Address _eventAddress;

    public Event(string title, string description, string date, 
        string time, string street, string city, string state, string zip) {
            _eventTitle = title;
            _eventDescription = description;
            _eventDate = date;
            _eventTime = time;
            _eventAddress = new Address(street, city, state, zip);
    }

    public void DisplayStandardDetails() {
        Console.WriteLine($"The event title is {_eventTitle}");
        Console.WriteLine($"The event description is {_eventDescription}");
        Console.WriteLine($"The event date is {_eventDate}");
        Console.WriteLine($"The event time is {_eventTime}");
        Console.WriteLine($"The event will be at:");
        _eventAddress.DisplayAddress();
    }

    public void DisplayShortDescription() {
        Console.WriteLine($"A {GetType()} Event");
        Console.WriteLine($"The event title is {_eventTitle}");
        Console.WriteLine($"The event date is {_eventDate}");
    }
}