/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Final
Program 2: Encapsulation with Online Ordering
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Click and Ship");
        Console.WriteLine();
        Order c1 = new Order("Carolyn Brown", "123 Main Street", "Avocadodale", "MI", "9587", "USA");
        c1.AddProduct("Effortless Pans", "EP589", 18.99, 2);
        c1.AddProduct("Fruit Saver", "FS879", 5.89, 3);
        c1.AddProduct("Tie Dye Socks", "TDS55", 6.79, 1);
        c1.AddProduct("Glow-in-the-Dark Paint Set", "GDPS8", 15.78, 1);
        c1.PrintPackingLabel();
        Console.WriteLine($"Invoice Total: ${c1.CalculateTotalPrice()}");
        Console.WriteLine();
        c1.PrintShippingLabel();
    }
}