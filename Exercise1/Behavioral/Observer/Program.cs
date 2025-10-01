namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Observer Pattern Demo ===");

            College college = new College();

            // Create students
            Student alice = new Student("Alice");
            Student bob = new Student("Bob");
            Student charlie = new Student("Charlie");

            // Students subscribe to notifications
            college.Attach(alice);
            college.Attach(bob);
            college.Attach(charlie);

            // Post announcements
            college.PostAnnouncement("Midterm exams schedule released!");
            college.PostAnnouncement("Guest lecture on AI this Friday!");

            // Bob unsubscribes
            college.Detach(bob);

            college.PostAnnouncement("Holiday on Monday!"); 

            Console.ReadKey();
        }
    }
}
