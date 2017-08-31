using OpenRTX.Domain.Entities.Interfaces;

namespace OpenRTX.Domain.Entities
{

    public enum TerrainType
    {
        Water,
        Flat,
        Hills,
        Mountain
    }
    
    public class TerrainLayer : Entity, ILayer
    {

        public TerrainLayer(TerrainType type)
        {
            TerrainType = type;
        }
        
        public LayerType LayerType => LayerType.Terrain;
        
        public TerrainType TerrainType { get; protected set; }
        
    }
}