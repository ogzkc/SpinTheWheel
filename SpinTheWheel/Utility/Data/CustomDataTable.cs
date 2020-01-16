using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SpinTheWheel.Utility.Data
{
    [Serializable]
    public class CustomDataTable : DataTable
    {
        public CustomDataTable() : base()
        {
        }

        public CustomDataTable(string tableName) : base(tableName)
        {
        }

        public CustomDataTable(string tableName, string tableNamespace) : base(tableName, tableNamespace)
        {
        }

        public CustomDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        protected override Type GetRowType()
        {
            return typeof(CustomDataRow);
        }

        protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
        {
            return new CustomDataRow(builder);
        }
    }
}
