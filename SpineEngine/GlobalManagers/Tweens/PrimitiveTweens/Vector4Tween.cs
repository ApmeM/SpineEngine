namespace SpineEngine.GlobalManagers.Tweens.PrimitiveTweens
{
    using Microsoft.Xna.Framework;

    using SpineEngine.GlobalManagers.Tweens.Interfaces;
    using SpineEngine.Maths.Easing;

    public class Vector4Tween : Tween<Vector4>
    {
        public Vector4Tween(ITweenTarget<Vector4> tweenTarget, Vector4 toValue, float duration)
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