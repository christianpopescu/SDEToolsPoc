using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.vadc.OSFacade.Interfaces
{
    /// <summary>
    /// Interface to operating system Directory Class
    /// The purpose is to facilitate the separation of client from operating system (Facilitate tests)
    /// </summary>
    public interface IOSDirectory
    {
        static IEnumerable<string> EnumerateDirectories(string pPath) => throw new NotImplementedException();

        static IEnumerable<string> EnumerateFiles(string pPath) => throw new NotImplementedException();
    }
}
