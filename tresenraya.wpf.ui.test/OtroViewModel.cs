using System.Collections.Generic;

namespace tresenraya.wpf.ui.test
{
    public class OtroViewModel
    {
        private readonly IServicio _unCampoDeOtraClase;

        public OtroViewModel(IServicio unCampoDeOtraClase)
        {
            _unCampoDeOtraClase = unCampoDeOtraClase;

            //Maestros = _unCampoDeOtraClase.ObtenerDatosMaestros();
        }

        public IEnumerable<string> Maestros { get; set; }

        public IServicio Servicio2 { get; set; }

        public void ObtenerMaestros()
        {
            Servicio2.ObtenerDatosMaestros();
        }
    }
}