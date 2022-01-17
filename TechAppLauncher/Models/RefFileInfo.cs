using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAppLauncher.Models
{
    public class RefFileInfo
    {
        public string Title { get; set; }
        public string FileName { get; set; }
        public string FileRelativeUrl { get; set; }
        public double FileSize { get; set; }
        public bool IsAvailable { get; set; }
    }
}
