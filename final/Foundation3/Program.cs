/*
Developer: Jason Rusk
CSE 210: Programming with Classes
Final Project
Program 3: Inheritance with Event Planning
*/

class Program {
    static void Main(string[] args) {

        Console.Clear();

        Console.WriteLine("\x1B[34;1mPremier Parties and Event Planning\x1B[0m");

        Console.WriteLine("---------------------------------------------------------------------");

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

        Lecture lecture = new Lecture(
            title, description, date, time, street, city, state, zip, name, capacity);

        Console.WriteLine("\x1B[31;1mShort Description\x1B[0m");

        lecture.DisplayShortDescription();

        // Blank Line
        Console.WriteLine();

        Console.WriteLine("\x1B[31;1mStandard Details\x1B[0m");

        lecture.DisplayStandardDetails();
        // Blank Line
        Console.WriteLine();
   
        Console.WriteLine("\x1B[31;1mFull Details\x1B[0m");

        lecture.DisplayFullDetails();

        Console.WriteLine("---------------------------------------------------------------------");

        Thread.Sleep(5000);

        // Blank Line
        Console.WriteLine();

        Console.WriteLine("\x1B[34;1mPremier Parties and Event Planning\x1B[0m");

        Console.WriteLine("---------------------------------------------------------------------");

        title = "Music Festival Concert"; 
        description = "Annual Coachella music festival with performances by the top artists and bands.";
        date = "04/15/2023";
        time = "3:00 PM";
        street = "81-800 Avenue";
        city = "Indio";
        state = "CA";
        zip = "92201";
        string weather = "Sunny and clear, high of 85°F";

        Outdoor outdoor = new Outdoor(
            title, description, date, time, street, city, state, zip, weather);

        Console.WriteLine("\x1B[31;1mShort Description\x1B[0m");

        outdoor.DisplayShortDescription();

        // Blank Line
        Console.WriteLine();

        Console.WriteLine("\x1B[31;1mStandard Details\x1B[0m");

        outdoor.DisplayStandardDetails();

        // Blank Line
        Console.WriteLine();
   
        Console.WriteLine("\x1B[31;1mFull Details\x1B[0m");

        outdoor.DisplayFullDetails(); 

        Console.WriteLine("---------------------------------------------------------------------");

        Thread.Sleep(5000);

        // Blank Line
        Console.WriteLine();

        Console.WriteLine("\x1B[34;1mPremier Parties and Event Planning\x1B[0m");
  
        Console.WriteLine("---------------------------------------------------------------------");

        title = "Company Annual Reception"; 
        description = "Formal annual reception to celebrate the company's success over the past year.";
        date = "12/31/2023";
        time = "7:00 PM";
        street = "123 Main St";
        city = "Springfield";
        state = "IL";
        zip = "62701";
        string email = "reception@acmecorp.com";

        Reception reception = new Reception(
            title, description, date, time, street, city, state, zip, email);

        Console.WriteLine("\x1B[31;1mShort Description\x1B[0m");

        reception.DisplayShortDescription();

        // Blank Line
        Console.WriteLine();

        Console.WriteLine("\x1B[31;1mStandard Details\x1B[0m");

        reception.DisplayStandardDetails();

        // Blank Line
        Console.WriteLine();
   
        Console.WriteLine("\x1B[31;1mFull Details\x1B[0m");

        reception.DisplayFullDetails(); 

        Console.WriteLine("---------------------------------------------------------------------");

        // Blank Line
        Console.WriteLine();

        
    }
}