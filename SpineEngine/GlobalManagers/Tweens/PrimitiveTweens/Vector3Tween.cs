namespace SpineEngine.GlobalManagers.Tweens.PrimitiveTweens
{
    using Microsoft.Xna.Framework;

    using SpineEngine.GlobalManagers.Tweens.Interfaces;
    using SpineEngine.Maths.Easing;

    public class Vector3Tween : Tween<Vector3>
    {
        public Vector3Tween(ITweenTarget<Vector3> tweenTarget, Vector3 toValue, float duration)
            : base(tweenTarget, toValue, duration)
        {
        }

        public override void UpdateValue(float elapsedTime)
        {
            this.TweenTarget.TweenedValue = Lerps.Ease(
                this.EaseType,
                this.FromValue,
                this.ToValue,
                elapsedTime,
                this.Duration);
        }
    }
}