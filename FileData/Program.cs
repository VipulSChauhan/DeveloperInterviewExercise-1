using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
       
        public static void Main(string[] args)
        {
            printJob printJob = new printJob();
            if (args.Length != 2)
            {
                printJob.printResult("Must be 2 arguments");
                Console.ReadLine();
                return;
            }
            FileDetails fd = new FileDetails();
            printJob.printResult("With main method : Task 1");
            string result = (args[0] == "-v") ? fd.Version(args[1]) : "No argument to call function";
            Console.WriteLine(result);

            printJob.printResult("With prototype : Task 2");
            FileDetails fdProtoType = fd;

            string protoResult = (new[] { "-v", "--v", "/v", "--version" }).Contains(args[0]) ? fdProtoType.Version(args[0]) : ((new[] { "-s", "--s", "/s", "--size" }).Contains(args[0]) ? fdProtoType.Size(args[0]).ToString() : "Make sure arguments are in proper place to call function"); ;
            printJob.printResult(protoResult);

            Console.ReadLine();
        }
    }
    public class printJob {
        public static void printResult(string resultString)
        {
            Console.WriteLine(resultString);
        }
    }
}
