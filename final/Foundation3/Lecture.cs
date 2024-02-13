public class Lecture: Event {

    private string _speakerName;

    private string _capacity;


    public Lecture(string title, string description, string date, 
        string time, string street, string city, string state, string zip, 
        string name, string capacity) :
        base(title, description, date, time, street, city, state, zip) {

        _speakerName = name;
        _capacity = capacity;
    }

    public void DisplayFullDetails() {
        Console.WriteLine($"A {GetType()} Event");
        DisplayStandardDetails();
        Console.WriteLine($"The speaker is {_speakerName}");
        Console.WriteLine($"The event capacity is {_capacity}");
    }
}