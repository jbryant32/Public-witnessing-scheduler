using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PWSSchduler.FileIO
{
    public class FolderPaths
    {
        public static readonly string DataBasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"pwsdb.db3");
    }
}
