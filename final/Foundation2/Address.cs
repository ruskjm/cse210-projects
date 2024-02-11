// Address class
public class Address {

    // Street address string
    private string _street;

    // City string
    private string _city;

    // State or Province string
    private string _stateOrProvince;

    // Zip Code String
    private string _zipCode;

    // Country string
    private string _country;

    // Empty Address constructor
    public Address() {}

    // Address constructor
    public Address(string street, string city, string stateOrProvince, 
        string zipCode, string country) {

            // Set values
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _zipCode = zipCode;
            _country = country;
    }

    // USA country method
    public bool InUsa() {
        return _country.ToLower() == "usa";
    }

    // Displays the customer address
    public void DisplayAddress() {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_stateOrProvince} {_zipCode}");
        Console.WriteLine($"{_country}");
    }
}