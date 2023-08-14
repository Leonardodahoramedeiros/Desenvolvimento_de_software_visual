using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _aula004
{
    public class Acompanhamento
    {
        public string tipo;
        public string texto;
        public int tamanho;

        public string Tipo{get => tipo; set => tipo = value;}
        public string Texto{get => texto; set => texto = value;}
        public int Tamanho{get => tamanho; set => tamanho = value;}
        
        
    }
}