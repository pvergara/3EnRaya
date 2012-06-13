using System;

namespace tresenraya.domain
{
   public class Tablero
   {
       private Fichas? _ultimaFicha; 
       private const int size = 3;
       private readonly Fichas? [,] _tablero =new Fichas?[size,size];

       public int GetNumeroFichas()
       {
           int numFichas = 0;
           for (int i = 0; i < size; i++)
               for (int j = 0; j < size; j++)
                   if (_tablero[i, j] !=null)
                       numFichas++;
           return numFichas;
       }

       public Fichas? GetFicha(int x, int y)
       {
           return _tablero[x,y];
       }

       public void AddFicha(Fichas ficha, int x, int y)
       {
           if (ficha == _ultimaFicha)
           {               
               throw new InvalidOperationException("No se pueden añadir dos fichas seguidas.");
           }          

           if (_tablero[x, y] != null)
               throw new InvalidOperationException("Ya existe una ficha en esa posici�n.");
           
           _tablero[x,y] = ficha;
           _ultimaFicha = ficha;
       }

       public int GetNumeroFichas(Fichas fichas)
       {
           int numFichas = 0;
           for (int i = 0; i < size; i++)
               for (int j = 0; j < size; j++)
                   if (_tablero[i, j] != fichas)
                       numFichas++;
           return numFichas;
       }

       public Fichas? GetGanador()
       {
           Fichas? fichaEncontrada = null;
           int numVeces = 0;

           //Comprobamos por filas
           for (int i = 0; i < size; i++)
           {
               fichaEncontrada = null;
               numVeces = 0;

               for (int j = 0; j < size; j++)
               {
                   //Si hay una casilla vacia, o el tipo de ficha no coincide con la anteriore, saltamos a la siguiente fila a comprobar.
                   if (_tablero[i, j] == null || fichaEncontrada != null && _tablero[i, j] != fichaEncontrada)
                       break;

                   numVeces++;
                   fichaEncontrada = _tablero[i, j];
               }
               if (numVeces == size)
                   return fichaEncontrada;
           }

           //Comprobamos por columnas
           for (int j = 0; j < size; j++)
           {
               fichaEncontrada = null;
               numVeces = 0;

               for (int i = 0; i < size; i++)
               {
                   //Si hay una casilla vacia, o el tipo de ficha no coincide con la anteriore, saltamos a la siguiente columna a comprobar.
                   if (_tablero[i, j] == null || fichaEncontrada != null && _tablero[i, j] != fichaEncontrada)
                       break;

                   numVeces++;
                   fichaEncontrada = _tablero[i, j];
               }
               if (numVeces == size)
                   return fichaEncontrada;
           }

           //Primera Diagonal
           fichaEncontrada = null;
           numVeces = 0;
           for (int i = 0; i < size; i++)
           {  
                   //Si hay una casilla vacia, o el tipo de ficha no coincide con la anteriore, saltamos a la siguiente fila a comprobar.
                   if (_tablero[i, i] == null || fichaEncontrada != null && _tablero[i, i] != fichaEncontrada)
                       break;

                   numVeces++;
                   fichaEncontrada = _tablero[i, i];
           }

           if (numVeces == size)
              return fichaEncontrada;
           
           //Segunda Diagonal
           fichaEncontrada = null;
           numVeces = 0;
           for (int i = 0; i < size; i++)
           {  
                   //Si hay una casilla vacia, o el tipo de ficha no coincide con la anteriore, saltamos a la siguiente fila a comprobar.
                   if (_tablero[i, size-1-i] == null || fichaEncontrada != null && _tablero[i, size-1-i] != fichaEncontrada)
                       break;

                   numVeces++;
                   fichaEncontrada = _tablero[i, size - 1 - i];
           }

           if (numVeces == size)
              return fichaEncontrada;
           
           return null;
       }

       private Fichas _ficha;
       public Tablero Add(Fichas ficha)
       {
           _ficha = ficha;
           return this;

           var servicioMock = new Mock<ServicioWeb1>();
           servicioMock.
               SetUp(sm => sm.MetodoDelServicio(1)).
               Returns(3);
       }

       public void En(Posicion posicion)
       {
           AddFicha(_ficha, posicion.Fila, posicion.Columna);
       }
   }

}
