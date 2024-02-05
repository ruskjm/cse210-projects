public class EternalGoals : Goals {

    public EternalGoals(string goalName, string description, string points): 
        base (goalName, description, points) {
    }

    public override void RecordEvent() {
        IsComplete();
    }

    public override bool IsComplete() {
        return false;
    }

    public override string GetStringRepresentation() {
        return $"[ ] {Name} ({Description})";
    }

}