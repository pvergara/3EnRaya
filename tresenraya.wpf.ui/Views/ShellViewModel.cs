using Caliburn.Micro;
using tresenraya.domain;

namespace tresenraya.wpf.ui.Views
{
    public class ShellViewModel : Screen
    {
        private readonly Juego _juego;

        public ShellViewModel()
        {
            _juego = new Juego();
            Tablero = _juego.Tablero;
            Turno = _juego.Turno;
        }

        public Tablero Tablero { get; set; }

        public Turno Turno { get; private set; }

        public void IniciarNuevaPartida()
        {
            _juego.NuevaPartida();
            Tablero = _juego.Tablero;
            //Turno = _juego.Turno;
        }
    }
}