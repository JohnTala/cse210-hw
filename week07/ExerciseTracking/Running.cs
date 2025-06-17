class Running : Activity
{
    private double _distance; // miles or km (choose miles here)

    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // speed = (distance / minutes) * 60
        return (_distance / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        // pace = minutes / distance
        return (double)LengthMinutes / _distance;
    }
}
