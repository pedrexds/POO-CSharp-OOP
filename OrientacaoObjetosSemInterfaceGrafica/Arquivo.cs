using System.Collections;

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

        public void ler()
        {
            string linha;
            try
            {
                StreamReader sr = new StreamReader(this.caminhoArquivo);

                linha = sr.ReadLine();

                while(linha != null)
                {
                    Console.WriteLine(linha);
                    linha = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando bloco 'finally'");
            }
        }
        
        public void escrever(ArrayList linhas)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.caminhoArquivo);
                sw.WriteLine("Olá mundo!");
                sw.WriteLine("Da classe StreamWriter.");
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executando bloco 'finally'");
            }
        }
    }
}