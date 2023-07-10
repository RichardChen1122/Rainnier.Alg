using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg.competition.basic;
using System;

namespace Rainnier.Alg.Test.competition.basic
{
    [TestClass]
    public class CompetitionBasic
    {
        [TestMethod]
        public void HanNuoTa()
        {
            var h = new HanNuoTa();

            h.Execute(3);

            Assert.IsNotNull(h);
        }


        [TestMethod]
        public void FullPermutation()
        {
            var h = new FullPermutation();

            var r = h.Execute("abc");

            Assert.AreEqual(6, r.Count);
        }
    }
}
