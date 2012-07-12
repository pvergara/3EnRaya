namespace tresenraya.domain
{
    public class OpcionesDelJuego
    {
        private static OpcionesDelJuego _opcionesDelJuego;

        public byte RangoFilaColumna
        {
            get { return 3; }
        }

        public static OpcionesDelJuego GetOpcionesDelJuego()
        {
            if(_opcionesDelJuego==null)
                _opcionesDelJuego = new OpcionesDelJuego();
            
            return _opcionesDelJuego;
        }
    }
}