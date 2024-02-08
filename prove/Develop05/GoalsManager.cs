// GoalsManager class to process the requests from the user
public class GoalsManager {

    // // Create new List of goals
    private List<Goals> _goals = new List<Goals>();
     
    // Declare and initialze variable to track the total points
    private int _totalPoints = 0;

    // Declare and initialze variable to track how many times to complete a goal
    private int _target = 0;

    // Declare and initialze variable for the bonus amount
    private int _bonus = 0;

    
    //Set the default path where to save the file
    //Found an example on how to do this at
    //https://learn.microsoft.com/en-us/dotnet/api/system.environment.getfolderpath?view=net-8.0
    string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    // Method to read in option entered by the user
    public string GetSelection() {
        // Read in user input
        string input = Console.ReadLine();

        // Return user input
        return input;
    }

    // Method to display total points
    public void DisplayTotalPoints() {

        // Displays the total points
        Console.WriteLine($"You have {_totalPoints} total points.");
    }

    //Show menu options method
    public void ShowMenu() {

        //Menu options
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals to File");
        Console.WriteLine("\t4. Load Goals from File");
        Console.WriteLine("\t5. Record Completed Goal");
        Console.WriteLine("\t6. Remove a Goal");
        Console.WriteLine("\t7. Delete the Goal File");
        Console.WriteLine("\t8. Reset a Goal");
        Console.WriteLine("\t9. Quit the Program");
        Console.Write("Select a choice from the menu: ");
    }

    //Show goal options to select method
    public void DisplayGoalsOptions() {

        // Goal options
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Select a choice from the menu: ");
    }

    // Method to create a goal
    public void CreateGoal(string goalType) {

        // User question
        Console.Write("What is the name of the goal? ");

        // Call the GetSelection to read in the user input
        string name = GetSelection();
        
        // User question
        Console.Write("What is a short description of the goal? ");

        // Call the GetSelection to read in the user input
        string description = GetSelection();

        // User question        
        Console.Write("How many points earned for completing the goal? ");

        // Call the GetSelection to read in the user input
        string points = GetSelection();

        // If user selects option 3 code
        if (goalType == "3") {

            // User question
            Console.Write("What is the bonus points for accomplishing the goal? ");
                    
            // Call the GetSelection to read in the user input
            string targetInput = GetSelection();

            // Convert to an int
            _target = int.Parse(targetInput);

            // User question
            Console.Write("How many times does this goal need to be completed to get bonus points? ");
                    
            // Call the GetSelection to read in the user input
            string bonusString = GetSelection();

            // Convert to an int
            _bonus = int.Parse(bonusString);
        }

        // Create goal object and set to null
        Goals goal = null;

        // If user selects 1
        if (goalType == "1") {

            // Call the SimpleGoals class and pass variables to constructor
            goal = new SimpleGoals(name, description, points);
        }

        // If user selects 2
        else if (goalType == "2") {

            // Call the EternalGoals class and pass variables to constructor
            goal = new EternalGoals(name, description, points);
        }

        // If user selects 3
        else if (goalType == "3"){

            // Call the ChecklistGoals class and pass variables to constructor
            goal = new ChecklistGoals(name, description, points, _target, _bonus);
        }            

        // If the goal object is not null    
        if (goal != null) {

            // Add to goal list
            _goals.Add(goal);
        }

        // Blank line
        Console.WriteLine();
    }

    // Method to list the goals
    public void ListGoals() {

        // Create goal counter to display a count when goals are listed
        int goalCounter = 1;

        // Blank line
        Console.WriteLine();

        // Message to display
        Console.WriteLine("Current Goals");

        // Iterate through the goals list
        foreach(Goals goal in _goals) {

            // Call the GetStringRepresentation method to get the message to display
            string display = goal.GetStringRepresentation();

            // Display the counter and message
            Console.WriteLine($"{goalCounter}. {display}");

            // Increment the counter
            goalCounter++;
        }

        // Blank line
        Console.WriteLine();
    }
    
    // Method to save the goals to a file
    public void SaveGoals() {

        // User question
        Console.Write("Enter file name to save goals to: ");

        // Call the GetSelection to read in the user input
        string fileName = GetSelection();

        // Set the file path to the default path and file name
        string fullPath = Path.Combine(defaultPath, fileName);

        // Blank line
        Console.WriteLine();

        //Open file stream for writing and overwrites the file
        using (StreamWriter writer = new StreamWriter(fullPath, false)) {

            // Writes the total points on the first line
            writer.WriteLine(_totalPoints);

            // Iterate through the goals list
            foreach(Goals goal in _goals) {

                // If the class is SimpleGoals
                if (goal is SimpleGoals sg) {

                    // Write to file adds the class name and isComplete flags
                    writer.WriteLine($"{goal}|{goal.Name}|{goal.Description}|{goal.Points}|{sg.IsComplete()}");
                }

                // If the class is EternalGoals
                else if (goal is EternalGoals) {

                    // Write to file adds the class name
                    writer.WriteLine($"{goal}|{goal.Name}|{goal.Description}|{goal.Points}");
                }

                // If the class is ChecklistGoals
                else if (goal is ChecklistGoals cg) {

                    // Write to file adds the class name and amount completed
                    writer.WriteLine($"{goal}|{goal.Name}|{goal.Description}|{goal.Points}|{cg.ChecklistTarget}|{cg.ChecklistBonus}|{cg.AmountCompleted}");
                }  
            }
        }

        // Blank line
        Console.WriteLine();
        
        // Display the where the file was saved
        Console.WriteLine("Goals saved to " + fullPath);

        // Blank line   
        Console.WriteLine();
    }

    // Method to load goals from a file
    public void LoadGoals() {
        
        //Clear existing goals list before loading
        _goals.Clear();

        // Blank line
        Console.WriteLine();
        
        // User question
        Console.Write("Enter file name to load goals from: ");
                
        // Call the GetSelection to read in the user input
        string fileName = GetSelection();

        // Set the file path to the default path and file name
        string fullPath = Path.Combine(defaultPath, fileName);

        //Open file stream for writing
        using (StreamReader reader = new StreamReader(fullPath)) {

            // Reads the first line to get the total points
            string firstLine = reader.ReadLine();

            // If first line is not null
            if (firstLine != null) {

            // Assigns the first line to points as an int
            int points = int.Parse(firstLine);

            // Assigns points to _totalPoints
            _totalPoints = points;
            }
            
            string line;
            while ((line = reader.ReadLine()) != null) {

                Goals goal = null;

                // Split line on delimiter of |
                string[] parts = line.Split('|');

                // Grabs the class name from the first iteration
                string classType = parts[0];

                // classType is SimpleGoals
                if(classType == "SimpleGoals") {

                    // Saves off second iteration to name
                    string name = parts[1];

                    // Saves off third iteration to description
                    string description = parts[2];

                    // Saves off fourth iteration to points
                    string points = parts[3];

                    // Saves off fifth iteration to isCompleteString
                    string isCompleteString = parts[4];

                    // Converts to boolean
                    bool isComplete = bool.Parse(isCompleteString);

                    // Calls SimpleGoals method constructor with below values and returns to goal object
                    goal = new SimpleGoals(name, description, points, isComplete);
                } 

                // classType is EternalGoals
                else if(classType == "EternalGoals") {

                    // Saves off second iteration to name
                    string name = parts[1];

                    // Saves off third iteration to description
                    string description = parts[2];

                    // Saves off fourth iteration to points
                    string points = parts[3];

                    // Calls EternalGoals method constructor with below values and returns to goal object
                    goal = new EternalGoals(name, description, points);
                }

                // classType is ChecklistGoals
                else if (classType == "ChecklistGoals") {

                    // Saves off second iteration to name
                    string name = parts[1];

                    // Saves off third iteration to description
                    string description = parts[2];

                    // Saves off fourth iteration to points
                    string points = parts[3];

                    // Saves off fifth iteration to targetNumber as int
                    int targetNumber = int.Parse(parts[4]);

                    // Saves off sixth iteration to bonusNumber as int
                    int bonusNumber = int.Parse(parts[5]);

                    // Saves off seventh iteration to completedNumber as int
                    int completedNumber = int.Parse(parts[6]);

                    // Calls ChecklistGoals method constructor with below values and returns to goal object
                    goal = new ChecklistGoals(name, description, points, targetNumber, bonusNumber, completedNumber);
                }

                // If the goal object is not null
                if (goal != null) {

                    // Add to goal list
                    _goals.Add(goal);
                }
            }
                // Blank line
                Console.WriteLine();

                // Display location file loaded from
                Console.WriteLine("Goals loaded from " + fullPath);

                // Blank line
                Console.WriteLine();
        }
    }

    // Method to record goal completion
    public void RecordGoal() {

        // Call the ListGoals method to list the goals
        ListGoals();
                
        // User question
        Console.Write("What goal number would you like to marked completed? ");

        // Call the GetSelection in the GoalsManager class to read in the user input
        int selectedIndex = int.Parse(GetSelection());

        Goals selectedGoal = _goals[selectedIndex-1];

        // Blank line
        Console.WriteLine();            

        // If class is ChecklistGoals
        if (selectedGoal is ChecklistGoals cg) {

            // Calls IncrementCount method from ChecklistGoals to 
            // increment the counter for the goal completion number
            cg.IncrementCount();

            // Calls the RecordEvent() from the class object
            selectedGoal.RecordEvent();

            // Calls the GetBonus() from the class object
            _bonus = cg.GetBonus();

        // If not ChecklistGoals class 
        } else {

            // Calls the RecordEvent() from the class object
            selectedGoal.RecordEvent();  
        }                        

        // Totals total points selectedGoal points, _totalPoints and _bonus
        _totalPoints = int.Parse(selectedGoal.Points) + _totalPoints + _bonus;

        // Gets the current points from selectedGoal points
        int currentPoints = int.Parse(selectedGoal.Points) + _bonus;

        // Display points earned
        Console.WriteLine($"Congratulations! You have earned {currentPoints} points!" );
                
        // Blank line
        Console.WriteLine();
    }

    // Method to remove goal 
    public void RemoveGoal() {

        // Call the ListGoals method to list the goals
        ListGoals();

        // User question
        Console.Write("What goal number would you like to remove? ");

        // Get the goal to remove inputed by user as int
        int goalIndex = int.Parse(GetSelection());

        // Save off goal object before delete
        Goals goalToRemove = _goals[goalIndex - 1];

        // Save off as goal object as a string
        string goalAsString = $"{goalToRemove.Name} {goalToRemove.Description}";

        // Remove selected goal
        _goals.RemoveAt(goalIndex - 1);

        // Blank line
        Console.WriteLine();

        // Display goal remove
        Console.WriteLine($"Goal {goalAsString} successfully remove.");

        // Blank line
        Console.WriteLine();
    }
}