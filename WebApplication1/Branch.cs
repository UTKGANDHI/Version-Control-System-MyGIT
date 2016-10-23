using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication1
{
    public static class Branch
    {

        public static void DirectoryCopy(string sourceDirName, string destDirName)
        {
            // Get the subdirectories for the specified directory.
            string temp = Path.Combine(@"G:/Git Branch/",Path.GetFileName(sourceDirName));
            //string temp = Path.Combine(@"G:/Git Branch/",destDirName);
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

       
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }

            Directory.CreateDirectory(Path.Combine(temp,destDirName));

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(Path.Combine(temp, destDirName), file.Name);
                try
                {
                    file.CopyTo(temppath, false);
                }catch(Exception e)
                {

                }
            }

            
        }
    }
}