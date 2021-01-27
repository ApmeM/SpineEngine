namespace SpineEngine.ECS.Components
{
    using LocomotorECS;

    using SpineEngine.Graphics.Meshes;

    public class FinalRenderComponent : Component
    {
        public MeshBatch Batch { get; } = new MeshBatch();
    }
}