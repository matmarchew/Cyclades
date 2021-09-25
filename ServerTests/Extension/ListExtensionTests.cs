using NUnit.Framework;
using Server.Extension;
using System.Collections.Generic;
using TddXt.AnyRoot.Strings;
using static TddXt.AnyRoot.Root;

namespace ServerTests.Extension
{
    [TestFixture]
    public class ListExtensionTests
    {
        [Test]
        public void ShouldGetAndRemoveElementFromListWhenIndexIsCorrect()
        {
            //GIVEN
            var element = Any.String();
            IList<string> list = new List<string> { element };

            //WHEN
            var result = list.GetAndRemove(0);

            //THEN
            Assert.AreEqual(0, list.Count);
            Assert.AreEqual(element, result);
        }

        [TestCase(-1)]
        [TestCase(1)]
        public void ShouldReturnDefaultWhenIndexIsNotCorrect(int index)
        {
            //GIVEN
            var element = Any.String();
            IList<string> list = new List<string> { element };

            //WHEN
            var result = list.GetAndRemove(index);

            //THEN
            Assert.AreEqual(default, result);
        }

        [Test]
        public void ShouldAppendAllElementsToAnotherList()
        {
            //GIVEN
            IList<string> destination = Any.Instance<List<string>>();
            IList<string> source = Any.Instance<List<string>>();
            var destinationCount = destination.Count;

            //WHEN
            destination.AppendAll(source);

            //THEN
            Assert.AreEqual(source.Count + destinationCount, destination.Count);
            CollectionAssert.IsSubsetOf(source, destination);
        }

        [Test]
        public void ShouldShuffleList()
        {
            //GIVEN
            IList<string> list = Any.Instance<List<string>>();
            IList<string> copyList = new List<string>();
            copyList.AppendAll(list);

            //WHEN
            list.Shuffle();

            //THEN
            CollectionAssert.AreEquivalent(copyList, list);
        }

        [Test]
        public void ShouldSwapElements()
        {
            //GIVEN
            var firstElement = Any.String();
            var secondElement = Any.String();
            var list = new List<string>
            {
                firstElement,
                secondElement
            };

            //WHEN
            list.Swap(0, 1);

            //THEN
            Assert.AreEqual(secondElement, list[0]);
            Assert.AreEqual(firstElement, list[1]);
        }
    }
}
