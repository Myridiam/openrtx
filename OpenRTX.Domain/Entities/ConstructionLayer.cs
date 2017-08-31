using System.Collections.Generic;
using OpenRTX.Domain.Entities.Interfaces;

namespace OpenRTX.Domain.Entities
{
   
    public class ConstructionLayer : Entity, ILayer
    {

        public ConstructionLayer(TerrainType type)
        {
            Constructions = new List<IConstruction>();
        }
        
        public LayerType LayerType => LayerType.Construction;
        
        public List<IConstruction> Constructions { get; set; }
        
    }

}