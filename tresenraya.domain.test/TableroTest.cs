using System;
using Xunit;

namespace tresenraya.domain.test
{
    public class TableroTest
    {
        [Fact]
        public void si_inicio_el_tablero_este_no_tiene_fichas()
        {
            Tablero tablero = new Tablero();
            Assert.Equal(0, tablero.GetNumeroFichas());
        }
        
        [Fact]
        public void si_añado_una_ficha_a_un_tablero_iniciado_este_contendra_una_ficha_en_la_posicion_indicada()
        {
            const Fichas ficha = Fichas.Aspa;
            Tablero tablero = new Tablero();
            
            tablero.AddFicha(ficha,0,2);
           
            Assert.Equal(1,tablero.GetNumeroFichas());
            Assert.Equal(ficha,tablero.GetFicha(0,2));
        }

        [Fact]
        public void si_existe_una_ficha_en_una_posicion_no_se_puede_poner_otra()
        {
            Tablero tablero = new Tablero();
            tablero.AddFicha(Fichas.Aspa, 0, 0);
            Assert.Throws<InvalidOperationException>(
                delegate
                    {
                        tablero.AddFicha(Fichas.Circulo, 0, 0);
                    });
        }

        [Fact]
        public void diferencia_entre_los_dos_tipos_de_fichas_sobre_el_tablero_siempre_es_cero_o_uno()
        {
            Tablero tablero=new Tablero();
            tablero.AddFicha(Fichas.Aspa,0,0);
            Assert.Equal(1,Math.Abs(tablero.GetNumeroFichas(Fichas.Aspa)-tablero.GetNumeroFichas(Fichas.Circulo)));
            tablero.AddFicha(Fichas.Circulo,0,1);
            Assert.Equal(0, Math.Abs(tablero.GetNumeroFichas(Fichas.Aspa) - tablero.GetNumeroFichas(Fichas.Circulo)));  
        }

        [Fact]
        public void si_todas_las_fichas_de_misma_fila_son_iguales_ganan_esas_fichas()
        {
            Tablero tablero = new Tablero();

            tablero.AddFicha(Fichas.Aspa, 0, 0);
            tablero.AddFicha(Fichas.Aspa, 0, 1);
            Assert.Equal(null, tablero.GetGanador());
            tablero.AddFicha(Fichas.Aspa, 0, 2);
            Assert.Equal(Fichas.Aspa, tablero.GetGanador());
        }
        
        [Fact]
        public void si_todas_las_fichas_de_misma_columna_son_iguales_ganan_esas_fichas()
        {
            Tablero tablero = new Tablero();

            tablero.AddFicha(Fichas.Aspa, 1, 0);
            tablero.AddFicha(Fichas.Aspa, 1, 1);
            Assert.Equal(null, tablero.GetGanador());
            tablero.AddFicha(Fichas.Aspa, 1, 2);
            Assert.Equal(Fichas.Aspa, tablero.GetGanador());   
        }

        [Fact]
        public void si_todas_las_fichas_de_misma_diagonal_son_iguales_ganan_esas_fichas()
        {
            Tablero tablero = new Tablero();

            tablero.AddFicha(Fichas.Aspa, 0, 2);
            tablero.AddFicha(Fichas.Aspa, 1, 1);
            Assert.Equal(null, tablero.GetGanador());
            tablero.AddFicha(Fichas.Aspa, 2, 0);
            Assert.Equal(Fichas.Aspa, tablero.GetGanador());
        }


    }
}
