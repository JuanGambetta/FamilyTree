using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        private string nombre;
        private int edad;
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string Nombre {
            get
            {
                return this.nombre;
            }
        }

        public int Edad {
            get
            {
                return this.edad;
            }
        }

    }
}