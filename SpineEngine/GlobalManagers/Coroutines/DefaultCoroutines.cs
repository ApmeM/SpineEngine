namespace SpineEngine.GlobalManagers.Coroutines
{
    using System;
    using System.Collections;

    using SpineEngine.GlobalManagers.Tweens;
    using SpineEngine.GlobalManagers.Tweens.Interfaces;

    public static class DefaultCoroutines
    {
        public static IEnumerator Wait(float seconds)
        {
            var startAt = DateTime.Now;
            while ((DateTime.Now - startAt).TotalSeconds < seconds)
            {
                yield return null;
            }
        }

        public static IEnumerator Empty()
        {
            yield return null;
        }

        public static IEnumerator WaitForTweenCompletition(ITween tween)
        {
            var globalManager = Core.Instance.GetGlobalManager<TweenGlobalManager>();
            while (globalManager.IsTweenCompleted(tween))
            {
                yield return null;
            }
        }
    }
}