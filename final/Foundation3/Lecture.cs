using System; 
public class Lectures : Event
{
    private string _announcment {get; set;}    
    private int _capacity {get; set;}    
    public Lectures(string title, string description, string date, string time, string address, string type, int capacity, string announcment ) : base (title, description, date, time, address, type)
    {
        _announcment = announcment;
        _capacity = capacity;
    }
    public void DisplayLectureFullDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"Announcment: {_announcment}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}