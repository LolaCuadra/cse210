class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            Running running = new Running(new DateTime(2023, 03, 27), 30, 3.0);
            Bycicle cycling = new Bycicle(new DateTime(2022, 03, 28), 45, 20.0);
            Swimming swimming = new Swimming(new DateTime(2022, 03, 29), 60, 40);

            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);
            
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.ReadLine();
        }
    }