using LibGit2Sharp;
using System;
using System.IO;

namespace DotNetGitVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(Path.Combine("dotnetgiversion", @"..\..\..\..\..\..\" )));            

            using (var repo = new Repository(directory.FullName))
            {
                var branches = repo.Branches;
                foreach (var b in branches)
                {
                    Console.WriteLine(b.FriendlyName);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
