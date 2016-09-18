﻿using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphsLib.Test.Unit
{
    [TestClass]
    public class DepthFirstSearchTest
    {
        [TestMethod]
        public void DFS()
        {
            string filePath = @"..\..\..\Algorithms_SedgewickWayne\GraphsLib\Txt\TinyG.txt";
            //string filePath = @"..\..\..\Algorithms_SedgewickWayne\GraphsLib\Txt\MediumG.txt";
            //string filePath = @"..\..\..\Algorithms_SedgewickWayne\GraphsLib\Txt\LargeG.txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);
            var g = new Graph(lines);
            int[] edge = Array.ConvertAll(lines[2].Split(' '), int.Parse);

            var dfs = new DepthFirstSearch(g, edge[0]);
            for (int v = 0; v < g.V; v++)
            {
                if(dfs.Marked(v))
                    Console.Write($"{v} ");
            }
            Console.WriteLine();
            if(g.E != dfs.Count)
                Console.WriteLine("not connected");
            else
                Console.WriteLine("connected");
        }
    }
}
