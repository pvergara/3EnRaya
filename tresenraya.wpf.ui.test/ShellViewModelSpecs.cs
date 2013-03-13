﻿using NUnit.Framework;
using tresenraya.domain;
using tresenraya.wpf.ui.Views;

namespace tresenraya.wpf.ui.test
{
    [TestFixture]
    public class ShellViewModelSpecs
    {
        [Test]
        public void init()
        {
            var shellViewModel = new ShellViewModel();

            Assert.AreEqual(0, shellViewModel.Tablero.GetNumeroFichas());

            Assert.AreEqual(Fichas.Aspa, shellViewModel.Turno.GetFichaActual());
        }

        [Test]
        public void si_empiezo_a_jugar_y_pulso_sobre_iniciar_partida_esta_vuelve_al_estado_inicial()
        {
            //Arrange
            var shellViewModel = new ShellViewModel();
            //TODO PASAR A COMANDO
            var fichaActual = shellViewModel.Turno.GetFichaActual();
            shellViewModel.Tablero.AddFicha(fichaActual, new Posicion(0, 0));

            Assert.AreNotEqual(0, shellViewModel.Tablero.GetNumeroFichas());
            Assert.AreNotEqual(Fichas.Circulo, fichaActual);

            //Action
            shellViewModel.IniciarNuevaPartida();

            //Assert
            Assert.AreEqual(0, shellViewModel.Tablero.GetNumeroFichas());
            Assert.AreEqual(Fichas.Aspa, shellViewModel.Turno.GetFichaActual());
        }

        [Test]
        public void si_añado_una_ficha_en_la_posicion_00_se_situa_en_la_posicion_00_la_ficha_aspa()
        {
            //Arrange
            var shellViewModel = new ShellViewModel();
            var posicion = new Posicion(0, 0);
            shellViewModel.Tablero.AddFicha(Fichas.Aspa, posicion);

            //Action
            var ficha = shellViewModel.Tablero.GetFicha(posicion);

            //Assert
            Assert.AreEqual(Fichas.Aspa, ficha);

        }
    }
}