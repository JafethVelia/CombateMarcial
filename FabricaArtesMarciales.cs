using System.Collections.Generic;

namespace CombateMarcial
{
    public static class FabricaArtesMarciales
    {
        public static List<ArteMarcial> CrearArtes()
        {
            return new List<ArteMarcial>
            {
                new ArteMarcial("Karate", new List<Golpe>
                {
                    new Golpe("Puño recto", 20),
                    new Golpe("Patada circular", 25, true),        // cura
                    new Golpe("Golpe descendente", 30, false, 10)  // daño extra
                }),
                new ArteMarcial("Taekwondo", new List<Golpe>
                {
                    new Golpe("Patada frontal", 22),
                    new Golpe("Patada giratoria", 28, false, 12),
                    new Golpe("Golpe de talón", 26, true)
                }),
                new ArteMarcial("Muay Thai", new List<Golpe>
                {
                    new Golpe("Codo cruzado", 30),
                    new Golpe("Rodillazo", 35, false, 10),
                    new Golpe("Patada baja", 20, true)
                }),
                new ArteMarcial("Kung Fu", new List<Golpe>
                {
                    new Golpe("Palm strike", 25),
                    new Golpe("Golpe de grulla", 30, false, 8),
                    new Golpe("Patada del tigre", 27, true)
                }),
                new ArteMarcial("Boxeo", new List<Golpe>
                {
                    new Golpe("Jab", 18),
                    new Golpe("Uppercut", 30, false, 10),
                    new Golpe("Gancho", 24, true)
                }),
                new ArteMarcial("Jiu Jitsu", new List<Golpe>
                {
                    new Golpe("Palanca de brazo", 30),
                    new Golpe("Luxación", 28, false, 12),
                    new Golpe("Estrangulación", 32, true)
                }),
                new ArteMarcial("Capoeira", new List<Golpe>
                {
                    new Golpe("Meia Lua", 24),
                    new Golpe("Rabo de Arraia", 29, true),
                    new Golpe("Armada", 25, false, 10)
                }),
                new ArteMarcial("Krav Maga", new List<Golpe>
                {
                    new Golpe("Rodillazo al torso", 30),
                    new Golpe("Golpe ocular", 25, false, 15),
                    new Golpe("Codazo", 28, true)
                }),
                new ArteMarcial("Savate", new List<Golpe>
                {
                    new Golpe("Chassé", 23),
                    new Golpe("Fouetté", 26, true),
                    new Golpe("Revers", 27, false, 9)
                }),
                new ArteMarcial("Kickboxing", new List<Golpe>
                {
                    new Golpe("Low kick", 24),
                    new Golpe("High kick", 30, false, 10),
                    new Golpe("Hook", 25, true)
                }),
            };
        }
    }
}
