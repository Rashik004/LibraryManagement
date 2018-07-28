using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.Artifacts
{
    public interface IArtifact
    {
        string Title { get; set; }
        string Category { get; set; }
        double AccessLevel { get; set; }
        double Price { get; set; }
        
    }
}
