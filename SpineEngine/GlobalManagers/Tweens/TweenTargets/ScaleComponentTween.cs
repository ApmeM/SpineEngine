namespace SpineEngine.GlobalManagers.Tweens.TweenTargets
{
    using Microsoft.Xna.Framework;

    using SpineEngine.ECS.Components;
    using SpineEngine.GlobalManagers.Tweens.Interfaces;

    public class ScaleComponentTweenTarget : ITweenTarget<Vector2>
    {
        private readonly ScaleComponent target;

        public ScaleComponentTweenTarget(ScaleComponent target)
        {
            this.target = target;
        }

        public Vector2 TweenedValue
        {
            get => this.target.Scale;
            set => this.target.Scale = value;
        }

        public object Target => this.target;
    }
}