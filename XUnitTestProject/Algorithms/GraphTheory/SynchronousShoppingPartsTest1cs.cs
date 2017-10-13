﻿using System.Collections.Generic;
using Tasks.Algorithms.GraphTheory;
using Xunit;

namespace XUnitTestProject.Algorithms.GraphTheory
{
    public class SynchronousShoppingPartsTest1cs
    {
        public SynchronousShoppingPartsTest1cs()
        {
        }

        [Fact]
        public void TestWay1()
        {
            var ss = GetTestGraph();

            var way = ss.FindWayToFish(1, new HashSet<int> { 7, 8 });
            var dotgraph = ss.ToDotGraph();

            Assert.Equal(new[] { 1, 3, 4, 8 }, way.Path);
            Assert.Equal(8, way.Cost);
        }

        [Fact]
        public void TestWay2()
        {
            var ss = GetTestGraph();

            var way = ss.FindWayToSC(3, 5);
            var dotgraph = ss.ToDotGraph();

            Assert.Equal(new[] { 3, 2, 5 }, way.Path);
            Assert.Equal(4, way.Cost);
        }

        private static SynchronousShopping GetTestGraph()
        {
            var ss = new SynchronousShopping(10, 9, 10);
            int length = 10;
            for (int i = 1; i <= length; i++)
                ss.AddShoppingCenter(i, new[] { "1", i.ToString() });

            ss.AddRoad(1, 2, 1);
            ss.AddRoad(2, 3, 2);
            ss.AddRoad(1, 3, 1);
            ss.AddRoad(3, 4, 3);
            ss.AddRoad(4, 5, 4);
            ss.AddRoad(2, 5, 2);
            ss.AddRoad(4, 7, 7);
            ss.AddRoad(4, 8, 4);
            ss.AddRoad(7, 8, 7);
            return ss;
        }
    }
}