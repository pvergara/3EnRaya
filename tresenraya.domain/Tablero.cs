

namespace tresenraya.domain
{
   public class Tablero
    {
       private string [] _tablero;
       public Tablero() {
           _tablero = new [] {"","",""};
       }
        public void addFicha(string ficha, int columna)
        {

            _tablero[columna] = ficha;   
        }

        public string getCelda(int fila, int columna)
        {
            return _tablero[columna];
        }
    }
}
