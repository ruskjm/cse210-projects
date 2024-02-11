public class Customer {

    private string _customerName;

    private Address _customerAddress;

    public Customer(string customerName, Address address) {
        _customerName = customerName;
        _customerAddress = address;
    }

    public string GetCustomerName() {
        return _customerName;
    }

    public Address GetCustomerAddress() {
        return _customerAddress;
    }

}