using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCliente
{
    class ConsomeCalculadora
    {
        public void consomeDados()
        {
            CalculadoraRemota.CalculadoraClient cc = new CalculadoraRemota.CalculadoraClient();
            Console.WriteLine(string.Format("Somando  5 + 5 = {0}", cc.adicionar(5, 5)));
            Console.WriteLine(string.Format("Subtraindo  4 - 1 = {0}", cc.subtrair(4, 1)));
            Console.WriteLine(string.Format("Multiplicando  3 * 2 = {0}", cc.multiplicar(3, 2)));
            try
            {
                Console.WriteLine(string.Format("Dividindo  4 / 2 = {0}", cc.dividir(4, 0)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Divisão por zero");
            }
            Console.Read();
        }
    }
}
