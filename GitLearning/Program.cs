using System;
using System.EnterpriseServices.Internal;
using System.Globalization;

namespace GitLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString(@"dddd, MMMM M\t\h yyyy", CultureInfo.CreateSpecificCulture("en-US")));
            Console.ReadKey(true);
        }
    }
}
