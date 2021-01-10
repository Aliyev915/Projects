using Microsoft.AspNetCore.Http;
using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Helpers
{
    public static class Helper
    {
        public static void DeleteImg(string file,string root,string folder )
        {
            string path = Path.Combine(root, folder);
            string fullPath = Path.Combine(path,file);
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
        }
        public enum Roles
        {
            Admin,
            Moderator,
            Member
        }
    }
}
