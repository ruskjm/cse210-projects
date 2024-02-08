// ChecklistGoals class to process checklist goals 
// that inherits from Goals
public class ChecklistGoals : Goals {

    // Private int to track how many the goal has been completed
    private int _amountCompleted;

    // Private int for the amount of times the goal has to 
    // be completed
    private int _target;

    // Private int for the bonus amount
    private int _bonus;

    // Private boolean to track when goal is completed
    private bool _isComplete;
 
    // Constructor to initialize ChecklistGoals properties
    // Uses goalName, description, points from the base class Goals
    public ChecklistGoals(string goalName, string description, string points, 
        int target, int bonus): 
            base (goalName, description, points) {

                // set variables
                _target = target;
                _bonus = bonus;
                _isComplete = false;
                _amountCompleted = 0;
    }

   // Overridden constructor to initialize ChecklistGoals properties
    public ChecklistGoals(string goalName, string description, string points, 
        int target, int bonus, int amountCompleted): 
            base (goalName, description, points) {

                // set variables
                _target = target;
                _bonus = bonus;
                _amountCompleted = amountCompleted;

                // Call RecordEvent method to see if goal can be marked completed
                RecordEvent();
            }

    // Geter for _target
    public int ChecklistTarget {
        get { return _target; }
    }

    // Geter for _amountCompleted
    public int AmountCompleted {
        get { return _amountCompleted; }
    }

    //Geter for _bonus
    public int ChecklistBonus {  
        get { return _bonus; }
    }

    //  If _isComplete is true returns _bonus
    //  else return 0
    public int GetBonus() {
        if (_isComplete) {
            return _bonus;
        }
        else {
            return 0;
        }
    }

    // Method to increment _amountCompleted
    public void IncrementCount() {
        _amountCompleted++;
    }

    // Override method to to record even and call
    // IsComplete if _amountCompleted equals _target
    public override void RecordEvent() {
        if (_amountCompleted == _target) {
            IsComplete();
        }
    }

    // Override method sets _isComplete to true 
    // and returns the value
    public override bool IsComplete() {
        return _isComplete = true;
    }

    // Override method returns string for format to display
    public override string GetStringRepresentation() {
        return _isComplete ? 
        $"[X] {Name} ({Description}) -- Currently completed: {_amountCompleted}/{_target}":
        $"[ ] {Name} ({Description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}