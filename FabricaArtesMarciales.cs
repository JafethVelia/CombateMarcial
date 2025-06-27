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
                    new Golpe("Gyaku Zuki", 20),
                    new Golpe("Mae Geri", 25),
                    new Golpe("Ushiro Geri", 30)
                }),

                new ArteMarcial("Taekwondo", new List<Golpe>
                {
                    new Golpe("Dollyo Chagi", 22),
                    new Golpe("Ap Chagi", 24),
                    new Golpe("Bandal Chagi", 28)
                }),

                new ArteMarcial("Kung Fu", new List<Golpe>
                {
                    new Golpe("Puño de Tigre", 26),
                    new Golpe("Patada de Grulla", 24),
                    new Golpe("Golpe de Palma", 20)
                }),

                new ArteMarcial("Muay Thai", new List<Golpe>
                {
                    new Golpe("Codo Ascendente", 30),
                    new Golpe("Rodillazo Volador", 35),
                    new Golpe("Low Kick", 25)
                }),

                new ArteMarcial("Jiu Jitsu", new List<Golpe>
                {
                    new Golpe("Llave de brazo", 28),
                    new Golpe("Rear Naked Choke", 32),
                    new Golpe("Guillotina", 26)
                }),

                new ArteMarcial("Boxeo", new List<Golpe>
                {
                    new Golpe("Jab", 18),
                    new Golpe("Cross", 22),
                    new Golpe("Uppercut", 26)
                }),

                new ArteMarcial("Capoeira", new List<Golpe>
                {
                    new Golpe("Meia Lua", 23),
                    new Golpe("Armada", 27),
                    new Golpe("Martelo", 25)
                }),

                new ArteMarcial("Krav Maga", new List<Golpe>
                {
                    new Golpe("Golpe al cuello", 30),
                    new Golpe("Patada a la ingle", 28),
                    new Golpe("Puño directo", 22)
                }),

                new ArteMarcial("Sambo", new List<Golpe>
                {
                    new Golpe("Proyección de cadera", 27),
                    new Golpe("Tackle doble pierna", 29),
                    new Golpe("Llave de tobillo", 25)
                }),

                new ArteMarcial("Jeet Kune Do", new List<Golpe>
                {
                    new Golpe("Intercepting Fist", 28),
                    new Golpe("Backfist", 26),
                    new Golpe("Side Kick", 30)
                })
            };
        }
    }
}
