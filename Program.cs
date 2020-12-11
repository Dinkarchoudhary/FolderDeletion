using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace FolderDeletion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for Deletion of Folder in Windows
            var root = ConfigurationManager.AppSettings["Path"];
            try
            {
                if (Directory.Exists(root))
                {
                    Directory.Delete(root, true);
                    Console.WriteLine("File Successfully Deleted");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("File Doesn't Exists");
            }
        }
    }
}
