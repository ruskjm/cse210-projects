public class SimpleGoals : Goals {

    private bool _isComplete;

      public SimpleGoals() {}

    public SimpleGoals(string goalName, string description, string points): 
        base (goalName, description, points) {
        _isComplete = false;
    }

    public override void RecordEvent() {
        IsComplete();
    }

    public override bool IsComplete() {
        return _isComplete = true;
    }

    public override string GetStringRepresentation() {
        return _isComplete ? 
        $"[X] {Name} ({Description})":
        $"[ ] {Name} ({Description})";
                
    }

}