using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsomeCalculadora com = new ConsomeCalculadora();
            com.consomeDados();

            ConsomeCliente cliente = new ConsomeCliente();
            cliente.consomeDados();

            ConsomeClienteSecreto clienteSecreto = new ConsomeClienteSecreto();
            clienteSecreto.consomeDados();
        }

        
    }
}
