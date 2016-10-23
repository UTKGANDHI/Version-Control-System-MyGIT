using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class Commit
    {
        public static string[] compare(string original,string branch)//To decide whether there exists a conflict or not
        {
            int count = 0;
            string[] s=new string[100];
            DirectoryInfo master = new DirectoryInfo(original);
            DirectoryInfo branch1 = new DirectoryInfo(branch);
            foreach(FileInfo f in master.GetFiles())
            {
                foreach(FileInfo b in branch1.GetFiles())
                {
                    if(f.Name==b.Name)
                    {
                        s[count] = b.Name;
                        count++;
                    }
                }
            }
            return s;
            

        }
        public static void merge(int x, string reponame, string branchname, string sender, string description)
        {


            DataClasses4_mergeDataContext dm = new DataClasses4_mergeDataContext();
            merge_req m = new merge_req();
            m.reponame = reponame;
            m.branchname = branchname;
            m.sender = sender;
            m.Id = x;
            m.timestamp = DateTime.Now.ToString();
            dm.merge_reqs.InsertOnSubmit(m);
            dm.SubmitChanges();
        }
    }
}