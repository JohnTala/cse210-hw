class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // distance in miles:
        // distance (miles) = laps * 50 / 1000 * 0.62
        return _laps * LapLengthMeters / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        // speed = (distance / minutes) * 60
        return (GetDistance() / LengthMinutes) * 60.0;
    }

    public override double GetPace()
    {
        // pace = minutes / distance
        return (double)LengthMinutes / GetDistance();
    }
}
