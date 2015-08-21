using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProjeto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICliente" in both code and config file together.
    [ServiceContract]
    public interface ICliente
    {
        [OperationContract]
        string cadastrar(ClienteInformacoes cliente);
    }

    public class ClienteInformacoes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
    }
}
