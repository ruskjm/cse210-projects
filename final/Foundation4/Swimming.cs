// Swimming class that inherits from Activity base class
public class Swimming : Activity {

    // Swimming laps private int
    private int _swimmingLaps;

    // Swimming construtor with date/duration from base class
    public Swimming(string date, int duration, int laps):
        base (date, duration) {

            // Set the value
            _swimmingLaps = laps;
    }

    // Overridden method to calculate and return the distance
    public override double GetDistance() {
        return Math.Round(_swimmingLaps * 50 / 1000 * .62, 2);
    }

    // Overridden method to calculate and return the speed
    public override double GetSpeed() {
        return Math.Round(GetDistance() / _activityLength, 2);
    }

    // Overridden method to calculate and return the pace
    public override double GetPace() {
        return Math.Round(_activityLength / GetDistance(), 2);
    }
}