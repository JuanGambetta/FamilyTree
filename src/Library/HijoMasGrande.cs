using System;

namespace Library
{
    public class HijoMasGrande : IVisitor
    {
        public void Visit(Node node)
        {
            int maxima = 0;
            foreach(Node node1 in node.Children)
            {
                if (node1.Edad > maxima)
                {
                    maxima = node1.Edad;
                }
            }
            Console.WriteLine($"El hijo mas grande es el que tiene {maxima}");
        }
    }
}