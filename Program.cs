using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFirstByteOfFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = args.Length > 0 ? args[0] : @"D:\home\LogFiles\Application";

            while (true)
            {
                foreach (var file in Directory.EnumerateFiles(folder, "*.log"))
                {
                    using (var stream = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        int b = stream.ReadByte();
                    }
                }

                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
