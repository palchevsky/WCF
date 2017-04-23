using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiskInfoHost
{
    public class DiskInfo : IDiskInfo
    {
        List<string> dirsAndFiles = new List<string>();

        public string[] GetDiskInfo(string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                foreach (var dir in dirs)
                {
                    dirsAndFiles.Add("DIRECTORY\t" + Path.GetFileName(dir));
                }
                foreach (var file in files)
                {
                    dirsAndFiles.Add("FILE\t" + Path.GetFileName(file));
                }
                return dirsAndFiles.ToArray();
            }
            catch (DirectoryNotFoundException)
            {
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            return dirsAndFiles.ToArray();
        }
    }
}
