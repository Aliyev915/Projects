using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Helpers
{
    public class Helper
    {
        public static void DeleteImage(string filename,string path,string folder)
        {
            string fullpath = path + folder + filename;
            if (System.IO.File.Exists(fullpath))
            {
                System.IO.File.Delete(fullpath);
            }
        }
    }
    public enum Roles{
        Admin,
        User
    }
}
