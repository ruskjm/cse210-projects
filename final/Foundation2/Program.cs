/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Final
Program 2: Encapsulation with Online Ordering
*/

// Main application class
class Program {
    // Entry point for application
    static void Main(string[] args) {

        // Create total as double
        double total;

        // Clear the console
        Console.Clear();

        // Create first object, set values and display
        Console.WriteLine("\x1B[31;1mWelcome to Buy Cheap Clothes from Us\x1B[0m");
        Console.WriteLine();
        // Add address
        Order c1 = new Order("Joe Blow", "123 Main Street", "Sacramento", "CA", "95829", "USA");
        // Add products to list
        c1.AddProduct("Socks", "SOC25", 6.99, 6);
        c1.AddProduct("T-Shirts", "TS258", 8.89, 5);
        c1.AddProduct("Shorts", "SH1487", 10.99, 2);
        c1.AddProduct("Pants", "PN", 19.78, 1);
        // Display output
        c1.PrintPackingLabel();  
        total = c1.CalculateTotalPrice();
        Console.WriteLine($"Shipping cost is: ${c1.GetShippingCost()}");
        Console.WriteLine($"Invoice Total: ${total}");
        Console.WriteLine();
        c1.PrintShippingLabel();

        // Create second object, set values and display
        Console.WriteLine("\x1B[31;1mWelcome to Health Food Store\x1B[0m");
        Console.WriteLine();
        // Add address
        Order c2 = new Order("Cole Slaw", "123 East West St", "Rexburg", "ID", "83440", "USA");
        // Add products to list
        c2.AddProduct("Protein Shakes", "PRO89", 20.99, 1);
        c2.AddProduct("Cale", "GROSS99", 1.89, 3);
        c2.AddProduct("Vitamins", "WASTE12", 29.99, 1);
        c2.AddProduct("Water", "W34", .99, 6);
        // Display output
        c2.PrintPackingLabel();  
        total = c2.CalculateTotalPrice();
        Console.WriteLine($"Shipping cost is: ${c2.GetShippingCost()}");
        Console.WriteLine($"Invoice Total: ${total}");
        Console.WriteLine();
        c2.PrintShippingLabel();

        // Create third object, set values and display
        Console.WriteLine("\x1B[31;1mWelcome to Canada Store\x1B[0m");
        Console.WriteLine();
        // Add address
        Order c3 = new Order("Chip Munk", "123 Canada Rd", "Edmonton", "Alberta", "T0A", "Canada");
        // Add products to list
        c3.AddProduct("Tuna", "TU14", 1.99, 6);
        c3.AddProduct("Banana", "BAN45", .89, 12);
        c3.AddProduct("Oatmeal", "OATS12", 2.99, 3);
        c3.AddProduct("Coca-Cola", "COLO88", 7.99, 2);
        // Display output
        c3.PrintPackingLabel();  
        total = c3.CalculateTotalPrice();
        Console.WriteLine($"Shipping cost is: ${c3.GetShippingCost()}");
        Console.WriteLine($"Invoice Total: ${total}");
        Console.WriteLine();
        c3.PrintShippingLabel();
    }
}