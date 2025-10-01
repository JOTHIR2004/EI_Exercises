using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class College : ISubject
    {
        private List<IObserver> students = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            students.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            students.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var student in students)
            {
                student.Update(message);
            }
        }

        public void PostAnnouncement(string announcement)
        {
            Console.WriteLine($"\nCollege Announcement: {announcement}");
            Notify(announcement);
        }
    }
}
