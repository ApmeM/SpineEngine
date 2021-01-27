namespace SpineEngine.ECS.Components
{
    using LocomotorECS;

    using SpineEngine.Maths;

    /// <summary>
    ///     Component that check if cursor (touch or mouse) over the specified region on this entity.
    ///     System takes in account current entity position.
    /// </summary>
    public class CursorOverComponent : Component
    {
        public bool IsMouseOver;

        public RectangleF OverRegion;
    }
}