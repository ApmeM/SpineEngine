namespace SpineEngine.ECS.Components
{
    using LocomotorECS;

    using SpineEngine.Graphics.Materials;

    public class MaterialComponent : Component
    {
        public Material Material;

        public MaterialComponent()
        {
            this.Material = new Material();
        }

        public MaterialComponent(Material material)
        {
            this.Material = material;
        }
    }
}