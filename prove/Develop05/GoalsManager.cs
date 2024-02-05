public class GoalsManager {

    private List<string> _goals = new List<string>();
     
    private int _score = 0;

    public GoalsManager() {}

    public void ShowMenu() {
        Console.WriteLine($"You have {_score} points.");

         Console.WriteLine();

        //Menu options
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public string GetMenuSelection() {
        // Read in user input
        string input = Console.ReadLine();

        // Return user input
        return input;
    }

    public void DisplayGoalsOptions() {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Select a choice from the menu: ");
    }

    public (string goal, string description, string points) DisplayGoalsQuestions() {
        Console.Write("What is the name of the goal? ");
        string goal = GetMenuSelection();
        Console.Write("What is a short description of the goal? ");
        string description = GetMenuSelection();
        Console.Write("How many points for the goal? ");
        string points = GetMenuSelection();

        string allText = goal + "|" + description + "|" + points;

        _goals.Add(allText);

        return (goal, description, points);

    }

    public void CreateGoal() {
        DisplayGoalsOptions();

        string input = GetMenuSelection();

        (string goal, string description, string points) = DisplayGoalsQuestions();

        if (input == "1") {
            SimpleGoals simpleGoal = new SimpleGoals(goal, description, points);

           
        }
        else if (input == "2") {
        }
        else if (input == "3") {
        }


    }

    public void ListGoals() {
        // foreach (string g in _goals) {
        //     Console.WriteLine(g);
        // }
        SimpleGoals simpleGoal = new SimpleGoals();
        Console.WriteLine(simpleGoal.GetStringRepresentation());

    }
        

    

    public void SaveGoals() {

    }

    public void LoadGoals() {

    }

    public void RecordEvent() {

    }



}