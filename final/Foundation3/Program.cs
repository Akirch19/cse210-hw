using System;

class Program
{
    static void Main(string[] args)
    {
        //lecture
        Address address1 = new Address ("16275 Starlight View Ln", "Sahuarita", "AZ", "85629", "USA");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with Sahuarita Stake.", "October 29, 2023", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", 400,"Also being brodcasted to Sahuarita Church house. ");
       
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();
        //reception
        Address address2 = new Address ("1212 Fake Ave.", "Sahuarita", "AZ", "85629", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Hosted by the Kirchner's", "Alayna's Second Birthday Party", "October 5, 2023", "5:00 pm - 8:00am", $"{receptionAddress}", "Reception", "Austink@gmail.com");
       
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();
        //outdoor
        Address address3 = new Address ("3400 E Zoo Ct", "Tucson", "AZ", "85716", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Park Day", "Zoo and park day for all parents and kids.", "December 4, 2023", "11:00 am - 3:00pm", $"{outdoorAddress}", "Outdoor", "Cold and partly cloudy");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();

        
    }
}