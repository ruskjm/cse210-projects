// Running class that inherits from Activity base class
public class Running : Activity {

    // Running distace private double
    private double _runningDistance;

    // Running construtor with date/duration from base class
    public Running(string date, int duration, double distance):
        base (date, duration) {

            // Set the value
            _runningDistance = distance;
    }

    // Overridden method to return the distance
    public override double GetDistance() {
        return _runningDistance;
    }

    // Overridden method to calculate and return the speed
    public override double GetSpeed() {
        return Math.Round(_runningDistance / _activityLength * 60, 2);
    }

    // Overridden method to calculate and return the pace
    public override double GetPace() {
        return Math.Round(_activityLength / _runningDistance, 2);
    }
}