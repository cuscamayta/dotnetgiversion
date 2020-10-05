using LibGit2Sharp;
using System;

namespace DotNetGitVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repo = new Repository(@"F:\SERVERGIT\dotnetgiversion"))
            {
                var branches = repo.Branches;
                foreach (var b in branches)
                {
                    Console.WriteLine(b.FriendlyName);
                }
            }
            Console.WriteLine("thisx is another change");
            Console.WriteLine("this is another change in another commit ");
            Console.WriteLine("Hello World!");
        }
    }
}
