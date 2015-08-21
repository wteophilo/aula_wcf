using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCliente
{
    class ConsomeClienteSecreto
    {
        public void consomeDados()
        {
            ClienteSecretoRemoto.ClienteSecretoClient cliente = new ClienteSecretoRemoto.ClienteSecretoClient();
            ClienteSecretoRemoto.ClienteInformacoesSecretas info = new ClienteSecretoRemoto.ClienteInformacoesSecretas();
            info.nome = "Willian Secreto";
            info.endereco = "Rua 2";
            //Senha não fica aparente para consumo
            Console.WriteLine(cliente.cadastrar(info));
            Console.Read();
        }
    }
}
