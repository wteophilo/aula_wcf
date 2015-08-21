using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFProjeto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteSecreto" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClienteSecreto.svc or ClienteSecreto.svc.cs at the Solution Explorer and start debugging.
    public class ClienteSecreto : IClienteSecreto
    {
        public string cadastrar(ClienteInformacoesSecretas cliente)
        {
            return string.Format("Cliente {0} cadastro com sucesso", cliente.nome);
        }
    }
}
