class Program
{
    static void Main(string[] args)
    {

        int totalPoints = 0;

        // Variable used to store user input for menu selection
        string input = "";

        string goalType;

        int target = 0;

        int bonus = 0;

        // Create list to store goals
        List<Goals> goals = new List<Goals>();

        //Set the default path where to save the file
        //Found an example on how to do this at
        //https://learn.microsoft.com/en-us/dotnet/api/system.environment.getfolderpath?view=net-8.0
        string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // While loop that will continue until user enters 4
        while(input != "6") {

            Console.WriteLine($"You have {totalPoints} total points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();

            if (input == "1") {  
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("\t1. Simple Goal");
                Console.WriteLine("\t2. Eternal Goal");
                Console.WriteLine("\t3. Checklist Goal");
                Console.Write("Select a choice from the menu: ");

                string[] validChoices = {"1", "2", "3"};

                goalType = Console.ReadLine();

                while (!validChoices.Contains(goalType)) {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    Console.Write("Select a choice from the menu: ");
                    goalType = Console.ReadLine();
                }

                Console.Write("What is the name of the goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of the goal? ");
                string description = Console.ReadLine();

                Console.Write("How many points for the goal? ");
                string points = Console.ReadLine();

                if (goalType == "3") {
                    Console.Write("How many times does this goal need to be completed to get bonus? ");
                    string targetInput = Console.ReadLine();
                    target = int.Parse(targetInput);

                    Console.Write("What is the bonus for accomplishing the goal? ");
                    string bonusInput = Console.ReadLine();
                    bonus = int.Parse(bonusInput);
                }

                Goals goal = null;

                if (goalType == "1") {
                    goal = new SimpleGoals(name, description, points);
                }
                else if (goalType == "2") {
                    goal = new EternalGoals(name, description, points);
                }
                else if (goalType == "3"){
                    goal = new ChecklistGoals(name, description, points, target, bonus);
                }            
                
                if (goal != null) {
                    goals.Add(goal);
                }
            }

            else if (input == "2") {
                int goalCounter = 1;

                foreach(Goals goal in goals) {
                    string display = goal.GetStringRepresentation();
                    Console.WriteLine(goal);
                    Console.WriteLine($"{goalCounter}. {display}");
                    goalCounter++;
                }
                Console.WriteLine();
                
            }

            else if (input == "3") {
                Console.Write("Enter file name to save goals to: ");
                string fileName = Console.ReadLine();

                string fullPath = Path.Combine(defaultPath, fileName);

                using (StreamWriter writer = new StreamWriter(fullPath, false)) {
                    writer.WriteLine(totalPoints);
                    foreach(Goals goal in goals) {
                        if (goal is SimpleGoals sg) {
                            writer.WriteLine($"{goal}|{goal.Name}|{goal.Description}|{goal.Points}|{sg.IsComplete()}");
                        }
                        else if (goal is EternalGoals) {
                            writer.WriteLine($"{goal}|{goal.Name}|{goal.Description}|{goal.Points}");
                        }
                        else if (goal is ChecklistGoals cg) {
                        writer.WriteLine($"{goal}|{goal.Name}|{goal.Description}|{goal.Points}|{cg.ChecklistTarget}|{cg.ChecklistBonus}|{cg.AmountCompleted}");
                        }  
                    }
                }

                Console.WriteLine("Goals saved to " + fullPath);

            }
            else if (input == "4") {
                //Clear existing goals list before loading
                goals.Clear();

                Console.Write("Enter file name to load goals from: ");
                string fileName = Console.ReadLine();

                string fullPath = Path.Combine(defaultPath, fileName);

                // Open file and read lines
                using (StreamReader reader = new StreamReader(fullPath)) {
                string firstLine = reader.ReadLine();
                if (firstLine != null) {
                    int points = int.Parse(firstLine);
                    totalPoints = points;
                    Console.WriteLine(points);
                }
                
                string line;
                    while ((line = reader.ReadLine()) != null) {

                        Goals goal = null;

                        // Split line on delimiter
                        string[] parts = line.Split('|');

                        string classType = parts[0];

                        if(classType == "SimpleGoals") {
                            string name = parts[1];
                            string description = parts[2];
                            string points = parts[3];
                            string isCompleteString = parts[4];
                            bool isComplete = bool.Parse(isCompleteString);
                            goal = new SimpleGoals(name, description, points, isComplete);
                        } 
                        else if(classType == "EternalGoals") {
                            string name = parts[1];
                            string description = parts[2];
                            string points = parts[3];
                            goal = new EternalGoals(name, description, points);
                        }
                        else if (classType == "ChecklistGoals"){
                            string name = parts[1];
                            string description = parts[2];
                            string points = parts[3];
                            int targetNumber = int.Parse(parts[4]);
                            int bonusNumber = int.Parse(parts[5]);
                            int completedNumber = int.Parse(parts[6]);
                            goal = new ChecklistGoals(name, description, points, targetNumber, bonusNumber, completedNumber);
                        }

                       // Add to list
                        if (goal != null) {
                            goals.Add(goal);
                            Console.WriteLine(goal);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Goals laoded from " + fullPath);
                    Console.WriteLine();
                }
            }
            else if (input == "5") {
                int goalCounter = 1; 

                foreach(Goals goal in goals) {
                    string display = goal.GetStringRepresentation();
                    Console.WriteLine(goal);
                    Console.WriteLine($"{goalCounter}. {display}");
                    goalCounter++;
                }

                Console.Write("What goal would you like to accomplish? ");
                int selectedIndex = int.Parse(Console.ReadLine());

                Goals selectedGoal = goals[selectedIndex-1];

                Console.WriteLine();            

                if (selectedGoal is ChecklistGoals cg) {
                    cg.IncrementCount();
                    //Console.WriteLine($"Counter = {cg.IncrementCount}");
                    selectedGoal.RecordEvent();
                    bonus = cg.GetBonus();
                    Console.WriteLine($"Bonus = {bonus}");
                } else {
                    selectedGoal.RecordEvent();  
                }                        

                totalPoints = int.Parse(selectedGoal.Points) + totalPoints + bonus;

                //selectedGoal.IsComplete();

                int currentPoints = int.Parse(selectedGoal.Points) + bonus;

                Console.WriteLine($"Congratulations! You have earned {currentPoints} points!" );
                Console.WriteLine();
                
            }
            // Message to display if user enters to quit
            else if (input == "6") {
                // Blank Line
                Console.WriteLine();

                // Message to display
                Console.WriteLine("Thank you using Goal Setting Program");
            }
            // Message to display if valid option not entered
            else {
                Console.WriteLine("Not a valid entry, try again!");
            }

        }
        
    }
}