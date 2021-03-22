using System;
using System.IO;

namespace FileSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferConfig transferConfig = new TransferConfig { FileExtention = "exe", DestinationFolder = @"G:\Test\Setups", SourceFolder = @"C:\Users\richa\Downloads" };
            DirectoryInfo directoryInfo = new DirectoryInfo(transferConfig.SourceFolder);
            DirectoryInfo destDirectoryInfo = new DirectoryInfo(transferConfig.DestinationFolder);
            foreach (var fileInfo in directoryInfo.GetFiles())
            {
                if(fileInfo.Name.EndsWith(transferConfig.FileExtention))
                fileInfo.MoveTo(transferConfig.DestinationFolder+@"\"+fileInfo.Name);
            }
            Console.WriteLine("Hello");
        }
    }
}
