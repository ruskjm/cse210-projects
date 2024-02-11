
// Product class
public class Product {

    // Product name string
    private string _productName;

    // Product ID string
    private string _productId;

    // Product price double
    private double _productPrice;

    // Product quantity int
    private int _productQuantity;

    // Product constructor
    public Product(string productName, string productId, double productPrice, 
        int productQuantity) {

        // Set values
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    // Product name getter
    public string GetProductName() {
        return _productName;
    }

    // Product ID getter
    public string GetProductId() {
        return _productId;
    }

    // Product price getter
    public double GetProductPrice() {
        return _productPrice;
    }

    // Product quantity getter
    public int GetProductQuantity() {
        return _productQuantity;
    }

    // Method to calculate the price and a product
    public double CalculatePrice() {
        return _productPrice * _productQuantity;
    }
}