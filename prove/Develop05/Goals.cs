public abstract class Goals {

    protected string _goalName;
    protected string _description;
    protected string _points;
    //protected int _goalCount = 0;

    public Goals(){}

    public Goals(string goalName, string description, string points) {
        _goalName = goalName; 
        _description = description;
        _points = points;
    }

    public string Name {
        get { return _goalName; }
    }

    public string Description {
        get { return _description; }
    }

    public string Points {
        get { return _points; }
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

}