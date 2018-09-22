using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolaciones
{
    class Interpolacion
    {
        
        double fx, er,b0,b1,b2 = 0;
        

        public void calcularInter(int x, int  x0, int x1)
        {
            
            fx = (((Math.Log(x0)) + (Math.Log(x1) - Math.Log(x0)) / (x1 - x0)))*(x - x0);
            er = Math.Abs(((Math.Log(x) - fx) / fx) * 100);
   
        }
        public void lagrange1(int x, int x0, int x1)
        {
            fx = ((x - x1 / x0 - x1) * Math.Log(x0)) 
                + ((x - x0 / x1 - x0) * Math.Log(x1));
            er = Math.Abs(((Math.Log(x) - fx) / fx) * 100);
        }

        public void lagrange2(int x, int x0, int x1, int x2)
        {
            fx = (((x - x1 / x0 - x1) * (x - x2 / x0 - x2)) * Math.Log(x0))
                + (((x - x0 / x1 - x0) * (x - x2 / x1 - x2)) * Math.Log(x1))
                + (((x - x0 / x2 - x0) * (x - x1 / x2 - x1)) * Math.Log(x2));

            er = Math.Abs(((Math.Log(x) - fx) / fx) * 100);
        }

        public void InterCuadratica(int x, int x0, int x1, int x2)
        {
            b0 = Math.Log(x0);
            b1 = (Math.Log(x1) - Math.Log(x0)) / (x1 - x0);
            b2 = (((Math.Log(x2) - Math.Log(x1)) / (x2 - x1)) - b1) / (x2 - x0);

            fx = b0 + (b1 * (x - x0)) + (b2 * ((x - x0) * (x - x1)));   
        }


        public string resultado()
        {
            string cdn = "";

            cdn = "f(x)= " + fx + "\r\n" + "Error relativo = " + er;
            
            return cdn;
        }

    }
}
