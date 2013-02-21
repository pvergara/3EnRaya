using System;
using Caliburn.Micro;
using tresenraya.domain;

namespace tresenraya.wpf.ui.Views
{
    public class ShellViewModel : Screen
    {
        private Juego _juego;

        public ShellViewModel()
        {
            _juego = new Juego();
            Tablero = _juego.Tablero;
        }

        public Tablero Tablero { get; set; }

        public void IniciarNuevaPartida()
        {
            _juego.NuevaPartida();
            Tablero = _juego.Tablero;
        }
    }
}