namespace tresenraya.domain
{
    public class Juego
    {
        public Juego()
        {
            Turno = new Turno();
            Tablero = new Tablero();
        }

        public Turno Turno { get; private set; }
        public Tablero Tablero { get; private set; }

        public void NuevaPartida()
        {
            Turno.ReiniciarPartida();
            Tablero = new Tablero();
        }
    }
}