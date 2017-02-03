using System;
using System.EnterpriseServices.Internal;

namespace GitLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var publication = new Publish();
            // just fun
            publication.GacInstall("pathToFile");
            Console.ReadKey(true);
        }
    }
}
