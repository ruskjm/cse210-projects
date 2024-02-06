// EternalGoals class to process eternal goals
// that inherits from Goals
public class EternalGoals : Goals {

    // Constructor to initialize EternalGoal properties
    public EternalGoals(string goalName, string description, string points): 
        base (goalName, description, points) {
    }

    // Override method to process when the goal is completed
    public override void RecordEvent() {
        IsComplete();
    }

    // Override method sets to false when the goal is completed
    public override bool IsComplete() {
        return false;
    }

    // Override method returns string for format to display
    public override string GetStringRepresentation() {
        return $"[ ] {Name} ({Description})";
    }

}