namespace SpineEngine.GlobalManagers.Coroutines
{
    using System.Collections;

    using SpineEngine.Utils.Collections;

    /// <summary>
    ///     class used by the CoroutineManager to hide the data it requires for a Coroutine
    /// </summary>
    public class Coroutine : IPoolable
    {
        internal IEnumerator Enumerator;

        internal bool IsDone;

        internal Coroutine WaitForCoroutine;

        void IPoolable.Reset()
        {
            this.IsDone = true;
            this.WaitForCoroutine = null;
            this.Enumerator = null;
        }

        public void Stop()
        {
            this.IsDone = true;
        }
    }
}