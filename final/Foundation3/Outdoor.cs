public class Outdoor: Event {

    private string _weatherForecast;

    public Outdoor(string title, string description, string date, 
        string time, string street, string city, string state, string zip, string weather) :
        base(title, description, date, time, street, city, state, zip) {

        _weatherForecast = weather;
    }

    public void DisplayFullDetails() {
        Console.WriteLine($"A {GetType()} Event");
        DisplayStandardDetails();
        Console.WriteLine($"The weather forcaste is {_weatherForecast}");
    }
}