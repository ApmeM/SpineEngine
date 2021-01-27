namespace SpineEngine.GlobalManagers.Tweens.TweenTargets
{
    using SpineEngine.ECS.Components;
    using SpineEngine.GlobalManagers.Tweens.Interfaces;

    public class RotateDegreesComponentTweenTarget : ITweenTarget<float>
    {
        private readonly RotateComponent target;

        public RotateDegreesComponentTweenTarget(RotateComponent target)
        {
            this.target = target;
        }

        public float TweenedValue
        {
            get => this.target.RotationDegrees;
            set => this.target.RotationDegrees = value;
        }

        public object Target => this.target;
    }
}