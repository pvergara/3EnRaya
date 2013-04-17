using System.Linq;
using Moq;
using NUnit.Framework;
using tresenraya.domain;
using tresenraya.wpf.ui.Views;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace tresenraya.wpf.ui.test
{
    [TestFixture]
    public class ShellViewModelSpecs
    {
        [Test]
        public void CuandoInicioLaPantallaDelJuegoEntoncesElTableroEstaVacioYElTurnoEstaPreparadoParaQueElPrimerJugadorEmpieceConUnAspa()
        {
            #region
            //TDD vs BDD
            //-------------
            //Given. Dado un contexto determinado
            //When. Cuando pasa una acción que queremos testear
            //Then. Entonces assert 1
            //Then. Entonces assert 2
            //...
            //Then. Entonces assert N
            #endregion

            #region
            //"".Context(() => { });
            //"Cuando inicio la pantalla del juego".Do(() => { });

            //"El tablero está vacío".Assert(() => { });

            //"YElTurnoEstaPreparadoParaQueElPrimerJugadorEmpieceConUnAspa".Assert(() => { });
            #endregion
            
            var shellViewModel = new ShellViewModel();

            Assert.AreEqual(0, shellViewModel.Tablero.GetNumeroFichas());

            Assert.AreEqual(Fichas.Aspa, shellViewModel.Turno.GetFichaActual());
        }

        [Test]
        public void si_añado_una_ficha_en_la_posicion_00_se_situa_en_la_posicion_00_la_ficha_aspa()
        {
            //Arrange
            var shellViewModel = new ShellViewModel();

            //Action
            shellViewModel.AnhadirFicha(0, 0);

            //Assert
            Assert.AreEqual(Fichas.Aspa, shellViewModel.Tablero.GetFicha(new Posicion(0, 0)));
        }

        [Test]
        public void DadaUnaPartidaIniciadaConUnMovimientoCuandoPulsoSobreIniciarNuevaPartidaEntoncesElTableroSeReiniciaYElTurnoEsAspa()
        {
            //Arrange
            var shellViewModel = new ShellViewModel();
            shellViewModel.AnhadirFicha(0, 0);

            Assert.AreNotEqual(0, shellViewModel.Tablero.GetNumeroFichas());
            Assert.AreNotEqual(Fichas.Circulo, shellViewModel.Tablero.GetFicha(new Posicion(0, 0)));

            //Action
            shellViewModel.IniciarNuevaPartida();

            //Assert
            Assert.AreEqual(0, shellViewModel.Tablero.GetNumeroFichas());
            Assert.AreEqual(Fichas.Aspa, shellViewModel.Turno.GetFichaActual());
        }

        [Fact]
        public void FactMethodName()
        {
            //Arrange
            //var viewModel = new OtroViewModel(new Servicio());
            var mock = new Mock<IServicio>();
            mock.
                Setup(s => s.ObtenerDatosMaestros()).
                Returns(new[] {"perico"});
            var viewModel = new OtroViewModel(mock.Object);
            viewModel.Servicio2 = mock.Object;
           
            //Act
            viewModel.ObtenerMaestros();

            //Asserts
            //Assert.True(viewModel.Maestros.Contains("perico"));

            //Asserts
            mock.Verify(s=>s.ObtenerDatosMaestros(),Times.Once());
        }


    }
}