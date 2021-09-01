using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoriesExample.Classes
{
    public static class Extensions
    {
        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions) 
            => dir.EnumerateFiles().Where((f) => extensions.Contains(f.Extension));

    }
}