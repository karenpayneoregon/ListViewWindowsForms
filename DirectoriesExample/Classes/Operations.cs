using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoriesExample.Classes
{
    public class Operations
    {
        public static List<ItemDetails> GetFiles(string path, params string[] extensions)
        {
            
            return new DirectoryInfo(path).GetFilesByExtensions(extensions).
                OrderBy(x => x.Name).
                Select(info => new ItemDetails()
                {
                    Name = info.Name,
                    Directory = info.DirectoryName, 
                    FullName = info.FullName, 
                    LastWriteTime = info.LastWriteTime
                }).
                ToList();
        }
    }
}