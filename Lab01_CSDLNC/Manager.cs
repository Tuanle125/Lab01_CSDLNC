using Db4objects.Db4o; // thư viện
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_CSDLNC
{
    public static class Manager
    {
        public static string DbFileName { get; set; }
        public static IObjectContainer Database => Db4oEmbedded.OpenFile(DbFileName);

    }
}
