using System;

namespace tresenraya.domain
{
    public class Posicion
    {
        private readonly byte _fila;
        private readonly byte _columna;
        private readonly OpcionesDelJuego _opcionesDelJuego;

        public int Fila { get { return _fila; } }
        public int Columna { get { return _columna; } }

        public Posicion(byte fila, byte columna)
        {
            _opcionesDelJuego = OpcionesDelJuego.GetOpcionesDelJuego();

            if (fila >= _opcionesDelJuego.RangoFilaColumna || columna >= _opcionesDelJuego.RangoFilaColumna)
                throw new ArgumentException("No se permiten posiciones fuera de rango");
            _fila = fila;
            _columna = columna;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Posicion);
        }

        public bool Equals(Posicion other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._fila == _fila && other._columna == _columna;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_fila.GetHashCode()*397) ^ _columna.GetHashCode();
            }
        }
    }
}