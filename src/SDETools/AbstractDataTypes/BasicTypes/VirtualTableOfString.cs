using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractDataTypes.Exceptions;

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
        protected IList<RowOfStringsElements> ListOfRows;
        protected int NumberOfColumns;
        protected int NumberOfRows;
        protected IList<String> Headers;
        public static readonly int MaxNumberOfColumns = 256;

        protected VirtualTableOfString(IList<string> headerDefinition)
        {
            Headers = headerDefinition;
        }

        protected static bool ValidateHeaders(IList<string> headerDefinition)
        {
            if (headerDefinition.Count() <= 0 || headerDefinition.Count() > MaxNumberOfColumns)
                throw new InvalidTableHeader();
            return true;
        }

        public static VirtualTableOfString DefineTable(IList<string> headerDefinition)
        {
            if (ValidateHeaders(headerDefinition))
                return new VirtualTableOfString(headerDefinition);
            else
                return null;
        }

        // To do : show headers
        // to do : Add + validate line
        // to do : compare tables

    }
}
