/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace POO_CSharp_OOP
{
    public class Arquivo
    {
        private string filename;
        private string caminhoArquivo;

        public Arquivo(string filename, string caminhoArquivo)
        {
            this.filename = filename;
            this.caminhoArquivo = caminhoArquivo;
        }

        public ArrayList ler()
        {
            ArrayList linhas = new ArrayList();
            StreamReader leitor = new StreamReader(this.caminhoArquivo);
            //StreamWriter x = File.CreateText(this.caminhoArquivo);

            linhas = File.ReadAllLines();
        }
    }
}*/