namespace tresenraya.domain
{
    public class Posicion
    {
        private readonly byte _fila;
        private readonly byte _columna;

        public Posicion(byte fila, byte columna)
        {
            _fila = fila;
            _columna = columna;
        }

        public int Fila
        {
            get {
                return _fila;
            }
        }

        public int Columna
        {
            get {
                return _columna;
            }
        }
    }
}