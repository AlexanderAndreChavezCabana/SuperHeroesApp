using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHero(ISuperHero superHero)
        {
            Console.WriteLine($"Id: { superHero.Id }");
            Console.WriteLine($"Nombre: { superHero.Nombre }");
            Console.WriteLine($"Identidad Secreta: { superHero.IdentidadSecreta }");
        }
    }
}
