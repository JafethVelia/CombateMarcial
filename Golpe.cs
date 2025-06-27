namespace CombateMarcial
{
    public class Golpe
    {
        public string Nombre { get; set; }
        public int Danio { get; set; }

        public Golpe(string nombre, int danio)
        {
            Nombre = nombre;
            Danio = danio;
        }
    }
}
