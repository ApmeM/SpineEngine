namespace SpineEngine.GlobalManagers.Tweens.TweenTargets
{
    using SpineEngine.ECS.Components;
    using SpineEngine.GlobalManagers.Tweens.Interfaces;

    public class RotateComponentTweenTarget : ITweenTarget<float>
    {
        private readonly RotateComponent target;

        public RotateComponentTweenTarget(RotateComponent target)
        {
            this.target = target;
        }

        public float TweenedValue
        {
            get => this.target.Rotation;
            set => this.target.Rotation = value;
        }

        public object Target => this.target;
    }
}