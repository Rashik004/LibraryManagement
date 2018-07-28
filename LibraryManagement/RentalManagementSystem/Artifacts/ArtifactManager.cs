using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagementSystem.Artifacts
{
    /// <summary>
    /// Responsibility of this class is to determine if an user is allowed to borrow an artifact based on
    /// various conditions
    /// </summary>
    public class ArtifactManager : IArtifactManager
    {
        List<IArtifact> _artifacts;

        public ArtifactManager()
        {
            _artifacts = new List<IArtifact>();
        }
        

    }
}
