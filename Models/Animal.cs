using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class Animal
    {
        private string _Nombre;
        public int Id;
        public string Nombre 
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }
        }
        public double Tamanio;
        public List<Familia> Familia;
        public List<Habitat> Habitat;

        public Animal()
        {
            Id = 1;
            Nombre = "León";
            Tamanio = 2.0;
        }

        public string AnimalHabitat()
        {
            StringBuilder sb = new StringBuilder();
            foreach ( var hab in Habitat )
            {
                sb.AppendLine($"{Nombre} vive en la {hab.Nombre}");
                //Console.WriteLine($"{ Nombre } vive en la { hab.Nombre }");
            }

            return sb.ToString();
        }


    }

}
