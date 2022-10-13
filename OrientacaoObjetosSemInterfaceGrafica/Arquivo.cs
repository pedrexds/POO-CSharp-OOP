using System;
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

            try
            {
                linhas.Add(File.ReadAllLines(this.caminhoArquivo));
            }
            catch(FileNotFoundException f)
            {
                f.ToString();
            }
            return linhas;
        }
        /*
        public void escrever(ArrayList linhas)
        {
            TextWriter tw;
            
        }
        */
    }
}