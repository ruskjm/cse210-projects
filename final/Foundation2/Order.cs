public class Order {

    private List<Product> _productList = new List<Product>();

    private Customer _customer; 

    public Order(string customerName, string street, string city, string stateOrProvince, 
        string zipCode, string country) {
            Address address = new Address(street, city, stateOrProvince, 
                zipCode, country);
            _customer = new Customer(customerName, address);       
    }

    public void AddProduct(string name, string id, double price, int quantity) {
        Product product = new Product(name, id, price, quantity);
        _productList.Add(product);
    }

    public double CalculateShipping() {
        if (_customer.GetCustomerAddress().InUsa()) {
            return 5;
        }
        else {
            return 35;
        }
    }

    public double CalculateTotalPrice() {
        double totalPrice = CalculateShipping();
        foreach(Product product in _productList) {
            totalPrice += product.CalculatePrice();
        }

        return Math.Round(totalPrice, 2);
    }

    public void PrintShippingLabel() {
        Address address = _customer.GetCustomerAddress();

        Console.WriteLine("Ship To:");
        Console.WriteLine(_customer.GetCustomerName());
        address.DisplayAddress();
        Console.WriteLine(); 
    }

    public void PrintPackingLabel() {
        Console.WriteLine("Packing List:");

        foreach(Product product in _productList) {
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