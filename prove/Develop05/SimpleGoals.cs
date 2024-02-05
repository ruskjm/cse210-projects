public class SimpleGoals : Goals {

    private bool _isComplete;

      public SimpleGoals() {}

    public SimpleGoals(string goalName, string description, string points): 
        base (goalName, description, points) {
        _isComplete = false;
    }

    public SimpleGoals(string goalName, string description, string points, bool isComplete): 
        base (goalName, description, points) {
            _isComplete = isComplete;
    }

    public override void RecordEvent() {
        _isComplete = true;
    }

    public override bool IsComplete() {
        return _isComplete;
    }

    public override string GetStringRepresentation() {
        return _isComplete ? 
        $"[X] {Name} ({Description})":
        $"[ ] {Name} ({Description})";
                
    }

}