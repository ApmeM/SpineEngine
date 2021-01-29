namespace SpineEngine.GlobalManagers.Tweens.PrimitiveTweens
{
    using Microsoft.Xna.Framework;

    using SpineEngine.GlobalManagers.Tweens.Interfaces;
    using SpineEngine.Maths.Easing;

    public class Vector2Tween : Tween<Vector2>
    {
        public Vector2Tween(ITweenTarget<Vector2> tweenTarget, Vector2 toValue, float duration)
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