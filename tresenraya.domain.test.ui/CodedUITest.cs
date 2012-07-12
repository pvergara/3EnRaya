using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    /// <summary>
    /// Descripción resumida de CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest
    {
        public CodedUITest()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
            // Para obtener más información sobre el código generado, vea http://go.microsoft.com/fwlink/?LinkId=179463
            this.UIMap.RecordedMethodNuevaPartida();
            this.UIMap.AssertMethodNuevaPartida();
        }

        #region Atributos de prueba adicionales

        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:

        ////Use TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
        //    // Para obtener más información sobre el código generado, vea http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup para ejecutar el código después de ejecutar cada prueba
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
        //    // Para obtener más información sobre el código generado, vea http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
