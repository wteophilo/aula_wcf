using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProjeto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculadora" in both code and config file together.
    [ServiceContract]
    public interface ICalculadora
    {
        [OperationContract]
        int  adicionar(int val1, int val2);
        [OperationContract]
        int subtrair(int val1, int val2);
        [OperationContract]
        int multiplicar(int val1, int val2);
        [OperationContract]
        [FaultContract(typeof(FaultException))]
        double  dividir(int val1, int val2);

    }
}
