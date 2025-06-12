// Abstract base class
abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkBox;

        if (IsComplete())
        {
            checkBox = "X";
        }
        else
        {
            checkBox = " ";
        }

        string result = "[" + checkBox + "] " + _shortName + " (" + _description + ")";
        return result;
    }

    public abstract string GetStringRepresentation();
}
