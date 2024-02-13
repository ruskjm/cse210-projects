public class Reception: Event {

    // Private string to store email address
    private string _rsvpEmail;

    public Reception(string title, string description, string date, 
        string time, string street, string city, string state, string zip, string email) :
        base(title, description, date, time, street, city, state, zip) {

            // Set email address
            _rsvpEmail = email;
    }

    public void DisplayFullDetails() {

        Console.WriteLine($"A {GetType()} Event");
        DisplayStandardDetails();
        Console.WriteLine($"Please send RSVP to: {_rsvpEmail}");
    }
}