// Customer class
public class Customer {

    // Customer name string
    private string _customerName;

    // The address from class instance 
    private Address _customerAddress;

    // Customer constructor
    public Customer(string customerName, Address address) {

        // Set values
        _customerName = customerName;
        _customerAddress = address;
    }

    // Customer name getter
    public string GetCustomerName() {
        return _customerName;
    }

    // Customer address getter
    public Address GetCustomerAddress() {
        return _customerAddress;
    }

}