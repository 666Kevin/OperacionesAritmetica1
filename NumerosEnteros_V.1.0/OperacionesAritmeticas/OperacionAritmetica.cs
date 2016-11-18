using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
namespace OperacionesAritmeticas
{
      
    
    public class OperacionAritmetica
    {
        public int maximoComunDivisor(int num1, int num2)
        {
            int mcd = 0;
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
              do
                  {
                    mcd = b;
                    b = a % b;
                    a = mcd;
                    } while (b != 0);
                    return mcd;
            
            
        }

   
         public int minimoComunMultiplo(int num1, int num2)
                 
         {
              int mcm = 0;
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
            mcm = (a / maximoComunDivisor(a, b)) * b;
            return mcm;




        }
         
         public int Subtract(int numberToSubtract, int subtractFrom)
         {
             return 0;
         }
    }
}
