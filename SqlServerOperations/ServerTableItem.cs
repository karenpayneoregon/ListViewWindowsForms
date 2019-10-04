using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace SqlServerOperations
{
    public class ServerTableItem
    {
        public string Table { get; set; }
        public string Field { get; set; }
        public Int16 FieldOrder { get; set; }
        public string DataType { get; set; }
        public Int16 Length { get; set; }
        public Int16 Precision { get; set; }
        public Int32 Scale { get; set; }
        public string AllowNulls { get; set; }
        public string Identity { get; set; } = Empty;
        public string PrimaryKey { get; set; }
        public string ForeignKey { get; set; } = Empty;
        public string RelatedTable { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Field;
        }
    }
}
