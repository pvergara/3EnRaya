using System;

namespace tresenraya.domain
{
    public class Turno
    {
        private Fichas _fichaActual;

        public Turno()
        {
            _fichaActual = Fichas.Aspa;
        }

        public Fichas GetFichaActual()
        {
            var resultado = _fichaActual;

            if (_fichaActual == Fichas.Aspa)
                _fichaActual = Fichas.Circulo;
            else
                _fichaActual = Fichas.Aspa;

            return resultado;
        }

        public void ReiniciarPartida()
        {
            _fichaActual = Fichas.Aspa;
        }
    }
}