using System.Collections.Generic;

namespace tresenraya.wpf.ui.test
{
    public class Servicio : IServicio
    {
        public IEnumerable<string> ObtenerDatosMaestros()
        {
            return new []{"perico"};            
        }
    }
}