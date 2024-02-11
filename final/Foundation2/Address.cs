public class Address {

    private string _street;

    private string _city;

    private string _stateOrProvince;

    private string _zipCode;

    private string _country;

    public Address() {}

    public Address(string street, string city, string stateOrProvince, 
        string zipCode, string country) {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _zipCode = zipCode;
            _country = country;
    }

    public bool InUsa() {
        return _country.ToLower() == "usa";
    }

    public void DisplayAddress() {
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_stateOrProvince} {_zipCode}");
        Console.WriteLine($"{_country}");
    }
}