using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Extensions
{

    public static class Extension
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool Length(this IFormFile file,int length)
        {
            return file.FileName.Length / 1024 > length;
        }

        public async static Task<string> GetImagePath(this IFormFile file,string root, string folder)
        {
            string path = Path.Combine(root, folder);
            string filename = Guid.NewGuid().ToString() + file.FileName;
             
            string fullPath = Path.Combine(path, filename);
            using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return filename;

        }
    }
}
