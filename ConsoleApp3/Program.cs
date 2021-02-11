using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using static System.Console;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("./");
            List<FileInfo> fileInfos = new List<FileInfo>();

            foreach (string fileName in fileNames) {
                fileInfos.Add(new FileInfo(fileName));
            }

            foreach (FileInfo fileInfo in fileInfos) {
                WriteLine("{0,25} {1, 20}", fileInfo.Name, fileInfo.Length);
            }
            ReadKey();
        }
    }
}
