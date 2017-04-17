using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskInfoLibrary
{
    public class DiskInfo : IDiskInfo
    {
        IEnumerable<string> dirsAndFiles = new List<string>();


        public string[] GetDiskInfo(string path)
        {
            //string[] result;
            try
            {
                string[] dirs = Directory.GetDirectories(path, "*");
                string[] files = Directory.GetFiles(path, "*");
                dirsAndFiles = dirs.Concat(files);
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
