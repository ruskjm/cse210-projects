// SimpleGoals class to process simple goals
// that inherits from Goals
public class SimpleGoals : Goals {

    // Private boolean to track when goal is completed
    private bool _isComplete;

    // Constructor to initialize SimpleGoals properties
    // Uses goalName, description, points from the base class Goals
    public SimpleGoals(string goalName, string description, string points): 
        base (goalName, description, points) {

          // set variables  
        _isComplete = false;
    }

    // Overridden constructor to initialize SimpleGoals properties
    public SimpleGoals(string goalName, string description, string points, bool isComplete): 
        base (goalName, description, points) {
            _isComplete = isComplete;
    }

    // Override method to set _isComplete when goal is completed
    public override void RecordEvent() {
        _isComplete = true;
    }

    // Override method to return _isComplete
    public override bool IsComplete() {
        return _isComplete;
    }

    // Override method returns string for format to display
    public override string GetStringRepresentation() {
        return _isComplete ? 
        $"[X] {Name} ({Description})":
        $"[ ] {Name} ({Description})";              
    }
}