using Xunit;

namespace tresenraya.domain.test
{
    public class JuegoSpecs
    {

        //Red Geen Refactor
        [Fact]
        public void al_iniciar_el_juego_se_inicia_el_tablero_y_el_turno()
        {
            //Arrange
             

            //Act
            var juego = new Juego();


            //limbo
            var turno = juego.Turno;
            var tablero = juego.Tablero;

            //Assert: Comprobar el estado inicial del turno
            var fichaActual = turno.GetFichaActual();
            Assert.Equal(Fichas.Aspa,fichaActual);

            //Assert: Comprobar el estado inicial del tablero
            Assert.Equal(0, tablero.GetNumeroFichas());
        }

        //Red Geen Refactor
        [Fact]
        public void al_jugar_y_pedir_una_nueva_partida_se_vuelven_a_iniciar_el_tablero_y_el_turno()
        {
            //Arrange
            var juego = new Juego();
            var turno = juego.Turno;
            var tablero = juego.Tablero;

            //jugar!!!!
            var ficha = turno.GetFichaActual();
            tablero.AddFicha(ficha, new Posicion(0, 0));
            var fichaAntesDeNuevaPartida = turno.GetFichaActual();
            var numeroDeFichasAntesDeNuevaPartida = tablero.GetNumeroFichas();

            //Act
            juego.NuevaPartida();


            //limbo
            //turno = juego.Turno;
            tablero = juego.Tablero;


            //Assert: Comprobar el estado inicial del turno y que si has jugado la ficha anterior a nueva partida no tiene porqué ser un aspa
            var fichaActual = turno.GetFichaActual();
            Assert.NotEqual(fichaAntesDeNuevaPartida,fichaActual);
            Assert.Equal(Fichas.Aspa, fichaActual);

            //Assert: Comprobar el estado inicial del tablero
            var numeroDeFichasConPartidaReiniciada = tablero.GetNumeroFichas();
            Assert.True(numeroDeFichasAntesDeNuevaPartida != numeroDeFichasConPartidaReiniciada);
            Assert.Equal(0, numeroDeFichasConPartidaReiniciada);

        }
    }

}
