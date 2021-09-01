using System;

namespace DirectoriesExample.Classes
{
    public class ItemDetails
    {
        public string Directory { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public DateTime LastWriteTime { get; set; }
        public string[] ItemArray => new[] {Name, LastWriteTime.ToString("MM/dd/yyyy")};
    }
}