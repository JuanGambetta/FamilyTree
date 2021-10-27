using System;

namespace Library
{
    public class SumaEdades : IVisitor
    {
        public int total = 0;
        public void Visit(Node node)
        {
            foreach(Node children in node.Children)
            {
                total += children.Edad;
            }
            Console.WriteLine($"El total de edades de los hijos de ermenegildo es {total}");
        }
    }
}