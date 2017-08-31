namespace OpenRTX.Domain.Entities.Interfaces
{
    
    public enum LayerType
    {
        Terrain,
        Construction
    }
    
    public interface ILayer
    {
        
        LayerType LayerType { get; }
        
    }
    
}