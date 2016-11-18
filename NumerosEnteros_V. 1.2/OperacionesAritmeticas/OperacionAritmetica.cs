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

        public int Sumar(int num1, int num2)
         {
            
            int sum = 0, a=num1, b=   num2;
            sum = a + b;
            return sum;
            
               
         }

        public int Restar(int num1, int num2)
        {

            int res = 0, a = num1, b = num2;
            res = a - b;
            return res;
        }

        public int Multiplica(int num1, int num2)
        {

            int mult = 0, a = num1, b = num2;
            mult = a*b;
            return mult;
        }
        public int Division(int num1, int num2)
        {

            int div = 0, a = num1, b = num2;
            div = a / b;
            return div;
        }

        //public double RaizCuadrada(double num1)
        //{
        //    double raiz =0;
        //    raiz = Math.Sqrt(num1);
        //    return raiz;
           
        //}
        public int RaizCubica(int num1)
        {

            int r3 = 0;
            r3 = num1 ^ (1 / 3);
            return r3;
        } 
                
         public int Subtract(int numberToSubtract, int subtractFrom)
         {
             return 0;
         }


    }
}
