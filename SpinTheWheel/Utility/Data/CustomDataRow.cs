using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinTheWheel.Utility.Data
{
    public class CustomDataRow : DataRow
    {
        public object Tag { get; set; }
        protected internal CustomDataRow(DataRowBuilder builder) : base(builder)
        {

        }
    }
}
