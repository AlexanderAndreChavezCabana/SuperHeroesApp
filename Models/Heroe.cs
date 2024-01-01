using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {
        public abstract string Nombre { get; set; }

        public abstract string NombreEIdentidadSecreta { get; }
        public abstract string SalvarElMundo(); // Cuando no es marcado como abstracto no se necesita instanciar en el principal

        public virtual string SalvarLaTierra()
        {
            return $"{Nombre} ha salvado la tierra";
        }

        public virtual string UsarPoderes()
        {
            return $"{ NombreEIdentidadSecreta } Nombre e Identidad";
        }
    }
}
