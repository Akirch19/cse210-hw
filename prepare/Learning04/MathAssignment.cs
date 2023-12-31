using System;

public class MathAssignment : Assignment
{

    private string _textBookSection;
    private string _problems;

    public MathAssignment()
    {
        
    }
    public MathAssignment(string studentName, string topic, string textBookSection, string problems)
        : base(studentName, topic)
    {

        _textBookSection = textBookSection;
        _problems = problems;
    }

    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
   
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} Problems: {_problems}";
    }


}