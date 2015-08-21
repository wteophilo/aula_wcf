using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProjeto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculadora" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculadora.svc or Calculadora.svc.cs at the Solution Explorer and start debugging.
    public class Calculadora : ICalculadora
    {
        
        public int adicionar(int val1, int val2)
        {
            return val1 + val2;
        }

        public int subtrair(int val1, int val2) {
            return val1 - val2;
        }
        
        public int multiplicar(int val1, int val2)
        {
            return val1 * val2;
        }
        
        public double dividir(int val1, int val2)
        {
            try
            {
                return val1 / val2;
            }
            catch(Exception e)
            {
                throw new FaultException(e.Message);
            }
            
        }
    }
}
