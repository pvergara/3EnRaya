using System;
using Xunit;

namespace tresenraya.domain.test
{
    public class PosicionSpec
    {
        [Fact]
        public void como_se_crea_una_posicion()
        {
            const int fila = 0;
            const int columna = 1;
            var posicion = new Posicion(fila, columna);

            Assert.NotNull(posicion);
            Assert.IsType<Posicion>(posicion);
        }

        [Fact]
        public void no_puedo_crear_una_posicion_fuera_del_rango_permitido()
        {
           var opciones = OpcionesDelJuego.GetOpcionesDelJuego();

           Assert.Throws<ArgumentException>(() => new Posicion(opciones.RangoFilaColumna, 0));
           Assert.Throws<ArgumentException>(() => new Posicion(0, opciones.RangoFilaColumna));
        }

        [Fact]
        public void dos_objetos_posicion_son_iguales_si_coinciden_la_fila_y_la_columna()
        {
            var posicion1 = new Posicion(0, 0);
            var posicion2 = new Posicion(0, 0);
            
            Assert.Equal(posicion1,posicion2);
            Assert.True(posicion1.Equals(posicion2));
        }

    }
}
