class Cycling : Activity
{
    private double _speed; // mph or kph (choose mph here)

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // distance = speed * (minutes/60)
        return _speed * LengthMinutes / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // pace = 60 / speed
        return 60.0 / _speed;
    }
}
