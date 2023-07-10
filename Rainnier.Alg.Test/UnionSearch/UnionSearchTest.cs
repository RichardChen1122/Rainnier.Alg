using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg.UnionSearch;
using System;

namespace Rainnier.Alg.Test.UnionSearch
{
    [TestClass]
    public class UnionSearchTest
    {
        [TestMethod]
        public void TestUnionSearch()
        {
            var UnionSearch = new UnionSearchClass();

            UnionSearch.Init(9);

            //UnionSearch.SlowMerge(4, 3);
            //UnionSearch.SlowMerge(3, 2);
            //UnionSearch.SlowMerge(2, 1);
            //UnionSearch.SlowMerge(4, 5);

            UnionSearch.Merge(4, 3);
            UnionSearch.Merge(3, 2);
            UnionSearch.Merge(2, 1);
            UnionSearch.Merge(4, 5);

            Assert.AreEqual(4, 4);

        }
    }
}
