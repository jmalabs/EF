using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SANDBOX2Entities();
            var courses = context.GetCourses();

            var course = new COURSE();

            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);

            }

            Console.ReadLine();
        }
    }
}
