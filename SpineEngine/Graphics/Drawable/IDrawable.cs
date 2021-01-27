namespace SpineEngine.Graphics.Drawable
{
    using Microsoft.Xna.Framework;

    using SpineEngine.Graphics.Meshes;
    using SpineEngine.Maths;

    public interface IDrawable
    {
        RectangleF Bounds { get; }

        void DrawInto(Color color, float depth, MeshBatch target);

        void DrawInto(float width, float height, Color color, float depth, MeshBatch target);
    }
}