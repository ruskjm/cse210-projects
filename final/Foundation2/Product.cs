public class Product {
    private string _productName;

    private string _productId;

    private double _productPrice;

    private int _productQuantity;

    public Product(string productName, string productId, double productPrice, 
        int productQuantity) {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public string GetProductName() {
        return _productName;
    }

    public string GetProductId() {
        return _productId;
    }

    public double GetProductPrice() {
        return _productPrice;
    }

    public int GetProductQuantity() {
        return _productQuantity;
    }

    public double CalculatePrice() {
        return _productPrice * _productQuantity;
    }
}