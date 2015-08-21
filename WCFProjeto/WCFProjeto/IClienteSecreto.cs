using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProjeto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClienteSecreto" in both code and config file together.
    [ServiceContract]
    public interface IClienteSecreto
    {
        [OperationContract]
        string cadastrar(ClienteInformacoesSecretas cliente);
    }

    [DataContract]
    public class ClienteInformacoesSecretas
    {
        [DataMember]
        public string nome { get; set; }
        [DataMember]
        public string endereco { get; set; }
        public string senha { get; set; }
    }
    
}
