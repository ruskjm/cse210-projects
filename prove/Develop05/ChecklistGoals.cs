public class ChecklistGoals : Goals {

    private int _amountCompleted = 0;

    private int _target;

    private int _bonus;

    private bool _isComplete;
 
    public ChecklistGoals(string goalName, string description, string points, 
        int target, int bonus): 
            base (goalName, description, points) {
                _target = target;
                _bonus = bonus;
                _isComplete = false;
    }

    public int ChecklistTarget {
        get { return _target; }
    }

    public int ChecklistBonus {  
        get { return _bonus; }
    }

    public int GetBonus() {
        if (_isComplete) {
            return _bonus;
        }
        else {
            return 0;
        }
    }

    public void IncrementCount() {
        _amountCompleted++;
        Console.WriteLine($"Counter = {_amountCompleted}");
    }

    public override void RecordEvent() {
        if (_amountCompleted == _target) {
            IsComplete();
        }
        Console.WriteLine($"_isComplete = {_isComplete}");
    }

    public override bool IsComplete() {
        return _isComplete = true;
    }

    public override string GetStringRepresentation() {
        return _isComplete ? 
        $"[X] {Name} ({Description}) -- Currently completed: {_amountCompleted}/{_target}":
        $"[ ] {Name} ({Description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    //string details = GetDetailsString();

  }