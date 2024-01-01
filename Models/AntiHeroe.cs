using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe: SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe( string accion)
        {
            return $"El antiheroe { NombreEIdentidadSecreta } ha realizado { accion }"; // Hereda 'Nombre' de la clase SuperHeroe
        }
    }
}
