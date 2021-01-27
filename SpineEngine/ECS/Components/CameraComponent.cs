namespace SpineEngine.ECS.Components
{
    using LocomotorECS;

    using SpineEngine.Graphics.Cameras;

    public class CameraComponent : Component
    {
        public Camera Camera { get; set; }
    }
}