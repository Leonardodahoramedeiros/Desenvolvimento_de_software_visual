using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _aula004
{
    public class Cliente
    {
        public int cpf;
        public string nome;

        public int CPF{get => cpf; set => cpf = value;}
        public string Nome{get => nome; set => nome = value;}

        public void inserir()
        {

        }
        public void consultar()
        {
            Console.WriteLine("Olá "+nome+" seu cpf é "+cpf);
        }
        public void alterar()
        {

        }
        public void exclui()
        {
            
        }
        
    }
}