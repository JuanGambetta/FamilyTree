using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            */
            Persona Martin = new Persona("Martin",18);
            Persona Martina = new Persona("Martina",20);
            Persona Juan = new Persona("Juan",21);
            Persona Josefina = new Persona("Josefina",18);
            Persona Ermenegildo= new Persona("Ermenegildo",50);
            Persona Jose = new Persona("Jose",35);
            Persona Isabel = new Persona("Isabel",40);
            Persona Pedro = new Persona("Pedro",21);

            Node martin = new Node(Martin);
            Node martina = new Node(Martina);
            Node juan = new Node(Juan);
            Node josefina = new Node(Josefina);
            Node ermenegildo = new Node(Ermenegildo);
            Node jose = new Node(Jose);
            Node isabel = new Node(Isabel);
            Node pedro = new Node(Pedro);

            ermenegildo.AddChildren(juan);
            ermenegildo.AddChildren(pedro);
            ermenegildo.AddChildren(jose);
            ermenegildo.AddChildren(josefina);
            ermenegildo.AddChildren(martina);
            ermenegildo.AddChildren(isabel);
            ermenegildo.AddChildren(martin);


            var sumaEdades = new SumaEdades();
            var hijoMasGrande = new HijoMasGrande();
            var NombreMasLargo = new NombreMasLargo();
            ermenegildo.Accept(sumaEdades);
            ermenegildo.Accept(hijoMasGrande);
            ermenegildo.Accept(NombreMasLargo);
            
        }
    }
}
