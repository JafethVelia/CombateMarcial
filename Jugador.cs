using System;
using System.Collections.Generic;
using System.Linq;

namespace CombateMarcial
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int Vida { get; set; } = 200;
        public List<ArteMarcial> ArtesMarciales { get; private set; }

        private Random random = new Random();

        public Jugador(string nombre)
        {
            Nombre = nombre;
            ArtesMarciales = new List<ArteMarcial>();
        }

        public void ReasignarArtes(List<ArteMarcial> nuevas)
        {
            ArtesMarciales = nuevas;
        }

        public List<Golpe> GenerarCombo(bool manual, ArteMarcial arteManual = null)
        {
            int cantidad = random.Next(3, 7); // 3 a 6 golpes

            if (manual)
            {
                return Enumerable.Range(0, cantidad)
                    .Select(_ => arteManual.Golpes[random.Next(arteManual.Golpes.Count)])
                    .ToList();
            }
            else
            {
                return Enumerable.Range(0, cantidad)
                    .Select(_ =>
                    {
                        var arte = ArtesMarciales[random.Next(ArtesMarciales.Count)];
                        return arte.Golpes[random.Next(arte.Golpes.Count)];
                    })
                    .ToList();
            }
        }

        public void AplicarCombo(List<Golpe> combo, Jugador oponente, Bitacora bitacora)
        {
            foreach (var golpe in combo)
            {
                int totalDano = golpe.Poder + golpe.DanoExtra;
                oponente.Vida -= totalDano;

                string log = $"{Nombre} usó {golpe.Nombre} y causó {totalDano} de daño";

                if (golpe.Cura)
                {
                    int cantidadCurada = golpe.Poder / 2;
                    this.Vida = Math.Min(200, this.Vida + cantidadCurada);
                    log += $" (curó {cantidadCurada})";
                }

                if (golpe.DanoExtra > 0)
                {
                    log += $" (daño extra: {golpe.DanoExtra})";
                }

                bitacora.Agregar(log);
            }
        }

        public void Reiniciar()
        {
            Vida = 200;
        }
    }
}
