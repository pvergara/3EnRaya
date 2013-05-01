using System;
using System.Collections.Generic;
using Caliburn.Micro;
using tresenraya.domain;

namespace tresenraya.wpf.ui.Views
{
    public class ShellViewModel : Screen
    {
        private readonly Juego _juego;
        private readonly byte _rangoFilaColumna;

        public ShellViewModel()
        {
            _juego = new Juego();
            Tablero = _juego.Tablero;
            Turno = _juego.Turno;
            _rangoFilaColumna = OpcionesDelJuego.GetOpcionesDelJuego().RangoFilaColumna;
            var dimension = _rangoFilaColumna * _rangoFilaColumna;
            EstadosTablero = new List<Boolean>(dimension);
            IniciarEstadosTablero();
        }

        private void IniciarEstadosTablero()
        {
            int dimension = _rangoFilaColumna * _rangoFilaColumna;
            EstadosTablero.Clear();
            for (var i = 0; i < dimension; i++)
            {
                EstadosTablero.Add(true);
            }
        }

        public Tablero Tablero { get; set; }

        public Turno Turno { get; private set; }

        public IList<Boolean> EstadosTablero { get; private set; }

        public void IniciarNuevaPartida()
        {
            _juego.NuevaPartida();
            Tablero = _juego.Tablero;
            IniciarEstadosTablero();
        }

        public void AnhadirFicha(byte fila, byte columna)
        {
            var fichaActual = Turno.GetFichaActual();
            Tablero.AddFicha(fichaActual, new Posicion(fila, columna));
            EstadosTablero[columna+(fila*_rangoFilaColumna)] = false;

        }
    }
}