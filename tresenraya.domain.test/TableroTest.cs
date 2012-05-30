

using Xunit;
namespace tresenraya.domain.test
{
    public class TableroTest
    {
        private string ficha="*";
        private int columna=0;
        private int fila=2;
        [Fact]
        public void cuando_añado_la_primera_ficha_en_la_primera_columna_esta_se_coloca_en_la_ultima_fila_de_esa_columna() 
        {
            var tablero = new Tablero();
            
            tablero.addFicha(ficha,columna);
            Assert.Equal(ficha,tablero.getCelda(fila,columna));
        }
        [Fact]
        public void cuando_añado_una_segunda_ficha_en_la_segunda_columna_esta_se_coloca_en_la_segunda_columna_de_la_ultima_fila_pero_esta_es_distinta_que_la_primera_ficha() {
        
        
        } 
    }
}
    