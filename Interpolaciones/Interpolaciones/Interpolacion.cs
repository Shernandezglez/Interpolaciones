using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolaciones
{
    class Interpolacion
    {
        
        double fx, er = 0;
        

        public void calcularInter(int x, int  x0, int x1)
        {
            
            fx = (((Math.Log(x0)) + (Math.Log(x1) - Math.Log(x0)) / (x1 - x0)))*(x - x0);
            er = Math.Abs(((Math.Log(x) - fx) / fx) * 100);
   
        }

        public string resultado()
        {
            string cdn = "";

            cdn = "f(x)= " + fx + "\r\n" + "Error relativo = " + er;

            return cdn;
        }

    }
}
