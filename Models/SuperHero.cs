using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe, ISuperHero
    {
        private string _Nombre;
        public int Id { get; set; }
        public override string Nombre 
        { get 
            {
                return _Nombre;
            }

          set
            {
                _Nombre = value.Trim();
            }
        }
        
        public override string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }

        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        //public string[] SuperPoderes;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe() // El constructor lleva el mismo nombre que el de la clase del constructor se utiliza en la construccion del objeto,
                            // # el constructor se ejecuta cuando se instancia con NEW
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        //public void UserSuperPoderes()
        //{
        //    foreach ( var item in SuperPoderes)
        //    {
        //        Console.WriteLine($"{Nombre} esta usando el super poder { item.Nombre }!!");
        //    }
        //}
        public string UserSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var superPoder in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder {superPoder.Nombre}");
                //Console.WriteLine($"{Nombre} esta usando el super poder {superPoder.Nombre}");
            }

            return sb.ToString();
        }




        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";    
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }

        public override string UsarPoderes()
        {
            //return base.UsarPoderes();
            return $"{Nombre} Nombre desde SuperHero";
        }
    }
}
