namespace CombateMarcial
{
    public class Golpe
    {
        public string Nombre { get; set; }
        public int Poder { get; set; }
        public bool Cura { get; set; } = false;
        public int DanoExtra { get; set; } = 0;

        public Golpe(string nombre, int poder)
        {
            Nombre = nombre;
            Poder = poder;
        }

        public Golpe(string nombre, int poder, bool cura)
        {
            Nombre = nombre;
            Poder = poder;
            Cura = cura;
        }

        public Golpe(string nombre, int poder, bool cura, int danoExtra)
        {
            Nombre = nombre;
            Poder = poder;
            Cura = cura;
            DanoExtra = danoExtra;
        }
    }
}
