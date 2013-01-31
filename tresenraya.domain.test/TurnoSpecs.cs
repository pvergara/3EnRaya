using Xunit;

namespace tresenraya.domain.test
{
    public class TurnoSpecs
    {
        //RED GREEN REFACTOR!!!!!!
        [Fact]
        public void si_empiezo_con_un_turno_la_primera_ficha_es_de_tipo_aspa()
        {
            //Arrange
            var turno = new Turno();

            //Action
            var fichaActual = turno.GetFichaActual();

            //Assert
            Assert.Equal(Fichas.Aspa,fichaActual);
        }

        //RED GREEN REFACTOR!!!!!!
        [Fact]
        public void la_segunda_ficha_es_de_tipo_circulo()
        {
            //Arrange
            var turno = new Turno();
            turno.GetFichaActual();

            //Action
            var fichaActual = turno.GetFichaActual();

            //Assert
            Assert.Equal(Fichas.Circulo, fichaActual);
        }

        //RED GREEN REFACTOR!!!!!!
        [Fact]
        public void la_tercera_ficha_es_de_tipo_aspa()
        {
            //Arrange
            var turno = new Turno();
            turno.GetFichaActual(); //1ª
            turno.GetFichaActual(); //2ª

            //Action
            var fichaActual = turno.GetFichaActual(); //3ª

            //Assert
            Assert.Equal(Fichas.Aspa, fichaActual);
        }

        //RED GREEN REFACTOR!!!!!!
        [Fact]
        public void al_reiniciar_una_partida_la_primera_ficha_VUELVE_a_ser_un_aspa()
        {
            //Arrange
            var turno = new Turno();
         
            //Action
            var fichaActualAntesDeReiniciar = turno.GetFichaActual();
            turno.ReiniciarPartida();
            var fichaActual = turno.GetFichaActual();
            
            //Assert
            Assert.Equal(Fichas.Aspa, fichaActualAntesDeReiniciar);
            Assert.Equal(Fichas.Aspa, fichaActual);
        }
    }
}