using System.Collections.Generic;

namespace CombateMarcial
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Vida { get; private set; }
        public List<ArteMarcial> ArtesMarciales { get; private set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Vida = 200;
            ArtesMarciales = new List<ArteMarcial>();
        }

        public void ReasignarArtes(List<ArteMarcial> nuevas)
        {
            ArtesMarciales = nuevas;
        }

        public void Reiniciar()
        {
            Vida = 200;
        }

        public List<Golpe> GenerarCombo(bool usuario, ArteMarcial arte = null)
        {
            var random = new Random();
            var combo = new List<Golpe>();
            var origen = arte != null ? arte.Golpes : TodasLosGolpes();

            int cantidad = random.Next(3, 7); // de 3 a 6 golpes
            for (int i = 0; i < cantidad; i++)
            {
                combo.Add(origen[random.Next(origen.Count)]);
            }
            return combo;
        }

        public void AplicarCombo(List<Golpe> combo, Jugador oponente, Bitacora bitacora)
        {
            foreach (var golpe in combo)
            {
                oponente.Vida -= golpe.Danio;
                bitacora.Agregar($"{Nombre} usó {golpe.Nombre} causando {golpe.Danio} de daño");
            }
        }

        private List<Golpe> TodasLosGolpes()
        {
            var lista = new List<Golpe>();
            foreach (var arte in ArtesMarciales)
            {
                lista.AddRange(arte.Golpes);
            }
            return lista;
        }
    }
}
