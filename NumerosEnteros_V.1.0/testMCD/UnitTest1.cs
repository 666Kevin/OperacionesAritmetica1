using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperacionesAritmeticas;

namespace testMCD
{
    [TestClass]
    public class testmcd
    {
        [TestMethod]
        public void PruebamMCD()
        {
            int   res;
           bool esperado;
            OperacionAritmetica mcd = new OperacionAritmetica();
           res= mcd.maximoComunDivisor(1,-99999);
          
            if(res>0)
            {
                 esperado = false;
                Assert.AreEqual(res,esperado,"Error: No paso la prueba");
            }
            else
            {

            }
            
        }
    }
}
