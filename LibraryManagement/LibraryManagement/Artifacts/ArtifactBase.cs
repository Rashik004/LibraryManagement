using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Artifacts
{
    public abstract class ArtifactBase
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public double AccessLevel { get; set; }
        public double Price { get; set; }
    }
}
