// Order class
public class Order {

    // New of products list object from Product class
    private List<Product> _productList = new List<Product>();

    // Customer object from Customer class
    private Customer _customer; 

    // Shipping cost double
    private double _shippingCost;

    // Order constructor
    public Order(string customerName, string street, string city, string stateOrProvince, 
        string zipCode, string country) {

            // New address object and set with Address constructor
            Address address = new Address(street, city, stateOrProvince, 
                zipCode, country);

            // Set the customer object with customer name and address
            _customer = new Customer(customerName, address);       
    }

    // Add the product information to the product list
    public void AddProduct(string name, string id, double price, int quantity) {

        // New product object and set with Product constructor
        Product product = new Product(name, id, price, quantity);
        
        // Add to the product list
        _productList.Add(product);
    }

    // Calculate the shipping amount based on customer location
    public double CalculateShipping() {

        // If USA customer ship cost is $5 else it's $35
        if (_customer.GetCustomerAddress().InUsa()) {
            return 5;
        }
        else {
            return 35;
        }
    }

    // Calculate the total price of the invoice
    public double CalculateTotalPrice() {

        // Set the shipping cost
        _shippingCost = CalculateShipping();

        // Create total price variable and set it to shipping cost
        double totalPrice = _shippingCost;

        // Loop thru the products list and calcualte the price for each product
        foreach(Product product in _productList) {
            totalPrice += product.CalculatePrice();
        }

        // Round to 2 decimal places
        return Math.Round(totalPrice, 2);
    }

    // Shipping cost getter
    public double GetShippingCost() {
        return _shippingCost;
    }

    // Print the shipping address label
    public void PrintShippingLabel() {
        Address address = _customer.GetCustomerAddress();

        Console.WriteLine("Ship To:");

        // Get customer name and display it
        Console.WriteLine(_customer.GetCustomerName());

        // Call the DisplayAddress method and display the address
        address.DisplayAddress();

        // Blank Line
        Console.WriteLine(); 
    }

    // Print the packing label
    public void PrintPackingLabel() {
        Console.WriteLine("Packing List:");

        // Loop thru each product in the list from Product class and 
        // display the results for each product
        foreach(Product product in _productList) {

            // Display product info for each product from product class
            Console.WriteLine($"Product ID: {product.GetProductId()}"); 
            Console.WriteLine($"Product Name: {product.GetProductName()}");
            Console.WriteLine($"Product Quantity: {product.GetProductQuantity()}");
            Console.WriteLine($"Product Price: ${product.GetProductPrice()}");
            Console.WriteLine($"Total Price: ${Math.Round(product.GetProductPrice() * product.GetProductQuantity(), 2)}");
            
            // Blank Line
            Console.WriteLine();
        }
    } 
}