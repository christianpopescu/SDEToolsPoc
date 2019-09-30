using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypes.BasicTypes
{
    /// <summary>
    /// The purpose is to virtualize Tables as defined in database
    /// - Number of columns
    /// - Number of rows
    /// - Headers
    /// - List of Rows
    /// </summary>
    public class VirtualTableOfString
    {
        public IList<RowOfStringsElements<List<StringElement>>> ListOfRows;
        public int NumberOfColumns;
        public int NumberOfRows;
        public IList<String> Headers;


    }
}
