using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.FilesAndFoldersHelper
{
    [Flags]
    public enum ElementSelection
    {
        none = 0x00,
        file = 0x01,
        folder = 0x10
    }
}
