// Abstract class of goals
public abstract class Goals {
    
    // Protected string for goal name
    private string _goalName;

    // Protected string for goal description
    private string _description;

    // Protected string for goal points
    private string _points;
  
    // Blank constructor
    public Goals(){}

    // Constructor to initialize Goals properties
    public Goals(string goalName, string description, string points) {
        _goalName = goalName; 
        _description = description;
        _points = points;
    }

    // Getter for goal name
    public string Name {
        get { return _goalName; }
    }

    // Getter for goal description
    public string Description {
        get { return _description; }
    }

    // Getter for goal points
    public string Points {
        get { return _points; }
    }

    // Declare RecordEvent method that must be implemented by subclasses  
    public abstract void RecordEvent();

    // Declare IsComplete method that must be implemented by subclasses  
    public abstract bool IsComplete();

    // Declare method to return string representation of goal details
    public abstract string GetStringRepresentation();
}