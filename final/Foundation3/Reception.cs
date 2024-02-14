// Reception class that inherits from Event class
public class Reception: Event {

    // Email address string
    private string _rsvpEmail;

    // Reception constructor
    // Inherits title, description, date, time, street, city, state, zip
    // from base class
    public Reception(string title, string description, string date, 
        string time, string street, string city, string state, string zip, string email) :
        base(title, description, date, time, street, city, state, zip) {

            // Set value
            _rsvpEmail = email;
    }

    // Method to display event details
    public void DisplayFullDetails() {
        Console.WriteLine($"A {GetType()} Event");
        // Calls DisplayStandardDetails from base class
        DisplayStandardDetails();
        Console.WriteLine($"Please send RSVP to: {_rsvpEmail}");
    }
}