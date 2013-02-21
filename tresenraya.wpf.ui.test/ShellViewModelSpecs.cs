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
        }

        [Fact]
        public void BotonIniciarPartida()
        {
            //Arrange
            var shellViewModel = new ShellViewModel();
            //TODO PASAR A COMANDO
            shellViewModel.Tablero.AddFicha(Fichas.Circulo, new Posicion(0, 0));
            Assert.NotEqual(0, shellViewModel.Tablero.GetNumeroFichas());

            //Action
            shellViewModel.IniciarNuevaPartida();

            //Assert
            Assert.Equal(0, shellViewModel.Tablero.GetNumeroFichas());
        }
    }
}
