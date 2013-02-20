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
    }
}
