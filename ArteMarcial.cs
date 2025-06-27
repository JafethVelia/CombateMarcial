using System.Collections.Generic;

namespace CombateMarcial
{
    public class ArteMarcial
    {
        public string Nombre { get; set; }
        public List<Golpe> Golpes { get; set; }

        public ArteMarcial(string nombre, List<Golpe> golpes)
        {
            Nombre = nombre;
            Golpes = golpes;
        }
    }
}
