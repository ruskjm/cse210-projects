// Cycling class that inherits from Activity base class
public class Cycling : Activity {

    // Cycling speed private double
    private double _cyclingSpeed;

    // Cycling construtor with date/duration from base class
    public Cycling(string date, int duration, double speed):
        base (date, duration) {

            // Set the value
            _cyclingSpeed = speed;
    }

    // Overridden method to calculate and return the distance
    public override double GetDistance() {
        return Math.Round(_cyclingSpeed * (_activityLength / 60), 2);
    }

    // Overridden method to return the speed
    public override double GetSpeed() {
        return _cyclingSpeed;
    }

    // Overridden method to calculate and return the pace
    public override double GetPace() {
        return Math.Round(_activityLength / GetDistance(), 2);
    }
}