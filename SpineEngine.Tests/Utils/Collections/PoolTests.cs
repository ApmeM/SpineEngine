namespace SpineEngine.Tests.Utils.Collections
{

    using NUnit.Framework;
    using SpineEngine.Utils.Collections;

    [TestFixture]
    public class PoolTests
    {
        public class Data : IPoolable
        {
            public int InnerData;
            public int ResetCount;
            public void Reset()
            {
                ResetCount++;
            }
        }

        [Test]
        public void Free_ResetCalled()
        {
            var data = Pool<Data>.Obtain();
            Pool<Data>.Free(data);

            Assert.AreEqual(1, data.ResetCount);
        }

        [Test]
        public void Obtain_AfterFree_SameObject()
        {
            var data = Pool<Data>.Obtain();
            Pool<Data>.Free(data);
            var secondData = Pool<Data>.Obtain();
            Assert.AreEqual(data, secondData);
        }

        [Test]
        public void Obtain_AfterObtain_DifferentObjects()
        {
            var data = Pool<Data>.Obtain();
            var secondData = Pool<Data>.Obtain();
            Assert.AreNotEqual(data, secondData);
        }
    }
}