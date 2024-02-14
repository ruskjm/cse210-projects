// Address class 
public class Address {

    // Street address string
    private string _street;

    // City string
    private string _city;

    // State string
    private string _state;

    // Zip Code String
    private string _zipCode;

    // Address constructor
    public Address(string street, string city, string state, string zipCode) {

            // Set values
            _street = street;
            _city = city;
            _state = state;
            _zipCode = zipCode;
    }

    // Method to display the address
    public void DisplayAddress() {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_state} {_zipCode}");
    }

}