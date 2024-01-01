using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{

    class Habitat
    {
        public int Id;
        public string Nombre;
        public string Descripcion;
        public TipoHabitat TipoHabitat;
    }

    enum TipoHabitat
    {
        Terrestre,
        Acuatico,
        Maritimo
    }

}
