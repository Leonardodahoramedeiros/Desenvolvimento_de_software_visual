using System;

namespace _aula004 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.cpf=111;
            cliente.nome="Leo";
            cliente.consultar();

        PedidoIdentificado pi = new PedidoIdentificado();
        pi.exibir();
            
          
        }
    }
}