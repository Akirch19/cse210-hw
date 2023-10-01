using System;


public class JournalPrompt
{

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What is something I can improve on tomorrow?",
        "What did you do right before writting in your journal today?",
        "How could you of been more patient today?",
        "What would you of done with an extra hour today?",
        "What was the worst part of your day?",
        "What is your favorite song or video you consumed today?",
        "What super power could you of used today?",
        "what did you do today vs what you wish you could of done?",
        "How can you better prepare yourself for tomorrow?",

    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public JournalPrompt()
    {

    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }


}