using System;

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("13 Burritt", "Norwalk", "CT", "06854");
        Address address2 = new Address("17 Saith John St", "Norwalk", "CT", "06855");
        DateTime dateTime1 = new DateTime(2023, 4, 15, 19, 0, 0);
        DateTime dateTime2 = new DateTime(2023, 5, 20, 14, 30, 0);

        Lecture lecture = new Lecture("Introduction to Data Science", "Learn the basics of Data Science from an expert", dateTime1, address1, "Josue Molina", 50);
        Reception reception = new Reception("Weeding", "Join us to celebrate our love", dateTime2, address2, "inloom@gmail.com");
        Outdoor outdoorGathering = new Outdoor("Community Picnic", "Join us for a day of fun in the sun", dateTime1, address1, "Sunny skies with a high of 75 degrees");

        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
    }
}
