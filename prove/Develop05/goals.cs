using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

    public Goal() 
    {
        _name = "Test Name";
        _description = "Test Description";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    protected void CreateBase() 
    {   
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringGoalPoints = (Console.ReadLine());
        _goalPoints = Convert.ToInt32(stringGoalPoints);

        _status = false;
    }

    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    public virtual void CreateChildGoal()
    {

    }

    public virtual void RecordEvent() 
    {

    }

    public virtual bool IsComplete() 
    {
        return false;
    }

    public virtual void ListGoal() 
    {

    }

    public virtual int CalculateAGP()
    {
        return 0;
    }
}

/*Next section*/

public class Eternal : Goal
{
    private int _stepCounter;

    public Eternal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _stepCounter = 0;
    }
    public Eternal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _stepCounter = 0;
    }
    public override void CreateChildGoal()
    {
        CreateBase();
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal:" + _name + "," + _description + "," + _goalPoints.ToString();
        return line;
    }

    public override void RecordEvent()
    {
        _stepCounter ++;
    }
    public override int CalculateAGP()
    {
        int points = _goalPoints;
        return points;
    }
}

/*Next section*/

public class Simple : Goal
{
    public Simple()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _goalPoints = 50;
        _status = false;
    }

    public Simple(string name, string description, int goalPoints, bool status)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

    public override void CreateChildGoal()
    {
        CreateBase();
    }

    public override void RecordEvent()
    {
        if (_status == false) { 
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_status == true) {
            return true;
        } else {
            return false;
        }
    }

    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }
        Console.Write($"[{statusSymbol}] {_name} ({_description})");
    }
    
    public override int CalculateAGP()
    {
        bool status = IsComplete();
        int aGP = 0;
        if (status == true) {
            aGP = _goalPoints;
        } else {
            aGP = 0;
        }
        return aGP;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_name},{_description}{_goalPoints},{IsComplete().ToString()}";
        return line;
    }
}
