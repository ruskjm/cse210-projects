/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Final Project
Program 3: Inheritance with Event Planning
*/

// Main application class
class Program {

    // Entry point for application
    static void Main(string[] args) {

        // Clear the console
        Console.Clear();

        // Display company name
        Console.WriteLine("\x1B[34;1mPremier Parties and Event Planning\x1B[0m");

        // Display dashes for readability
        Console.WriteLine("---------------------------------------------------------------------");

        // Set strings to pass to constructor
        string title = "Machine Learning Fundamentals";
        string description = "Introductory ML lecture covering basic concepts and algorithms"; 
        string date = "03/18/2023";
        string time = "10:00 AM";
        string street = "101 CS Dept"; 
        string city = "Springfield";
        string state = "IL"; 
        string zip = "62701";
        string name = "Dr. John Smith";
        string capacity = "150";

        // New object and pass values to constructor
        Lecture lecture = new Lecture(
            title, description, date, time, street, city, state, zip, name, capacity);

        // Display heading
        Console.WriteLine("\x1B[31;1mShort Description\x1B[0m");

        // Call method to display event info
        lecture.DisplayShortDescription();

        // Blank Line
        Console.WriteLine();

        // Display heading
        Console.WriteLine("\x1B[31;1mStandard Details\x1B[0m");

        // Call method to display event info
        lecture.DisplayStandardDetails();

        // Blank Line
        Console.WriteLine();
   
        // Display heading
        Console.WriteLine("\x1B[31;1mFull Details\x1B[0m");

        // Call method to display event info
        lecture.DisplayFullDetails();

        // Display dashes for readability
        Console.WriteLine("---------------------------------------------------------------------");

        // Sleep for 5 seconds
        Thread.Sleep(5000);

        // Blank Line
        Console.WriteLine();

        // Display company name
        Console.WriteLine("\x1B[34;1mPremier Parties and Event Planning\x1B[0m");

        // Display dashes for readability
        Console.WriteLine("---------------------------------------------------------------------");

        // Set strings to pass to constructor
        title = "Music Festival Concert"; 
        description = "Annual Coachella music festival with performances by the top artists and bands.";
        date = "04/15/2023";
        time = "3:00 PM";
        street = "81-800 Avenue";
        city = "Indio";
        state = "CA";
        zip = "92201";
        string weather = "Sunny and clear, high of 85°F";

        // New object and pass values to constructor
        Outdoor outdoor = new Outdoor(
            title, description, date, time, street, city, state, zip, weather);

        // Display heading
        Console.WriteLine("\x1B[31;1mShort Description\x1B[0m");

        // Call method to display event info
        outdoor.DisplayShortDescription();

        // Blank Line
        Console.WriteLine();

        // Display heading
        Console.WriteLine("\x1B[31;1mStandard Details\x1B[0m");

        // Call method to display event info
        outdoor.DisplayStandardDetails();

        // Blank Line
        Console.WriteLine();
   
        // Display heading
        Console.WriteLine("\x1B[31;1mFull Details\x1B[0m");

        // Call method to display event info
        outdoor.DisplayFullDetails(); 

        // Display dashes for readability
        Console.WriteLine("---------------------------------------------------------------------");

        // Sleep for 5 seconds
        Thread.Sleep(5000);

        // Blank Line
        Console.WriteLine();

        // Display company name
        Console.WriteLine("\x1B[34;1mPremier Parties and Event Planning\x1B[0m");
  
        // Display dashes for readability
        Console.WriteLine("---------------------------------------------------------------------");

        // Set strings to pass to constructor
        title = "Company Annual Reception"; 
        description = "Formal annual reception to celebrate the company's success over the past year.";
        date = "12/31/2023";
        time = "7:00 PM";
        street = "123 Main St";
        city = "Springfield";
        state = "IL";
        zip = "62701";
        string email = "reception@acmecorp.com";

        // New object and pass values to constructor
        Reception reception = new Reception(
            title, description, date, time, street, city, state, zip, email);

        // Display heading
        Console.WriteLine("\x1B[31;1mShort Description\x1B[0m");

        // Call method to display event info
        reception.DisplayShortDescription();

        // Blank Line
        Console.WriteLine();

        // Display heading
        Console.WriteLine("\x1B[31;1mStandard Details\x1B[0m");

        // Call method to display event info
        reception.DisplayStandardDetails();

        // Blank Line
        Console.WriteLine();

        // Display heading
        Console.WriteLine("\x1B[31;1mFull Details\x1B[0m");

        // Call method to display event info
        reception.DisplayFullDetails(); 

        // Display dashes for readability
        Console.WriteLine("---------------------------------------------------------------------");

        // Blank Line
        Console.WriteLine();       
    }
}