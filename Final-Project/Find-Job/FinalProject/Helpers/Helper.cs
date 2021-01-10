using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Helpers
{
    public static class Helper
    {
        public static void DeleteImage(string fileName)
        {
            if(System.IO.File.Exists(fileName))
            {
                System.IO.File.Delete(fileName);
            }
        }
        public enum Roles
        {
            Admin,
            Moderator,
            User
        }

    }
}
