using tresenraya.domain;
using tresenraya.wpf.ui.Views;
using Xunit;

namespace tresenraya.wpf.ui.test
{
    public class ShellViewModelSpecs
    {
        [Fact]
        public void init()
        {
            var shellViewModel = new ShellViewModel();

            Assert.Equal(0, shellViewModel.Tablero.GetNumeroFichas());
            
            Assert.Equal(Fichas.Aspa, shellViewModel.Turno.GetFichaActual());
        }

        [Fact]
        public void si_empiezo_a_jugar_y_pulso_sobre_iniciar_partida_esta_vuelve_al_estado_inicial()
        {
            //Arrange
            var shellViewModel = new ShellViewModel();
            //TODO PASAR A COMANDO
            var fichaActual = shellViewModel.Turno.GetFichaActual();
            shellViewModel.Tablero.AddFicha(fichaActual, new Posicion(0, 0));

            Assert.NotEqual(0, shellViewModel.Tablero.GetNumeroFichas());
            Assert.NotEqual(Fichas.Circulo, fichaActual);

            //Action
            shellViewModel.IniciarNuevaPartida();

            //Assert
            Assert.Equal(0, shellViewModel.Tablero.GetNumeroFichas());
            Assert.Equal(Fichas.Aspa, shellViewModel.Turno.GetFichaActual());
        }

        [Fact]
        public void si_añado_una_ficha_en_la_posicion_00_se_situa_en_la_posicion_00_la_ficha_aspa()
        {
            
        }
    }
}
