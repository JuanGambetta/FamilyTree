using System;

namespace Library
{
    public class NombreMasLargo : IVisitor
    {
        public void Visit(Node node)
        {
            int maslargo = 0;
            string nombrelargo = null;
            foreach(Node node1 in node.Children)
            {
                if (node1.Nombre.Length > maslargo)
                {
                    maslargo = node1.Nombre.Length;
                    nombrelargo = node1.Nombre;
                }
            }
            Console.WriteLine($"La persona con el nombre mas largo es {nombrelargo}");
        }
    }
}