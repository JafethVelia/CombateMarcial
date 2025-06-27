using System;
using System.Linq;
using System.Windows;
using System.Collections.Generic;

namespace CombateMarcial
{
    public partial class MainWindow : Window
    {
        private Jugador jugador1;
        private Jugador jugador2;
        private List<ArteMarcial> todas;

        public MainWindow()
        {
            InitializeComponent();
            todas = FabricaArtesMarciales.CrearArtes();
            jugador1 = new Jugador("Player 1");
            jugador2 = new Jugador("Player 2");
            AsignarArtes(jugador1);
            AsignarArtes(jugador2);
            ComboArtesP1.SelectionChanged += ComboArtesP1_SelectionChanged;
            Refrescar();
        }

        private void AsignarArtes(Jugador jugador)
        {
            var random = new Random();
            jugador.ReasignarArtes(todas.OrderBy(x => random.Next()).Take(3).ToList());
        }

        private void Refrescar()
        {
            VidaP1.Text = $"{jugador1.Vida} de 200";
            VidaP2.Text = $"{jugador2.Vida} de 200";
            ComboArtesP1.ItemsSource = jugador1.ArtesMarciales.Select(a => a.Nombre);
            ListaGolpesP1.ItemsSource = null;
            ListaGolpesP2.ItemsSource = null;
        }

        private void BtnReasignarP1_Click(object sender, RoutedEventArgs e)
        {
            AsignarArtes(jugador1);
            Refrescar();
        }

        private void BtnReasignarP2_Click(object sender, RoutedEventArgs e)
        {
            AsignarArtes(jugador2);
            Refrescar();
        }

        private void BtnGenerarCombo_Click(object sender, RoutedEventArgs e)
        {
            if (ComboArtesP1.SelectedItem is null)
            {
                MessageBox.Show("Seleccione un arte marcial");
                return;
            }

            string seleccion = ComboArtesP1.SelectedItem.ToString();
            ArteMarcial arte = jugador1.ArtesMarciales.First(a => a.Nombre == seleccion);

            var combo1 = jugador1.GenerarCombo(true, arte);
            var arteP2 = jugador2.ArtesMarciales[new Random().Next(jugador2.ArtesMarciales.Count)];
            TextoArteP2.Text = arteP2.Nombre;
            var combo2 = jugador2.GenerarCombo(true, arteP2);  // mismo método que el P1


            ListaGolpesP1.ItemsSource = combo1.Select(g => g.Nombre);
            ListaGolpesP2.ItemsSource = combo2.Select(g => g.Nombre);

            jugador1.AplicarCombo(combo1, jugador2, Bitacora.Instancia);
            jugador2.AplicarCombo(combo2, jugador1, Bitacora.Instancia);

            BitacoraLista.ItemsSource = null;
            BitacoraLista.ItemsSource = Bitacora.Instancia.Registro;

            Refrescar();

            if (jugador1.Vida <= 0 || jugador2.Vida <= 0)
            {
                string ganador = jugador1.Vida > jugador2.Vida ? "Player 1" : "Player 2";
                MessageBox.Show($"Ganó {ganador}!");
                jugador1.Reiniciar();
                jugador2.Reiniciar();
                // Bitacora.Instancia.Reiniciar();  // Lo comentamos para no borrar la bitácora
                AsignarArtes(jugador1);
                AsignarArtes(jugador2);
                Refrescar();
            }
        }

        private void BtnAtacar_Click(object sender, RoutedEventArgs e)
        {
            BtnGenerarCombo_Click(sender, e);
        }

        private void ComboArtesP1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ComboArtesP1.SelectedItem is string nombre)
            {
                var arte = jugador1.ArtesMarciales.FirstOrDefault(a => a.Nombre == nombre);
                if (arte != null)
                {
                    ListaGolpesP1.ItemsSource = arte.Golpes.Select(g => g.Nombre);
                }
            }
        }
    }
}