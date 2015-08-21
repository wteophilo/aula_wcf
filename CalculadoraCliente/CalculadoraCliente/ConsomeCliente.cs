using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCliente
{
    class ConsomeCliente
    {
        public void consomeDados()
        {
            ClienteRemoto.ClienteClient cliente = new ClienteRemoto.ClienteClient();
            ClienteRemoto.ClienteInformacoes info = new ClienteRemoto.ClienteInformacoes();
            info.nome = "Willian";
            info.endereco = "Rua 2";
            info.telefone = "(11)1111-4502";
            Console.WriteLine(cliente.cadastrar(info));
            Console.Read();
        }
    }
}
