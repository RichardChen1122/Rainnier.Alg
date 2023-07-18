using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg.competition.Search;
using System;

namespace Rainnier.Alg.Test.competition.search
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void EightNumberProblem()
        {
            var e = new EightNumberProblem();

            var r = e.Execute();
            Assert.AreEqual(362864, r);
        }

        [TestMethod]
        public void Maze()
        {
            var e = new Maze();

            e.CreateTestDemo();
            var r = e.BFS_NoStorePathInStuct();
            Assert.AreEqual("DRRURRDDDR", r);
        }
    }
}
