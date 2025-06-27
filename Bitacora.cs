using System.Collections.Generic;

namespace CombateMarcial
{
    public class Bitacora
    {
        public List<string> Registro { get; private set; }
        private static Bitacora instancia;

        private Bitacora()
        {
            Registro = new List<string>();
        }

        public static Bitacora Instancia => instancia ??= new Bitacora();

        public void Agregar(string texto)
        {
            Registro.Add(texto);
        }

        public void Reiniciar()
        {
            Registro.Clear();
        }
    }
}
