using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg.graph.model;
using System;

namespace Rainnier.Alg.Test.graph
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void Dijkstra()
        {
            var graph = new DemoGraph();
            graph.CreateDemoGraph();

            //var result = graph.Dijkstra(0, 3);

            //Assert.AreEqual(50, result);

            var result = graph.Dijkstra(0);
            Assert.AreEqual(6, result.Length);
            Assert.AreEqual(60, result[5]);

        }
    }
}
