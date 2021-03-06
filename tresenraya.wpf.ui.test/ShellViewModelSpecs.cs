﻿using System.Linq;
using NUnit.Framework;
using tresenraya.domain;
using tresenraya.wpf.ui.Views;

namespace tresenraya.wpf.ui.test
{
    [TestFixture]
    public class ShellViewModelSpecs
    {
        [Test]
        public void CuandoInicioLaPantallaDelJuegoEntoncesElTableroEstaVacioYLosEstadosDelTableroSeranTodosTrueYElTurnoEstaPreparadoParaQueElPrimerJugadorEmpieceConUnAspa()
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

            Assert.IsTrue(shellViewModel.EstadosTablero.Count>0);
            Assert.IsTrue(shellViewModel.EstadosTablero.All(e=>e));
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
        public void DadaUnaPartidaIniciadaConUnMovimientoCuandoPulsoSobreIniciarNuevaPartidaEntoncesElTableroSeReiniciaYElTurnoEsAspaYLosEstadosDelTableroSeranTodosTrue()
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

            Assert.IsTrue(shellViewModel.EstadosTablero.All(e => e));

        }

        [Test]
        public void DadaUnaPartidaIniciadaSinMovimientosCuandoPulsoUnBotonSeDesactivaElBoton()
        {
            //Dada
            var viewModel =new ShellViewModel();
            var posicionCeroCero = 0;

            //Cuando
            viewModel.AnhadirFicha(0,0);

            //Entonces
            Assert.IsFalse(viewModel.EstadosTablero[posicionCeroCero]);
        }


        [Test]
        public void DadaUnaPartidaIniciadaConMovimientosCuandoAnhadoUnaFichaQueCompletaUnaLineaDelMismoTipoEntoncesSeDesactivanTodosLosBotonesDelTableroYSeMuestraUnMensajeIndicandoElGanador()
        {
        }

        [Test]
        public void DadaUnaPartidaIniciadaConMovimientosCuandoAnhadoLaUltimaFichaPosbileYNoHayVencedorSeMuestraUnMensajeDeTablas()
        {
        }
    }
}
