using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAppLauncher.Models
{
    public class LauncherVersion
    {
        public int Major { get; set; }
        public int MajorRevision { get; set; }
        public int Minor { get; set; }
        public int MinorRevision { get; set; }

        public string ToString() => $"{Major}.{MajorRevision}.{Minor}.{MinorRevision}";
    }
}
